using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211220_SandwichWorld
{
    public partial class Form2 : Form
    {
        Form form1;
        double total_price;

        public Form2(Form form)
        {
            InitializeComponent();
            form1 = form;
            total_price = 0;
            
            
            ListSandwiches();            
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            ReturnMethod();
        }

        void ReturnMethod()
        {
            form1.Show();
            this.Hide();
            
        }

        void ListSandwiches()
        {
            foreach (Sandwich sandwich in Form1.sandwiches)
            {
                string name = "";
                name += sandwich.Bread.Name;
                name += sandwich.IsHollow ? "hollow" : "";
                name += sandwich.MainIngredient.Name;
                name += sandwich.Beverage.Name;
                foreach (ExtraIngredient extraingredient in sandwich.ExtraIngredients)
                {
                    name += extraingredient.Name;
                }
                sandwiches_listbox.Items.Add(name);
                total_price += sandwich.CalculatePrice();
            }
            total_price_label.Text = "Toplam tutar " + total_price.ToString() + "TL";

        }

        private void delete_sandwich_button_Click(object sender, EventArgs e)
        {
            DeleteSandwichMethod();
        }

        void DeleteSandwichMethod()
        {
            int index = sandwiches_listbox.SelectedIndex;
            if (index != -1)
            {
                DialogResult dialog_result = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo);

                if (dialog_result == DialogResult.Yes)
                {
                    total_price -= Form1.sandwiches[index].CalculatePrice();
                    sandwiches_listbox.Items.RemoveAt(index);
                    Form1.sandwiches.RemoveAt(index);
                    total_price_label.Text = "Toplam tutar " + total_price.ToString() + "TL";
                }
            }
        }

        private void complete_order_button_Click(object sender, EventArgs e)
        {
            CompleteOrderMethod();
        }

        void CompleteOrderMethod()
        {
            MessageBox.Show("Sipariş tamamlanmıştır. Program Kapatılıyor.");
            this.Close();
        }
    }
}
