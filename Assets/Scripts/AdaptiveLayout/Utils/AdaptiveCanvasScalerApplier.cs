using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
#define DEBUG_CANVAS_SCALER
#endif

namespace AdaptiveLayout
{
    [RequireComponent(typeof(CanvasScaler))]
    public class AdaptiveCanvasScalerApplier : MonoBehaviour
    {
        [SerializeField] private CanvasScaler canvasScaler;
        
        private IResolutionProvider _resolutionProvider;
// TODO: Replace with DI container injection (e.g., Zenject or VContainer)
        private void Construct(IResolutionProvider resolutionProvider)
        {
            _resolutionProvider = resolutionProvider;
        }
        
        private void Awake()
        {
            IResolutionProviderFactory resolutionProviderFactory = new ResolutionProviderFactory();
            var resolutionProvider = resolutionProviderFactory.Create();
            Construct(resolutionProvider);
        }
        
        private void Start()
        {
            canvasScaler.referenceResolution = _resolutionProvider.GetReferenceResolution();
        }

#if DEBUG_CANVAS_SCALER
        private void Update()
        {
            DebugCanvasResolution();
        }

        private void DebugCanvasResolution()
        {
            if (canvasScaler == null)
            {
                return;
            }

            var res = canvasScaler.referenceResolution;
            Debug.Log($"[CanvasScaler Debug] Reference Resolution: {res.x} x {res.y}");
        }
#endif
    }
}


