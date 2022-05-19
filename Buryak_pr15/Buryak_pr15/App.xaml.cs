using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Buryak_pr15
{
    public partial class App : Application
    {

        static fortime dataBase;

        // Create the database connection as a singleton.
        internal static fortime DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new fortime(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Times.db3"));
                }
                return dataBase;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
