using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp6
{
    public partial  class MainWindowViewModel :ObservableObject
    {

        [ObservableProperty]  // The ObservableProperty type is an attribute that allows generating observable properties from annotated fields.
        public int fontsize;

        [RelayCommand]
        void IncreaseFontSize()
        {
            Fontsize += 5;
            if (Fontsize > 100) { Fontsize = 100; }
        }
        [RelayCommand]
        void DecreaseFontSize()
        {
              Fontsize-= 5;
            if (Fontsize <= 0) { Fontsize = 0; }
        }
    }
}
