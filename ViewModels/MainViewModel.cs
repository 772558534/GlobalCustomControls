using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GlobalCustomControls
{
    public partial class MainViewModel : BaseViewModel
    {

        [ObservableProperty] bool slideMenuVisibility;
        [ObservableProperty] bool systemPage1Visibility;
        [ObservableProperty] bool systemPage2Visibility;

        [ObservableProperty] DateTime text;


        public MainViewModel()
        {
            SlideMenuVisibility = false;
            SystemPage1Visibility = false;
            SystemPage2Visibility = false;

        }

        [RelayCommand]
        void HideSlideMenu()
        {
            SlideMenuVisibility ^= true;
        }

        [RelayCommand]
        void ToSystemPage1()
        {
            SlideMenuVisibility = false;
            SystemPage1Visibility = true;
            SystemPage2Visibility = false;
        }

        [RelayCommand]
        void ToSystemPage2()
        {
            SlideMenuVisibility = false;
            SystemPage1Visibility = false;
            SystemPage2Visibility = true;
        }


    }
}
