using Foundation;
using System;
using UIKit;

namespace ChoreTracker
{
    public partial class DailyChoreListCollectionViewController : UICollectionViewController
    {
		public DailyChoreListCollectionView Collection
		{
			get
			{
				return CollectionView as DailyChoreListCollectionView;
			}
		}
        public DailyChoreListCollectionViewController (IntPtr handle) : base (handle)
        {
        }
		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			Collection.ParentController = this;
		}
    }
}