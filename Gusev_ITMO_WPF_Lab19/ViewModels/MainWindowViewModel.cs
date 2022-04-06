using Gusev_ITMO_WPF_Lab19.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gusev_ITMO_WPF_Lab19.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private double radius;

        private double circumference;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }



        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        public double Circumference
        {
            get
            {
                return circumference;
            }
            set
            {
                circumference = value;
                OnPropertyChanged();
            }
        }

        //public ICommand RadiusToCircumferenceCommand { get; }
        public ICommand RadiusToCircumferenceCommand { get; set; }

        private void OnRadiusToCircumferenceCommandExecute(object p)
        {
            Circumference = MyMath.GetCircumferenceFromRadius(Radius);
        }

        private bool CanRadiusToCircumferenceCommandExecuted(object p)
        {
            if (Radius >= 0) return true;
            else return false;//
        }

        public MainWindowViewModel()
        {
            RadiusToCircumferenceCommand = new RelayCommand(OnRadiusToCircumferenceCommandExecute, CanRadiusToCircumferenceCommandExecuted);
        }
    }
}
