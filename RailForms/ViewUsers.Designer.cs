namespace RailForms
{
    partial class ViewUsers
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
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.lblTrainInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.AllowUserToAddRows = false;
            this.GridViewUsers.AllowUserToDeleteRows = false;
            this.GridViewUsers.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Location = new System.Drawing.Point(79, 126);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.ReadOnly = true;
            this.GridViewUsers.Size = new System.Drawing.Size(956, 358);
            this.GridViewUsers.TabIndex = 0;
            // 
            // lblTrainInfo
            // 
            this.lblTrainInfo.AutoSize = true;
            this.lblTrainInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainInfo.Font = new System.Drawing.Font("Zero Threes", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainInfo.ForeColor = System.Drawing.Color.Gold;
            this.lblTrainInfo.Location = new System.Drawing.Point(322, 44);
            this.lblTrainInfo.Name = "lblTrainInfo";
            this.lblTrainInfo.Size = new System.Drawing.Size(543, 45);
            this.lblTrainInfo.TabIndex = 7;
            this.lblTrainInfo.Text = ">>> ALL SYSTEM USERS <<<";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RailForms.Properties.Resources.user_group_icon;
            this.pictureBox1.Location = new System.Drawing.Point(176, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RailForms.Properties.Resources.Sys_Login_New_001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 503);
            this.Controls.Add(this.lblTrainInfo);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewUsers";
            this.Text = "View all Users";
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Label lblTrainInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}