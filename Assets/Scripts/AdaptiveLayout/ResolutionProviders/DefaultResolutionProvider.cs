using UnityEngine;

namespace AdaptiveLayout
{
    public class DefaultResolutionProvider : IResolutionProvider
    {
        public Vector2 GetReferenceResolution()
        {
            return new Vector2(Screen.width, Screen.height);
        }
    }
}
