using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace UWP_Calc
{
    public sealed class CalculatorViewModel : BaseViewModel<Calculator>
    {
        public readonly ICommand AddNumberCommand;
        public readonly ICommand AddOperatorCommand;
        public readonly ICommand ClearNumbersCommand;
        public readonly ICommand SolveCommand;

        public string DisplayValue
        {
            get => Model.DisplayValue;
            set => SetProperty(Model.DisplayValue, value, () => Model.DisplayValue = value);
        }
        public string Display2Value
        {
            get => Model.Display2Value;
            set => SetProperty(Model.Display2Value, value, () => Model.Display2Value = value);
        }
        public bool GetalIngevuld
        {
            get => Model.GetalIngevuld;
            set => SetProperty(Model.GetalIngevuld, value, () => Model.GetalIngevuld = value);
        }
        public string Bewerking
        {
            get => Model.Bewerking;
            set => SetProperty(Model.Bewerking, value, () => Model.Bewerking = value);
        }
        public string Getal1
        {
            get => Model.Getal1;
            set => SetProperty(Model.Getal1, value, () => Model.Getal1 = value);
        }
        public string Getal2
        {
            get => Model.Getal2;
            set => SetProperty(Model.Getal2, value, () => Model.Getal2 = value);
        }
        public bool InvertAfgehandeld
        {
            get => Model.InvertAfgehandeld;
            set => SetProperty(Model.InvertAfgehandeld, value, () => Model.InvertAfgehandeld = value);
        }

        private ObservableCollection<HistoryViewModel> _selectedCalc;
        public ObservableCollection<HistoryViewModel> SelectedCalc
        {
            get => _selectedCalc;
            set => SetProperty(ref _selectedCalc, value);
        }

        private ObservableCollection<HistoryViewModel> _history;
        public ObservableCollection<HistoryViewModel> History
        {
            get => _history;
            set => SetProperty(ref _history, value);
        }

        public CalculatorViewModel(Calculator model) : base(model)
        {
            this.AddNumberCommand = new RelayCommand<string>((s) => AddNumber(s));
            this.AddOperatorCommand = new RelayCommand<object>(AddOperator);
            this.ClearNumbersCommand = new RelayCommand<object>(ClearNumbers);
            this.SolveCommand = new RelayCommand<object>(Solve);
            History = new ObservableCollection<HistoryViewModel>();

        }

        internal void AddNumber(string obj)
        {
            if (GetalIngevuld && !InvertAfgehandeld)
            {
                DisplayValue = "";
                Display2Value = "";
            }
            else if (!GetalIngevuld)
            {
                DisplayValue = "";
            }
            GetalIngevuld = true;
            DisplayValue  += obj.ToString();
            InvertAfgehandeld = true;
        }

        internal void AddOperator(object obj)
        {
            Display2Value = "";
            if (GetalIngevuld && DisplayValue != "-" && (Display2Value.Contains("+") || Display2Value.Contains("-") || Display2Value.Contains("*") || Display2Value.Contains("/")))
            {
                Getal2 = DisplayValue;
                DisplayValue = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
                Getal1 = DisplayValue;
                GetalIngevuld = false;
                Bewerking = obj.ToString();
                Display2Value += Getal2 + " " + Bewerking + " ";
            }

            else if (Display2Value.Length < 1)
            {
                Getal1 = DisplayValue;
                GetalIngevuld = false;
                Bewerking = obj.ToString();
                Display2Value += Getal1 + " " + Bewerking + " ";
            }
            Bewerking = obj.ToString();
            Getal1 = DisplayValue;           
        }

        internal void Solve(object obj)
        {
            if (Bewerking == null)
            {
                Getal1 = DisplayValue;

                History.Add(new HistoryViewModel(new History { Opgave = Getal1, Result = Getal1 }));
            }
            else if (GetalIngevuld && DisplayValue != "-")
            {
                Getal2 = DisplayValue;
                GetalIngevuld = false;
                DisplayValue = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
                Display2Value += " " + Getal2;

                History.Add(new HistoryViewModel(new History { Opgave = Display2Value, Result = DisplayValue }));
                //listView.Items.Add(Display2Value);
            }
            else if (DisplayValue.Any(c => char.IsDigit(c)) && DisplayValue != "-")
            {
                Getal1 = DisplayValue;
                DisplayValue = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
                Display2Value += Getal1 + " " + Bewerking + " " + Getal2;

                History.Add(new HistoryViewModel(new History { Opgave = Display2Value, Result = DisplayValue }));
                //listView.Items.Add(Display2Value);
            }

            Display2Value = "";

        }

        internal void ClearNumbers(object obj)
        {
            DisplayValue = "";
            Display2Value = "";
        }
    }
}
