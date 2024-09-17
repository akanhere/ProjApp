using ProjectManagementApp.ViewModels;

namespace ProjectManagementApp.Views;

public partial class HomeView : ContentPage
{
	public HomeView(HomeViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}