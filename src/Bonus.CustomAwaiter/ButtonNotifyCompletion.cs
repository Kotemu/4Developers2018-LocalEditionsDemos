using System.Runtime.CompilerServices;
using System;

namespace Bonus.CustomAwaiter
{
    class ButtonNotifyCompletion : INotifyCompletion
    {
        private Action _continuation;

        public ButtonNotifyCompletion(Button button)
        {
            Button = button;
            Button.OnTouch += Button_Touched;
        }

        //We simulate that we are waiting for user action of touching button
        public bool IsCompleted => false;

        public Button Button { get; }

        public void OnCompleted(Action continuation)
        {
            _continuation = continuation;
        }

        public void GetResult()
        {
        }

        private void Button_Touched(object sender, EventArgs args)
        {
            Button.OnTouch -= Button_Touched;
            _continuation();
        }
    }
}