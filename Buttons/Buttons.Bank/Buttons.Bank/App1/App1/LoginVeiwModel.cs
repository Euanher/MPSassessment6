using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;



namespace LoginDetails.VeiwModels
{
    public class LoginVeiwModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email;
        {
        get {return email;}
    set
        {
        email = value;
        PropertChanged(this, new PropertyChangedEventArgs("Email"));
        }
}

     private string password;
public string Password;
{
    get { return password; }
    set
{
        password = value;
        PropertyChanged(this. new PropertyChangedEventArgs("Password"));
    }
}
public ICommand SubmitCommand { protected set; get; }
public LoginVeiwModel()
{
    SubmitCommand = new Command(OnSubmit);
}
public void OnSubmit()
{
    if (email != "euanheradien@gmail.com" || password != "secret")
        }
DisplayInvalidLoginPrompt()
    }
    }
    }
    }


