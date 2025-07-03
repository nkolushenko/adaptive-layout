using UnityEngine;

namespace AdaptiveLayout
{
    public class LogWrapper : ILogWrapper
    {
        public void Log(string message)
        {
            Debug.Log(message);
        }

        public void LogError(string message)
        {
            Debug.LogError(message);
        }
    }
}