#if UNITY_ANDROID
using UnityEngine;

namespace AdaptiveLayout
{
    public class AndroidResolutionProvider : IResolutionProvider
    {
        private const string JavaClassName = "com.adaptiveLayout.utils.PixelConverter";
        private const string MethodPixelsToDp = "pixelsToDp";

        private static readonly AndroidJavaClass PixelConverterClass = new AndroidJavaClass(JavaClassName);

        private Vector2? _cached;

        public Vector2 GetReferenceResolution()
        {
            if (_cached.HasValue)
            {
                return _cached.Value;
            }

            try
            {
                int widthDp = PixelConverterClass.CallStatic<int>(MethodPixelsToDp, (float)Screen.width);
                int heightDp = PixelConverterClass.CallStatic<int>(MethodPixelsToDp, (float)Screen.height);
                _cached = new Vector2(widthDp, heightDp);
            }
            catch (AndroidJavaException e)
            {
                Debug.LogError($"[AndroidResolutionProvider] JNI call failed: {e.Message}");
                _cached = new Vector2(Screen.width, Screen.height);
            }

            return _cached.Value;
        }
    }
}
#endif