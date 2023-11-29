using System;
namespace MainTabTest.ViewModels
{
	public class InnerTabAViewModel : BaseViewModel
	{
		public InnerTabAViewModel(INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService) : base(navigationService, pageDialogs, dialogService)
        {
            
		}
    }
}

