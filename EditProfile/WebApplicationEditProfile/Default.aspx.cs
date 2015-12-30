using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using System.Collections;
using System.Xml.Serialization;
using System.Text;

namespace WebApplicationEditProfile
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

                if (TextBox3.Text.Length != 0)
                {
                    userProfile.Add("EmailID", TextBox3.Text);
                }

                if (TextBox4.Text.Length != 0)
                {
                    userProfile.Add("Address", TextBox4.Text);
                }

                if (TextBox5.Text.Length != 0)
                {
                    userProfile.Add("SSN", TextBox5.Text);
                }

                if (TextBox6.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactName", TextBox6.Text);
                }

                if (TextBox7.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactPhoneNumber", TextBox7.Text);
                }

                if (TextBox8.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactEmailID", TextBox8.Text);
                }

                if (TextBox9.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactRelation", TextBox9.Text);
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

                TextBox14.Text = myClient.modifyUserDetails(userProfile, TextBox1.Text);
                
            }
            catch (Exception ex)
            {
                TextBox14.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();

            TextBox14.Text = myClient.deleteUser(TextBox15.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
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

                if (TextBox3.Text.Length != 0)
                {
                    userProfile.Add("EmailID", TextBox3.Text);
                }

                if (TextBox4.Text.Length != 0)
                {
                    userProfile.Add("Address", TextBox4.Text);
                }

                if (TextBox5.Text.Length != 0)
                {
                    userProfile.Add("SSN", TextBox5.Text);
                }

                if (TextBox6.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactName", TextBox6.Text);
                }

                if (TextBox7.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactPhoneNumber", TextBox7.Text);
                }

                if (TextBox8.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactEmailID", TextBox8.Text);
                }

                if (TextBox9.Text.Length != 0)
                {
                    userProfile.Add("EmergencyContactRelation", TextBox9.Text);
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

                TextBox14.Text = myClient.saveData(userProfile, TextBox1.Text);
            }
            catch (Exception ex)
            {
                TextBox14.Text = ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            try
            {
                String output = myClient.displayUserDetails(TextBox16.Text);

                XElement rootElement = XElement.Parse(output);

                foreach (var element in rootElement.Elements())
                {
                    builder.Append(element.Name.LocalName + ": " + element.Value + "\n");
                }

                TextBox14.Text = builder.ToString();
            }
            catch (Exception ex)
            {
                TextBox14.Text = String.Format("User {0} does not exists.", TextBox16.Text);
            }
        }

    


        // Second Service

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();

                Dictionary<String, String> userProfile = new Dictionary<string, string>();

                if (TextBox17.Text.Length != 0)
                {
                    userProfile.Add("Name", TextBox17.Text);
                }

                if (TextBox18.Text.Length != 0)
                {
                    userProfile.Add("PhoneNumber", TextBox18.Text);
                }

                if (TextBox19.Text.Length != 0)
                {
                    userProfile.Add("SecurityQuestion1", TextBox19.Text);
                }

                if (TextBox20.Text.Length != 0)
                {
                    userProfile.Add("SecurityAnswer1", TextBox20.Text);
                }

                if (TextBox21.Text.Length != 0)
                {
                    userProfile.Add("SecurityQuestion2", TextBox21.Text);
                }

                if (TextBox22.Text.Length != 0)
                {
                    userProfile.Add("SecurityAnswer2", TextBox22.Text);
                }

                Boolean check = myClient.forgotPassowrd(userProfile, TextBox17.Text);

                if (check == true)
                {
                    if (TextBox23.Text.Length != 0)
                    {
                        if (TextBox23.Text.Equals(TextBox24.Text))
                        {
                            userProfile.Add("Password", TextBox23.Text);
                            String result = myClient.saveData(userProfile, TextBox17.Text);

                            TextBox25.Text = result;
                        }
                        else
                        {
                            TextBox25.Text = "Passwords don't match.";
                        }
                    }
                    else
                    {
                        TextBox25.Text = "Empty Password.";
                    }
                }
                else
                {
                    TextBox25.Text = "Wrong credentials provided. Can not allow change of password.";
                }
            }
            catch (Exception ex)
            {
                TextBox25.Text = "Error Somewhere";
            }

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            string[] users = myClient.PeopleTravellingToSameDestination(TextBox27.Text, TextBox26.Text);

            TextBox28.Text = string.Join("\n", users.Select(user => user.ToString()));
        }




        protected void Button5_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference2.Service1Client();

            try
            {
                if (!String.IsNullOrWhiteSpace(TextBox29.Text))
                {
                    var result = client.Top10Words(TextBox29.Text);
                    TextBox30.Text = String.Join("\n", result);
                }
                client.Close();
            }
            catch (Exception ex)
            {
                TextBox30.Text = ex.Message;
                client.Abort();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference2.Service1Client();

            try
            {
                if (!String.IsNullOrWhiteSpace(TextBox29.Text))
                {
                    var result = client.Top10ContentWords(TextBox29.Text);
                    TextBox32.Text = String.Join("\n", result);
                }
                client.Close();
            }
            catch (Exception ex)
            {
                TextBox32.Text = ex.Message;
                client.Abort();
            }
        }
    }
}