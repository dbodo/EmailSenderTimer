namespace EmailSenderAPP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSend = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lMessage = new System.Windows.Forms.Label();
            this.rTBmessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSend.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnSend.Location = new System.Drawing.Point(316, 296);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 36);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(86, 33);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(318, 20);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lEmail.ForeColor = System.Drawing.Color.MistyRose;
            this.lEmail.Location = new System.Drawing.Point(13, 31);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(58, 22);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "E-mail:";
            this.lEmail.Click += new System.EventHandler(this.lEmail_Click);
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lSubject.ForeColor = System.Drawing.Color.MistyRose;
            this.lSubject.Location = new System.Drawing.Point(13, 65);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(67, 22);
            this.lSubject.TabIndex = 4;
            this.lSubject.Text = "Subject:";
            this.lSubject.Click += new System.EventHandler(this.lSubject_Click);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(86, 66);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(318, 20);
            this.tbSubject.TabIndex = 5;
            this.tbSubject.TextChanged += new System.EventHandler(this.tbSubject_TextChanged);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lMessage.ForeColor = System.Drawing.Color.MistyRose;
            this.lMessage.Location = new System.Drawing.Point(13, 103);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(73, 22);
            this.lMessage.TabIndex = 6;
            this.lMessage.Text = "Message:";
            this.lMessage.Click += new System.EventHandler(this.labelMessage_Click);
            // 
            // rTBmessage
            // 
            this.rTBmessage.Location = new System.Drawing.Point(86, 105);
            this.rTBmessage.Name = "rTBmessage";
            this.rTBmessage.Size = new System.Drawing.Size(318, 144);
            this.rTBmessage.TabIndex = 7;
            this.rTBmessage.Text = "";
            this.rTBmessage.TextChanged += new System.EventHandler(this.rTBmessage_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(416, 355);
            this.Controls.Add(this.rTBmessage);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lSubject);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Email sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.RichTextBox rTBmessage;
    }
}

