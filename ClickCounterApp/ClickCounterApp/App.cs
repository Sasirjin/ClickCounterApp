#if __ANDROID__
using ClickCounterApp.Droid;
#elif __IOS__
using ClickCounterApp.iOS.Helpers;
#elif WINDOWS_UWP
using ClickCounterApp.UWP.Helpers;
#endif
using ClickCounterApp.Helpers;
using ClickCounterApp.Interfaces;
using ClickCounterApp.Services;
using ClickCounterApp.Model;

namespace ClickCounterApp
{
    public partial class App 
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            ServiceLocator.Instance.Register<IMessageDialog, MessageDialog>();
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}