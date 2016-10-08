//MIT License

//Copyright(c) 2016 Dheeraj Kumar Gunti

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System.Drawing;
using CoreAnimation;
using UIKit;
using CoreGraphics;

namespace KBProgressLoader
{
    /// <summary>
    /// Progress loader.
    /// </summary>
    public  class ProgressLoader : UIView
	{
		#region Private Properties

		private UIImageView LoadingImages = new UIImageView ();

		private UIImage[] LoadingImagesArray { get; set; }

		private UIView TransperantView  { get; set; }

		private UILabel LblPleaseWait { get; set; }

		private UITextView TitleView { get; set; }

		private UIButton OkButton { get; set; }

        private double loaderWidth { get;  set;}

        private double loaderHeight { get;  set; }

		#endregion

		#region Public Properties

		private string _loaderDescription;
        private string _loaderTitle;
        private UIView _mainView;
        private string[] _loadingSprites;
        private ProgressType _progressType;
        private LoaderType _type;

        public string LoaderDescription {
			get {
				return this._loaderDescription;
			}
			set {
				this._loaderDescription = value;
			}
		}
		public UIView MainView {
			get {
				return this._mainView;
			}
			set {
				this._mainView = value;
			}
		}
		public string LoaderTitle {
			get {
				return this._loaderTitle;
			}
			set {
				this._loaderTitle = value;
			}
		}
		public string[] LoadingSprites {
			get {
				return this._loadingSprites;
			}
			set {
				this._loadingSprites = value;
			}
		}
		public ProgressType ProgressLoaderType {
			get {
				return this._progressType;
			}
			set {
				this._progressType = value;
			}
		}
		public LoaderType Type {
			get {
				return this._type;
			}
			set {
				this._type = value;
			}
		}

        #endregion

        /// <summary>
        /// Initializes a new instance of the ProgressLoader class.
        /// </summary>
        /// <param name="currentView">The Presenting view.</param>
        public ProgressLoader (UIView currentView)
		{
			this.MainView = currentView;
		}

        /// <summary>
        /// Displays the Loader.
        /// </summary>
        public void Show ()
		{
			if (ProgressLoaderType == ProgressType.Loader) {
				string errorMessage = string.Empty;
             
				if (Type == LoaderType.Custom) {
					if (LoadingSprites == null) {
						errorMessage = "Please Specify Loading Image Sprites";
					}
				}

				if (Type == null) {
					errorMessage = "Please Specify Loader Type - Type1 or Type 2 or Type 3 or Type 4 or Custom";
				}

				if (string.IsNullOrWhiteSpace (Description)) {
					errorMessage = "Please Specify Loader Description";
				}

				if (string.IsNullOrWhiteSpace (errorMessage)) {
					ShowLoading ();    
				}
               
			} else if (ProgressLoaderType == ProgressType.Error) {
				ShowError ();
			} else if (ProgressLoaderType == ProgressType.Info) {
				ShowInfo ();
			} else if (ProgressLoaderType == ProgressType.Success) {
				ShowSuccess ();
			}
		}

		/// <summary>
		/// Shows the Loading
		/// </summary>
		private void ShowLoading ()
		{
			CreateLayout ();
			//Creating Loading Images Layout
			this.loaderWidth = 48;
			this.loaderHeight = 48;
			 
			LoadingImages = new UIImageView (new CGRect ((MainView.Bounds.Width / 2) - (this.loaderWidth / 2), 
				120, this.loaderWidth, this.loaderHeight));
			if (this.Type == LoaderType.Type1) {
				LoadingSprites = new string[] {
					"1/Frame-1.png", "1/Frame-2.png", "1/Frame-3.png",
					"1/Frame-4.png", "1/Frame-5.png", "1/Frame-6.png",
					"1/Frame-7.png", "1/Frame-8.png"
				};
				LoadingImagesArray = new  UIImage[LoadingSprites.Length];
				for (int i = 0; i < LoadingSprites.Length; i++) {
					LoadingImagesArray [i] = new UIImage (LoadingSprites [i].ToString ());
				}
				LoadingImages.AnimationImages = LoadingImagesArray;
				LoadingImages.AnimationRepeatCount = 0; 
				LoadingImages.AnimationDuration = 0.8f; 
				LoadingImages.StartAnimating ();
			} else if (this.Type == LoaderType.Type2) {
				LoadingSprites = new string[] {
					"3/Frame_0000.png", "3/Frame_0001.png", "3/Frame_0002.png", "3/Frame_0003.png",
					"3/Frame_0004.png", "3/Frame_0005.png", "3/Frame_0006.png", "3/Frame_0007.png",
					"3/Frame_0008.png", "3/Frame_0009.png", "3/Frame_0010.png", "3/Frame_0011.png",
					"3/Frame_0012.png", "3/Frame_0013.png", "3/Frame_0014.png", "3/Frame_0015.png",
					"3/Frame_0016.png", "3/Frame_0017.png", "3/Frame_0018.png", "3/Frame_0019.png",
					"3/Frame_0020.png", "3/Frame_0021.png", "3/Frame_0022.png", "3/Frame_0023.png"
				};
				LoadingImagesArray = new  UIImage[LoadingSprites.Length];
				for (int i = 0; i < LoadingSprites.Length; i++) {
					LoadingImagesArray [i] = new UIImage (LoadingSprites [i].ToString ());
				}
				LoadingImages.AnimationImages = LoadingImagesArray;
				LoadingImages.AnimationRepeatCount = 0; 
				LoadingImages.AnimationDuration = 0.9f; 
				LoadingImages.StartAnimating ();
			} else if (this.Type == LoaderType.Type3) {
				LoadingSprites = new string[] {
					"2/Frame-1.png", "2/Frame-2.png", "2/Frame-3.png",
					"2/Frame-4.png", "2/Frame-5.png", "2/Frame-6.png",
					"2/Frame-7.png", "2/Frame-8.png"
				};
				LoadingImagesArray = new  UIImage[LoadingSprites.Length];
				for (int i = 0; i < LoadingSprites.Length; i++) {
					LoadingImagesArray [i] = new UIImage (LoadingSprites [i].ToString ());
				}
				LoadingImages.AnimationImages = LoadingImagesArray;
				LoadingImages.AnimationRepeatCount = 0; 
				LoadingImages.AnimationDuration = 1f; 
				LoadingImages.StartAnimating ();
			} else if (this.Type == LoaderType.Type4) {
				LoadingSprites = new string[] {
					"4/Frame_0000.png", "4/Frame_0001.png", "4/Frame_0002.png", "4/Frame_0003.png",
					"4/Frame_0004.png", "4/Frame_0005.png", "4/Frame_0006.png", "4/Frame_0007.png",
					"4/Frame_0008.png", "4/Frame_0009.png", "4/Frame_0010.png", "4/Frame_0011.png",
					"4/Frame_0012.png", "4/Frame_0013.png", "4/Frame_0014.png", "4/Frame_0015.png",
					"4/Frame_0016.png", "4/Frame_0017.png", "4/Frame_0018.png", "4/Frame_0019.png"
				};
				LoadingImagesArray = new  UIImage[LoadingSprites.Length];
				for (int i = 0; i < LoadingSprites.Length; i++) {
					LoadingImagesArray [i] = new UIImage (LoadingSprites [i].ToString ());
				}
				LoadingImages.AnimationImages = LoadingImagesArray;
				LoadingImages.AnimationRepeatCount = 0; 
				LoadingImages.AnimationDuration = 0.8f; 
				LoadingImages.StartAnimating ();
			} else {
				LoadingImagesArray = new  UIImage[LoadingSprites.Length];
				for (int i = 0; i < LoadingSprites.Length; i++) {
					LoadingImagesArray [i] = new UIImage (LoadingSprites [i].ToString ());
				}
				LoadingImages.AnimationImages = LoadingImagesArray;
				LoadingImages.AnimationRepeatCount = 0; 
				LoadingImages.AnimationDuration = 0.8f; 
				LoadingImages.StartAnimating ();
			}
			//Creating Please Wait Label
			LblPleaseWait = new UILabel ();
			LblPleaseWait.Frame = new CGRect (0, LoadingImages.Frame.Y + LoadingImages.Frame.Height + 10, MainView.Bounds.Width, 20);
			LblPleaseWait.Text = LoaderTitle;
			LblPleaseWait.TextAlignment = UITextAlignment.Center;
			LblPleaseWait.TextColor = UIColor.White;
			LblPleaseWait.BackgroundColor = UIColor.Clear;
			LblPleaseWait.Font = UIFont.FromName ("GillSans", 14);

			//Creating Description Label
			TitleView = new UITextView ();
			TitleView.Frame = new CGRect (0, LblPleaseWait.Frame.Y + LblPleaseWait.Frame.Height, 
				MainView.Bounds.Width, 300);
			TitleView.Text = LoaderDescription;
			TitleView.TextAlignment = UITextAlignment.Center;
			TitleView.TextColor = UIColor.White;
			TitleView.UserInteractionEnabled = false;
			TitleView.BackgroundColor = UIColor.Clear;
			TitleView.Font = UIFont.FromName ("GillSans", 14);
			//Adding all the views to Main View
			MainView.AddSubview (LoadingImages);
			MainView.AddSubview (LblPleaseWait);
			MainView.AddSubview (TitleView);
			MainView.AddSubview (TransperantView); 
			MainView.BringSubviewToFront (LoadingImages);
			MainView.BringSubviewToFront (LblPleaseWait);
			MainView.BringSubviewToFront (TitleView);
		}

		private void ShowSuccess ()
		{
			System.Timers.Timer waitTimer = new System.Timers.Timer ();
			waitTimer.Interval = 3000;
			waitTimer.Start ();
			CreateLayout ();
			this.loaderWidth = 48;
			this.loaderHeight = 48;
			LoadingImages = new UIImageView (new CGRect ((MainView.Bounds.Width / 2) - (this.loaderWidth / 2), 
				120, this.loaderWidth, this.loaderHeight));
			LoadingImages.Image = UIImage.FromFile ("Alerts/Success.png");
			TitleView = new UITextView ();
			TitleView.Frame = new CGRect (0, LoadingImages.Frame.Y + LoadingImages.Frame.Height + 10, 
				TransperantView.Frame.Width, 300);
			TitleView.Text = Description;
			TitleView.TextAlignment = UITextAlignment.Center;
			TitleView.TextColor = UIColor.White;
			TitleView.UserInteractionEnabled = false;
			TitleView.BackgroundColor = UIColor.Clear;
			TitleView.Font = UIFont.FromName ("GillSans", 16);
			waitTimer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				InvokeOnMainThread (delegate {
					if (TransperantView != null)
						TransperantView.Hidden = true;
					if (TitleView != null)
						TitleView.Hidden = true;
					if (LoadingImages != null)
						LoadingImages.Hidden = true;
					var transition = CATransition.CreateAnimation ();
					transition.Duration = 0.25;
					transition.Speed = 1f;
					transition.Type = CATransition.TransitionPush;
					transition.Subtype = CATransition.TransitionFade;
					TransperantView.Layer.AddAnimation (transition, "fade");
					TransperantView.Layer.AddAnimation (transition, "fade");
					waitTimer.Stop ();
					waitTimer.Close ();
					waitTimer.Dispose ();
				});
			};

			//Adding all the views to Main View
			MainView.AddSubview (LoadingImages);
			MainView.AddSubview (TitleView);
			MainView.AddSubview (TransperantView); 
			MainView.BringSubviewToFront (LoadingImages);
			MainView.BringSubviewToFront (TitleView);
			var transitionSlide = CATransition.CreateAnimation ();
			transitionSlide.Duration = 0.25;
			transitionSlide.Speed = 1f;
			transitionSlide.Type = CATransition.TransitionPush;
			transitionSlide.Subtype = CATransition.TransitionFade;
			TransperantView.Layer.AddAnimation (transitionSlide, "fade");
			TransperantView.Layer.AddAnimation (transitionSlide, "fade");
		}

		private void ShowInfo ()
		{
			System.Timers.Timer waitTimer = new System.Timers.Timer ();
			waitTimer.Interval = 3000;
			waitTimer.Start ();
			CreateLayout ();
			this.loaderWidth = 48;
			this.loaderHeight = 48;
			LoadingImages = new UIImageView (new CGRect ((MainView.Bounds.Width / 2) - (this.loaderWidth / 2), 
				120, this.loaderWidth, this.loaderHeight));
			LoadingImages.Image = UIImage.FromFile ("Alerts/Info.png");
			TitleView = new UITextView ();
			TitleView.Frame = new CGRect (0, LoadingImages.Frame.Y + LoadingImages.Frame.Height + 10, 
				TransperantView.Frame.Width, 300);
			TitleView.Text = Description;
			TitleView.TextAlignment = UITextAlignment.Center;
			TitleView.TextColor = UIColor.White;
			TitleView.UserInteractionEnabled = false;
			TitleView.BackgroundColor = UIColor.Clear;
			TitleView.Font = UIFont.FromName ("GillSans", 16);
			waitTimer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				InvokeOnMainThread (delegate {
					if (TransperantView != null)
						TransperantView.Hidden = true;
					if (TitleView != null)
						TitleView.Hidden = true;
					if (LoadingImages != null)
						LoadingImages.Hidden = true;
					var transition = CATransition.CreateAnimation ();
					transition.Duration = 0.25;
					transition.Speed = 1f;
					transition.Type = CATransition.TransitionPush;
					transition.Subtype = CATransition.TransitionFade;
					TransperantView.Layer.AddAnimation (transition, "fade");
					TransperantView.Layer.AddAnimation (transition, "fade");
					waitTimer.Stop ();
					waitTimer.Close ();
					waitTimer.Dispose ();
				});
			};

			//Adding all the views to Main View
			MainView.AddSubview (LoadingImages);
			MainView.AddSubview (TitleView);
			MainView.AddSubview (TransperantView); 
			MainView.BringSubviewToFront (LoadingImages);
			MainView.BringSubviewToFront (TitleView);
			var transitionSlide = CATransition.CreateAnimation ();
			transitionSlide.Duration = 0.25;
			transitionSlide.Speed = 1f;
			transitionSlide.Type = CATransition.TransitionPush;
			transitionSlide.Subtype = CATransition.TransitionFade;
			TransperantView.Layer.AddAnimation (transitionSlide, "fade");
			TransperantView.Layer.AddAnimation (transitionSlide, "fade");
		}

		private void ShowError ()
		{
			System.Timers.Timer waitTimer = new System.Timers.Timer ();
			waitTimer.Interval = 3000;
			waitTimer.Start ();
			CreateLayout ();
			this.loaderWidth = 48;
			this.loaderHeight = 48;
			LoadingImages = new UIImageView (new CGRect ((MainView.Bounds.Width / 2) - (this.loaderWidth / 2), 
				120, this.loaderWidth, this.loaderHeight));
			LoadingImages.Image = UIImage.FromFile ("Alerts/Error.png");
			TitleView = new UITextView ();
			TitleView.Frame = new CGRect (0, LoadingImages.Frame.Y + LoadingImages.Frame.Height + 10, 
				TransperantView.Frame.Width, 300);
			TitleView.Text = Description;
			TitleView.TextAlignment = UITextAlignment.Center;
			TitleView.TextColor = UIColor.White;
			TitleView.UserInteractionEnabled = false;
			TitleView.BackgroundColor = UIColor.Clear;
			TitleView.Font = UIFont.FromName ("GillSans", 16);
			waitTimer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				InvokeOnMainThread (delegate {
					if (TransperantView != null)
						TransperantView.Hidden = true;
					if (TitleView != null)
						TitleView.Hidden = true;
					if (LoadingImages != null)
						LoadingImages.Hidden = true;
					var transition = CATransition.CreateAnimation ();
					transition.Duration = 0.25;
					transition.Speed = 1f;
					transition.Type = CATransition.TransitionPush;
					transition.Subtype = CATransition.TransitionFade;
					TransperantView.Layer.AddAnimation (transition, "fade");
					TransperantView.Layer.AddAnimation (transition, "fade");
					waitTimer.Stop ();
					waitTimer.Close ();
					waitTimer.Dispose ();
				});
			};
	
			//Adding all the views to Main View
			MainView.AddSubview (LoadingImages);
			MainView.AddSubview (TitleView);
			MainView.AddSubview (TransperantView); 
			MainView.BringSubviewToFront (LoadingImages);
			MainView.BringSubviewToFront (TitleView);
			var transitionSlide = CATransition.CreateAnimation ();
			transitionSlide.Duration = 0.25;
			transitionSlide.Speed = 1f;
			transitionSlide.Type = CATransition.TransitionPush;
			transitionSlide.Subtype = CATransition.TransitionFade;
			TransperantView.Layer.AddAnimation (transitionSlide, "fade");
			TransperantView.Layer.AddAnimation (transitionSlide, "fade");
		}

		private void CreateLayout ()
		{
			TransperantView = new UIView ();
			if (UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeLeft ||
			            UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeRight) {
				TransperantView.Frame = new CGRect (0, 0, UIScreen.MainScreen.Bounds.Height, UIScreen.MainScreen.Bounds.Width);
			} else {
				TransperantView.Frame = new CGRect (0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);
			}
			TransperantView.BackgroundColor = UIColor.FromRGB (9, 13, 19);
			TransperantView.Alpha = 0.8f;
			TransperantView.Hidden = false;
		}

		/// <summary>
		/// Hides the Loading
		/// </summary>
		public void Hide ()
		{
			if (TransperantView != null) {
				TransperantView.Hidden = true; 
			}

			if (LblPleaseWait != null) {
				LblPleaseWait.Hidden = true; 
			}

			if (TitleView != null) {
				TitleView.Hidden = true; 
			}
			if (LoadingImages != null) {
				LoadingImages.StopAnimating ();
			}
		}
	}
}

