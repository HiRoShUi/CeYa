using Makro.Core.Serialization.Implementation;
using MaKro.Applications.CeYa.Client.Models;
using MaKro.Applications.CeYa.Client.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MaKro.Applications.CeYa.Client.ViewModels
{
    public class RegistrationViewModel : BindableBase
    {
        private string _firstName;
        private string _lastName;
        private string _mailAdress;
        private string _company;
        private string _contact;
        private Picture _picture;

            #region Commands

        #region BackCommands

        public ICommand BackCommand { get; private set; }
        private void Back()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                var window = Application.Current.MainWindow;
                LoginForm regForm = new LoginForm();
                Application.Current.MainWindow = regForm;
                regForm.Show();
                window.Close();
            });

        }
        private bool LoginFormPossible()
        {
            return true;
        }

        #endregion

        #region Picturecommands
        public ICommand GetPictureCommand { get; private set; }
        private void MakePicture()
        {
            //ToDo: Load camera-settings and make a picture
            throw new NotImplementedException("Prototype-State: Function not yet implemented.");
        }
        private bool PictureCanBeTaken()
        {
            return true;
        }
        #endregion

        #region RegisterCommand

        public ICommand RegisterCommand { get; private set; }
        private void Register(object aiParameter)
        {
            var visitor = new Visitor(Guid.NewGuid(), _firstName, _lastName, _mailAdress, _company, _contact, DateTime.Now, _picture);

            NewtonsoftJsonSerializer serializer = new NewtonsoftJsonSerializer();
            string json = serializer.Serialize(visitor);

            MessageBox.Show(json);

            //ToDo: Sending to webservice
        }
        private bool RegistrationPossible(object aiParameter)
        {
            return true;
        }

        #endregion

        #endregion

        /// <summary>
        /// Initializes the commands.
        /// </summary>
        public RegistrationViewModel()
        {
            BackCommand = new DelegateCommand(Back, LoginFormPossible);
            GetPictureCommand = new DelegateCommand(MakePicture, PictureCanBeTaken);
            this.RegisterCommand = new DelegateCommand<object>(this.Register, this.RegistrationPossible);
        }

        #region Properties

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                SetProperty(ref this._firstName, value);
                RaisePropertyChanged("FirstName");              
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                SetProperty(ref this._lastName, value);
                RaisePropertyChanged("LastName");
            }
        }

        public string EMailAdress
        {
            get
            {
                return this._mailAdress;
            }
            set
            {
                SetProperty(ref this._mailAdress, value);
                RaisePropertyChanged("EMailAdress");
            }
        }

        public string Company
        {
            get
            {
                return this._company;
            }
            set
            {
                SetProperty(ref this._company, value);
                RaisePropertyChanged("Company");
            }
        }

        public string Contact
        {
            get
            {
                return this._contact;
            }
            set
            {
                SetProperty(ref this._contact, value);
                RaisePropertyChanged("Contact");
            }
        }


        #endregion

    }
}
