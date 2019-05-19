using UnityEngine;

namespace Karma
{
    public partial class Kar
    {
        public static void Log(object message, Object context = null)
        {
            Current._logger.Log(message, context);
        }

        public static void Warn(object message, Object context = null)
        {
            Current._logger.Warn(message, context);
        }

        public static void Error(object message, Object context = null)
        {
            Current._logger.Error(message, context);
        }
    }
}