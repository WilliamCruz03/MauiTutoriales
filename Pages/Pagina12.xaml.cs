using TutorialesMaui.Pages;

namespace MauiTutoriales.Pages;

public partial class Pagina12 : ContentPage
{
	public Pagina12()
	{
		InitializeComponent();
		BindingContext = new PrincipalViewModel();
    }
}