# Conectivity Watcher

Helper to control internet connectivity for Universal Windows Platform
Date: 29/04/2016

* How to use:

Implement event InternetConnectionChanged:

		Conectivity.InternetConnectionChanged += Conectivity_InternetConnectionChanged;

and fill generated method:

        private async void Conectivity_InternetConnectionChanged(object sender, InternetConnectionChangedEventArgs e)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                if (e.IsConnected)
                {
                  //TODO...
                }
            });
        }

