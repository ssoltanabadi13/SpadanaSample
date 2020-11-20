using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Core.GenericDto
{
    public class IdResponse
    {
        public Guid Id { get;private set; }
        public IdResponse(Guid id)
        {
            Id = id;
        }
    }
}
