using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailEncryptionSystem
{
    public partial class Form1 : Form
    {
        private void sendMail(string email,string psw)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(email);
                mail.To.Add("saifullaharshad999@gmail.com");
                mail.Subject = "[Testing email]";
                mail.Body = "This is a test email";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, psw);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                MessageBox.Show("Email sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong/Invalid email!!!");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendMail(textBox1.Text,textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        
    }
}
