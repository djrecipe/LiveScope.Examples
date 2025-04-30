# Welcome to LiveScope for .NET!
[http://livescope.net/](http://livescope.net/)

If you want to display real-time data in your proprietary cross-platform .NET application, you're in the right place. This library is a simpler and cheaper alternative to such (wonderful and well-produced) options like SciChart or TeeChart.

Livescope is aimed specifically at displaying real-time stream data from proprietary ADC hardware. We are still in very early stages of development, so this repo allows FREE usage via a 1-year trial key.

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
_What's the deal with these license keys anyway?_

I want people to use LiveScope in its early development stages. This is why I have decided to continually update this repository to include a FREE license key, good for one year of free updates.

As LiveScope approaches commercial viability, I will eventually reduce trial license periods to one month and shift to a more serious monetization strategy via perpetual license keys. By this point, I'm confident that LiveScope will be well worth every penny.

### How to Use the FREE License
Use the license file "LiveScopeTrial2025.lic" contained within this repo:
```
LiveScope.Net.Licensing.LoadFromFile("LiveScopeTrial2025.lic");
```

Alternatively, set the license key value in your code like this:
```
LiveScope.Net.Licensing.LicenseKey = "PExpY2Vuc2U+DQogIDxJZD45MTJkNzVjZC1hODg1LTQyNWMtOTI2NC1hMjFmOWQ2ZTNjZDE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+U2F0LCAxMyBTZXAgMjAyNSAwMTo1NjoyNyBHTVQ8L0V4cGlyYXRpb24+DQogIDxQcm9kdWN0RmVhdHVyZXM+DQogICAgPEZlYXR1cmUgbmFtZT0iQWxwaGEgQnVpbGQiPnllczwvRmVhdHVyZT4NCiAgPC9Qcm9kdWN0RmVhdHVyZXM+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSVFDWFpiMEh5RzFDTkJkc2FjQjJJWXNQWk1vd1l6czlMQXlwdHJOcC9JUzZzZ0lnQmowSncvZHhSSXR5cGgzOTZHa1lFWjRwelgwL0c3djIwSXVPV3dPRFBiaz08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";
```
