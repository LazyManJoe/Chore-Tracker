using System;
using System.Collections.Generic;
using UIKit;
using Foundation;
using CoreGraphics;

namespace ChoreTracker
{
	public class ChoreImageDelegate : UICollectionViewDelegateFlowLayout

	{
		public static AppDelegate App
		{
			get
			{
				return (AppDelegate)UIApplication.SharedApplication.Delegate;
			}
		}

		public ChoreImageDelegate()
		{
		}

		public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
		{
			return new CGSize (100, 100) ;
		}
		public override bool CanFocusItem(UICollectionView collectionView, NSIndexPath indexPath)
		{
			if (indexPath == null)
			{
				return false;
			}
			else
			{
				var controller = collectionView as DailyChoreListCollectionView;
				return controller.Source.Chores[indexPath.Row].CanSelect;
			}
		}
		public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
		{
			var controller = collectionView as DailyChoreListCollectionView;
			App.SelectedChore = controller.Source.Chores[indexPath.Row];
			controller.ParentController.DismissViewController(true,null);
		}
	}
}
