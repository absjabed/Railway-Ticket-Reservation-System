namespace RailForms
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.AdminmenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTrainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNRQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fareListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTrainSchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSysUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.seeAllReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketSellsBetweenDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.AdminpictureBox = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.byUserReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminmenuStrip
            // 
            this.AdminmenuStrip.BackColor = System.Drawing.SystemColors.Info;
            this.AdminmenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminmenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.AdminmenuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.AdminmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ticketToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.userToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.AdminmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdminmenuStrip.Name = "AdminmenuStrip";
            this.AdminmenuStrip.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.AdminmenuStrip.ShowItemToolTips = true;
            this.AdminmenuStrip.Size = new System.Drawing.Size(1280, 31);
            this.AdminmenuStrip.TabIndex = 0;
            this.AdminmenuStrip.Text = "menuStrip1";
            this.AdminmenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainToolStripMenuItem,
            this.removeTrainToolStripMenuItem,
            this.searchTrainsToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::RailForms.Properties.Resources.unnamed;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 23);
            this.toolStripMenuItem1.Text = "Train";
            // 
            // addTrainToolStripMenuItem
            // 
            this.addTrainToolStripMenuItem.Image = global::RailForms.Properties.Resources.Button_Add_icon;
            this.addTrainToolStripMenuItem.Name = "addTrainToolStripMenuItem";
            this.addTrainToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.addTrainToolStripMenuItem.Text = "&Add Train";
            this.addTrainToolStripMenuItem.Click += new System.EventHandler(this.addTrainToolStripMenuItem_Click);
            // 
            // removeTrainToolStripMenuItem
            // 
            this.removeTrainToolStripMenuItem.Image = global::RailForms.Properties.Resources.Button_Close_icon;
            this.removeTrainToolStripMenuItem.Name = "removeTrainToolStripMenuItem";
            this.removeTrainToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.removeTrainToolStripMenuItem.Text = "&Remove Train";
            this.removeTrainToolStripMenuItem.Click += new System.EventHandler(this.removeTrainToolStripMenuItem_Click);
            // 
            // searchTrainsToolStripMenuItem
            // 
            this.searchTrainsToolStripMenuItem.Image = global::RailForms.Properties.Resources.Start_Menu_Search_icon;
            this.searchTrainsToolStripMenuItem.Name = "searchTrainsToolStripMenuItem";
            this.searchTrainsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.searchTrainsToolStripMenuItem.Text = "&Search Trains";
            this.searchTrainsToolStripMenuItem.Click += new System.EventHandler(this.searchTrainsToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.cancelationToolStripMenuItem,
            this.pNRQueryToolStripMenuItem,
            this.fareListToolStripMenuItem});
            this.ticketToolStripMenuItem.Image = global::RailForms.Properties.Resources.Ticket_1_Icon_128;
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Image = global::RailForms.Properties.Resources.Transport_Train_icon;
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.reservationToolStripMenuItem.Text = "&Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // cancelationToolStripMenuItem
            // 
            this.cancelationToolStripMenuItem.Image = global::RailForms.Properties.Resources.remove_ticket_1_icon;
            this.cancelationToolStripMenuItem.Name = "cancelationToolStripMenuItem";
            this.cancelationToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.cancelationToolStripMenuItem.Text = "&Cancelation";
            this.cancelationToolStripMenuItem.Click += new System.EventHandler(this.cancelationToolStripMenuItem_Click);
            // 
            // pNRQueryToolStripMenuItem
            // 
            this.pNRQueryToolStripMenuItem.Image = global::RailForms.Properties.Resources.Start_Menu_Search_icon;
            this.pNRQueryToolStripMenuItem.Name = "pNRQueryToolStripMenuItem";
            this.pNRQueryToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.pNRQueryToolStripMenuItem.Text = "&PNR Query";
            this.pNRQueryToolStripMenuItem.Click += new System.EventHandler(this.pNRQueryToolStripMenuItem_Click);
            // 
            // fareListToolStripMenuItem
            // 
            this.fareListToolStripMenuItem.Image = global::RailForms.Properties.Resources.payment_icon;
            this.fareListToolStripMenuItem.Name = "fareListToolStripMenuItem";
            this.fareListToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.fareListToolStripMenuItem.Text = "&Fare List";
            this.fareListToolStripMenuItem.Click += new System.EventHandler(this.fareListToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkTrainSchedulesToolStripMenuItem,
            this.changeScheduleToolStripMenuItem});
            this.scheduleToolStripMenuItem.Image = global::RailForms.Properties.Resources.calendar__1_;
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // checkTrainSchedulesToolStripMenuItem
            // 
            this.checkTrainSchedulesToolStripMenuItem.Image = global::RailForms.Properties.Resources.Start_Menu_Search_icon;
            this.checkTrainSchedulesToolStripMenuItem.Name = "checkTrainSchedulesToolStripMenuItem";
            this.checkTrainSchedulesToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.checkTrainSchedulesToolStripMenuItem.Text = "&Check Train Schedules";
            this.checkTrainSchedulesToolStripMenuItem.Click += new System.EventHandler(this.checkTrainSchedulesToolStripMenuItem_Click);
            // 
            // changeScheduleToolStripMenuItem
            // 
            this.changeScheduleToolStripMenuItem.Image = global::RailForms.Properties.Resources.Redo_icon;
            this.changeScheduleToolStripMenuItem.Name = "changeScheduleToolStripMenuItem";
            this.changeScheduleToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.changeScheduleToolStripMenuItem.Text = "Change &Schedule";
            this.changeScheduleToolStripMenuItem.Click += new System.EventHandler(this.changeScheduleToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.updateProfileToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.Image = global::RailForms.Properties.Resources.personal;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.userToolStripMenuItem.Text = "User";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::RailForms.Properties.Resources.vcard__1_;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.profileToolStripMenuItem.Text = "&Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::RailForms.Properties.Resources.Key_icon;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.changePasswordToolStripMenuItem.Text = "&Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Image = global::RailForms.Properties.Resources.Apps_system_software_update_icon;
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.updateProfileToolStripMenuItem.Text = "&Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.viewSysUsersToolStripMenuItem});
            this.viewUsersToolStripMenuItem.Image = global::RailForms.Properties.Resources.Edit_Users_icon;
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.viewUsersToolStripMenuItem.Text = "&Sys Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::RailForms.Properties.Resources.add_user_icon;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.addNewUserToolStripMenuItem.Text = "&Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = global::RailForms.Properties.Resources.remove_user_icon;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.deleteUserToolStripMenuItem.Text = "&Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // viewSysUsersToolStripMenuItem
            // 
            this.viewSysUsersToolStripMenuItem.Image = global::RailForms.Properties.Resources.user_group_icon;
            this.viewSysUsersToolStripMenuItem.Name = "viewSysUsersToolStripMenuItem";
            this.viewSysUsersToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.viewSysUsersToolStripMenuItem.Text = "&View Sys Users";
            this.viewSysUsersToolStripMenuItem.Click += new System.EventHandler(this.viewSysUsersToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::RailForms.Properties.Resources.Log_Out_icon;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.seeAllReservationsToolStripMenuItem,
            this.ticketSellsBetweenDatesToolStripMenuItem,
            this.byUserReservationsToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = global::RailForms.Properties.Resources.document_scroll_icon;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // seeAllReservationsToolStripMenuItem
            // 
            this.seeAllReservationsToolStripMenuItem.Image = global::RailForms.Properties.Resources.ok_icon__1_;
            this.seeAllReservationsToolStripMenuItem.Name = "seeAllReservationsToolStripMenuItem";
            this.seeAllReservationsToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.seeAllReservationsToolStripMenuItem.Text = "See all Reservations";
            this.seeAllReservationsToolStripMenuItem.Click += new System.EventHandler(this.seeAllReservationsToolStripMenuItem_Click);
            // 
            // ticketSellsBetweenDatesToolStripMenuItem
            // 
            this.ticketSellsBetweenDatesToolStripMenuItem.Image = global::RailForms.Properties.Resources.document_scroll_icon;
            this.ticketSellsBetweenDatesToolStripMenuItem.Name = "ticketSellsBetweenDatesToolStripMenuItem";
            this.ticketSellsBetweenDatesToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.ticketSellsBetweenDatesToolStripMenuItem.Text = "Ticket Sells Between Dates";
            this.ticketSellsBetweenDatesToolStripMenuItem.Click += new System.EventHandler(this.ticketSellsBetweenDatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::RailForms.Properties.Resources.Info_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Zero Threes", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(229, 475);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authority: Administrator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Zero Threes", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(229, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome!!!!";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Zero Threes", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdmin.Location = new System.Drawing.Point(384, 88);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(150, 25);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "User Name";
            // 
            // AdminpictureBox
            // 
            this.AdminpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminpictureBox.Image = global::RailForms.Properties.Resources.administrator_icon;
            this.AdminpictureBox.Location = new System.Drawing.Point(234, 335);
            this.AdminpictureBox.Name = "AdminpictureBox";
            this.AdminpictureBox.Size = new System.Drawing.Size(137, 137);
            this.AdminpictureBox.TabIndex = 10;
            this.AdminpictureBox.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Zero Threes", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Red;
            this.time.Location = new System.Drawing.Point(879, 87);
            this.time.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(155, 34);
            this.time.TabIndex = 1;
            this.time.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // byUserReservationsToolStripMenuItem
            // 
            this.byUserReservationsToolStripMenuItem.Image = global::RailForms.Properties.Resources.document_scroll_icon;
            this.byUserReservationsToolStripMenuItem.Name = "byUserReservationsToolStripMenuItem";
            this.byUserReservationsToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.byUserReservationsToolStripMenuItem.Text = "By User Reservations";
            this.byUserReservationsToolStripMenuItem.Click += new System.EventHandler(this.byUserReservationsToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::RailForms.Properties.Resources.railway_logo_edi2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.AdminpictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminmenuStrip);
            this.Font = new System.Drawing.Font("Zero Threes", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AdminmenuStrip;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AdminPanel";
            this.Text = "|||| Railway Reservation System |||| ADMIN PANEL ||||";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.AdminmenuStrip.ResumeLayout(false);
            this.AdminmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdminmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTrainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNRQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTrainSchedulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fareListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSysUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox AdminpictureBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem seeAllReservationsToolStripMenuItem;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ticketSellsBetweenDatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byUserReservationsToolStripMenuItem;
    }
}

