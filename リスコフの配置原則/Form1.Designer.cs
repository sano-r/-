namespace リスコフの配置原則
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
            PriceTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            PriceTextBox.Location = new Point(123, 66);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(167, 38);
            PriceTextBox.TabIndex = 0;
            PriceTextBox.Text = "100";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(123, 126);
            button1.Name = "button1";
            button1.Size = new Size(122, 53);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 274);
            Controls.Add(button1);
            Controls.Add(PriceTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PriceTextBox;
        private Button button1;
    }
}
