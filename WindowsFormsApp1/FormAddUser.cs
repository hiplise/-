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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            {
                // Простая проверка: если логин или email пустые, ругаемся и не закрываем окно
                if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните логин и Email!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Отменяем автоматическое закрытие формы, если DialogResult настроен как OK
                    this.DialogResult = DialogResult.None;
                    return;
                }

                // Если всё заполнено, подтверждаем успешный результат
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
