Adaptive Layout for Unity  

A Unity UI scaling solution that ensures a consistent physical size of UI elements across different devices.  

📖 Overview  

This package solves the problem of inconsistent UI sizes across screens by dynamically adjusting the CanvasScaler based on the device's actual screen density (DPI) rather than just resolution.  

🛑 The Problem  
By default, Unity’s CanvasScaler scales UI elements based on screen resolution, not physical size. This leads to:  

Buttons appearing larger on low-resolution tablets than on high-resolution phones.  
UI elements feeling too big or too small depending on the device's DPI and screen scale factor.  

✅ Key Features  
✔ Maintains a consistent physical size of UI elements across different screens.  
✔ Uses native APIs for precise screen scaling (UIScreen.mainScreen.nativeScale on iOS and DisplayMetrics on Android).  
✔ Supports both high-DPI and low-DPI devices for a uniform user experience.  
✔ Standalone-friendly – does not require DI (but can be adapted for DI frameworks like Zenject).  
✔ Lightweight & optimized – minimal performance overhead.
