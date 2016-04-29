//----------------------------------------------------------------------------------//
//<author> César Reneses Cárcamo </author> 
//<date> 29/04/2016  </date> 
//<summary> Conectivity watcher for Universal Windows Platform </summary> 
//<website> http://cesarreneses.net </website>
//----------------------------------------------------------------------------------//

namespace ConectivityWatcher
{
    #region Namespaces
    using System;
    #endregion
    public class InternetConnectionChangedEventArgs : EventArgs
    {
        #region Properties
        public bool IsConnected { get; }
        #endregion

        #region Public Methods
        public InternetConnectionChangedEventArgs(bool isConnected)
        {
            IsConnected = isConnected;
        }
        #endregion
    }
}
