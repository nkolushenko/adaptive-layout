package com.adaptiveLayout.plugin;

import android.content.res.Resources;
import android.util.DisplayMetrics;

public class NativeDeviceHelper {
    public static int convertPixelsToDp(int pixels) {
        DisplayMetrics metrics = Resources.getSystem().getDisplayMetrics();
        return (int) (pixels / ((float) metrics.densityDpi / DisplayMetrics.DENSITY_DEFAULT));
    }
}
