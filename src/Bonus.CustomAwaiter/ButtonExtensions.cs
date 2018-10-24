using System;

namespace Bonus.CustomAwaiter
{
    static class ButtonExtensions
    {
        public static ButtonNotifyCompletion GetAwaiter(this Button button)
        {
            return new ButtonNotifyCompletion(button);
        }
    }
}