namespace LUW_extractor
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
            button1 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(657, 56);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 0;
            button1.Text = "Choose LUW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(530, 27);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(77, 144);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(690, 245);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Location = new Point(77, 56);
            label1.Name = "label1";
            label1.Size = new Size(530, 25);
            label1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(657, 91);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 4;
            button2.Text = "extract";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 467);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "SM58 - LUW_extractor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button2;
    }
}