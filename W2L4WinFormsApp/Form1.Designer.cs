namespace W2L4WinFormsApp
{
    partial class btnShow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SampleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SampleButton
            // 
            this.SampleButton.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SampleButton.Location = new System.Drawing.Point(158, 39);
            this.SampleButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SampleButton.Name = "SampleButton";
            this.SampleButton.Size = new System.Drawing.Size(103, 27);
            this.SampleButton.TabIndex = 0;
            this.SampleButton.Text = "Welcome";
            this.SampleButton.UseVisualStyleBackColor = true;
            this.SampleButton.Click += new System.EventHandler(this.SampleButton_Click);
            // 
            // btnShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.SampleButton);
            this.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "btnShow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button SampleButton;
    }
}