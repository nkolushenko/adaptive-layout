namespace AdaptiveLayout
{
    public static class ResolutionProviderFactory
    {
        public static IResolutionProvider GetResolutionProvider()
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
