#if UNITY_IOS
using UnityEngine;
using System.Runtime.InteropServices;

namespace AdaptiveLayout
{
    public class IOSResolutionProvider : IResolutionProvider
    {
        [DllImport("__Internal")]
        private static extern float _GetNativeScale();

        public Vector2 GetReferenceResolution()
        {
            float scaleFactor = _GetNativeScale();
            return new Vector2(Screen.width / scaleFactor, Screen.height / scaleFactor);
        }
    }
}
#endif
