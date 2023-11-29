using System;
namespace MainTabTest.ViewModels
{
	public class InnerTabEViewModel : BaseViewModel
	{
		public InnerTabEViewModel(INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService) : base (navigationService, pageDialogs, dialogService)
		{
		}
	}
}

