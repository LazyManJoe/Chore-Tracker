using System;
using System.Collections.Generic;
using UIKit;
using Foundation;
using CoreGraphics;
using ObjCRuntime;

namespace ChoreTracker
{
	public class ChoreImageDatasource : UICollectionViewDataSource
	{
		public static AppDelegate App
		{
			get
			{
				return (AppDelegate)UIApplication.SharedApplication.Delegate;
			}
		}

		public static NSString CardCellId = new NSString("DailyChore");

		public List<ChoreListModel> Chores { get; set;} = new List<ChoreListModel>();
		public DailyChoreListCollectionView ViewController { get; set;}

		public ChoreImageDatasource(DailyChoreListCollectionView controller)
		{
			// Initialize
			this.ViewController = controller;
			PopulateChores();
		}

		public void PopulateChores()
		{
			//Clear Existing Chore
			Chores.Clear();

			//Add new Chores
			Chores.Add(new ChoreListModel("toothbrush.png", "Brush Teeth", true));
			Chores.Add(new ChoreListModel("bed.png", "Make Bed", true));
			Chores.Add(new ChoreListModel("broom.png", "Sweep Room", true));
			Chores.Add(new ChoreListModel("hairbrush.png", "Brush Hair", true));
		}

		public override nint NumberOfSections(UICollectionView collectionView)
		{
			return base.NumberOfSections(collectionView);
		}

		public override nint GetItemsCount(UICollectionView collectionView, nint section)
		{
			return Chores.Count;
		}

		public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
		{
			var dailyChore = (DailyChoreCollectionViewCell)collectionView.DequeueReusableCell(CardCellId, indexPath);
			var chore = Chores[indexPath.Row];

			//initialize chore
			dailyChore.ChoreItem = chore;
			return dailyChore;
		}
	}
}
