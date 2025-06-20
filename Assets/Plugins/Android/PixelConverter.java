package com.adaptiveLayout.utils;

import android.content.res.Resources;
import android.util.DisplayMetrics;
import com.unity3d.player.UnityPlayer;

public final class PixelConverter 
{
    private static float densityRatio = -1f;

    private PixelConverter() {}

    public static int pixelsToDp(float pixels) 
    {
        ensureInitialized();
        return Math.round(pixels * densityRatio);
    }

    public static int dpToPixels(float dp) 
    {
        ensureInitialized();
        return Math.round(dp / densityRatio);
    }

    private static void ensureInitialized() 
    {
        if (densityRatio > 0f) 
	    {
		    return;
	    }

        try 
        {
            DisplayMetrics metrics = getDisplayMetrics();

            densityRatio = DisplayMetrics.DENSITY_DEFAULT / (float) metrics.densityDpi;
        } 
        catch (Exception e) 
        {
            densityRatio = 1.0f;
        }
    }
    
    private static DisplayMetrics getDisplayMetrics()
    {    
        if(UnityPlayer.currentActivity != null)
        {
            return UnityPlayer.currentActivity.getResources().getDisplayMetrics();
        }
        
        return Resources.getSystem().getDisplayMetrics();
    }
}

