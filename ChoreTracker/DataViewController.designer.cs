// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ChoreTracker
{
    [Register ("DataViewController")]
    partial class DataViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel dataLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView msDayNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dataLabel != null) {
                dataLabel.Dispose ();
                dataLabel = null;
            }

            if (msDayNumber != null) {
                msDayNumber.Dispose ();
                msDayNumber = null;
            }
        }
    }
}