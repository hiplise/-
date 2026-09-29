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
    public partial class FormAddSeller : Form
    {
        public FormAddSeller()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None; // Отменяем закрытие формы
                return;
            }

            // 2. Проверяем, что введены именно числа, а не буквы
            if (!int.TryParse(textBox1.Text, out _) ||
                !double.TryParse(textBox2.Text, out _) ||
                !int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("В полях должны быть только числа! Проверьте ввод.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None; // Отменяем закрытие формы
                return;
            }

            // 3. Если проверки пройдены, закрываем форму с успешным результатом
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}

