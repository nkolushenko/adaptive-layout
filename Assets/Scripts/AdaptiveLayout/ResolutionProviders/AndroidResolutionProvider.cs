#if UNITY_ANDROID
using UnityEngine;

namespace AdaptiveLayout
{
    public class AndroidResolutionProvider : IResolutionProvider
    {
        private const string DeviceHelperClassName = "com.adaptiveLayout.plugin";
        private const string ConvertPixelsToDpMethodName = "convertPixelsToDp";

        public Vector2 GetReferenceResolution()
        {
            using (var javaClass = new AndroidJavaClass(DeviceHelperClassName))
            {
                int widthDp = javaClass.CallStatic<int>(ConvertPixelsToDpMethodName, Screen.width);
                int heightDp = javaClass.CallStatic<int>(ConvertPixelsToDpMethodName, Screen.height);
                return new Vector2(widthDp, heightDp);
            }
        }
    }
}
#endif

