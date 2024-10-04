using ProjectManagementApp.ViewModels;

namespace ProjectManagementApp.Views;

public partial class AddResourceView : ContentPage
{
    public AddResourceView(AddResourceViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}