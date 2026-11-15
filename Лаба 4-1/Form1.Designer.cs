namespace Лаба_4_1
{
    partial class Form1
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
            circle_button = new Button();
            square_button = new Button();
            rhomb_button = new Button();
            SuspendLayout();
            // 
            // circle_button
            // 
            circle_button.Location = new Point(52, 375);
            circle_button.Name = "circle_button";
            circle_button.Size = new Size(94, 29);
            circle_button.TabIndex = 0;
            circle_button.Text = "Circle";
            circle_button.UseVisualStyleBackColor = true;
            circle_button.Click += circle_button_Click;
            // 
            // square_button
            // 
            square_button.Location = new Point(169, 375);
            square_button.Name = "square_button";
            square_button.Size = new Size(94, 29);
            square_button.TabIndex = 1;
            square_button.Text = "Square";
            square_button.UseVisualStyleBackColor = true;
            square_button.Click += square_button_Click;
            // 
            // rhomb_button
            // 
            rhomb_button.Location = new Point(290, 375);
            rhomb_button.Name = "rhomb_button";
            rhomb_button.Size = new Size(94, 29);
            rhomb_button.TabIndex = 2;
            rhomb_button.Text = "Rhomb";
            rhomb_button.UseVisualStyleBackColor = true;
            rhomb_button.Click += rhomb_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rhomb_button);
            Controls.Add(square_button);
            Controls.Add(circle_button);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button circle_button;
        private Button square_button;
        private Button rhomb_button;
    }
}
