using MauiTutoriales.Data;
using MauiTutoriales.Pages;

using System.Threading.Tasks;

namespace MauiTutoriales
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            /*await Navigation.PushAsync(new Pages.Pagina2());*/
            /*await Navigation.PushModalAsync(new Pages.Pagina2());*/


            FlyoutPageItem item = new FlyoutPageItem()
            {
                Title = "Ejemplo de paginas de Navegacion",
                IconSource ="contacto.png"
            };

            await Navigation.PushModalAsync(new Pages.Pagina2
            {
                BindingContext = item
            });
        }
    }
}
