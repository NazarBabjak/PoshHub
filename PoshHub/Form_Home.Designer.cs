namespace PoshHub
{
    partial class Form_Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Basket = new System.Windows.Forms.PictureBox();
            this.button_Profile = new System.Windows.Forms.PictureBox();
            this.button_Search = new System.Windows.Forms.PictureBox();
            this.button_ForGirls = new System.Windows.Forms.PictureBox();
            this.button_ForBoys = new System.Windows.Forms.PictureBox();
            this.button_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_ForGirls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_ForBoys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button_Basket);
            this.panel1.Controls.Add(this.button_Profile);
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.button_ForGirls);
            this.panel1.Controls.Add(this.button_ForBoys);
            this.panel1.Controls.Add(this.button_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 75);
            this.panel1.TabIndex = 0;
            // 
            // button_Basket
            // 
            this.button_Basket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Basket.Image = global::PoshHub.Properties.Resources.basket;
            this.button_Basket.Location = new System.Drawing.Point(1740, 20);
            this.button_Basket.Name = "button_Basket";
            this.button_Basket.Size = new System.Drawing.Size(41, 34);
            this.button_Basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_Basket.TabIndex = 4;
            this.button_Basket.TabStop = false;
            this.button_Basket.Click += new System.EventHandler(this.button_Basket_Click);
            // 
            // button_Profile
            // 
            this.button_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Profile.Image = global::PoshHub.Properties.Resources.profile;
            this.button_Profile.Location = new System.Drawing.Point(1653, 20);
            this.button_Profile.Name = "button_Profile";
            this.button_Profile.Size = new System.Drawing.Size(38, 34);
            this.button_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_Profile.TabIndex = 4;
            this.button_Profile.TabStop = false;
            this.button_Profile.Click += new System.EventHandler(this.button_Profile_Click);
            // 
            // button_Search
            // 
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.Image = global::PoshHub.Properties.Resources.search;
            this.button_Search.Location = new System.Drawing.Point(1562, 20);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(42, 34);
            this.button_Search.TabIndex = 3;
            this.button_Search.TabStop = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_ForGirls
            // 
            this.button_ForGirls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ForGirls.Image = global::PoshHub.Properties.Resources.forGirls;
            this.button_ForGirls.Location = new System.Drawing.Point(528, 31);
            this.button_ForGirls.Name = "button_ForGirls";
            this.button_ForGirls.Size = new System.Drawing.Size(126, 23);
            this.button_ForGirls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_ForGirls.TabIndex = 2;
            this.button_ForGirls.TabStop = false;
            this.button_ForGirls.Click += new System.EventHandler(this.button_ForGirls_Click);
            // 
            // button_ForBoys
            // 
            this.button_ForBoys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ForBoys.Image = global::PoshHub.Properties.Resources.forBoys;
            this.button_ForBoys.Location = new System.Drawing.Point(353, 27);
            this.button_ForBoys.Name = "button_ForBoys";
            this.button_ForBoys.Size = new System.Drawing.Size(121, 28);
            this.button_ForBoys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_ForBoys.TabIndex = 1;
            this.button_ForBoys.TabStop = false;
            this.button_ForBoys.Click += new System.EventHandler(this.button_ForBoys_Click);
            // 
            // button_Logo
            // 
            this.button_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Logo.Image = global::PoshHub.Properties.Resources.logo;
            this.button_Logo.Location = new System.Drawing.Point(76, 7);
            this.button_Logo.Name = "button_Logo";
            this.button_Logo.Size = new System.Drawing.Size(67, 65);
            this.button_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_Logo.TabIndex = 0;
            this.button_Logo.TabStop = false;
            this.button_Logo.Click += new System.EventHandler(this.button_Logo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 873);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_Basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_ForGirls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_ForBoys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox button_Logo;
        private System.Windows.Forms.PictureBox button_ForBoys;
        private System.Windows.Forms.PictureBox button_ForGirls;
        private System.Windows.Forms.PictureBox button_Search;
        private System.Windows.Forms.PictureBox button_Profile;
        private System.Windows.Forms.PictureBox button_Basket;
    }
}

