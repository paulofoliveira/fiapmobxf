using MOB.XF.MVVMBasic.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MOB.XF.MVVMBasic
{
    public class App : Application
    {
        public App()
        {            
            MainPage = new NavigationPage(new AlunoView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
