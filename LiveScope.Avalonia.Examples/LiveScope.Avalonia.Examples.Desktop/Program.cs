using Avalonia;
using Avalonia.ReactiveUI;
using System;

namespace LiveScope.Avalonia.Examples.Desktop
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            LiveScope.Net.Licensing.LicenseKey = "PExpY2Vuc2U+DQogIDxJZD45MTJkNzVjZC1hODg1LTQyNWMtOTI2NC1hMjFmOWQ2ZTNjZDE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+U2F0LCAxMyBTZXAgMjAyNSAwMTo1NjoyNyBHTVQ8L0V4cGlyYXRpb24+DQogIDxQcm9kdWN0RmVhdHVyZXM+DQogICAgPEZlYXR1cmUgbmFtZT0iQWxwaGEgQnVpbGQiPnllczwvRmVhdHVyZT4NCiAgPC9Qcm9kdWN0RmVhdHVyZXM+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSVFDWFpiMEh5RzFDTkJkc2FjQjJJWXNQWk1vd1l6czlMQXlwdHJOcC9JUzZzZ0lnQmowSncvZHhSSXR5cGgzOTZHa1lFWjRwelgwL0c3djIwSXVPV3dPRFBiaz08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";
            var app = AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace()
                .UseReactiveUI();
            app.AfterSetup((x) => {
            });
            return app;
        }
    }
}