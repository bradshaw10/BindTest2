using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BindTest2
{
    public class Data : INotifyPropertyChanged
    {
        private string _dataText;
        public string DataText
        {
            get
            {
                return _dataText;
            }
            set
            {
                _dataText = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DataText"));

                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
