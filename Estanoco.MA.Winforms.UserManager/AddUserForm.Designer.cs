namespace Estanoco.MA.Winforms.UserManager
{
    partial class AddUserForm
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
            txtfullname = new TextBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnsave = new Button();
            SuspendLayout();
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(118, 110);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(186, 23);
            txtfullname.TabIndex = 0;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(118, 160);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(186, 23);
            txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(118, 210);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(186, 23);
            txtpassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(47, 113);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(47, 163);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(47, 213);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(169, 256);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 6;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(376, 372);
            Controls.Add(btnsave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(txtfullname);
            Name = "AddUserForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfullname;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnsave;
    }
}
