using System;
using System.Collections;
using System.Windows.Forms;

namespace Programming3
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        public MainForm()
        {
            InitializeComponent();
            _rectangles = new Rectangle[5];
            Random random = new Random(); // ������� ������ ��� ��������� ��������� �����

            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = random.Next(1, 101); // ����� �� 1 �� 100 
                double width = random.Next(1, 101);  // ������ �� 1 �� 100 
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // ��������� ����

                _rectangles[i] = new Rectangle(length, width, randomColor);

                for (int j = 0; j < _rectangles.Length; j++)
                {
                    RectanglesListBox.Items.Add(_rectangles[j].ToString());
                }
            }


        }


        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1) // ���������, ��� ���-�� �������
            {
                int selectedIndex = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[selectedIndex];
            }
            else
            {
                _currentRectangle = null;

            }
        }
        private void UpdateTextFields()
        {
            if (_currentRectangle != null)
            {
                LengthTextBox.Text = _currentRectangle.Length.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                extBox.Text = "";
            }
            else
            {
                ClearTextFields();
            }
        }


        private void ClearTextFields()
        {
            LengthTextBox.Text = "";
            WidthTextBox.Text = "";
            extBox.BackColor = Color.White; // ���������� ���� ���� (��� ������ �������� �� ���������)
            extBox.Text = "";
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                if (double.TryParse(LengthTextBox.Text, out double length))
                {
                    _currentRectangle.Length = length;
                    LengthTextBox.BackColor = Color.White; // ����� ���� ��� �������� ��������������
                }
                else
                {
                    LengthTextBox.BackColor = Color.LightPink; // ��������� ��� ������
                }
                UpdateTextFields();  // ���������� �����
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                if (double.TryParse(WidthTextBox.Text, out double width))
                {
                    _currentRectangle.Width = width;
                    WidthTextBox.BackColor = Color.White;
                }
                else
                {
                    WidthTextBox.BackColor = Color.LightPink;
                }
                UpdateTextFields();  // ���������� �����
            }
        }

       

        
    }
}
