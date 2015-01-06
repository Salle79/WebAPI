using System;

namespace WebApi2Book.Common
{
    public class DateTimeAdapter : IDateTime
    {

        #region IDateTime Members

        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }

        #endregion



    }
}
