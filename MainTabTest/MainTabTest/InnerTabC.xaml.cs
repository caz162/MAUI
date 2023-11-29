using MainTabTest.ViewModels;

namespace MainTabTest;

public partial class InnerTabC : ContentPage
{
	public InnerTabC(InnerTabCViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}