using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace MauiAppBlazorTest;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.Landscape, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]


public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        
        //base.SetTheme(Resource.Style.Maui_SplashTheme);
        base.OnCreate(savedInstanceState);

        if (Build.VERSION.SdkInt < Android.OS.BuildVersionCodes.Lollipop)
            return;
        var activity = Platform.CurrentActivity;
        var window = activity.Window;

        window.AddFlags(Android.Views.WindowManagerFlags.DrawsSystemBarBackgrounds);
        window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
        window.SetStatusBarColor(Android.Graphics.Color.Rgb(50, 51, 61));

        if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
        {
            window.DecorView.SystemUiVisibility = Android.Views.StatusBarVisibility.Hidden;
        }


    }

}



