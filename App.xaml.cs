using MauiTutoriales.Pages;

namespace MauiTutoriales
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*MainPage = new FlyoutPageT();*/ /* Paginas Menu */

            MainPage = new TabbedPageT();
        }
        
    }
}