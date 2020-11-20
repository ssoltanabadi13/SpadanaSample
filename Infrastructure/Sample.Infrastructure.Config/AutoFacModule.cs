using System.Data.Common;
using System.Data.SqlClient;
using Autofac;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Sample.Application.Tags;
using Sample.Infrastructure.EF;
using Sample.Infrastructure.EF.Repositories;
using Sample.Interface.Facade;
using Sample.Interface.Facade.Query;

namespace Sample.Infrastructure.Config
{
    public class AutoFacModule : Module
    {
        private readonly string _connectionString;

        public AutoFacModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(typeof(TagsRepository).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(TagsFacade).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            //builder.RegisterAssemblyTypes(typeof(AccountsQueryRepository).Assembly)
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CategoryQueryFacade).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(TagsCommandHandler).Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>));

            var connection = CreateConnection(_connectionString);

            var optionBuilder = new DbContextOptionsBuilder<SampleDbContext>()
                .UseSqlServer(connection).Options;

            builder.RegisterType(typeof(SampleDbContext))
                .WithParameter("options", optionBuilder)
                .InstancePerLifetimeScope()
                .OnRelease(x =>
                {
                    connection.Close();
                });

        }
        public DbConnection CreateConnection(string connectionString)
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}