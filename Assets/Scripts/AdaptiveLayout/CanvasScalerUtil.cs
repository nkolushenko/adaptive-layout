using UnityEngine;
using UnityEngine.UI;
//using DeviceOrientations = DeviceOrientations.DeviceOrientations;

namespace AdaptiveLayout
{
    [RequireComponent(typeof(CanvasScaler))]
    public class CanvasScalerUtil : MonoBehaviour
    {
       // private DeviceOrientationsManager _orientationManager;
        private CanvasScaler _canvasScaler;
        private IResolutionProvider _resolutionProvider;
        private bool _isSubscribed;

        private void Awake()
        {
            _canvasScaler = GetComponent<CanvasScaler>();
            _resolutionProvider = ResolutionProviderFactory.GetResolutionProvider();
            //_orientationManager = BaseProjectContext.GetInstance<DeviceOrientationsManager>();
        }

        private void Start()
        {
            _canvasScaler.referenceResolution = _resolutionProvider.GetReferenceResolution();
          
            //Subscribe();
            //OnDeviceOrientationChanged(orientationManager.DeviceOrientation);
        }

        private void OnDestroy()
        {
            Unsubscribe();
        }
        
        private void Subscribe()
        {
            if (_isSubscribed)
            {
                return;
            }
            
            _isSubscribed = true;
            //_orientationManager.OrientationChanged += OnDeviceOrientationChanged;
        }
        
        private void Unsubscribe()
        {
            if (!_isSubscribed)
            {
                return;
            }
            
            _isSubscribed = false;
           // _orientationManager.OrientationChanged -= OnDeviceOrientationChanged;
        }
    }
}

