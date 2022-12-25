using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBlazorTest.Interfaces
{
    public interface IThemeEnvironment
    {
#if __ANDROID__
    void SetStatusBarColor(Android.Graphics.Color color, bool darkStatusBar);
#endif
    }
}


