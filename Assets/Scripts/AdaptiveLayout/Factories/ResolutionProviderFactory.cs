namespace AdaptiveLayout
{ 
    // NOTE: If using a DI container (e.g., Zenject or VContainer),
    // this factory should be removed and replaced with platform-specific 
    // dependency binding inside the Installer.
    
    public interface IResolutionProviderFactory
    {
        public IResolutionProvider Create();
    }
    
    public class ResolutionProviderFactory : IResolutionProviderFactory
    {
        public IResolutionProvider Create()
        {
#if UNITY_IOS
            return new IOSResolutionProvider();
#elif UNITY_ANDROID
            return new AndroidResolutionProvider();
#else
            return new DefaultResolutionProvider();
#endif
        }
    }
}
