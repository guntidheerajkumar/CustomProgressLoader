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
		private static UIVisualEffectView blurView;

		/// <summary>
		/// Shows the loading.
		/// </summary>
		/// <param name="currentView">Current view.</param>
		/// <param name="Title">Title.</param>
		/// <param name="loaderType">Loader type.</param>
		/// <param name="duration">Duration.</param>
		/// <param name="loaderImages">Loader images.</param>
		public static void ShowLoading(UIView currentView, LoaderType loaderType, string Title = "", double duration = 0, UIImage[] loaderImages = null)
		{
			blurView = new UIVisualEffectView(UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark)) {
				Frame = new CGRect(0, 0, currentView.Frame.Width, currentView.Frame.Height)
			};

			//blurView = new UIView() {
			//	Frame = new CGRect(0, 0, currentView.Frame.Width, currentView.Frame.Height)
			//};

			//blurView.BackgroundColor = UIColor.Black;
			//blurView.Alpha = 0.6f;
			var halfwidth = UIScreen.MainScreen.Bounds.Width / 2;
			var halfheight = UIScreen.MainScreen.Bounds.Height / 2;
			var image = new UIImageView(new CGRect(halfwidth - 15, halfheight - 35, 30, 30));
			image.AnimationImages = GetImages(loaderType, loaderImages);
			image.AnimationRepeatCount = 0;
			image.AnimationDuration = duration > 0 ? duration : 0.8f;
			image.StartAnimating();
			blurView.AddSubview(image);
			if (!string.IsNullOrWhiteSpace(Title)) {
				var label = new UITextView(new CGRect(0, image.Frame.Y + image.Frame.Height, currentView.Frame.Width, 40));
				label.BackgroundColor = UIColor.Clear;
				label.TextAlignment = UITextAlignment.Center;
				label.Text = Title;
				label.Font = UIFont.SystemFontOfSize(14);
				label.TextColor = UIColor.White;
				blurView.AddSubview(label);
			}
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
			if (type == LoaderType.Spin) {
				#region Spin
				loaderImages = new UIImage[] {
					UIImage.FromBundle("Spin/Frame-1"),
					UIImage.FromBundle("Spin/Frame-2"),
					UIImage.FromBundle("Spin/Frame-3"),
					UIImage.FromBundle("Spin/Frame-4"),
					UIImage.FromBundle("Spin/Frame-5"),
					UIImage.FromBundle("Spin/Frame-6"),
					UIImage.FromBundle("Spin/Frame-7"),
					UIImage.FromBundle("Spin/Frame-8")
				};
				#endregion
			} else if (type == LoaderType.CurveSpin) {
				#region CurveSpin
				loaderImages = new UIImage[] {
					UIImage.FromBundle("CurveSpin/Frame-1.png"), UIImage.FromBundle("CurveSpin/Frame-2.png"),
					UIImage.FromBundle("CurveSpin/Frame-3.png"),UIImage.FromBundle("CurveSpin/Frame-4.png"),
					UIImage.FromBundle("CurveSpin/Frame-5.png"),UIImage.FromBundle( "CurveSpin/Frame-6.png"),
					UIImage.FromBundle("CurveSpin/Frame-7.png"), UIImage.FromBundle("CurveSpin/Frame-8.png")
				};
				#endregion
			} else if (type == LoaderType.Squares) {
				#region Squares
				loaderImages = new UIImage[] {
					UIImage.FromBundle("Squares//Frame_0000.png"), UIImage.FromBundle("Squares//Frame_0001.png"),
					UIImage.FromBundle("Squares//Frame_0002.png"), UIImage.FromBundle("Squares//Frame_0003.png"),
					UIImage.FromBundle("Squares//Frame_0004.png"), UIImage.FromBundle("Squares//Frame_0005.png"),
					UIImage.FromBundle( "Squares//Frame_0006.png"), UIImage.FromBundle("Squares//Frame_0007.png"),
					UIImage.FromBundle("Squares//Frame_0008.png"), UIImage.FromBundle("Squares//Frame_0009.png"),
					UIImage.FromBundle( "Squares//Frame_0010.png"), UIImage.FromBundle("Squares//Frame_0011.png"),
					UIImage.FromBundle("Squares//Frame_0012.png"), UIImage.FromBundle("Squares//Frame_0013.png"),
					UIImage.FromBundle("Squares//Frame_0014.png"),UIImage.FromBundle( "Squares//Frame_0015.png"),
					UIImage.FromBundle("Squares//Frame_0016.png"), UIImage.FromBundle("Squares//Frame_0017.png"),
					UIImage.FromBundle("Squares//Frame_0018.png"), UIImage.FromBundle("Squares//Frame_0019.png"),
					UIImage.FromBundle("Squares//Frame_0020.png"), UIImage.FromBundle("Squares//Frame_0021.png"),
					UIImage.FromBundle("Squares//Frame_0022.png"), UIImage.FromBundle("Squares//Frame_0023.png")
				};
				#endregion
			} else if (type == LoaderType.Whiggle) {
				#region Whiggle
				loaderImages = new UIImage[] {
					UIImage.FromBundle("Whiggle/Frame_0000.png"), UIImage.FromBundle("Whiggle/Frame_0001.png"),
					UIImage.FromBundle("Whiggle/Frame_0002.png"), UIImage.FromBundle("Whiggle/Frame_0003.png"),
					UIImage.FromBundle("Whiggle/Frame_0004.png"), UIImage.FromBundle("Whiggle/Frame_0005.png"),
					UIImage.FromBundle("Whiggle/Frame_0006.png"), UIImage.FromBundle("Whiggle/Frame_0007.png"),
					UIImage.FromBundle("Whiggle/Frame_0008.png"), UIImage.FromBundle("Whiggle/Frame_0009.png"),
					UIImage.FromBundle("Whiggle/Frame_0010.png"), UIImage.FromBundle("Whiggle/Frame_0011.png"),
					UIImage.FromBundle("Whiggle/Frame_0012.png"), UIImage.FromBundle("Whiggle/Frame_0013.png"),
					UIImage.FromBundle("Whiggle/Frame_0014.png"), UIImage.FromBundle("Whiggle/Frame_0015.png"),
					UIImage.FromBundle("Whiggle/Frame_0016.png"), UIImage.FromBundle("Whiggle/Frame_0017.png"),
					UIImage.FromBundle("Whiggle/Frame_0018.png"), UIImage.FromBundle("Whiggle/Frame_0019.png")
				};
				#endregion
			} else if (type == LoaderType.HourGlass) {
				#region HourGlass
				loaderImages = new UIImage[] {
					UIImage.FromBundle("HourGlass/hourglass_1"), UIImage.FromBundle("HourGlass/hourglass_2"),
					UIImage.FromBundle("HourGlass/hourglass_3"), UIImage.FromBundle("HourGlass/hourglass_4"),
					UIImage.FromBundle("HourGlass/hourglass_5"), UIImage.FromBundle("HourGlass/hourglass_6"),
					UIImage.FromBundle("HourGlass/hourglass_7"), UIImage.FromBundle("HourGlass/hourglass_8"),
					UIImage.FromBundle("HourGlass/hourglass_9"), UIImage.FromBundle("HourGlass/hourglass_10"),
					UIImage.FromBundle("HourGlass/hourglass_11"), UIImage.FromBundle("HourGlass/hourglass_12"),
					UIImage.FromBundle("HourGlass/hourglass_13"), UIImage.FromBundle("HourGlass/hourglass_14"),
					UIImage.FromBundle("HourGlass/hourglass_15"), UIImage.FromBundle("HourGlass/hourglass_16"),
					UIImage.FromBundle("HourGlass/hourglass_17"), UIImage.FromBundle("HourGlass/hourglass_18"),
					UIImage.FromBundle("HourGlass/hourglass_19"), UIImage.FromBundle("HourGlass/hourglass_20")
				};
				#endregion
			} else if (type == LoaderType.Ring) {
				#region Ring
				loaderImages = new UIImage[] {
					UIImage.FromBundle("Ring/Ring_1"), UIImage.FromBundle("Ring/Ring_2"),
					UIImage.FromBundle("Ring/Ring_3"), UIImage.FromBundle("Ring/Ring_4"),
					UIImage.FromBundle("Ring/Ring_5"), UIImage.FromBundle("Ring/Ring_6"),
					UIImage.FromBundle("Ring/Ring_7"), UIImage.FromBundle("Ring/Ring_8"),
					UIImage.FromBundle("Ring/Ring_9"), UIImage.FromBundle("Ring/Ring_10"),
					UIImage.FromBundle("Ring/Ring_11"), UIImage.FromBundle("Ring/Ring_12"),
					UIImage.FromBundle("Ring/Ring_13"), UIImage.FromBundle("Ring/Ring_14"),
					UIImage.FromBundle("Ring/Ring_15"), UIImage.FromBundle("Ring/Ring_16"),
					UIImage.FromBundle("Ring/Ring_17"), UIImage.FromBundle("Ring/Ring_18"),
					UIImage.FromBundle("Ring/Ring_19"), UIImage.FromBundle("Ring/Ring_20")
				};
				#endregion
			} else if (type == LoaderType.Signal) {
				#region Signal
				loaderImages = new UIImage[] {
					UIImage.FromBundle("Signal/Signal_1"), UIImage.FromBundle("Signal/Signal_2"),
					UIImage.FromBundle("Signal/Signal_3"), UIImage.FromBundle("Signal/Signal_4"),
					UIImage.FromBundle("Signal/Signal_5"), UIImage.FromBundle("Signal/Signal_6"),
					UIImage.FromBundle("Signal/Signal_7"), UIImage.FromBundle("Signal/Signal_8"),
					UIImage.FromBundle("Signal/Signal_9"), UIImage.FromBundle("Signal/Signal_10"),
					UIImage.FromBundle("Signal/Signal_11"), UIImage.FromBundle("Signal/Signal_12"),
					UIImage.FromBundle("Signal/Signal_13"), UIImage.FromBundle("Signal/Signal_14"),
					UIImage.FromBundle("Signal/Signal_15"), UIImage.FromBundle("Signal/Signal_16"),
					UIImage.FromBundle("Signal/Signal_17"), UIImage.FromBundle("Signal/Signal_18"),
					UIImage.FromBundle("Signal/Signal_19"), UIImage.FromBundle("Signal/Signal_20")
				};
				#endregion
			} else if (type == LoaderType.Flickr) {
				#region Flickr
				loaderImages = new UIImage[] {
					UIImage.FromBundle("Flickr/Flickr_1"), UIImage.FromBundle("Flickr/Flickr_2"),
					UIImage.FromBundle("Flickr/Flickr_3"), UIImage.FromBundle("Flickr/Flickr_4"),
					UIImage.FromBundle("Flickr/Flickr_5"), UIImage.FromBundle("Flickr/Flickr_6"),
					UIImage.FromBundle("Flickr/Flickr_7"), UIImage.FromBundle("Flickr/Flickr_8"),
					UIImage.FromBundle("Flickr/Flickr_9"), UIImage.FromBundle("Flickr/Flickr_10"),
					UIImage.FromBundle("Flickr/Flickr_11"), UIImage.FromBundle("Flickr/Flickr_12"),
					UIImage.FromBundle("Flickr/Flickr_13"), UIImage.FromBundle("Flickr/Flickr_14"),
					UIImage.FromBundle("Flickr/Flickr_15"), UIImage.FromBundle("Flickr/Flickr_16"),
					UIImage.FromBundle("Flickr/Flickr_17"), UIImage.FromBundle("Flickr/Flickr_18"),
					UIImage.FromBundle("Flickr/Flickr_19"), UIImage.FromBundle("Flickr/Flickr_20")
				};
				#endregion
			} else if (type == LoaderType.Heart) {
				#region Heart
				loaderImages = new UIImage[] {
					UIImage.FromBundle("Heart/Heart_1"), UIImage.FromBundle("Heart/Heart_2"),
					UIImage.FromBundle("Heart/Heart_3"), UIImage.FromBundle("Heart/Heart_4"),
					UIImage.FromBundle("Heart/Heart_5"), UIImage.FromBundle("Heart/Heart_6"),
					UIImage.FromBundle("Heart/Heart_7"), UIImage.FromBundle("Heart/Heart_8"),
					UIImage.FromBundle("Heart/Heart_9"), UIImage.FromBundle("Heart/Heart_10"),
					UIImage.FromBundle("Heart/Heart_11"), UIImage.FromBundle("Heart/Heart_12"),
					UIImage.FromBundle("Heart/Heart_13"), UIImage.FromBundle("Heart/Heart_14"),
					UIImage.FromBundle("Heart/Heart_15"), UIImage.FromBundle("Heart/Heart_16"),
					UIImage.FromBundle("Heart/Heart_17"), UIImage.FromBundle("Heart/Heart_18"),
					UIImage.FromBundle("Heart/Heart_19"), UIImage.FromBundle("Heart/Heart_20")
				};
				#endregion
			} else if (type == LoaderType.Custom) {
				#region Custom
				if (customLoaderImages != null) {
					loaderImages = customLoaderImages;
				} else {
					throw new Exception("Please specify custom loader images. You have chose loader type as custom.");
				}
				#endregion
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

