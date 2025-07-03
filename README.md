# Adaptive Layout

Scales UI based on actual screen **DPI**, not resolution.  
Keeps UI size consistent across all devices.

## Features

- Native DPI support (iOS: `nativeScale`, Android: `densityDpi`)
- One-time scaling at startup (no runtime cost)
- No dependencies (Zenject/VContainer-friendly)
- Works with Unity 2020.3+ (URP & built-in UI)

## Usage

1. Add `AdaptiveLayout.cs` to your project  
2. Attach it to the root `Canvas`  
