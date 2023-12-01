namespace laba_5
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
            limitTextBox = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            aceptButton = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // limitTextBox
            // 
            limitTextBox.Location = new Point(143, 6);
            limitTextBox.Name = "limitTextBox";
            limitTextBox.Size = new Size(54, 23);
            limitTextBox.TabIndex = 0;
            limitTextBox.Text = "15";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите ограничение";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(989, 836);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "По левому краю", "По правому краю", "По центру" });
            comboBox1.Location = new Point(213, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // aceptButton
            // 
            aceptButton.Location = new Point(430, 5);
            aceptButton.Name = "aceptButton";
            aceptButton.Size = new Size(75, 23);
            aceptButton.TabIndex = 5;
            aceptButton.Text = "Прнинять";
            aceptButton.UseVisualStyleBackColor = true;
            aceptButton.Click += aceptButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(340, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = " по слогам";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 882);
            Controls.Add(checkBox1);
            Controls.Add(aceptButton);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(limitTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox limitTextBox;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button aceptButton;
        private CheckBox checkBox1;
    }
}