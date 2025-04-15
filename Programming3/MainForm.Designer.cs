namespace Programming3
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            extBox = new TextBox();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            RectanglesListBox = new ListBox();
            ColorTextBox = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(661, 460);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(653, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(extBox);
            panel1.Controls.Add(WidthTextBox);
            panel1.Controls.Add(LengthTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RectanglesListBox);
            panel1.Controls.Add(ColorTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 381);
            panel1.TabIndex = 0;
            // 
            // extBox
            // 
            extBox.Location = new Point(273, 193);
            extBox.Name = "extBox";
            extBox.Size = new Size(143, 27);
            extBox.TabIndex = 8;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(273, 126);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(143, 27);
            WidthTextBox.TabIndex = 7;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(273, 63);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(143, 27);
            LengthTextBox.TabIndex = 6;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 170);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 103);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 40);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Location = new Point(14, 40);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(239, 244);
            RectanglesListBox.TabIndex = 2;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(273, 253);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(143, 31);
            ColorTextBox.TabIndex = 1;
            ColorTextBox.Text = "Find";
            ColorTextBox.UseVisualStyleBackColor = true;
            ColorTextBox.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Rectangles";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 587);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button ColorTextBox;
        private Label label1;
        private TextBox extBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox RectanglesListBox;
    }
}
