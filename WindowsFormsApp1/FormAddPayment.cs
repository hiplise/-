using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddPayment : Form
    {
        public FormAddPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // 1. Проверяем заполнение текстовых полей
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.None;
                    return;
                }

                // 2. Проверяем, что ID сделки — это целое число, а Сумма — корректное число/денежный формат
                if (!int.TryParse(textBox1.Text, out _) || !decimal.TryParse(textBox2.Text, out _))
                {
                    MessageBox.Show("ID сделки и Сумма должны быть числовыми значениями!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }
    }
}
