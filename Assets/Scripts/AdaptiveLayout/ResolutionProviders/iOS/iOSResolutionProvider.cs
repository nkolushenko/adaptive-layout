#if UNITY_IOS
using UnityEngine;
using System.Runtime.InteropServices;

namespace AdaptiveLayout
{
    public class IOSResolutionProvider : IResolutionProvider
    {
        [DllImport("__Internal")]
        private static extern float GetNativeScreenScale();

        private Vector2? _cached;

        public Vector2 GetReferenceResolution()
        {
            if (_cached.HasValue)
            {
                return _cached.Value;
            }

            float scaleFactor = GetNativeScreenScale();
            _cached = new Vector2(Screen.width / scaleFactor, Screen.height / scaleFactor);
            return _cached.Value;
        }
    }
}
#endif