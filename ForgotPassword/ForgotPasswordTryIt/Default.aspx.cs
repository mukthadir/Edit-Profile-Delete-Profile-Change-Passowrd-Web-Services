using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForgotPasswordTryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();

                Dictionary<String, String> userProfile = new Dictionary<string, string>();

                if (TextBox1.Text.Length != 0)
                {
                    userProfile.Add("Name", TextBox1.Text);
                }

                if (TextBox2.Text.Length != 0)
                {
                    userProfile.Add("PhoneNumber", TextBox2.Text);
                }

                if (TextBox10.Text.Length != 0)
                {
                    userProfile.Add("SecurityQuestion1", TextBox10.Text);
                }

                if (TextBox11.Text.Length != 0)
                {
                    userProfile.Add("SecurityAnswer1", TextBox11.Text);
                }

                if (TextBox12.Text.Length != 0)
                {
                    userProfile.Add("SecurityQuestion2", TextBox12.Text);
                }

                if (TextBox13.Text.Length != 0)
                {
                    userProfile.Add("SecurityAnswer2", TextBox13.Text);
                }

                Boolean check = myClient.forgotPassowrd(userProfile, TextBox1.Text);

                if (check == true)
                {
                    if (TextBox3.Text.Length != 0)
                    {
                        if (TextBox3.Text == TextBox4.Text)
                        {
                            userProfile.Add("Password", TextBox3.Text);
                            String result = myClient.saveData(userProfile, TextBox1.Text);

                            TextBox5.Text = result;
                        }
                        else
                        {
                            TextBox5.Text = "Passwords don't match.";
                        }
                    }
                    else
                    {
                        TextBox5.Text = "Empty Password.";
                    }
                }
                else
                {
                    TextBox5.Text = "Wrong credentials provided. Can not allow change of password.";
                }
            }
            catch (Exception ex)
            {
                TextBox5.Text = "Error Somewhere";
            }
        }
    }
}