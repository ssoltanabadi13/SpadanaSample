﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Core
{
    public interface ISubscriberCommand<Guid> : IRequest<Guid>
    {
    }
}
