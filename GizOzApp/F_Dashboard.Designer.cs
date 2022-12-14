namespace GizOzApp
{
    partial class F_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Dashboard = new System.Windows.Forms.Button();
            this.bt_profile = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_recommendation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(417, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to GizOz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(358, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(782, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "The GizOz application is an application created to assist users in determining th" +
    "e food \r\nthat must be consumed according to the personal information provided an" +
    "d the selected program.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.bt_Dashboard);
            this.panel1.Controls.Add(this.bt_profile);
            this.panel1.Controls.Add(this.bt_logout);
            this.panel1.Controls.Add(this.bt_recommendation);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 691);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_Dashboard
            // 
            this.bt_Dashboard.BackColor = System.Drawing.Color.Linen;
            this.bt_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Dashboard.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bt_Dashboard.Image = global::GizOzApp.Properties.Resources._12100351;
            this.bt_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Dashboard.Location = new System.Drawing.Point(0, 134);
            this.bt_Dashboard.Name = "bt_Dashboard";
            this.bt_Dashboard.Size = new System.Drawing.Size(264, 82);
            this.bt_Dashboard.TabIndex = 10;
            this.bt_Dashboard.Text = "Dashboard";
            this.bt_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Dashboard.UseVisualStyleBackColor = false;
            // 
            // bt_profile
            // 
            this.bt_profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_profile.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bt_profile.Image = global::GizOzApp.Properties.Resources.jhdhjfdhjfhjf;
            this.bt_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_profile.Location = new System.Drawing.Point(0, 213);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(264, 82);
            this.bt_profile.TabIndex = 9;
            this.bt_profile.Text = "Profile";
            this.bt_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_profile.UseVisualStyleBackColor = true;
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click_1);
            // 
            // bt_logout
            // 
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_logout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bt_logout.Image = ((System.Drawing.Image)(resources.GetObject("bt_logout.Image")));
            this.bt_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.Location = new System.Drawing.Point(0, 609);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(264, 82);
            this.bt_logout.TabIndex = 8;
            this.bt_logout.Text = "Logout";
            this.bt_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_recommendation
            // 
            this.bt_recommendation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_recommendation.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bt_recommendation.Image = ((System.Drawing.Image)(resources.GetObject("bt_recommendation.Image")));
            this.bt_recommendation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_recommendation.Location = new System.Drawing.Point(0, 290);
            this.bt_recommendation.Name = "bt_recommendation";
            this.bt_recommendation.Size = new System.Drawing.Size(264, 82);
            this.bt_recommendation.TabIndex = 6;
            this.bt_recommendation.Text = "Recommendation";
            this.bt_recommendation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_recommendation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_recommendation.UseVisualStyleBackColor = true;
            this.bt_recommendation.Click += new System.EventHandler(this.bt_recommendation_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 135);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GizOzApp.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(30, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(263, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BurlyWood;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(264, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(936, 80);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(67, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Home";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // F_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Dashboard";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_recommendation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_profile;
        private System.Windows.Forms.Button bt_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}