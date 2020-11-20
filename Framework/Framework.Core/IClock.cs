using System;

namespace Framework.Core
{
    public interface IClock
    {
        DateTime Now();
        DateTime Set(DateTime date);
        void SetClock(DateTime date);
        IClock SetClocks(DateTime date);
        DateTime GetDateTime();
    }
}
