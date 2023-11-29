using System;
namespace MainTabTest.ViewModels
{
	public class InnerTabDViewModel : BaseViewModel
	{
		public InnerTabDViewModel(INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService) : base (navigationService, pageDialogs, dialogService)
		{
		}
	}
}

