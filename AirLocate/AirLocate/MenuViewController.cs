using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AirLocate {

	public partial class MenuViewController : UITableViewController {

		UIViewController[] controllers = new UIViewController [5];

		public MenuViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			controllers [0] = (UIViewController) Storyboard.InstantiateViewController ("MonitoringViewController");
			controllers [1] = new RangingViewController (UITableViewStyle.Plain);
			controllers [2] = new CalibrationBeginViewController (UITableViewStyle.Plain);
			controllers [3] = (UIViewController) Storyboard.InstantiateViewController ("ConfigurationViewController");
			controllers [4] = (UIViewController) Storyboard.InstantiateViewController ("MapViewController");
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			NavigationController.PushViewController (controllers [indexPath.Row], true);
		}
	}
}