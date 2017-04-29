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
    [Register ("DailyChoreListCollectionView")]
    partial class DailyChoreListCollectionView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        ChoreTracker.DailyChoreListCollectionViewController dataSource { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        ChoreTracker.DailyChoreListCollectionViewController @delegate { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dataSource != null) {
                dataSource.Dispose ();
                dataSource = null;
            }

            if (@delegate != null) {
                @delegate.Dispose ();
                @delegate = null;
            }
        }
    }
}