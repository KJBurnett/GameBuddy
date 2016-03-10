namespace Game_Buddy
{
    partial class EmailForm
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.SendFeedbackButton = new System.Windows.Forms.Button();
            this.BodyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(117, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(327, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Please enter any feedback below. I will get to it as soon as possible!";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Subject: ";
            // 
            // SubjectBox
            // 
            this.SubjectBox.Location = new System.Drawing.Point(67, 46);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(590, 20);
            this.SubjectBox.TabIndex = 7;
            // 
            // SendFeedbackButton
            // 
            this.SendFeedbackButton.Location = new System.Drawing.Point(14, 13);
            this.SendFeedbackButton.Name = "SendFeedbackButton";
            this.SendFeedbackButton.Size = new System.Drawing.Size(97, 23);
            this.SendFeedbackButton.TabIndex = 6;
            this.SendFeedbackButton.Text = "Send Feedback!";
            this.SendFeedbackButton.UseVisualStyleBackColor = true;
            this.SendFeedbackButton.Click += new System.EventHandler(this.SendFeedbackButton_Click);
            // 
            // BodyBox
            // 
            this.BodyBox.Location = new System.Drawing.Point(13, 72);
            this.BodyBox.Multiline = true;
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(644, 254);
            this.BodyBox.TabIndex = 5;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 338);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.SendFeedbackButton);
            this.Controls.Add(this.BodyBox);
            this.Name = "EmailForm";
            this.Text = "Send Feedback";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox SubjectBox;
        internal System.Windows.Forms.Button SendFeedbackButton;
        internal System.Windows.Forms.TextBox BodyBox;
    }
}