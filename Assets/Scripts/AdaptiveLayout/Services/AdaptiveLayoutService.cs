using UnityEngine.UI;

namespace AdaptiveLayout
{
    public class AdaptiveLayoutService : IAdaptiveLayoutService
    {
        private readonly IResolutionProvider _resolutionProvider;

        public AdaptiveLayoutService(IResolutionProvider resolutionProvider)
        {
            _resolutionProvider = resolutionProvider;
        }

        public void Apply(CanvasScaler scaler)
        {
            scaler.referenceResolution = _resolutionProvider.GetReferenceResolution();
        }
    }
}