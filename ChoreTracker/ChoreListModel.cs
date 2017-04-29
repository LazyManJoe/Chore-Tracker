using System;
namespace ChoreTracker
{
	public class ChoreListModel
	{
		public string ImageFileName { get; set; }
		public string Title { get; set; }
		public bool CanSelect { get; set; }

		public ChoreListModel (string filename, string title, bool canSelect)
		{
			this.ImageFileName = filename;
			this.Title = title;
			this.CanSelect = canSelect;
		}
	}
}
