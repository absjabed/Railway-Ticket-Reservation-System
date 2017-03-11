namespace RailForms
{
    partial class SeeAllReservations
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
            this.lblTrainInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridViewSeeReservations = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSeeReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrainInfo
            // 
            this.lblTrainInfo.AutoSize = true;
            this.lblTrainInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainInfo.Font = new System.Drawing.Font("Zero Threes", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainInfo.ForeColor = System.Drawing.Color.LightYellow;
            this.lblTrainInfo.Location = new System.Drawing.Point(321, 29);
            this.lblTrainInfo.Name = "lblTrainInfo";
            this.lblTrainInfo.Size = new System.Drawing.Size(646, 40);
            this.lblTrainInfo.TabIndex = 10;
            this.lblTrainInfo.Text = ">>> SEE ALL RESERVATIONS HERE <<<";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RailForms.Properties.Resources.ok_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GridViewSeeReservations
            // 
            this.GridViewSeeReservations.BackgroundColor = System.Drawing.Color.Honeydew;
            this.GridViewSeeReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSeeReservations.Location = new System.Drawing.Point(5, 157);
            this.GridViewSeeReservations.Name = "GridViewSeeReservations";
            this.GridViewSeeReservations.Size = new System.Drawing.Size(1234, 354);
            this.GridViewSeeReservations.TabIndex = 12;
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(454, 87);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 36);
            this.btnView.TabIndex = 54;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXIT.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(679, 87);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(112, 36);
            this.btnEXIT.TabIndex = 54;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // SeeAllReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RailForms.Properties.Resources.Sys_Login_New_003;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 523);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.GridViewSeeReservations);
            this.Controls.Add(this.lblTrainInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SeeAllReservations";
            this.Text = "See all Reservations";
            this.Load += new System.EventHandler(this.fSeeReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSeeReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrainInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GridViewSeeReservations;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEXIT;
    }
}