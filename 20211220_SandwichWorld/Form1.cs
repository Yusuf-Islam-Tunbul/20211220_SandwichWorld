using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;

namespace _20211220_SandwichWorld
{
    public partial class Form1 : Form
    {
        Sandwich sandwich = new Sandwich();
        
        List<Bread> breads = new List<Bread>();
        List<MainIngredient> main_ingredients = new List<MainIngredient>();
        List<Beverage> beverages = new List<Beverage>();
        Dictionary<string, ExtraIngredient> extra_ingredients = new Dictionary<string, ExtraIngredient>();
        public static List<Sandwich> sandwiches = new List<Sandwich>();

        public Form1()
        {
            InitializeComponent();
            CreateIngredients();
            InitializeIndexes1();
            InitializeIndexes2();
        }

        void InitializeIndexes1()
        {
            bread_size_combobox.SelectedIndex = 1;
            bread_combobox.SelectedIndex = 0;
            main_ingredient_combobox.SelectedIndex = 0;
            beverage_combobox.SelectedIndex = 0;
            picturebox.Image = null;
            ingredient_listbox2.Items.Clear();

            hollow_bread_checkbox.Checked = false;

            foreach(Control control in extra_ingredients_panel.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        void InitializeIndexes2()
        {
            name_textbox.Text = "Ürün adı giriniz";
            price_textbox.Text = "Ürün fiyatı giriniz";
            type_combobox.SelectedIndex = 0;
        }

        void CreateIngredients()
        {
            CreateBread("Klasik Ekmek", 3);
            CreateBread("Baget Ekmek", 4);
            CreateBread("Susamlı Ekmek", 3.80);
            CreateMainIngredient("Kavurma Et", 20);
            CreateMainIngredient("Kavurma Tavuk", 15);
            CreateMainIngredient("Ton Balıgı", 14);
            CreateMainIngredient("Füme Et", 18);
            CreateMainIngredient("Salam", 17);
            CreateBeverage("Nuka Cola", 5);
            CreateBeverage("Ayran", 4);
            CreateBeverage("Bilinmeyen Sıvı (Tadı güzel)", 0.5);
            CreateExtraIngredient("Baharat", 0);
            CreateExtraIngredient("Çedar Peyniri", 1);
            CreateExtraIngredient("Turşu", 0.5);
            CreateExtraIngredient("Kaşar Peynir", 1);
            CreateExtraIngredient("Domates", 0.5);
            CreateExtraIngredient("Ketçap", 1);
            CreateExtraIngredient("Mayonez", 1);
            CreateExtraIngredient("Mısır", 1.5);
            CreateExtraIngredient("Yeşillik", 0.80);
        }

        void CreateBread(string name, double price)
        {
            Bread bread = new Bread(name, price);
            breads.Add(bread);
            bread_combobox.Items.Add(bread.Name);
        }

        void CreateMainIngredient(string name, double price)
        {
            MainIngredient main_ingredient = new MainIngredient(name, price);
            main_ingredients.Add(main_ingredient);
            main_ingredient_combobox.Items.Add(main_ingredient.Name);
        }

        void CreateBeverage(string name, double price)
        {
            Beverage beverage = new Beverage(name, price);
            beverages.Add(beverage);
            beverage_combobox.Items.Add(beverage.Name);
        }

        void CreateExtraIngredient(string name, double price)
        {
            ExtraIngredient extre_ingredient = new ExtraIngredient(name, price);
            extra_ingredients.Add(extre_ingredient.Name, extre_ingredient);

            CheckBox checkbox = new CheckBox();
            checkbox.Click+= checkbox_CheckedChanged;
            checkbox.Text = name;
            extra_ingredients_panel.Controls.Add(checkbox);
        }

        private void bread_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddBread();
        }


        private void hollow_bread_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            AddBread();
        }

        private void bread_size_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddBread();
        }

        void AddBread()
        {
            if (bread_combobox.SelectedIndex > 0)
            {
                string size = bread_size_combobox.SelectedItem.ToString();
                string bread = bread_combobox.SelectedItem.ToString();
                string is_hollow = hollow_bread_checkbox.Checked ? "(*)" : "";
                ingredient_listbox1.Items[0] = $"{size} {bread} {is_hollow}";
                sandwich.Size = Convert.ToDouble(bread_size_combobox.SelectedItem);
                sandwich.Bread = breads[bread_combobox.SelectedIndex - 1];
                sandwich.IsHollow = hollow_bread_checkbox.Checked;
                UpdatePrice();
                ShowImage(ingredient_listbox1, 0);
            }

            else
            {
                ingredient_listbox1.Items[0] = "Ekmek seçilmedi";
                sandwich.Bread = null;
                total_price_label.Text = "Tutar  0 TL";
            }
        }

        private void main_ingredient_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddMainIngredient();
        }

        void AddMainIngredient()
        {
            if (main_ingredient_combobox.SelectedIndex > 0)
            {
                ingredient_listbox1.Items[1] = main_ingredient_combobox.SelectedItem.ToString();
                sandwich.MainIngredient = (main_ingredients[main_ingredient_combobox.SelectedIndex - 1]);
                UpdatePrice();
                ShowImage(ingredient_listbox1, 1);
            }

            else
            {
                ingredient_listbox1.Items[1] = "Malzeme seçilmedi";
                sandwich.MainIngredient = null;
                total_price_label.Text = "Tutar 0 TL";
            }
        }

        private void beverage_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddBeverage();
        }

        void AddBeverage()
        {
            if (beverage_combobox.SelectedIndex > 0)
            {
                ingredient_listbox1.Items[2] = beverage_combobox.SelectedItem.ToString();
                sandwich.Beverage = beverages[beverage_combobox.SelectedIndex - 1];
                UpdatePrice();
                ShowImage(ingredient_listbox1, 2);
            }

            else
            {
                ingredient_listbox1.Items[2] = "İçecek seçilmedi";
                sandwich.Beverage = null;
                total_price_label.Text = "Tutar 0 TL";
            }
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            AddExtraIngredient(checkbox);
        }

        void AddExtraIngredient(CheckBox checkbox)
        {
            if (checkbox.Checked)
            {
                ingredient_listbox2.Items.Add(checkbox.Text);
                sandwich.ExtraIngredients.Add(extra_ingredients[checkbox.Text]);
                UpdatePrice();
                ShowImage(ingredient_listbox2, -1);
            }

            else
            {
                ingredient_listbox2.Items.Remove(checkbox.Text);
                sandwich.ExtraIngredients.Remove(extra_ingredients[checkbox.Text]);
                UpdatePrice();
            }
        }

        void UpdatePrice()
        {
            if(sandwich.Bread!=null && sandwich.MainIngredient!=null && sandwich.Beverage != null)
            {
                total_price_label.Text = "Tutar " + sandwich.CalculatePrice() + "TL";
            }

        }

        private void listbox_Click(object sender, EventArgs e)
        {
            ShowImage(sender);
        }

        void ShowImage(object sender,int index)
        {
            ListBox listbox = (ListBox)sender;

            if (index == -1)
            {
                index = listbox.Items.Count - 1;
            }

            string name;
                       
            name = listbox.Items[index].ToString();
                 
            name = EditText(name);

            try
            {
                picturebox.Image = Image.FromFile(Environment.CurrentDirectory + @"\" + name + ".jpg");
            }

            catch
            {
                try
                {
                    picturebox.Image = Image.FromFile(Environment.CurrentDirectory + @"\Image Not Found.jpg");
                }
                catch
                {
                    HideImage();
                }
            }
        }


        void ShowImage(object sender)
        {
            ListBox listbox = (ListBox)sender;

            string name;

            if (listbox.SelectedIndex == -1)
            {
                name = listbox.Items[listbox.Items.Count - 1].ToString();
            }

            else
            {
                name = listbox.SelectedItem.ToString();
            }

            



            if (name == "Ekmek seçilmedi" || name == "Malzeme seçilmedi" || name == "İçecek seçilmedi")
            {
                HideImage();
            }

            else
            {
                name = EditText(name);

                try
                {
                    picturebox.Image = Image.FromFile(Environment.CurrentDirectory + @"\" + name + ".jpg");
                }

                catch
                {
                    try
                    {
                        picturebox.Image = Image.FromFile(Environment.CurrentDirectory + @"\Image Not Found.jpg");
                    }
                    catch
                    {
                        HideImage();
                    }
                }
            }
        }


        string EditText(string name)
        {
            name = name.Replace("0,5", "");            
            name = name.Replace("1,5", "");
            name = name.Replace("2", "");
            name = name.Replace("1", "");
            name = name.Replace(" ", "");
            name = name.Replace("(*)", "");            
            return name;
        }

        void HideImage()
        {
            picturebox.Image = null;
        }

        private void add_sandwich_button_Click(object sender, EventArgs e)
        {
            AddSandWich();
        }

        void AddSandWich()
        {
            if (sandwich.Bread == null || sandwich.MainIngredient == null || sandwich.Beverage == null)
            {
                MessageBox.Show("Lütfen seçimlerinizi tamamlayınız.");
            }

            else
            {
                for (int i = 0; i < sandwich.Amount; i++)
                {
                    sandwiches.Add(sandwich);
                }
                sandwich = new Sandwich();
                InitializeIndexes1();
                MessageBox.Show("Siparişe eklendi.");
            }
        }

        private void complete_order_button_Click(object sender, EventArgs e)
        {
            CompleteOrderMethod();
        }

        void CompleteOrderMethod()
        {
            if (sandwiches.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir sipariş girişi yapınız.");
            }

            else
            {
                Form2 form2 = new Form2(this);

                form2.Show();
                InitializeIndexes1();
                this.Hide();
            }
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            CreateIngredient();
        }

        void CreateIngredient()
        {
            string name="";
            double price = 0;

            if (name_textbox.Text == "" || name_textbox.Text=="Ürün adı giriniz")
            {
                MessageBox.Show("Lütfen ürün adı giriniz.");
            }

            else if (price_textbox.Text == "" || price_textbox.Text == "Ürün fiyatı giriniz")
            {
                MessageBox.Show("Lütfen ürün fiyatı giriniz.");
            }

            else
            {
                name = name_textbox.Text;                

                try
                {
                    price = Convert.ToDouble(price_textbox.Text);

                    if (type_combobox.SelectedIndex == 0)
                    {
                        MessageBox.Show("Lütfen ürün tipi seçiniz.");
                    }

                    else
                    {
                        if (type_combobox.SelectedIndex == 1)
                        {
                            CreateBread(name, price);
                        }

                        else if (type_combobox.SelectedIndex == 2)
                        {
                            CreateMainIngredient(name, price);
                        }

                        else if(type_combobox.SelectedIndex == 3)
                        {
                            CreateBeverage(name, price);
                        }

                        else
                        {
                            CreateExtraIngredient(name, price);
                        }

                        InitializeIndexes2();
                        MessageBox.Show("Ürün oluşturuldu.");
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Lütfen sayı giriniz.");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Lütfen daha kısa bir sayı giriniz.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void amount_numeric_ValueChanged(object sender, EventArgs e)
        {
            ChangeAmount();
        }

        void ChangeAmount()
        {
            sandwich.Amount =Convert.ToInt32(amount_numeric.Value);
            UpdatePrice();
        }
    }
}
