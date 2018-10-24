using System;
using System.Threading.Tasks;
using UIKit;

namespace DeadlockExample
{
    public partial class ViewController : UIViewController
    {
        private int _counter = 0;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            DeadlockButton.TouchUpInside += DeadlockButton_TouchUpInside;
            PerfeclyWorkingButton.TouchUpInside += PerfeclyWorkingButton_TouchUpInside;
        }

        public override void ViewDidDisappear(bool animated)
        {

            DeadlockButton.TouchUpInside -= DeadlockButton_TouchUpInside;
            base.ViewDidDisappear(animated);
        }

        private async void PerfeclyWorkingButton_TouchUpInside(object sender, EventArgs e)
        {
            await VeryImportantMethod();
            UpdateCounterLabel();
        }

        private void DeadlockButton_TouchUpInside(object sender, EventArgs e)
        {
            VeryImportantMethod().Wait();
            UpdateCounterLabel();
        }

        private void UpdateCounterLabel()
        {
            Label.Text = $"Current count: {++_counter}";
        }

        private async Task VeryImportantMethod()
        {
            /* 
             * If you don't have to come back to caller thread (using SychronizationContext)
             * you should use ConfigureAwait(false) like below.
             * 
             * await Task.Delay(100).ConfigureAwait(false);
             */
            await Task.Delay(100);
            Console.WriteLine("I've done some serious job in here.");
        }
    }
}
