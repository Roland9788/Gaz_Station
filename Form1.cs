namespace Прога_для_Газпрома
{
    public partial class Form1 : Form
    {
        Fuel fuel = new Fuel();
        double viruchka = 0;
        double PaymentF = 0;
        double PaymentT = 0;
        double PaymentT1 = 0;
        double PaymentT2 = 0;
        double PaymentT3 = 0;
        double PaymentT4 = 0;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < fuel.GetCount(); i++)
            {
                comboBox1.Items.Add(fuel.GetFuelName(i));
            }
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e){ }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < fuel.GetCount(); i++)
            {
                if (comboBox1.SelectedItem.ToString() == fuel.GetFuelName(i))
                {
                    textBox1.Text = fuel.GetFuelPrice(fuel.GetFuelName(i)).ToString();
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox3.Text = "";
                label5.Text = "";
                groupBox3.Text = "К оплате";
                label7.Text = "руб.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                textBox2.Text = "";
                label5.Text = "";
                groupBox3.Text = "К выдаче";
                label7.Text = "л.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "" && textBox1.Text != "")
                {
                    PaymentF = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            label5.Text = PaymentF.ToString();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Enabled)
                {
                    if (textBox3.Text != "" && textBox1.Text != "")
                    {
                        PaymentF = Convert.ToDouble(textBox3.Text);
                        label5.Text = (Math.Round((Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox1.Text)), 2)).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox9.Enabled = true;
            }
            if (!checkBox2.Checked)
            {
                textBox9.Enabled = false;
                PaymentT2 -= Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox9.Text);
                textBox9.Text = "";
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox10.Enabled = true;
            }
            if (!checkBox3.Checked)
            {
                textBox10.Enabled = false;
                PaymentT3 -= Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox10.Text);
                textBox10.Text = "";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox8.Enabled = true;
            }
            if (!checkBox1.Checked)
            {
                textBox8.Enabled = false;
                PaymentT1 -= Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox8.Text);
                textBox8.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox11.Enabled = true;
            }
            if (!checkBox4.Checked)
            {
                textBox11.Enabled = false;
                PaymentT4 -= Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox11.Text);
                textBox11.Text = "";
            }

        }


        private void groupBox5_Enter(object sender, EventArgs e){}

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox7.Text != "" && textBox11.Text != "")
                {
                    PaymentT4 = Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox11.Text);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text != "" && textBox4.Text != "")
                {
                    PaymentT1 = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox8.Text);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text != "" && textBox5.Text != "")
                {
                    PaymentT2 = Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox9.Text);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox10.Text != "" && textBox6.Text != "")
                {
                    PaymentT3 = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox10.Text);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e){}

        private void textBox4_TextChanged(object sender, EventArgs e){}

        private void label11_TextChanged(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentT = 0;
            PaymentT += PaymentT1;
            PaymentT += PaymentT2;
            PaymentT += PaymentT3;
            PaymentT += PaymentT4;

            label11.Text = PaymentT.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viruchka += PaymentT + PaymentF;
            label12.Text = Math.Round((PaymentT + PaymentF), 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox3.Text = "";
            label5.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            groupBox3.Text = "К оплате";
            label7.Text = "руб.";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            label11.Text = "";
            label12.Text = "";

        }
    }
}