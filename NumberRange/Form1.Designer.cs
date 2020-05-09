namespace NumberRange
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
            this.valueButton = new System.Windows.Forms.Button();
            this.endBox = new System.Windows.Forms.TextBox();
            this.startBox = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueButton
            // 
            this.valueButton.Location = new System.Drawing.Point(508, 276);
            this.valueButton.Name = "valueButton";
            this.valueButton.Size = new System.Drawing.Size(102, 23);
            this.valueButton.TabIndex = 0;
            this.valueButton.Text = "Show Values";
            this.valueButton.UseVisualStyleBackColor = true;
            this.valueButton.Click += new System.EventHandler(this.valueButton_Click);
            // 
            // endBox
            // 
            this.endBox.Location = new System.Drawing.Point(510, 225);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(100, 20);
            this.endBox.TabIndex = 1;
            // 
            // startBox
            // 
            this.startBox.Location = new System.Drawing.Point(508, 189);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(100, 20);
            this.startBox.TabIndex = 2;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(347, 192);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(119, 13);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Enter a starting number:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(347, 225);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(123, 13);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "Enter an ending number:";
            // 
            // numberLabel
            // 
            this.numberLabel.Location = new System.Drawing.Point(46, 378);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(407, 23);
            this.numberLabel.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(522, 315);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.valueButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valueButton;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

