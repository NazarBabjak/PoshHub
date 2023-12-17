namespace PoshHub.Forms
{
    partial class Form_Search
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
            this.label_search = new System.Windows.Forms.Label();
            this.button_CloseSearch = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_RequestSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(12, 9);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(101, 38);
            this.label_search.TabIndex = 2;
            this.label_search.Text = "ПОШУК";
            // 
            // button_CloseSearch
            // 
            this.button_CloseSearch.AutoSize = true;
            this.button_CloseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CloseSearch.Location = new System.Drawing.Point(734, 9);
            this.button_CloseSearch.Name = "button_CloseSearch";
            this.button_CloseSearch.Size = new System.Drawing.Size(27, 25);
            this.button_CloseSearch.TabIndex = 3;
            this.button_CloseSearch.Text = "Х";
            this.button_CloseSearch.Click += new System.EventHandler(this.button_CloseSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(19, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(658, 4);
            this.panel4.TabIndex = 7;
            // 
            // button_Search
            // 
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.Image = global::PoshHub.Properties.Resources.search2;
            this.button_Search.Location = new System.Drawing.Point(689, 70);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(57, 44);
            this.button_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_Search.TabIndex = 8;
            this.button_Search.TabStop = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(19, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 4);
            this.panel3.TabIndex = 18;
            // 
            // text_RequestSearch
            // 
            this.text_RequestSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_RequestSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_RequestSearch.HideSelection = false;
            this.text_RequestSearch.Location = new System.Drawing.Point(19, 95);
            this.text_RequestSearch.Name = "text_RequestSearch";
            this.text_RequestSearch.Size = new System.Drawing.Size(658, 21);
            this.text_RequestSearch.TabIndex = 30;
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 136);
            this.Controls.Add(this.text_RequestSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_CloseSearch);
            this.Controls.Add(this.label_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Search";
            this.Text = "Form_Search";
            ((System.ComponentModel.ISupportInitialize)(this.button_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label button_CloseSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox button_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_RequestSearch;
    }
}