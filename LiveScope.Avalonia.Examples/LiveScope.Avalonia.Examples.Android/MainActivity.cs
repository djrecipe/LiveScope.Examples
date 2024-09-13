using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;
using Avalonia.ReactiveUI;
using LiveScope.Avalonia;
using LiveScope.Avalonia.Android;
using LiveScope.Avalonia.Examples;
using LiveScope.Net;

namespace LiveScope.Demo.Avalonia.Android
{
    [Activity(
        Label = "LiveScope.Avalonia.Demo.Android",
        Theme = "@style/MyTheme.NoActionBar",
        Icon = "@drawable/icon",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
    public class MainActivity : AvaloniaMainActivity<App>
    {
        protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
        {
            Licensing.LicenseKey =
                "<<enter your key here>>";
            var result = base.CustomizeAppBuilder(builder)
                .WithInterFont()
                .UseReactiveUI();
            result.AfterSetup((x) => {
            });
            return result;
        }
    }
}