namespace check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double full_price = 0;
        double full_valPercent = 0;
        double full = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button_addToCart_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(textBox_price.Text);
            double onePrice = price;
            double amount = Convert.ToDouble(numericUpDown_amount.Value);
            price *= amount;
            double percent = Convert.ToDouble(textBox_percent.Text);
            double percentVal = price * (percent / 100.0);
            double totalPrice = price - percentVal;
            double nds = 0.13 * totalPrice;
            double totalTotalPrice = totalPrice - nds;
            textBox_info.Text += "Вы приобрели товар: " + textBox_name.Text + "\r\nПо цене: " + price + "\r\nСтоимость товара: " + onePrice + "\r\nВеличина скидки: " + percentVal + "\r\nСтоимость со скидкой: " + totalPrice + "\r\nНДС(13%): " + nds + "\r\nИтоговая цена за товар: " + totalTotalPrice + "\r\n";
            textBox_name.Text = "";
            textBox_percent.Text = "";
            textBox_price.Text = "";
            numericUpDown_amount.Value = 0;
            full_price += totalPrice;
            full_valPercent += percentVal;
            full += totalTotalPrice;
            textBox_priceInTotal.Text = full_price.ToString();
            textBox_percentInTotal.Text += full_valPercent.ToString();
            textBox_inCassa.Text = full.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_percent.Text = "";
            textBox_price.Text = "";
            numericUpDown_amount.Value = 0;
            full_price = 0;
            full_valPercent = 0;
            full = 0;
            textBox_priceInTotal.Text = "";
            textBox_percentInTotal.Text = "";
            textBox_inCassa.Text = "";
            textBox_info.Text = "";
        }
    }
}