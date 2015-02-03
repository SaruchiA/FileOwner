namespace FileOwner
{
    partial class Form1
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
            this.textPath = new System.Windows.Forms.TextBox();
            this.textFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a file path";
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(119, 20);
            this.textPath.Multiline = true;
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(907, 25);
            this.textPath.TabIndex = 1;
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(119, 70);
            this.textFile.Multiline = true;
            this.textFile.Name = "textFile";
            this.textFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textFile.Size = new System.Drawing.Size(402, 165);
            this.textFile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of file names";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textOwner
            // 
            this.textOwner.Location = new System.Drawing.Point(620, 70);
            this.textOwner.Multiline = true;
            this.textOwner.Name = "textOwner";
            this.textOwner.Size = new System.Drawing.Size(406, 165);
            this.textOwner.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(548, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "List of owner names";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textOwner);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textOwner;
        private System.Windows.Forms.Label label3;
    }
}

