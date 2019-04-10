namespace SarreScoresFull
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
            this.uiLogOffButton = new System.Windows.Forms.Button();
            this.uiLoginButton = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.uiPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uiMarksDisplayTextBox = new System.Windows.Forms.TextBox();
            this.uiShowMarks100_0Button = new System.Windows.Forms.Button();
            this.uiShowMarksAZButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.uiMarkEntryConicalTextBox = new System.Windows.Forms.TextBox();
            this.uiMarkEntryClassTestTextBox = new System.Windows.Forms.TextBox();
            this.uiMarkEntryNameTextBox = new System.Windows.Forms.TextBox();
            this.uiStoreMarksButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uiMarkEntryDestructiveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiLogOffButton
            // 
            this.uiLogOffButton.Enabled = false;
            this.uiLogOffButton.Location = new System.Drawing.Point(184, 36);
            this.uiLogOffButton.Name = "uiLogOffButton";
            this.uiLogOffButton.Size = new System.Drawing.Size(75, 23);
            this.uiLogOffButton.TabIndex = 2;
            this.uiLogOffButton.Text = "Log Off";
            this.uiLogOffButton.UseVisualStyleBackColor = true;
            this.uiLogOffButton.Click += new System.EventHandler(this.uiLogOffButton_Click);
            // 
            // uiLoginButton
            // 
            this.uiLoginButton.Location = new System.Drawing.Point(105, 36);
            this.uiLoginButton.Name = "uiLoginButton";
            this.uiLoginButton.Size = new System.Drawing.Size(75, 23);
            this.uiLoginButton.TabIndex = 1;
            this.uiLoginButton.Text = "Log In";
            this.uiLoginButton.UseVisualStyleBackColor = true;
            this.uiLoginButton.Click += new System.EventHandler(this.uiLoginButton_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(46, 12);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(53, 13);
            this.Label11.TabIndex = 38;
            this.Label11.Text = "Password";
            // 
            // uiPasswordTextBox
            // 
            this.uiPasswordTextBox.Location = new System.Drawing.Point(105, 12);
            this.uiPasswordTextBox.Name = "uiPasswordTextBox";
            this.uiPasswordTextBox.PasswordChar = '*';
            this.uiPasswordTextBox.Size = new System.Drawing.Size(154, 20);
            this.uiPasswordTextBox.TabIndex = 0;
            this.uiPasswordTextBox.TextChanged += new System.EventHandler(this.uiPasswordTextBox_TextChanged);
            // 
            // uiMarksDisplayTextBox
            // 
            this.uiMarksDisplayTextBox.Location = new System.Drawing.Point(11, 315);
            this.uiMarksDisplayTextBox.Multiline = true;
            this.uiMarksDisplayTextBox.Name = "uiMarksDisplayTextBox";
            this.uiMarksDisplayTextBox.ReadOnly = true;
            this.uiMarksDisplayTextBox.Size = new System.Drawing.Size(370, 153);
            this.uiMarksDisplayTextBox.TabIndex = 37;
            this.uiMarksDisplayTextBox.TabStop = false;
            this.uiMarksDisplayTextBox.TextChanged += new System.EventHandler(this.uiMarksDisplayTextBox_TextChanged);
            // 
            // uiShowMarks100_0Button
            // 
            this.uiShowMarks100_0Button.Enabled = false;
            this.uiShowMarks100_0Button.Location = new System.Drawing.Point(168, 258);
            this.uiShowMarks100_0Button.Name = "uiShowMarks100_0Button";
            this.uiShowMarks100_0Button.Size = new System.Drawing.Size(142, 51);
            this.uiShowMarks100_0Button.TabIndex = 9;
            this.uiShowMarks100_0Button.Text = "Show Marks (100-0)";
            this.uiShowMarks100_0Button.UseVisualStyleBackColor = true;
            this.uiShowMarks100_0Button.Click += new System.EventHandler(this.uiShowMarks100_0Button_Click);
            // 
            // uiShowMarksAZButton
            // 
            this.uiShowMarksAZButton.Enabled = false;
            this.uiShowMarksAZButton.Location = new System.Drawing.Point(11, 258);
            this.uiShowMarksAZButton.Name = "uiShowMarksAZButton";
            this.uiShowMarksAZButton.Size = new System.Drawing.Size(142, 51);
            this.uiShowMarksAZButton.TabIndex = 8;
            this.uiShowMarksAZButton.Text = "Show Marks (A-Z)";
            this.uiShowMarksAZButton.UseVisualStyleBackColor = true;
            this.uiShowMarksAZButton.Click += new System.EventHandler(this.uiShowMarksAZButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 133);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 13);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "Conical Basket";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(44, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Class Test";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(64, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Name";
            // 
            // uiMarkEntryConicalTextBox
            // 
            this.uiMarkEntryConicalTextBox.Enabled = false;
            this.uiMarkEntryConicalTextBox.Location = new System.Drawing.Point(106, 133);
            this.uiMarkEntryConicalTextBox.MaxLength = 3;
            this.uiMarkEntryConicalTextBox.Name = "uiMarkEntryConicalTextBox";
            this.uiMarkEntryConicalTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiMarkEntryConicalTextBox.TabIndex = 5;
            this.uiMarkEntryConicalTextBox.TextChanged += new System.EventHandler(this.uiMarkEntryConicalTextBox_TextChanged);
            // 
            // uiMarkEntryClassTestTextBox
            // 
            this.uiMarkEntryClassTestTextBox.Enabled = false;
            this.uiMarkEntryClassTestTextBox.Location = new System.Drawing.Point(106, 107);
            this.uiMarkEntryClassTestTextBox.MaxLength = 3;
            this.uiMarkEntryClassTestTextBox.Name = "uiMarkEntryClassTestTextBox";
            this.uiMarkEntryClassTestTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiMarkEntryClassTestTextBox.TabIndex = 4;
            this.uiMarkEntryClassTestTextBox.TextChanged += new System.EventHandler(this.uiMarkEntryClassTestTextBox_TextChanged);
            // 
            // uiMarkEntryNameTextBox
            // 
            this.uiMarkEntryNameTextBox.Enabled = false;
            this.uiMarkEntryNameTextBox.Location = new System.Drawing.Point(105, 81);
            this.uiMarkEntryNameTextBox.Name = "uiMarkEntryNameTextBox";
            this.uiMarkEntryNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.uiMarkEntryNameTextBox.TabIndex = 3;
            this.uiMarkEntryNameTextBox.TextChanged += new System.EventHandler(this.uiMarkEntryNameTextBox_TextChanged);
            // 
            // uiStoreMarksButton
            // 
            this.uiStoreMarksButton.Enabled = false;
            this.uiStoreMarksButton.Location = new System.Drawing.Point(105, 196);
            this.uiStoreMarksButton.Name = "uiStoreMarksButton";
            this.uiStoreMarksButton.Size = new System.Drawing.Size(154, 36);
            this.uiStoreMarksButton.TabIndex = 7;
            this.uiStoreMarksButton.Text = "Store Marks";
            this.uiStoreMarksButton.UseVisualStyleBackColor = true;
            this.uiStoreMarksButton.Click += new System.EventHandler(this.uiStoreMarksButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Destructive Testing";
            // 
            // uiMarkEntryDestructiveTextBox
            // 
            this.uiMarkEntryDestructiveTextBox.Enabled = false;
            this.uiMarkEntryDestructiveTextBox.Location = new System.Drawing.Point(106, 159);
            this.uiMarkEntryDestructiveTextBox.MaxLength = 3;
            this.uiMarkEntryDestructiveTextBox.Name = "uiMarkEntryDestructiveTextBox";
            this.uiMarkEntryDestructiveTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiMarkEntryDestructiveTextBox.TabIndex = 6;
            this.uiMarkEntryDestructiveTextBox.TextChanged += new System.EventHandler(this.uiMarkEntryDestructiveTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiMarkEntryDestructiveTextBox);
            this.Controls.Add(this.uiLogOffButton);
            this.Controls.Add(this.uiLoginButton);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.uiPasswordTextBox);
            this.Controls.Add(this.uiMarksDisplayTextBox);
            this.Controls.Add(this.uiShowMarks100_0Button);
            this.Controls.Add(this.uiShowMarksAZButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.uiMarkEntryConicalTextBox);
            this.Controls.Add(this.uiMarkEntryClassTestTextBox);
            this.Controls.Add(this.uiMarkEntryNameTextBox);
            this.Controls.Add(this.uiStoreMarksButton);
            this.Name = "Form1";
            this.Text = "Sarre Scores System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button uiLogOffButton;
        internal System.Windows.Forms.Button uiLoginButton;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox uiPasswordTextBox;
        internal System.Windows.Forms.TextBox uiMarksDisplayTextBox;
        internal System.Windows.Forms.Button uiShowMarks100_0Button;
        internal System.Windows.Forms.Button uiShowMarksAZButton;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox uiMarkEntryConicalTextBox;
        internal System.Windows.Forms.TextBox uiMarkEntryClassTestTextBox;
        internal System.Windows.Forms.TextBox uiMarkEntryNameTextBox;
        internal System.Windows.Forms.Button uiStoreMarksButton;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox uiMarkEntryDestructiveTextBox;
    }
}

