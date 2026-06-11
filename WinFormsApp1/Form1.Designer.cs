namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefill = new Button();
            txtOut = new RichTextBox();
            btnGet = new Button();
            txtInfo = new RichTextBox();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(12, 23);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(231, 23);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 106);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(144, 96);
            txtOut.TabIndex = 1;
            txtOut.Text = "";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(162, 106);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(81, 96);
            btnGet.TabIndex = 2;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 59);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(231, 41);
            txtInfo.TabIndex = 3;
            txtInfo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 214);
            Controls.Add(txtInfo);
            Controls.Add(btnGet);
            Controls.Add(txtOut);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtOut;
        private Button btnGet;
        private RichTextBox txtInfo;
    }
}
