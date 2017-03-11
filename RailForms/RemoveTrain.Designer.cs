namespace RailForms
{
    partial class RemoveTrain
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrainNo = new System.Windows.Forms.Label();
            this.lblTrainInfo = new System.Windows.Forms.Label();
            this.lblTrainType = new System.Windows.Forms.Label();
            this.lblTrainSeats = new System.Windows.Forms.Label();
            this.lblTrainDestination = new System.Windows.Forms.Label();
            this.lblTrainOrigin = new System.Windows.Forms.Label();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.lblTname = new System.Windows.Forms.Label();
            this.lblTtype = new System.Windows.Forms.Label();
            this.lblTseats = new System.Windows.Forms.Label();
            this.lblTOrigin = new System.Windows.Forms.Label();
            this.lblTdestination = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTrainName = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDelateTrain = new System.Windows.Forms.Button();
            this.panelTrainInfo = new System.Windows.Forms.Panel();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblTno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.panelTrainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Zero Threes", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(220, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = ">>> DELETE A TRAIN <<<";
            // 
            // lblTrainNo
            // 
            this.lblTrainNo.AutoSize = true;
            this.lblTrainNo.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainNo.Location = new System.Drawing.Point(14, 43);
            this.lblTrainNo.Name = "lblTrainNo";
            this.lblTrainNo.Size = new System.Drawing.Size(154, 23);
            this.lblTrainNo.TabIndex = 2;
            this.lblTrainNo.Text = "Train Name :";
            this.lblTrainNo.Click += new System.EventHandler(this.lblTrainNo_Click);
            // 
            // lblTrainInfo
            // 
            this.lblTrainInfo.AutoSize = true;
            this.lblTrainInfo.Font = new System.Drawing.Font("Courier New", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainInfo.Location = new System.Drawing.Point(124, 19);
            this.lblTrainInfo.Name = "lblTrainInfo";
            this.lblTrainInfo.Size = new System.Drawing.Size(190, 31);
            this.lblTrainInfo.TabIndex = 5;
            this.lblTrainInfo.Text = "Train Info.";
            this.lblTrainInfo.Click += new System.EventHandler(this.lblTrainInfo_Click);
            // 
            // lblTrainType
            // 
            this.lblTrainType.AutoSize = true;
            this.lblTrainType.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTrainType.Location = new System.Drawing.Point(28, 132);
            this.lblTrainType.Name = "lblTrainType";
            this.lblTrainType.Size = new System.Drawing.Size(190, 23);
            this.lblTrainType.TabIndex = 27;
            this.lblTrainType.Text = "Train Type    :";
            // 
            // lblTrainSeats
            // 
            this.lblTrainSeats.AutoSize = true;
            this.lblTrainSeats.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainSeats.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTrainSeats.Location = new System.Drawing.Point(28, 167);
            this.lblTrainSeats.Name = "lblTrainSeats";
            this.lblTrainSeats.Size = new System.Drawing.Size(190, 23);
            this.lblTrainSeats.TabIndex = 26;
            this.lblTrainSeats.Text = "Total Seats   :";
            // 
            // lblTrainDestination
            // 
            this.lblTrainDestination.AutoSize = true;
            this.lblTrainDestination.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainDestination.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTrainDestination.Location = new System.Drawing.Point(28, 233);
            this.lblTrainDestination.Name = "lblTrainDestination";
            this.lblTrainDestination.Size = new System.Drawing.Size(190, 23);
            this.lblTrainDestination.TabIndex = 23;
            this.lblTrainDestination.Text = "Destination   :";
            // 
            // lblTrainOrigin
            // 
            this.lblTrainOrigin.AutoSize = true;
            this.lblTrainOrigin.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainOrigin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTrainOrigin.Location = new System.Drawing.Point(28, 198);
            this.lblTrainOrigin.Name = "lblTrainOrigin";
            this.lblTrainOrigin.Size = new System.Drawing.Size(190, 23);
            this.lblTrainOrigin.TabIndex = 22;
            this.lblTrainOrigin.Text = "Source Station:";
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTrainName.Location = new System.Drawing.Point(28, 99);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(190, 23);
            this.lblTrainName.TabIndex = 21;
            this.lblTrainName.Text = "Train Name    :";
            // 
            // lblTname
            // 
            this.lblTname.AutoSize = true;
            this.lblTname.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTname.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTname.Location = new System.Drawing.Point(224, 99);
            this.lblTname.Name = "lblTname";
            this.lblTname.Size = new System.Drawing.Size(58, 23);
            this.lblTname.TabIndex = 28;
            this.lblTname.Text = "Null";
            // 
            // lblTtype
            // 
            this.lblTtype.AutoSize = true;
            this.lblTtype.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtype.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTtype.Location = new System.Drawing.Point(224, 132);
            this.lblTtype.Name = "lblTtype";
            this.lblTtype.Size = new System.Drawing.Size(58, 23);
            this.lblTtype.TabIndex = 29;
            this.lblTtype.Text = "Null";
            // 
            // lblTseats
            // 
            this.lblTseats.AutoSize = true;
            this.lblTseats.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTseats.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTseats.Location = new System.Drawing.Point(224, 167);
            this.lblTseats.Name = "lblTseats";
            this.lblTseats.Size = new System.Drawing.Size(58, 23);
            this.lblTseats.TabIndex = 30;
            this.lblTseats.Text = "Null";
            // 
            // lblTOrigin
            // 
            this.lblTOrigin.AutoSize = true;
            this.lblTOrigin.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOrigin.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTOrigin.Location = new System.Drawing.Point(224, 198);
            this.lblTOrigin.Name = "lblTOrigin";
            this.lblTOrigin.Size = new System.Drawing.Size(58, 23);
            this.lblTOrigin.TabIndex = 32;
            this.lblTOrigin.Text = "Null";
            // 
            // lblTdestination
            // 
            this.lblTdestination.AutoSize = true;
            this.lblTdestination.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTdestination.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTdestination.Location = new System.Drawing.Point(224, 233);
            this.lblTdestination.Name = "lblTdestination";
            this.lblTdestination.Size = new System.Drawing.Size(58, 23);
            this.lblTdestination.TabIndex = 33;
            this.lblTdestination.Text = "Null";
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.btnRefresh);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.comboTrainName);
            this.panelInfo.Controls.Add(this.lblTrainNo);
            this.panelInfo.Controls.Add(this.label20);
            this.panelInfo.Location = new System.Drawing.Point(32, 138);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(383, 148);
            this.panelInfo.TabIndex = 34;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(155, 95);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 64;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(66, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Select a Train Name from below";
            // 
            // comboTrainName
            // 
            this.comboTrainName.DisplayMember = "TrainTbl.train_name";
            this.comboTrainName.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTrainName.FormattingEnabled = true;
            this.comboTrainName.Location = new System.Drawing.Point(176, 39);
            this.comboTrainName.Name = "comboTrainName";
            this.comboTrainName.Size = new System.Drawing.Size(174, 31);
            this.comboTrainName.TabIndex = 0;
            this.comboTrainName.ValueMember = "TrainTbl.train_name";
            this.comboTrainName.SelectedIndexChanged += new System.EventHandler(this.comboTrainNo_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(311, -1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 16);
            this.label20.TabIndex = 59;
            this.label20.Text = "*";
            // 
            // btnDelateTrain
            // 
            this.btnDelateTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelateTrain.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelateTrain.Location = new System.Drawing.Point(159, 320);
            this.btnDelateTrain.Name = "btnDelateTrain";
            this.btnDelateTrain.Size = new System.Drawing.Size(155, 35);
            this.btnDelateTrain.TabIndex = 1;
            this.btnDelateTrain.Text = "Delete Train";
            this.btnDelateTrain.UseVisualStyleBackColor = true;
            this.btnDelateTrain.Click += new System.EventHandler(this.btnDelateTrain_Click);
            // 
            // panelTrainInfo
            // 
            this.panelTrainInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrainInfo.Controls.Add(this.btnDelateTrain);
            this.panelTrainInfo.Controls.Add(this.lblConfirmation);
            this.panelTrainInfo.Controls.Add(this.lblTrainType);
            this.panelTrainInfo.Controls.Add(this.lblTrainOrigin);
            this.panelTrainInfo.Controls.Add(this.lblTno);
            this.panelTrainInfo.Controls.Add(this.lblTname);
            this.panelTrainInfo.Controls.Add(this.lblTdestination);
            this.panelTrainInfo.Controls.Add(this.label3);
            this.panelTrainInfo.Controls.Add(this.lblTrainName);
            this.panelTrainInfo.Controls.Add(this.lblTrainDestination);
            this.panelTrainInfo.Controls.Add(this.lblTrainInfo);
            this.panelTrainInfo.Controls.Add(this.lblTOrigin);
            this.panelTrainInfo.Controls.Add(this.lblTrainSeats);
            this.panelTrainInfo.Controls.Add(this.lblTseats);
            this.panelTrainInfo.Controls.Add(this.lblTtype);
            this.panelTrainInfo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelTrainInfo.Location = new System.Drawing.Point(433, 138);
            this.panelTrainInfo.Name = "panelTrainInfo";
            this.panelTrainInfo.Size = new System.Drawing.Size(444, 386);
            this.panelTrainInfo.TabIndex = 35;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmation.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.ForeColor = System.Drawing.Color.Firebrick;
            this.lblConfirmation.Location = new System.Drawing.Point(86, 279);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(274, 22);
            this.lblConfirmation.TabIndex = 58;
            this.lblConfirmation.Text = "Confirmation message!!!!";
            this.lblConfirmation.Visible = false;
            // 
            // lblTno
            // 
            this.lblTno.AutoSize = true;
            this.lblTno.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTno.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTno.Location = new System.Drawing.Point(224, 66);
            this.lblTno.Name = "lblTno";
            this.lblTno.Size = new System.Drawing.Size(58, 23);
            this.lblTno.TabIndex = 28;
            this.lblTno.Text = "Null";
            this.lblTno.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Train No      :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RailForms.Properties.Resources.Actions_process_stop_icon;
            this.pictureBox1.Location = new System.Drawing.Point(98, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(777, 539);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RemoveTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::RailForms.Properties.Resources.Sys_Login_New;
            this.ClientSize = new System.Drawing.Size(914, 580);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelTrainInfo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveTrain";
            this.Text = "Remove a Train";
            this.Load += new System.EventHandler(this.RemoveTrain_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelTrainInfo.ResumeLayout(false);
            this.panelTrainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrainNo;
        private System.Windows.Forms.Label lblTrainInfo;
        private System.Windows.Forms.Label lblTrainType;
        private System.Windows.Forms.Label lblTrainSeats;
        private System.Windows.Forms.Label lblTrainDestination;
        private System.Windows.Forms.Label lblTrainOrigin;
        private System.Windows.Forms.Label lblTrainName;
        private System.Windows.Forms.Label lblTname;
        private System.Windows.Forms.Label lblTtype;
        private System.Windows.Forms.Label lblTseats;
        private System.Windows.Forms.Label lblTOrigin;
        private System.Windows.Forms.Label lblTdestination;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelTrainInfo;
        private System.Windows.Forms.Button btnDelateTrain;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboTrainName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnRefresh;
    }
}