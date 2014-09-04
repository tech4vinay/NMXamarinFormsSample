using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NayamodeApp.Views;
using Xamarin.Forms;

namespace NayamodeApp
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new DashboardView(); 
        }
    }
}
