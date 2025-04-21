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
                "PExpY2Vuc2U+DQogIDxJZD45MTJkNzVjZC1hODg1LTQyNWMtOTI2NC1hMjFmOWQ2ZTNjZDE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+U2F0LCAxMyBTZXAgMjAyNSAwMTo1NjoyNyBHTVQ8L0V4cGlyYXRpb24+DQogIDxQcm9kdWN0RmVhdHVyZXM+DQogICAgPEZlYXR1cmUgbmFtZT0iQWxwaGEgQnVpbGQiPnllczwvRmVhdHVyZT4NCiAgPC9Qcm9kdWN0RmVhdHVyZXM+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSVFDWFpiMEh5RzFDTkJkc2FjQjJJWXNQWk1vd1l6czlMQXlwdHJOcC9JUzZzZ0lnQmowSncvZHhSSXR5cGgzOTZHa1lFWjRwelgwL0c3djIwSXVPV3dPRFBiaz08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";
            var result = base.CustomizeAppBuilder(builder)
                .WithInterFont()
                .UseReactiveUI();
            result.AfterSetup((x) => {
            });
            return result;
        }
    }
}