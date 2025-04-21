# Welcome to LiveScope for .NET!
[http://livescope.net/](http://livescope.net/) (still getting SSL sorted)

If you want to display real-time data in your proprietary cross-platform .NET application, you're in the right place. This library is much simpler and MUCH cheaper than alternatives such as SciChart or TeeChart, and is aimed specifically at displaying real-time stream data from proprietary ADC hardware. See section below to obtain a free trial key.

## Choosing the Right Package
Consult this table to determine which NuGet package is right for you.

| Platform | Project Type | Package |
|:---------|:------------:|:--------|
| Windows | WPF | 📦 LiveScope.WPF |
| Windows | Avalonia | 📦 LiveScope.Avalonia.Windows |
| MacOs | Avalonia | 📦 LiveScope.Avalonia.MacOs |
| Android | Avalonia | 📦 LiveScope.Avalonia.Android |

## Examples
This repo contains some basic example code to help you get started with LiveScope for .NET.

### LiveScope.Avalonia.Examples Directory
Contains examples for using LiveScope in a cross-platform Avalonia App on Windows and Android.

### LiveScope.WPF.Examples Directory
Contains examples for using LiveScope in a WPF app on Windows.

## Trial Key
Use the license file "LiveScopeTrial2024.lic" contained within this repo:
```
LiveScope.Net.Licensing.LoadFromFile("LiveScopeTrial2025.lic");
```

Alternatively, set the license key value in your code like this:
```
LiveScope.Net.Licensing.LicenseKey = "PExpY2Vuc2U+DQogIDxJZD45MTJkNzVjZC1hODg1LTQyNWMtOTI2NC1hMjFmOWQ2ZTNjZDE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+U2F0LCAxMyBTZXAgMjAyNSAwMTo1NjoyNyBHTVQ8L0V4cGlyYXRpb24+DQogIDxQcm9kdWN0RmVhdHVyZXM+DQogICAgPEZlYXR1cmUgbmFtZT0iQWxwaGEgQnVpbGQiPnllczwvRmVhdHVyZT4NCiAgPC9Qcm9kdWN0RmVhdHVyZXM+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSVFDWFpiMEh5RzFDTkJkc2FjQjJJWXNQWk1vd1l6czlMQXlwdHJOcC9JUzZzZ0lnQmowSncvZHhSSXR5cGgzOTZHa1lFWjRwelgwL0c3djIwSXVPV3dPRFBiaz08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";
```
