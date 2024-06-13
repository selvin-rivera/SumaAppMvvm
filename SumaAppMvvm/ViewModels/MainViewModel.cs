using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumaAppMvvm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? value1;

        [ObservableProperty]
        private string? value2;

        [ObservableProperty]
        private string? result;

        public MainViewModel()
        {
            SumCommand = new RelayCommand(OnSum);
            ClearCommand = new RelayCommand(OnClear);
        }

        public ICommand SumCommand { get; }
        public ICommand ClearCommand { get; }


        private void OnSum()
        {
            if (double.TryParse(Value1, out double v1) && double.TryParse(Value2, out double v2))
            {
                Result = (v1 + v2).ToString();
            }
            else
            {
                Result = "Entrada inválida";
            }
        }

        private void OnClear()
        {
            Value1 = string.Empty;
            Value2 = string.Empty;
            Result = string.Empty;
        }
    }
}
