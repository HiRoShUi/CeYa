using MaKro.Applications.CeYa.Client.Views;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace MaKro.Applications.CeYa.Client.ViewModels
{
    public class WelcomeViewModel : BindableBase
    {
        protected Visibility _isLoading;

        public WelcomeViewModel()
        {
            _isLoading = Visibility.Visible;

            Task.Factory.StartNew(() =>
            {
                LoadSettingsFromServer();
            });
        }

        private void LoadSettingsFromServer()
        {
            //ToDo: Loading Algorithm
            Thread.Sleep(5000);
            //When finished -> Loading_Visibility = hidden (not neccessary) and next window.
            IsLoading = Visibility.Hidden;
            Application.Current.Dispatcher.Invoke(() =>
            {
                var window = Application.Current.MainWindow;
                RegistrationForm regForm = new RegistrationForm();
                Application.Current.MainWindow = regForm;
                window.Close();
                regForm.ShowDialog();
            });
        }

        public Visibility IsLoading
        {
            get
            {
                return this._isLoading;
            }
            set
            {
                SetProperty(ref this._isLoading, value);
                RaisePropertyChanged("IsLoading");
            }
        }        
    }
}
