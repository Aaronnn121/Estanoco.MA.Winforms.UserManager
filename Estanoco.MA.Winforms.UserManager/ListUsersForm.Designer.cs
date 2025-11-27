namespace Estanoco.MA.Winforms.UserManager
{
    partial class ListUsersForm
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
            dgViewUsers = new DataGridView();
            label1 = new Label();
            btnNew = new Button();
            button2 = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dgViewUsers
            // 
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Location = new Point(70, 105);
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.Size = new Size(283, 240);
            dgViewUsers.TabIndex = 0;
            dgViewUsers.CellContentClick += dgViewUsers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(58, 65);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 1;
            label1.Text = "List of Users";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(70, 367);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(283, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // button2
            // 
            button2.Location = new Point(70, 396);
            button2.Name = "button2";
            button2.Size = new Size(283, 23);
            button2.TabIndex = 3;
            button2.Text = "VIEW";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(70, 338);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(283, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._69237;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(450, 450);
            Controls.Add(btnRefresh);
            Controls.Add(button2);
            Controls.Add(btnNew);
            Controls.Add(label1);
            Controls.Add(dgViewUsers);
            DoubleBuffered = true;
            Name = "ListUsersForm";
            Text = "ListUsersForm";
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgViewUsers;
        private Label label1;
        private Button btnNew;
        private Button button2;
        private Button btnRefresh;
    }
}