using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Calc
{
    public sealed class HistoryViewModel : BaseViewModel<History>
    {
        public string Opgave
        {
            get => Model.Opgave;
            set => SetProperty(Model.Opgave, value, () => Model.Opgave = value);
        }

        public string Result
        {
            get => Model.Result;
            set => SetProperty(Model.Result, value, () => Model.Result = value);
        }

        public HistoryViewModel(History model) : base(model)
        {

        }
    }
}
