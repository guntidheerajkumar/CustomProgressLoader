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

using UIKit;
using CoreGraphics;
using System;

namespace KBProgressLoader
{

	/// <summary>
	/// Progress loader.
	/// </summary>
	public class ProgressLoader
	{
		private static UIView blurView;

		public ProgressLoader()
		{

		}
		/// <summary>
		/// Shows the loading.
		/// </summary>
		/// <param name="currentView">Current view.</param>
		/// <param name="Title">Title.</param>
		/// <param name="loaderType">Loader type.</param>
		/// <param name="duration">Duration.</param>
		/// <param name="loaderImages">Loader images.</param>
		public static void ShowLoading(UIView currentView, string Title, LoaderType loaderType, double duration = 0, UIImage[] loaderImages = null)
		{
			blurView = new UIView() {
				Frame = new CGRect(0, 0, currentView.Frame.Width, currentView.Frame.Height)
			};

			blurView.BackgroundColor = UIColor.Black;
			blurView.Layer.Opacity = 0.5f;
			var halfwidth = UIScreen.MainScreen.Bounds.Width / 2;
			var halfheight = UIScreen.MainScreen.Bounds.Height / 2;
			var image = new UIImageView(new CGRect(halfwidth - 24, halfheight - 44, 48, 48));
			image.AnimationImages = GetImages(loaderType, loaderImages);
			image.AnimationRepeatCount = 0;
			image.AnimationDuration = duration > 0 ? duration : 0.6f;
			image.StartAnimating();
			var label = new UITextView(new CGRect(0, image.Frame.Y + 45, currentView.Frame.Width, 40));
			label.BackgroundColor = UIColor.Clear;
			label.TextAlignment = UITextAlignment.Center;
			label.Text = Title;
			label.Font = UIFont.SystemFontOfSize(14);
			label.TextColor = UIColor.White;
			blurView.AddSubviews(image, label);
			currentView.AddSubview(blurView);
		}

		/// <summary>
		/// Gets the images.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		/// <exception cref="Exception">Please specify custom loader images. You have chose loader type as custom.</exception>
		internal static UIImage[] GetImages(LoaderType type, UIImage[] customLoaderImages)
		{
			UIImage[] loaderImages = null;
			if (type == LoaderType.Type1) {
				loaderImages = new UIImage[] {
					UIImage.FromBundle("1/Frame-1"),
					UIImage.FromBundle("1/Frame-2"),
					UIImage.FromBundle("1/Frame-3"),
					UIImage.FromBundle("1/Frame-4"),
					UIImage.FromBundle("1/Frame-5"),
					UIImage.FromBundle("1/Frame-6"),
					UIImage.FromBundle("1/Frame-7"),
					UIImage.FromBundle("1/Frame-8")
				};
			} else if (type == LoaderType.Type2) {
				loaderImages = new UIImage[] {
					UIImage.FromBundle("3/Frame_0000.png"), UIImage.FromBundle("3/Frame_0001.png"),
					UIImage.FromBundle("3/Frame_0002.png"), UIImage.FromBundle("3/Frame_0003.png"),
					UIImage.FromBundle("3/Frame_0004.png"), UIImage.FromBundle("3/Frame_0005.png"),
					UIImage.FromBundle( "3/Frame_0006.png"), UIImage.FromBundle("3/Frame_0007.png"),
					UIImage.FromBundle("3/Frame_0008.png"), UIImage.FromBundle("3/Frame_0009.png"),
					UIImage.FromBundle( "3/Frame_0010.png"), UIImage.FromBundle("3/Frame_0011.png"),
					UIImage.FromBundle("3/Frame_0012.png"), UIImage.FromBundle("3/Frame_0013.png"),
					UIImage.FromBundle("3/Frame_0014.png"),UIImage.FromBundle( "3/Frame_0015.png"),
					UIImage.FromBundle("3/Frame_0016.png"), UIImage.FromBundle("3/Frame_0017.png"),
					UIImage.FromBundle("3/Frame_0018.png"), UIImage.FromBundle("3/Frame_0019.png"),
					UIImage.FromBundle("3/Frame_0020.png"), UIImage.FromBundle("3/Frame_0021.png"),
					UIImage.FromBundle("3/Frame_0022.png"), UIImage.FromBundle("3/Frame_0023.png")
				};
			} else if (type == LoaderType.Type3) {
				loaderImages = new UIImage[] {
					UIImage.FromBundle("2/Frame-1.png"), UIImage.FromBundle("2/Frame-2.png"),
					UIImage.FromBundle("2/Frame-3.png"),UIImage.FromBundle("2/Frame-4.png"),
					UIImage.FromBundle("2/Frame-5.png"),UIImage.FromBundle( "2/Frame-6.png"),
					UIImage.FromBundle("2/Frame-7.png"), UIImage.FromBundle("2/Frame-8.png")
				};
			} else if (type == LoaderType.Type4) {
				loaderImages = new UIImage[] {
					UIImage.FromBundle("4/Frame_0000.png"), UIImage.FromBundle("4/Frame_0001.png"),
					UIImage.FromBundle("4/Frame_0002.png"), UIImage.FromBundle("4/Frame_0003.png"),
					UIImage.FromBundle("4/Frame_0004.png"), UIImage.FromBundle("4/Frame_0005.png"),
					UIImage.FromBundle("4/Frame_0006.png"), UIImage.FromBundle("4/Frame_0007.png"),
					UIImage.FromBundle("4/Frame_0008.png"), UIImage.FromBundle("4/Frame_0009.png"),
					UIImage.FromBundle("4/Frame_0010.png"), UIImage.FromBundle("4/Frame_0011.png"),
					UIImage.FromBundle("4/Frame_0012.png"), UIImage.FromBundle("4/Frame_0013.png"),
					UIImage.FromBundle("4/Frame_0014.png"), UIImage.FromBundle("4/Frame_0015.png"),
					UIImage.FromBundle("4/Frame_0016.png"), UIImage.FromBundle("4/Frame_0017.png"),
					UIImage.FromBundle("4/Frame_0018.png"), UIImage.FromBundle("4/Frame_0019.png")
				};
			} else if (type == LoaderType.Custom) {
				if (customLoaderImages != null) {
					loaderImages = customLoaderImages;
				} else {
					throw new Exception("Please specify custom loader images. You have chose loader type as custom.");
				}
			}
			return loaderImages;
		}

		/// <summary>
		/// Dismiss the Loader.
		/// </summary>
		public static void Dismiss()
		{
			if (blurView != null) {
				blurView.RemoveFromSuperview();
			}
		}
	}
}

