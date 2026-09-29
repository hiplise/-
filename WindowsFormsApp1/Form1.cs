using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Администраторы". При необходимости она может быть перемещена или удалена.
            this.администраторыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Администраторы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Споры". При необходимости она может быть перемещена или удалена.
            this.спорыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Споры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Подтверждение_оплаты". При необходимости она может быть перемещена или удалена.
            this.подтверждение_оплатыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Подтверждение_оплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Замораживание_средств". При необходимости она может быть перемещена или удалена.
            this.замораживание_средствTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Замораживание_средств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Оплата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Сделки". При необходимости она может быть перемещена или удалена.
            this.сделкиTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Сделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Аккаунты". При необходимости она может быть перемещена или удалена.
            this.аккаунтыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Аккаунты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
            this.продавцыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Продавцы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Пользователи);

        }

        private void Сохранить_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Фиксируем изменения из графического интерфейса во всех BindingSource
                this.пользователиBindingSource.EndEdit();
                this.продавцыBindingSource.EndEdit();
                this.администраторыBindingSource.EndEdit();
                this.аккаунтыBindingSource.EndEdit();
                this.сделкиBindingSource.EndEdit();
                this.оплатаBindingSource.EndEdit();
                this.замораживаниеСредствBindingSource.EndEdit();
                this.подтверждениеОплатыBindingSource.EndEdit();
                this.спорыBindingSource.EndEdit();

                // 2. СОХРАНЕНИЕ В БАЗУ ДАННЫХ (Строго по иерархии связей)

                // Этап А: Сначала главные справочники (они ни от кого не зависят)
                this.пользователиTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Пользователи);
                this.продавцыTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Продавцы);
                this.администраторыTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Администраторы);

                // Этап Б: Таблицы второго уровня (зависят от пользователей/продавцов)
                this.аккаунтыTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Аккаунты);
                this.сделкиTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Сделки);

                // Этап В: Подчинённые таблицы (зависят от сделок или оплат)
                this.оплатаTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Оплата);
                this.замораживание_средствTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Замораживание_средств);
                this.подтверждение_оплатыTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Подтверждение_оплаты);
                this.спорыTableAdapter.Update(this.microsoft_Access_База_данныхDataSet.Споры);

                MessageBox.Show("Все данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения из-за нарушения связей: \n\n{ex.Message}", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView5_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView6_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView7_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView8_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView9_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Вкладка: Пользователи
                    FormAddUser userForm = new FormAddUser();

                    if (userForm.ShowDialog() == DialogResult.OK)
                    {
                        string newLogin = userForm.txtLogin.Text;
                        string newEmail = userForm.txtEmail.Text;

                        try
                        {
                            this.пользователиTableAdapter.Insert(newLogin, newEmail, DateTime.Now);
                            this.пользователиTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Пользователи);

                            MessageBox.Show("Пользователь успешно добавлен в базу Access!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении в Access: \n" + ex.Message,
                                            "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case 1: // Вкладка: Продавцы
                    FormAddSeller sellerForm = new FormAddSeller();

                    if (sellerForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            int userId = int.Parse(sellerForm.textBox1.Text);
                            int rating = int.Parse(sellerForm.textBox2.Text);
                            int salesCount = int.Parse(sellerForm.textBox3.Text);
                            this.продавцыTableAdapter.Insert(userId, rating, salesCount);
                            this.продавцыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Продавцы);

                            MessageBox.Show("Продавец успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Пожалуйста, заполните все поля и вводите только числа!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении в Access: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case 2: // Вкладка: Аккаунты
                    FormAddAccount accForm = new FormAddAccount();

                    if (accForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string name = accForm.textBox1.Text;
                            string description = accForm.textBox2.Text;
                            decimal price = decimal.Parse(accForm.textBox3.Text);
                            int sellerId = int.Parse(accForm.textBox4.Text);
                            this.аккаунтыTableAdapter.Insert(name, description, price, sellerId);
                            this.аккаунтыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Аккаунты);

                            MessageBox.Show("Аккаунт успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении аккаунта: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case 3: // Вкладка: Сделки
                    FormAddDeal dealForm = new FormAddDeal();

                    if (dealForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            int buyerId = int.Parse(dealForm.textBox1.Text);
                            int sellerId = int.Parse(dealForm.textBox2.Text);
                            int accountId = int.Parse(dealForm.textBox3.Text);
                            string status = dealForm.textBox4.Text;
                            DateTime dealDate = dealForm.dateTimePicker1.Value;
                            this.сделкиTableAdapter.Insert(buyerId, sellerId, accountId, dealDate, status);
                            this.сделкиTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Сделки);

                            MessageBox.Show("Сделка успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении сделки: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case 4: // Вкладка: Оплаты
                    FormAddPayment payForm = new FormAddPayment();

                    if (payForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            int dealId = int.Parse(payForm.textBox1.Text);
                            decimal amount = decimal.Parse(payForm.textBox2.Text);
                            string status = payForm.textBox3.Text;
                            DateTime paymentDate = payForm.dateTimePicker1.Value;
                            this.оплатаTableAdapter.Insert(dealId, amount, paymentDate, status);
                            this.оплатаTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Оплата);

                            MessageBox.Show("Оплата успешно зафиксирована!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении оплаты: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case 5: // Вкладка: Замораживание средств
                    FormAddFreeze freezeForm = new FormAddFreeze();

                    if (freezeForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            int paymentId = int.Parse(freezeForm.textBox1.Text);
                            decimal amount = decimal.Parse(freezeForm.textBox2.Text);
                            string status = freezeForm.textBox3.Text;
                            DateTime freezeDate = freezeForm.dateTimePicker1.Value;
                            this.замораживание_средствTableAdapter.Insert(paymentId, amount, freezeDate, status);
                            this.замораживание_средствTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Замораживание_средств);

                            MessageBox.Show("Средства успешно заморожены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении заморозки: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case 6: // Вкладка: Подтвержденные оплаты
                    FormAddConfirm confirmForm = new FormAddConfirm();

                    if (confirmForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            int dealId = int.Parse(confirmForm.textBox1.Text);
                            string status = confirmForm.textBox2.Text;
                            DateTime confirmDate = confirmForm.dateTimePicker1.Value;
                            this.подтверждение_оплатыTableAdapter.Insert(dealId, confirmDate, status);
                            this.подтверждение_оплатыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Подтверждение_оплаты);

                            MessageBox.Show("Оплата успешно подтверждена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении подтверждения: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case 7: // Вкладка: Споры
                    FormAddDispute disputeForm = new FormAddDispute();

                    if (disputeForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            int dealId = int.Parse(disputeForm.textBox1.Text);
                            int adminId = int.Parse(disputeForm.textBox4.Text);
                            string reason = disputeForm.textBox2.Text;
                            string resolution = disputeForm.textBox3.Text;
                            this.спорыTableAdapter.Insert(dealId, reason, resolution, adminId);
                            this.спорыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Споры);

                            MessageBox.Show("Спор успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении спора: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case 8: // Вкладка: Администраторы
                    FormAddAdmin adminForm = new FormAddAdmin(); 

                    if (adminForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string login = adminForm.textBox1.Text;
                            string password = adminForm.textBox2.Text;
                            string fio = adminForm.textBox3.Text;
                            this.администраторыTableAdapter.Insert(login, password, fio);
                            this.администраторыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Администраторы);

                            MessageBox.Show("Администратор успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при сохранении администратора: \n" + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

            }
        }
    }
}
