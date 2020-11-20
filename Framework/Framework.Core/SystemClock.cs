using System;

namespace Framework.Core
{
    public class SystemClock : IClock
    {
        private DateTime _date;
        public DateTime Now()
        {
            return DateTime.Now;
        }
        public DateTime Set(DateTime date)
        {
            return _date = date;
        }
        
        public void SetClock(DateTime date)
        {
            this._date = date;
        }
        public IClock SetClocks(DateTime date)
        {
            this._date = date;
            return this;
        }
        public DateTime GetDateTime()
        {
            return _date;
        }
    }
}
