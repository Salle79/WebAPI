using System;
using log4net;
namespace WebApi2Book.Common.Logging
{
    public class LogManagerAdapter : ILogManager 
    {
        #region ILogManager Members

        public log4net.ILog GetLog ( Type typeAssociatedWithRequestedLog )
        {
            return LogManager.GetLogger (typeAssociatedWithRequestedLog );
        }

        #endregion
    }
}
