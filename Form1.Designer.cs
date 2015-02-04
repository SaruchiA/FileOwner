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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonChangeOwner = new System.Windows.Forms.Button();
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
            this.textFile.Size = new System.Drawing.Size(461, 202);
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
            this.button1.Location = new System.Drawing.Point(389, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(770, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // buttonChangeOwner
            // 
            this.buttonChangeOwner.Location = new System.Drawing.Point(802, 336);
            this.buttonChangeOwner.Name = "buttonChangeOwner";
            this.buttonChangeOwner.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeOwner.TabIndex = 6;
            this.buttonChangeOwner.Text = "changeOwner";
            this.buttonChangeOwner.UseVisualStyleBackColor = true;
            this.buttonChangeOwner.Click += new System.EventHandler(this.buttonChangeOwner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 442);
            this.Controls.Add(this.buttonChangeOwner);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonChangeOwner;
    }
}

