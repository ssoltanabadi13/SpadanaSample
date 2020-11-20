using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using Microsoft.AspNetCore.Http;

namespace Framework.Core.Claims
{
    public class ClaimHelper : IClaimHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        
        public ClaimHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid GetUserId()
        {
            var claims = _httpContextAccessor.HttpContext.User.Claims;
            var id = claims.FirstOrDefault(x => x.Type == "sub")?.Value;
            return Guid.Parse(id);
        }
    }
}