namespace WatsonOnMars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.massBox = new System.Windows.Forms.TextBox();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.massLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.watsonWeightOutput = new System.Windows.Forms.Label();
            this.watsonEVAoutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(49, 98);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(100, 20);
            this.massBox.TabIndex = 1;
            this.massBox.Text = "639000000000000000000000";
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(49, 135);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(100, 20);
            this.radiusBox.TabIndex = 2;
            this.radiusBox.Text = "3389000";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massLabel.Location = new System.Drawing.Point(155, 98);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(116, 25);
            this.massLabel.TabIndex = 3;
            this.massLabel.Text = "Mass in kg";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.Location = new System.Drawing.Point(155, 130);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(125, 25);
            this.radiusLabel.TabIndex = 4;
            this.radiusLabel.Text = "Radius in m";
            // 
            // watsonWeightOutput
            // 
            this.watsonWeightOutput.AutoSize = true;
            this.watsonWeightOutput.BackColor = System.Drawing.Color.White;
            this.watsonWeightOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watsonWeightOutput.Location = new System.Drawing.Point(65, 121);
            this.watsonWeightOutput.Name = "watsonWeightOutput";
            this.watsonWeightOutput.Size = new System.Drawing.Size(173, 24);
            this.watsonWeightOutput.TabIndex = 5;
            this.watsonWeightOutput.Text = "watson weight here";
            this.watsonWeightOutput.Visible = false;
            // 
            // watsonEVAoutput
            // 
            this.watsonEVAoutput.AutoSize = true;
            this.watsonEVAoutput.BackColor = System.Drawing.Color.White;
            this.watsonEVAoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watsonEVAoutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.watsonEVAoutput.Location = new System.Drawing.Point(77, 174);
            this.watsonEVAoutput.Name = "watsonEVAoutput";
            this.watsonEVAoutput.Size = new System.Drawing.Size(208, 24);
            this.watsonEVAoutput.TabIndex = 6;
            this.watsonEVAoutput.Text = "watson with EVA output";
            this.watsonEVAoutput.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 600);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calcButton.Location = new System.Drawing.Point(126, 293);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(127, 104);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(115, 316);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(147, 41);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(344, 600);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.watsonEVAoutput);
            this.Controls.Add(this.watsonWeightOutput);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.massLabel);
            this.Controls.Add(this.radiusBox);
            this.Controls.Add(this.massBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Watson on Mars";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label watsonWeightOutput;
        private System.Windows.Forms.Label watsonEVAoutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button resetButton;
    }
}

