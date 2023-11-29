using System;
namespace MainTabTest.ViewModels
{
	public class InnerTabBViewModel : BaseViewModel
	{
		public InnerTabBViewModel(INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService) : base (navigationService, pageDialogs, dialogService)
		{
		}
	}
}

