using MaKro.Applications.CeYa.Client.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MaKro.Applications.CeYa.Client.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        #region Commands




        #region LogoutCommands
        public DelegateCommand LogoutCommand { get; private set; }
        private void Logout()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Environment.Exit(0);
            });

        }
        private bool LogoutPossible()
        {
            return true;
        }
        #endregion

        #region RegisterCommands
        public DelegateCommand RegisterCommand { get; private set; }
        private void Register()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                var window = Application.Current.MainWindow;
                RegistrationForm regForm = new RegistrationForm();
                Application.Current.MainWindow = regForm;
                regForm.Show();
                window.Close();
            });

        }
        private bool RegistrationPossible()
        {
            return true;
        }
        #endregion

        #endregion

        /// <summary>
        /// Initializes the commands.
        /// </summary>
        public LoginViewModel()
        {
            RegisterCommand = new DelegateCommand(Register, RegistrationPossible);
            LogoutCommand = new DelegateCommand(Logout, LogoutPossible);
        }
    
    }
}
