using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CruduxCruo.Agnostic
{
    public class DataModel<TSelf> : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public bool HasErrors => false;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return Enumerable.Empty<string>();
        }
    }
}
