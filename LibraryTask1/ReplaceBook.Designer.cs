namespace LibraryTask1
{
    partial class ReplaceBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceBook));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lvAscBooks = new System.Windows.Forms.ListView();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(319, 125);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(181, 46);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvBooks
            // 
            this.lvBooks.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvBooks.HideSelection = false;
            this.lvBooks.Location = new System.Drawing.Point(55, 307);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(322, 226);
            this.lvBooks.TabIndex = 1;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate Random Call Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replacing Books System";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(744, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvAscBooks
            // 
            this.lvAscBooks.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvAscBooks.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvAscBooks.HideSelection = false;
            this.lvAscBooks.Location = new System.Drawing.Point(465, 307);
            this.lvAscBooks.Name = "lvAscBooks";
            this.lvAscBooks.Size = new System.Drawing.Size(322, 226);
            this.lvAscBooks.TabIndex = 5;
            this.lvAscBooks.UseCompatibleStateImageBehavior = false;
            this.lvAscBooks.SelectedIndexChanged += new System.EventHandler(this.lvAscBooks_SelectedIndexChanged);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(254, 193);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(302, 29);
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ReplaceBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::LibraryTask1.Properties.Resources.booksCover;
            this.ClientSize = new System.Drawing.Size(868, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.lvAscBooks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBooks);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplaceBook";
            this.Text = "ReplaceBook";
            this.Load += new System.EventHandler(this.ReplaceBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvAscBooks;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button button1;
    }
}