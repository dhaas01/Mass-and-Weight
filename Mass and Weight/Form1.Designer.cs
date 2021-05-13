namespace Mass_and_Weight
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
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.massTextLabel = new System.Windows.Forms.Label();
            this.weightTextLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(230, 28);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 20);
            this.massTextBox.TabIndex = 0;
            // 
            // massTextLabel
            // 
            this.massTextLabel.AutoSize = true;
            this.massTextLabel.Location = new System.Drawing.Point(-1, 31);
            this.massTextLabel.Name = "massTextLabel";
            this.massTextLabel.Size = new System.Drawing.Size(200, 13);
            this.massTextLabel.TabIndex = 1;
            this.massTextLabel.Text = "Enter the mass of the object in kilograms:";
            // 
            // weightTextLabel
            // 
            this.weightTextLabel.AutoSize = true;
            this.weightTextLabel.Location = new System.Drawing.Point(64, 85);
            this.weightTextLabel.Name = "weightTextLabel";
            this.weightTextLabel.Size = new System.Drawing.Size(135, 13);
            this.weightTextLabel.TabIndex = 2;
            this.weightTextLabel.Text = "The weight of the object is:";
            // 
            // weightLabel
            // 
            this.weightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightLabel.Location = new System.Drawing.Point(230, 80);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(100, 23);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(35, 130);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 36);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Weight";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(151, 143);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(255, 143);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 210);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTextLabel);
            this.Controls.Add(this.massTextLabel);
            this.Controls.Add(this.massTextBox);
            this.Name = "Form1";
            this.Text = "Mass and Weight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.Label massTextLabel;
        private System.Windows.Forms.Label weightTextLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

