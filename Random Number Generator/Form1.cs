using System;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        // ������������� �����
        public Form1()
        {
            InitializeComponent();
        }

        // ���������� ������� ������ ��������� �����
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // ������ ������������ � ������������� �������� �� ��������� �����
                int minValue = int.Parse(txtMinValue.Text);
                int maxValue = int.Parse(txtMaxValue.Text);

                // �������� �� ������������ ���������
                if (minValue > maxValue)
                {
                    MessageBox.Show("����������� �������� �� ����� ���� ������ �������������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ��������� ���������� �����
                Random random = new Random();
                int randomNumber = random.Next(minValue, maxValue + 1);

                // ����������� ����������
                lblResult.Text = "���������: " + randomNumber;
            }
            catch (FormatException)
            {
                // ��������� ������ � ������ ������������� �����
                MessageBox.Show("����������, ������� ���������� �������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
