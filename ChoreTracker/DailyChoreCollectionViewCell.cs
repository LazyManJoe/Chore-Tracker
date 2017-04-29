using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace ChoreTracker
{
    public partial class DailyChoreCollectionViewCell : UICollectionViewCell
    {
		private ChoreListModel _choreItem;

		public UIImageView ChoreImage { get; set; }
		public UILabel ChoreTitle { get; set; }

		public ChoreListModel ChoreItem
		{
			get { return _choreItem; }
			set
			{
				_choreItem = value;
				ChoreImage.Image = UIImage.FromFile(ChoreItem.ImageFileName);
				ChoreImage.Alpha = (ChoreItem.CanSelect) ? 1.0f : 0.5f;
				ChoreTitle.Text = ChoreItem.Title;
			}
		}

        public DailyChoreCollectionViewCell (IntPtr handle) : base (handle)
        {
			// Initializee
			ChoreImage = new UIImageView(new CGRect(22, 19, 100, 100));
			AddSubview(ChoreImage);

			ChoreTitle = new UILabel(new CGRect(22, 110, 100, 21))
			{
				TextAlignment = UITextAlignment.Center,
				TextColor = UIColor.Black,
				Alpha = 0.0f
			};
			AddSubview(ChoreTitle);
        }
    }
}