namespace MauiTutoriales.Pages;

public partial class Image_Vista : ContentPage
{
    public Image_Vista()
    {
        InitializeComponent();
        Diseñador.Add(new Image { Source = ImageSource.FromResource("ControlesTipoVista.ImagenesGif.formatgif.gif"), WidthRequest = 100, HeightRequest = 100 });
    }
}