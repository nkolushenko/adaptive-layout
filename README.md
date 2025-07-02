## Overview

Unity's default UI scaling is based on screen resolution, which often leads to inconsistent UI sizes across devices.  
**Adaptive Layout** solves this by scaling UI based on the screen's actual pixel density (DPI), not just resolution.  
It uses native APIs to retrieve precise screen metrics on both iOS and Android.

## Key Features

- Maintains consistent physical size of UI elements across devices  
- Uses `UIScreen.mainScreen.nativeScale` on iOS and `DisplayMetrics.densityDpi` on Android  
- Supports both high-DPI and low-DPI screens  
- No dependency injection required (compatible with Zenject/VContainer if needed)  
- Scaling is calculated once on startup and has no runtime performance impact  

## How It Works

On application start, the system:

1. Retrieves the actual screen DPI using platform-specific native calls  
2. Calculates a DPI scaling factor relative to a predefined reference DPI  
3. Adjusts the `CanvasScaler` settings accordingly (e.g., `scaleFactor`, `referencePixelsPerUnit`)

## Installation

Simply copy the `AdaptiveLayout` script into your Unity project and attach it to your root Canvas object.

## Compatibility

- Unity 2020.3+ (recommended: 2022.3+)
- Supports iOS and Android (native DPI calls)
- Compatible with built-in and URP UI systems
