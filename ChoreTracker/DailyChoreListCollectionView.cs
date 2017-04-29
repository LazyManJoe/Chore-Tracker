using Foundation;
using System;
using UIKit;

namespace ChoreTracker
{
    public partial class DailyChoreListCollectionView : UICollectionView
    {
		public static AppDelegate App
		{
			get
			{
				return (AppDelegate)UIApplication.SharedApplication.Delegate;
			}
		}

		public ChoreImageDatasource Source
		{
			get
			{
				return DataSource as ChoreImageDatasource;
			}
		}

		public DailyChoreListCollectionViewController ParentController { get; set; }

        public DailyChoreListCollectionView (IntPtr handle) : base (handle)
        {
			// Initializee
			RegisterClassForCell(typeof(DailyChoreCollectionViewCell), ChoreImageDatasource.CardCellId);
			DataSource = new ChoreImageDatasource(this);
        }
		public override nint NumberOfSections()
		{
			return 1;
		}
		public override void DidUpdateFocus(UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			var previousItem = context.PreviouslyFocusedView as DailyChoreCollectionViewCell;
			if (previousItem != null)
			{
				Animate(0.2, () =>
				{
					previousItem.ChoreTitle.Alpha = 0.0f;
				}
					   );
			}
			var nextItem = context.NextFocusedView as DailyChoreCollectionViewCell;
			if (nextItem != null)
			{
				Animate(0.2, () =>
				{
					nextItem.ChoreTitle.Alpha = 1.0f;
				}
					   );
			}
		}
    }
}