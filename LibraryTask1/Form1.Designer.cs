namespace LibraryTask1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.replaceBookBtn = new System.Windows.Forms.Button();
            this.identifyAreaBtn = new System.Windows.Forms.Button();
            this.findNumBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // replaceBookBtn
            // 
            this.replaceBookBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceBookBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.replaceBookBtn.Image = global::LibraryTask1.Properties.Resources.white;
            this.replaceBookBtn.Location = new System.Drawing.Point(331, 136);
            this.replaceBookBtn.Name = "replaceBookBtn";
            this.replaceBookBtn.Size = new System.Drawing.Size(145, 55);
            this.replaceBookBtn.TabIndex = 0;
            this.replaceBookBtn.Text = "Replace Books";
            this.replaceBookBtn.UseVisualStyleBackColor = true;
            this.replaceBookBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // identifyAreaBtn
            // 
            this.identifyAreaBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifyAreaBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.identifyAreaBtn.Image = global::LibraryTask1.Properties.Resources.white;
            this.identifyAreaBtn.Location = new System.Drawing.Point(331, 271);
            this.identifyAreaBtn.Name = "identifyAreaBtn";
            this.identifyAreaBtn.Size = new System.Drawing.Size(145, 55);
            this.identifyAreaBtn.TabIndex = 1;
            this.identifyAreaBtn.Text = "Identifying Areas";
            this.identifyAreaBtn.UseVisualStyleBackColor = true;
            this.identifyAreaBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // findNumBtn
            // 
            this.findNumBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findNumBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.findNumBtn.Image = global::LibraryTask1.Properties.Resources.white;
            this.findNumBtn.Location = new System.Drawing.Point(331, 206);
            this.findNumBtn.Name = "findNumBtn";
            this.findNumBtn.Size = new System.Drawing.Size(145, 49);
            this.findNumBtn.TabIndex = 2;
            this.findNumBtn.Text = "Find Call Numbers";
            this.findNumBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to your Local Online Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(306, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please select options below:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::LibraryTask1.Properties.Resources.books;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findNumBtn);
            this.Controls.Add(this.identifyAreaBtn);
            this.Controls.Add(this.replaceBookBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button replaceBookBtn;
        private System.Windows.Forms.Button identifyAreaBtn;
        private System.Windows.Forms.Button findNumBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

