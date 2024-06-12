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
    public class MainViewModel: INotifyPropertyChanged
    {
        private string _value1;
        private string _value2;
        private string _result;

        public string Value1
        {
            get => _value1;
            set
            {
                _value1 = value;
                OnPropertyChanged();
            }
        }

        public string Value2
        {
            get => _value2;
            set
            {
                _value2 = value;
                OnPropertyChanged();
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand SumCommand { get; }
        public ICommand ClearCommand { get; }

        public MainViewModel()
        {
            SumCommand = new Command(OnSum);
            ClearCommand = new Command(OnClear);
        }

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
