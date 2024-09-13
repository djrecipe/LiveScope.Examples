using Avalonia;
using Avalonia.ReactiveUI;
using System;
using LiveScope.Avalonia.Windows;
using LiveScope.Windows;
using LiveScope.Net;

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
            LiveScope.Net.Licensing.LicenseKey = "PExpY2Vuc2U+DQogIDxJZD40ZWVhMDU2Ni04YjE5LTRlZjktOGJjYS00MjY5NWZjODc4YWE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+VHVlLCAzMSBEZWMgMjAyNCAxNzowMDowMCBHTVQ8L0V4cGlyYXRpb24+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSUNxTWdDbkMrRWc5Vmh5YnE3L0NUQmVqNDRBRjdWNnpuSEliemsrN1BLWVhBaUVBeUhwdE0wcWd1TUFCd1R5b2ozVWwvdXh6OS82aFZUOURLb3N2blVLaUVTWT08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";
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