using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Threading;
using System.Configuration;

namespace EmailSenderAPP
{
    public partial class Form1 : Form
    {
        
        public string sEmail, sSubject, sBody;
        public Form1()
        {                    
        InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            sEmail = tbEmail.Text;
        }

        private void tbSubject_TextChanged(object sender, EventArgs e)
        {
            sSubject = tbSubject.Text;
        }

        private void rTBmessage_TextChanged(object sender, EventArgs e)
        {
            sBody = rTBmessage.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Mailclient mail = new Mailclient();   
            mail.SendMail(sEmail, sSubject, sBody);         
        }

        private void lEmail_Click(object sender, EventArgs e)
        {

        }

        private void lSubject_Click(object sender, EventArgs e)
        {

        }
    }
}
