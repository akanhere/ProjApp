using ProjectManagementApp.ViewModels;

namespace ProjectManagementApp.Views;

public partial class AddProjectView : ContentPage
{
	public AddProjectView(AddProjectViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}