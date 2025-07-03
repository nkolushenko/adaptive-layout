#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.UI;

namespace AdaptiveLayout
{
    [RequireComponent(typeof(CanvasScaler))]
    public class DebugAdaptiveCanvasScalerApplier : MonoBehaviour
    {
        [SerializeField] private CanvasScaler canvasScaler;

        private IAdaptiveLayoutService _applier;
        private ILogWrapper _logger;

        // TODO: Replace with DI container injection (e.g., Zenject or VContainer)
        //[Inject]
        private void Construct(IAdaptiveLayoutService applier, ILogWrapper logger)
        {
            _applier = applier;
            _logger = logger;
        }

        private void Start()
        {
            _applier.Apply(canvasScaler);
        }

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
            _logger.Log($"[CanvasScaler Debug] Reference Resolution: {res.x} x {res.y}");
            _applier.Apply(canvasScaler);
        }
#endif
    }
}