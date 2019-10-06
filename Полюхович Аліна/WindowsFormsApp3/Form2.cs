using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        DataTable table = new DataTable();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double balanceUAH = Convert.ToDouble(label17.Text);
                balanceUAH += Convert.ToDouble(textBox4.Text);
                label17.Text = balanceUAH.ToString();
                textBox4.Text = "";
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double balanceUSD = Convert.ToDouble(label19.Text);
                balanceUSD += Convert.ToDouble(textBox5.Text);
                label19.Text = balanceUSD.ToString();
                textBox5.Text = "";
            }
            catch { }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double balanceEUR = Convert.ToDouble(label21.Text);
                balanceEUR += Convert.ToDouble(textBox2.Text);
                label21.Text = balanceEUR.ToString();
                textBox2.Text = "";
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double balanceRUB = Convert.ToDouble(label23.Text);
                balanceRUB += Convert.ToDouble(textBox3.Text);
                label23.Text = balanceRUB.ToString();
                textBox3.Text = "";
            }
            catch { }
        }
        public void cut()
        {
            // double ddd = Convert.ToDouble(textBox6.Text);
            //ddd = Math.Truncate(ddd * 100) / 100;
            //textBox6.Text = Convert.ToString(ddd);
           //float ddd = float.Parse(textBox6.Text);
            //Math.Round(ddd, 2);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double x;
                x = double.Parse(textBox7.Text);
                double usdP = Convert.ToDouble(numericUpDown4.Value);
                double eurP = Convert.ToDouble(numericUpDown5.Value);
                double rubP = Convert.ToDouble(numericUpDown6.Value);
                double usdK = Convert.ToDouble(numericUpDown1.Value);
                double eurK = Convert.ToDouble(numericUpDown2.Value);
                double rubK = Convert.ToDouble(numericUpDown3.Value);
                try
                {
                    if (comboBox1.SelectedItem.ToString() == "USD")
                    {

                        if (comboBox2.SelectedItem.ToString() == "UAH")
                            textBox6.Text = Convert.ToString(x * usdK);
                        cut();
                        if (comboBox2.SelectedItem.ToString() == "USD")
                            textBox6.Text = Convert.ToString(x);
                        if (comboBox2.SelectedItem.ToString() == "EUR")
                            textBox6.Text = Convert.ToString(x * usdK / eurP);
                        cut();
                        if (comboBox2.SelectedItem.ToString() == "RUB")
                            textBox6.Text = Convert.ToString(x * usdK / rubP);
                        cut();
                    }

                    if (comboBox1.SelectedItem.ToString() == "EUR")
                    {
                        if (comboBox2.SelectedItem.ToString() == "EUR")
                            textBox6.Text = Convert.ToString(x);
                        if (comboBox2.SelectedItem.ToString() == "USD")
                            textBox6.Text = Convert.ToString(x * eurK / usdP);
                        cut();
                        if (comboBox2.SelectedItem.ToString() == "RUB")
                            textBox6.Text = Convert.ToString(x * eurK / rubP);
                        cut();
                        if (comboBox2.SelectedItem.ToString() == "UAH")
                            textBox6.Text = Convert.ToString(x * eurK);
                        cut();
                    }

                    if (comboBox1.SelectedItem.ToString() == "RUB")
                    {
                        if (comboBox2.SelectedItem.ToString() == "RUB")
                            textBox6.Text = Convert.ToString(x);
                        if (comboBox2.SelectedItem.ToString() == "EUR")
                            textBox6.Text = Convert.ToString(x * rubK / eurP);
                        cut();
                        if (comboBox2.SelectedItem.ToString() == "USD")
                            textBox6.Text = Convert.ToString(x * rubK / usdP);
                        cut();
                        if (comboBox2.SelectedItem.ToString() == "UAH")
                            textBox6.Text = Convert.ToString(x * rubK);
                        cut();
                    }

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Оберіть в полі вище в яку валюту треба конвертувати");
                }

            }
            catch
            {
                MessageBox.Show("");
            }
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double x;
                x = double.Parse(textBox7.Text);
                double usdP = Convert.ToDouble(numericUpDown4.Value);
                double eurP = Convert.ToDouble(numericUpDown5.Value);
                double rubP = Convert.ToDouble(numericUpDown6.Value);
                double usdK = Convert.ToDouble(numericUpDown1.Value);
                double eurK = Convert.ToDouble(numericUpDown2.Value);
                double rubK = Convert.ToDouble(numericUpDown3.Value);
                if (comboBox1.SelectedItem.ToString() == "USD")
                    textBox6.Text = Convert.ToString(x * usdP);
                    cut();
                if (comboBox1.SelectedItem.ToString() == "EUR")
                    textBox6.Text = Convert.ToString(x * eurP);
                    cut();
                if (comboBox1.SelectedItem.ToString() == "RUB")
                    textBox6.Text = Convert.ToString(x * rubP);
                    cut();
                                       
            }
            catch { }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 prog = new Form3();
            prog.Show();
        }
        private void check()
        {
            //check for report
            
            textBox8.Text = Environment.NewLine + "Пункт обміну валют" + Environment.NewLine + textBox1.Text + Environment.NewLine + "Купівля" + Environment.NewLine + "Сума: " + textBox7.Text + Environment.NewLine + "Валюта: " + comboBox1.SelectedItem + Environment.NewLine + "Отримання готівки: " + textBox6.Text + " " + comboBox2.SelectedItem + Environment.NewLine + Environment.NewLine + dateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm:ss") + Environment.NewLine + "Фіскальний чек" + Environment.NewLine + "-----------------------------------";
            textBox8.TextAlign = HorizontalAlignment.Center;
            table.Rows.Add(dateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm:ss"), "Купівля", textBox7.Text, comboBox1.Text, textBox6.Text, comboBox2.Text);
            dataGridView1.DataSource = table;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Купити " + textBox7.Text + comboBox1.Text + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (comboBox1.SelectedItem.ToString() == "USD")
                    {
                        if (comboBox2.SelectedItem.ToString() == "EUR")
                        {
                            double balanceUSD = Convert.ToDouble(label19.Text);
                            double balanceEUR = Convert.ToDouble(label21.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceEUR -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                label21.Text = balanceEUR.ToString();
                                balanceUSD += Convert.ToDouble(textBox7.Text);
                                label19.Text = balanceUSD.ToString();
                                label21.Text = balanceEUR.ToString();
                                check();
                            }
                            else
                            {
                                MessageBox.Show("Недостатня сума EUR для здійснення даної операції");
                            }
                        }
                        if (comboBox2.SelectedItem.ToString() == "USD")
                            MessageBox.Show("Перевірте валюти");
                        if (comboBox2.SelectedItem.ToString() == "RUB")
                        {
                            double balanceUSD = Convert.ToDouble(label19.Text);
                            double balanceRUB = Convert.ToDouble(label23.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceRUB -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                label23.Text = balanceRUB.ToString();
                                balanceUSD += Convert.ToDouble(textBox7.Text);
                                label19.Text = balanceUSD.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума RUB для здійснення даної операції");
                        }
                        if (comboBox2.SelectedItem.ToString() == "UAH")
                        {
                            double balanceUSD = Convert.ToDouble(label19.Text);
                            double balanceUAH = Convert.ToDouble(label17.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceUAH -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                label17.Text = balanceUAH.ToString();
                                balanceUSD += Convert.ToDouble(textBox7.Text);
                                label19.Text = balanceUSD.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума UAH для здійснення даної операції");
                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "EUR")
                    {
                        if (comboBox2.SelectedItem.ToString() == "USD")
                        {
                            double balanceUSD = Convert.ToDouble(label19.Text);
                            double balanceEUR = Convert.ToDouble(label21.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceUSD -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                label19.Text = balanceUSD.ToString();
                                balanceEUR += Convert.ToDouble(textBox7.Text);
                                label21.Text = balanceEUR.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума USD для здійснення даної операції");
                        }
                        if (comboBox2.SelectedItem.ToString() == "EUR")
                            MessageBox.Show("Перевірте валюти");
                        if (comboBox2.SelectedItem.ToString() == "RUB")
                        {
                            double balanceEUR = Convert.ToDouble(label21.Text);
                            double balanceRUB = Convert.ToDouble(label23.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceRUB -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                balanceEUR += Convert.ToDouble(textBox7.Text);
                                label21.Text = balanceEUR.ToString();

                                label23.Text = balanceRUB.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума RUB для здійснення даної операції");
                        }
                        if (comboBox2.SelectedItem.ToString() == "UAH")
                        {
                            double balanceEUR = Convert.ToDouble(label21.Text);
                            double balanceUAH = Convert.ToDouble(label17.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceUAH -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                balanceEUR += Convert.ToDouble(textBox1.Text);
                                label21.Text = balanceEUR.ToString();
                                label17.Text = balanceUAH.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума UAH для здійснення даної операції");
                        }
                    }
                    //для RUB                    
                    if (comboBox1.SelectedItem.ToString() == "RUB")
                    {
                        if (comboBox2.SelectedItem.ToString() == "USD")
                        {
                            double balanceUSD = Convert.ToDouble(label19.Text);
                            double balanceRUB = Convert.ToDouble(label23.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceUSD -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                label19.Text = balanceUSD.ToString();
                                balanceRUB += Convert.ToDouble(textBox7.Text);
                                label23.Text = balanceRUB.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума USD для здійснення даної операції");
                        }
                        if (comboBox2.SelectedItem.ToString() == "RUB")
                            MessageBox.Show("Перевірте валюти");
                        if (comboBox2.SelectedItem.ToString() == "EUR")
                        {
                            double balanceEUR = Convert.ToDouble(label21.Text);
                            double balanceRUB = Convert.ToDouble(label23.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceEUR -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                label21.Text = balanceEUR.ToString();
                                balanceRUB += Convert.ToDouble(textBox7.Text);
                                label23.Text = balanceRUB.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума EUR для здійснення даної операції");
                        }
                        if (comboBox2.SelectedItem.ToString() == "UAH")
                        {
                            double balanceRUB = Convert.ToDouble(label23.Text);
                            double balanceUAH = Convert.ToDouble(label17.Text);
                            //check existence of certain sum of money in cash register
                            if (Convert.ToDouble(balanceUAH -= Convert.ToDouble(textBox6.Text)) >= 0)
                            {
                                balanceRUB += Convert.ToDouble(textBox1.Text);
                                label23.Text = balanceRUB.ToString();
                                label17.Text = balanceUAH.ToString();
                                //check for report
                                check();
                            }
                            else MessageBox.Show("Недостатня сума UAH для здійснення даної операції");
                        }
                    }
                                  
                                                         
                }
                else
                {
                    // user clicked no
                }
            }
            catch { }
        }  
        
        private void checks()
        {
            //check for report
            
            textBox8.Text = Environment.NewLine + "Пункт обміну валют" + Environment.NewLine + textBox1.Text + Environment.NewLine + "Продаж" + Environment.NewLine + "Сума: " + textBox7.Text + Environment.NewLine + "Валюта: " + comboBox1.SelectedItem + Environment.NewLine + "Отримання готівки: " + textBox6.Text + " " + comboBox2.SelectedItem + Environment.NewLine + Environment.NewLine + dateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm:ss") + Environment.NewLine + "Фіскальний чек" + Environment.NewLine + "-----------------------------------";
            textBox8.TextAlign = HorizontalAlignment.Center;
            table.Rows.Add(dateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm:ss"), "Продаж", textBox7.Text, comboBox1.Text, textBox6.Text, comboBox2.Text);
            dataGridView1.DataSource = table;
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Продати " + textBox7.Text + comboBox1.Text + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //user click yes
                    double balanceUAH = Convert.ToDouble(label17.Text);
                    if (comboBox1.SelectedItem.ToString() == "USD")
                    {
                        double balanceUSD = Convert.ToDouble(label19.Text);
                        //check existence of certain sum of money in cash register
                        if (Convert.ToDouble(balanceUSD -= Convert.ToDouble(textBox7.Text)) >= 0)
                        {
                            label19.Text = balanceUSD.ToString();
                            balanceUAH += Convert.ToDouble(textBox6.Text);
                            label17.Text = balanceUAH.ToString();
                            //check for report
                            checks();                            
                        }
                        else
                        {
                            MessageBox.Show("Недостатня сума USD для здійснення операції");
                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "EUR")
                    {
                        double balanceEUR = Convert.ToDouble(label21.Text);
                        //check existence of certain sum of money in cash register
                        if (Convert.ToDouble(balanceEUR -= Convert.ToDouble(textBox7.Text)) >= 0)
                        {
                            label21.Text = balanceEUR.ToString();
                            balanceUAH += Convert.ToDouble(textBox6.Text);
                            label17.Text = balanceUAH.ToString();
                            //check for report
                            checks();
                        }
                        else
                        {
                            MessageBox.Show("Недостатня сума EUR для здійснення операції");
                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "RUB")
                    {
                        double balanceRUB = Convert.ToDouble(label23.Text);
                        //check existence of certain sum of money in cash register
                        if (Convert.ToDouble(balanceRUB -= Convert.ToDouble(textBox7.Text)) >= 0)
                        {
                            label23.Text = balanceRUB.ToString();
                            balanceUAH += Convert.ToDouble(textBox6.Text);
                            label17.Text = balanceUAH.ToString();
                            //check for report
                            checks();
                        }
                        else MessageBox.Show("Недостатня сума RUB для здійснення операції");
                    }
                   
                }
                else
                {
                    // user clicked no
                }
            }
            catch { }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // занесення даних в таблицю
            dataGridView1.DataSource = table;
            table.Columns.Add("Дата", typeof(string));// data type int
            table.Columns.Add("Операція", typeof(string));// datatype string
            table.Columns.Add("Сума отриманих коштів", typeof(string));// datatype string
            table.Columns.Add("Валюта отриманих коштів", typeof(string));// datatype string
            table.Columns.Add("Сума видачі", typeof(string));// datatype string
            table.Columns.Add("Валюта видачі", typeof(string));// datatype string
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode =DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            comboBox3.SelectedItem = "UAH";
            comboBox1.SelectedItem = "USD";
            comboBox2.SelectedItem = "UAH";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox8.Text, new Font("Times New Roman", 12), Brushes.Black, new PointF(50,50));
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
