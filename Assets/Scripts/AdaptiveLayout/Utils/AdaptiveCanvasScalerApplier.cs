using UnityEngine;
using UnityEngine.UI;

namespace AdaptiveLayout
{
    [RequireComponent(typeof(CanvasScaler))]
    public class AdaptiveCanvasScalerApplier : MonoBehaviour
    {
        [SerializeField] private CanvasScaler canvasScaler;

        private IAdaptiveLayoutService _applier;

        // TODO: Replace with DI container injection (e.g., Zenject or VContainer)
        //[Inject]
        private void Construct(IAdaptiveLayoutService applier)
        {
            _applier = applier;
        }

        private void Start()
        {
            _applier.Apply(canvasScaler);
        }
    }
}