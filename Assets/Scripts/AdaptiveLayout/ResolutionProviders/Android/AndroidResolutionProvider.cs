#if UNITY_ANDROID
using UnityEngine;

namespace AdaptiveLayout
{
    public class AndroidResolutionProvider : IResolutionProvider
    {
        private const string JavaClassName = "com.adaptiveLayout.utils.PixelConverter";
        private const string MethodPixelsToDp = "pixelsToDp";

        private static readonly AndroidJavaClass PixelConverterClass = new(JavaClassName);

        private readonly ILogWrapper _logWrapper;

        private Vector2? _cached;

        public AndroidResolutionProvider(ILogWrapper logWrapper)
        {
            _logWrapper = logWrapper;
        }

        public Vector2 GetReferenceResolution()
        {
            if (_cached.HasValue)
            {
                return _cached.Value;
            }

            try
            {
                var widthDp = PixelConverterClass.CallStatic<int>(MethodPixelsToDp, (float)Screen.width);
                var heightDp = PixelConverterClass.CallStatic<int>(MethodPixelsToDp, (float)Screen.height);

                _cached = new Vector2(widthDp, heightDp);
            }
            catch (AndroidJavaException e)
            {
                _logWrapper.LogError($"[AndroidResolutionProvider] JNI call failed: {e.Message}");
                _cached = new Vector2(Screen.width, Screen.height);
            }

            return _cached.Value;
        }
    }
}
#endif