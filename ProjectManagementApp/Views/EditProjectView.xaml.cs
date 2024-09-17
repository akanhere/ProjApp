using ProjectManagementApp.ViewModels;

namespace ProjectManagementApp.Views;

public partial class EditProjectView : ContentPage
{
	public EditProjectView(EditProjectViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
	}
}