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
    using Windows.Networking.Connectivity;
    #endregion
    public static class Conectivity
    {

        #region Constructors
        static Conectivity()
        {
            NetworkInformation.NetworkStatusChanged += NetworkInformation_NetworkStatusChanged;
        }
        #endregion

        #region Events
        public static event EventHandler<InternetConnectionChangedEventArgs> InternetConnectionChanged;
        #endregion

        #region Public Methods

        /// <summary>
        /// Gets network connectivity.
        /// </summary>
        public static bool IsConnected
        {
            get
            {
                var profile = NetworkInformation.GetInternetConnectionProfile();
                return (profile != null && profile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);
            }
        }
        #endregion

        #region Private Methods
        private static void NetworkInformation_NetworkStatusChanged(object sender)
        {
            if (InternetConnectionChanged != null)
            {
                var arg = new InternetConnectionChangedEventArgs(IsConnected);
                InternetConnectionChanged(null, arg);
            }
        }
        #endregion
    }
}
