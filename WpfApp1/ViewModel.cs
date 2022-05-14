using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    // public enum ProcessState
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string prop)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private bool _s1;
        private bool _s2;
        private bool _s3;
        private bool _s4;

        public bool S1
        {
            get { return _s1; }
            set
            {
                _s1 = value;
                OnPropertyChanged(nameof(S1Visibility));
            }
        }
        public bool S2
        {
            get { return _s2; }
            set
            {
                _s2 = value;
                OnPropertyChanged(nameof(S2Visibility));
            }
        }
        public bool S3
        {
            get { return _s3; }
            set
            {
                _s3 = value;
                OnPropertyChanged(nameof(S3Visibility));
            }
        }
        public bool S4
        {
            get { return _s4; }
            set
            {
                _s4 = value;
                OnPropertyChanged(nameof(S4Visibility));
            }
        }
        public System.Windows.Visibility S1Visibility
        {
            get
            {
                if (_s1)
                    return System.Windows.Visibility.Visible;
                else 
                    return System.Windows.Visibility.Hidden;
            }
        }
        public System.Windows.Visibility S2Visibility
        {
            get
            {
                if (_s2)
                    return System.Windows.Visibility.Visible;
                else
                    return System.Windows.Visibility.Hidden;
            }
        }
        public System.Windows.Visibility S3Visibility
        {
            get
            {
                if (_s3)
                    return System.Windows.Visibility.Visible;
                else
                    return System.Windows.Visibility.Hidden;
            }
        }
        public System.Windows.Visibility S4Visibility
        {
            get
            {
                if (_s4)
                    return System.Windows.Visibility.Visible;
                else
                    return System.Windows.Visibility.Hidden;
            }
        }




    }
}
