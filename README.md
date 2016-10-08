# KBProgressLoader
>KB Progress Loader is a custom progress loader which makes your ios application more attractive.
There are custom formats that you can define to make use of this progress loader in to your application.

Type which to be defined first.
- Loader
- Error
- Success   
- Info

Progress Loader Type to be chosen
- Type 1
- Type 2
- Type 3
- Type 4
- Custom

For specifying the Title for the loader we can use *LoaderTitle* property.

Below is the snippet to work with KBProgressLoader

```
 var loader = new ProgressLoader(this.View);
 loader.Type = LoaderType.Type1;
 loader.ProgressLoaderType = ProgressType.Loader;
 loader.LoaderTitle = "Processing...";
 loader.Show();
 this.InvokeOnMainThread(() =>
 {
   //Processing Logic
   loader.Hide();
 });
 ```
