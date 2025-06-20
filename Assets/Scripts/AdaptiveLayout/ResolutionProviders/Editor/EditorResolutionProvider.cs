#if UNITY_EDITOR
using UnityEngine;

namespace AdaptiveLayout
{
    public class EditorResolutionProvider : IResolutionProvider
    {
        private Vector2? _cached;
        
        public Vector2 GetReferenceResolution()
        {
            if (_cached.HasValue)
            {
                return _cached.Value;
            }

            var resolution = new Vector2(Screen.width, Screen.height);
            _cached = resolution;
            
            return resolution;
        }
    }
}
#endif

