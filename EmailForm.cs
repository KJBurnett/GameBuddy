using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Buddy
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {

        }

        private void SendFeedbackButton_Click(object sender, EventArgs e)
        {
            string userSubject = SubjectBox.Text;
            string userBody = BodyBox.Text;
            SendEmail(userSubject, userBody);
            this.Close();
        }

        private void SendEmail(string subject, string body)
        {
            MailMessage MyMailMessage = new MailMessage();

            MyMailMessage.From = new MailAddress("gamebuddyfeedback@gmail.com");
            MyMailMessage.To.Add("gamebuddyfeedback@gmail.com");
            MyMailMessage.Subject = "Game Buddy User Feedback: " + subject;
            MyMailMessage.Body = body;

            SmtpClient SMTPServer = new SmtpClient("smtp.gmail.com");
            SMTPServer.Port = 587;
            SMTPServer.Credentials = new System.Net.NetworkCredential("gamebuddyfeedback@gmail.com", "iamafeedbackbot");
            SMTPServer.EnableSsl = true;

            try
            {
                SMTPServer.Send(MyMailMessage);
                MessageBox.Show("Email sent. Thank you!");
            }
            catch (SmtpException ex) { MessageBox.Show(ex.ToString()); }
        }

    }
}
