using System;

using System.Globalization;

using UIKit;

namespace ChoreTracker
{
	public partial class DataViewController : UIViewController
	{
		public string DataObject
		{
			get; set;
		}

		protected DataViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			//dataLabel.Text = DataObject;
            DateTime currentDate = DateTime.Now;
			int currentMonth = currentDate.Month;
			string dateMonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
			dataLabel.Text = dateMonthName;
			switch (currentDate.Day)
			//switch (32)
			{
				case 1:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 1");
					break;
				case 2:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 2");
					break;
				case 3:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 3");
					break;
				case 4:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 4");
					break;
				case 5:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 5");
					break;
				case 6:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 6");
					break;
				case 7:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 7");
					break;
				case 8:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 8");
					break;
				case 9:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 9");
					break;
				case 10:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 10");
					break;
				case 11:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 11");
					break;
				case 12:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 12");
					break;
				case 13:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 13");
					break;
				case 14:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 14");
					break;
				case 15:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 15");
					break;
				case 16:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 16");
					break;
				case 17:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 17");
					break;
				case 18:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 18");
					break;
				case 19:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 19");
					break;
				case 20:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 20");
					break;
				case 21:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 21");
					break;
				case 22:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 22");
					break;
				case 23:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 23");
					break;
				case 24:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 24");
					break;
				case 25:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 25");
					break;
				case 26:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 26");
					break;
				case 27:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 27");
					break;
				case 28:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 28");
					break;
				case 29:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 29");
					break;
				case 30:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 30");
					break;
				case 31:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day 31");
					break;
				default:
					msDayNumber.Image = UIImage.FromBundle("Main Screen Day Default");
					break;
			}
					
					
			//if (currentDate.Day == 2)
			//{
			//	msDayNumber.Image = UIImage.FromBundle("Main Screen Day 1");
			//}
			//else
			//{
			//	msDayNumber.Image = UIImage.FromBundle("Main Screen Day 30");
			//}
		}
	}
}
