// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DeadlockExample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeadlockButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PerfeclyWorkingButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DeadlockButton != null) {
                DeadlockButton.Dispose ();
                DeadlockButton = null;
            }

            if (Label != null) {
                Label.Dispose ();
                Label = null;
            }

            if (PerfeclyWorkingButton != null) {
                PerfeclyWorkingButton.Dispose ();
                PerfeclyWorkingButton = null;
            }
        }
    }
}