using MauiAppProj.Model;
 

namespace MauiAppProj;

public partial class RegistrationPage : ContentPage
{
	private User user;

	public RegistrationPage()
	{
		InitializeComponent();
		user = new User();

        user.BirthDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
        dpDate.Date = user.BirthDate;

    }

    private void btnReg_Clicked(object sender, EventArgs e)
    {
        string err=string.Empty;
        if (!IsVailDName())
            err += "Name cannot start with a number and contain spaces\n";
        if (!IsVailDPassword())
           err += "Password must contain an uppercase letter and a number\n";
        if (int.Parse(user.Age) < 18)
            err += "Must be over 18 years old";

        if (lbErr.Text != string.Empty)
        {
            lbErr.Text = err;
            frErr.BackgroundColor = Colors.Ivory;
            frErr.BorderColor = Colors.Ivory;
        }
        else
        {
            lbErr.Text = err;   
            frErr.BackgroundColor = Colors.AntiqueWhite;
            frErr.BorderColor = Colors.AntiqueWhite;
        }


    }

    private bool IsVailDPassword()
    {
        bool isCapital=false, isNumber=false;
         string password=enPassword.Text;
        if (string.IsNullOrEmpty(password))
            return false;
        for (char c = 'A'; c <= 'Z';c++)
            if (password.Contains(c))
                isCapital = true;
        for (char c = '0'; c <= '9'; c++)
            if (password.Contains(c))
                isNumber = true;
        return isCapital && isNumber;
    }

    private bool IsVailDName()
    {
        string name=string.Empty;
        if (enName!=null)
            name=enName.Text;
        if (string.IsNullOrEmpty(name)) 
            return false;
        for (char c = '0' ; c <= '9'; c++)
            if (name[0]==c)
                return false;
        if (name.Contains(' '))
             return false;
        return true;
    }

    private void dpDate_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        user.BirthDate = dpDate.Date;   
        user.Age = (DateTime.Now.Year - user.BirthDate.Year).ToString();
        lbAge.Text = $"age : {user.Age}";
    }
}