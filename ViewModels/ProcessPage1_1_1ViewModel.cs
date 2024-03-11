using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalCustomControls
{
    public partial class ProcessPage1_1_1ViewModel:BaseViewModel
    {
        [ObservableProperty] int back;

        public ProcessPage1_1_1ViewModel()
        {
            Back = 1;
        }

        [RelayCommand] void Add()
        {
            Back += 1;
        }
        [RelayCommand] void Reset()
        {
            Back -= 1;
        }
    }
}
