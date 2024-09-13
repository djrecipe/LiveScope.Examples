# Welcome to LiveScope for .NET!
https://www.livescope.net/

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
LiveScope.Net.Licensing.LoadFromFile("LiveScopeTrial2024.lic");
```

Alternatively, set the license key value in your code like this:
```
LiveScope.Net.Licensing.LicenseKey = "PExpY2Vuc2U+DQogIDxJZD40ZWVhMDU2Ni04YjE5LTRlZjktOGJjYS00MjY5NWZjODc4YWE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+VHVlLCAzMSBEZWMgMjAyNCAxNzowMDowMCBHTVQ8L0V4cGlyYXRpb24+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSUNxTWdDbkMrRWc5Vmh5YnE3L0NUQmVqNDRBRjdWNnpuSEliemsrN1BLWVhBaUVBeUhwdE0wcWd1TUFCd1R5b2ozVWwvdXh6OS82aFZUOURLb3N2blVLaUVTWT08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";
```
