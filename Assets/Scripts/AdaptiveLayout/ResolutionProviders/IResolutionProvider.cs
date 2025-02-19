using UnityEngine;

namespace AdaptiveLayout
{
    public interface IResolutionProvider
    {
        Vector2 GetReferenceResolution();
    }
}
