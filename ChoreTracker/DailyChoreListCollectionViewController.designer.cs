// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ChoreTracker
{
    [Register ("DailyChoreListCollectionViewController")]
    partial class DailyChoreListCollectionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        ChoreTracker.DailyChoreListCollectionView choreGrid { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (choreGrid != null) {
                choreGrid.Dispose ();
                choreGrid = null;
            }
        }
    }
}