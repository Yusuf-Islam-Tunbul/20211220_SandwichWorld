
namespace _20211220_SandwichWorld
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bread_label = new System.Windows.Forms.Label();
            this.bread_size_combobox = new System.Windows.Forms.ComboBox();
            this.bread_combobox = new System.Windows.Forms.ComboBox();
            this.main_ingredient_label = new System.Windows.Forms.Label();
            this.main_ingredient_combobox = new System.Windows.Forms.ComboBox();
            this.hollow_bread_label = new System.Windows.Forms.Label();
            this.hollow_bread_checkbox = new System.Windows.Forms.CheckBox();
            this.extra_ingredient_label = new System.Windows.Forms.Label();
            this.beverage_label = new System.Windows.Forms.Label();
            this.beverage_combobox = new System.Windows.Forms.ComboBox();
            this.ingredient_listbox2 = new System.Windows.Forms.ListBox();
            this.ingredient_listbox1 = new System.Windows.Forms.ListBox();
            this.total_price_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.add_sandwich_button = new System.Windows.Forms.Button();
            this.complete_order_button = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.amount_label = new System.Windows.Forms.Label();
            this.amount_numeric = new System.Windows.Forms.NumericUpDown();
            this.extra_ingredients_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.create_button = new System.Windows.Forms.Button();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.warning_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_numeric)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bread_label
            // 
            this.bread_label.AutoSize = true;
            this.bread_label.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bread_label.Location = new System.Drawing.Point(5, 20);
            this.bread_label.Name = "bread_label";
            this.bread_label.Size = new System.Drawing.Size(85, 31);
            this.bread_label.TabIndex = 0;
            this.bread_label.Text = "Ekmek";
            // 
            // bread_size_combobox
            // 
            this.bread_size_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bread_size_combobox.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bread_size_combobox.FormattingEnabled = true;
            this.bread_size_combobox.ItemHeight = 29;
            this.bread_size_combobox.Items.AddRange(new object[] {
            "0,5",
            "1",
            "1,5",
            "2"});
            this.bread_size_combobox.Location = new System.Drawing.Point(97, 17);
            this.bread_size_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bread_size_combobox.Name = "bread_size_combobox";
            this.bread_size_combobox.Size = new System.Drawing.Size(73, 37);
            this.bread_size_combobox.TabIndex = 1;
            this.bread_size_combobox.SelectedIndexChanged += new System.EventHandler(this.bread_size_combobox_SelectedIndexChanged);
            // 
            // bread_combobox
            // 
            this.bread_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bread_combobox.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bread_combobox.FormattingEnabled = true;
            this.bread_combobox.Items.AddRange(new object[] {
            "Ekmek seçiniz"});
            this.bread_combobox.Location = new System.Drawing.Point(229, 17);
            this.bread_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bread_combobox.Name = "bread_combobox";
            this.bread_combobox.Size = new System.Drawing.Size(224, 37);
            this.bread_combobox.TabIndex = 2;
            this.bread_combobox.SelectedIndexChanged += new System.EventHandler(this.bread_combobox_SelectedIndexChanged);
            // 
            // main_ingredient_label
            // 
            this.main_ingredient_label.AutoSize = true;
            this.main_ingredient_label.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_ingredient_label.Location = new System.Drawing.Point(5, 119);
            this.main_ingredient_label.Name = "main_ingredient_label";
            this.main_ingredient_label.Size = new System.Drawing.Size(165, 31);
            this.main_ingredient_label.TabIndex = 3;
            this.main_ingredient_label.Text = "Ana Malzeme";
            // 
            // main_ingredient_combobox
            // 
            this.main_ingredient_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.main_ingredient_combobox.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_ingredient_combobox.FormattingEnabled = true;
            this.main_ingredient_combobox.Items.AddRange(new object[] {
            "Malzeme seçiniz"});
            this.main_ingredient_combobox.Location = new System.Drawing.Point(188, 116);
            this.main_ingredient_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_ingredient_combobox.Name = "main_ingredient_combobox";
            this.main_ingredient_combobox.Size = new System.Drawing.Size(267, 37);
            this.main_ingredient_combobox.TabIndex = 4;
            this.main_ingredient_combobox.SelectedIndexChanged += new System.EventHandler(this.main_ingredient_combobox_SelectedIndexChanged);
            // 
            // hollow_bread_label
            // 
            this.hollow_bread_label.AutoSize = true;
            this.hollow_bread_label.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hollow_bread_label.Location = new System.Drawing.Point(5, 71);
            this.hollow_bread_label.Name = "hollow_bread_label";
            this.hollow_bread_label.Size = new System.Drawing.Size(218, 31);
            this.hollow_bread_label.TabIndex = 5;
            this.hollow_bread_label.Text = "Ekmeğin içi alınsın";
            // 
            // hollow_bread_checkbox
            // 
            this.hollow_bread_checkbox.AutoSize = true;
            this.hollow_bread_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hollow_bread_checkbox.Location = new System.Drawing.Point(243, 82);
            this.hollow_bread_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hollow_bread_checkbox.Name = "hollow_bread_checkbox";
            this.hollow_bread_checkbox.Size = new System.Drawing.Size(18, 17);
            this.hollow_bread_checkbox.TabIndex = 6;
            this.hollow_bread_checkbox.UseVisualStyleBackColor = true;
            this.hollow_bread_checkbox.CheckedChanged += new System.EventHandler(this.hollow_bread_checkbox_CheckedChanged);
            // 
            // extra_ingredient_label
            // 
            this.extra_ingredient_label.AutoSize = true;
            this.extra_ingredient_label.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra_ingredient_label.Location = new System.Drawing.Point(5, 231);
            this.extra_ingredient_label.Name = "extra_ingredient_label";
            this.extra_ingredient_label.Size = new System.Drawing.Size(177, 31);
            this.extra_ingredient_label.TabIndex = 7;
            this.extra_ingredient_label.Text = "Ek Malzemeler";
            // 
            // beverage_label
            // 
            this.beverage_label.AutoSize = true;
            this.beverage_label.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverage_label.Location = new System.Drawing.Point(5, 175);
            this.beverage_label.Name = "beverage_label";
            this.beverage_label.Size = new System.Drawing.Size(76, 31);
            this.beverage_label.TabIndex = 8;
            this.beverage_label.Text = "İçecek";
            // 
            // beverage_combobox
            // 
            this.beverage_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beverage_combobox.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverage_combobox.FormattingEnabled = true;
            this.beverage_combobox.Items.AddRange(new object[] {
            "Içecek seçiniz"});
            this.beverage_combobox.Location = new System.Drawing.Point(97, 169);
            this.beverage_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beverage_combobox.Name = "beverage_combobox";
            this.beverage_combobox.Size = new System.Drawing.Size(357, 37);
            this.beverage_combobox.TabIndex = 9;
            this.beverage_combobox.SelectedIndexChanged += new System.EventHandler(this.beverage_combobox_SelectedIndexChanged);
            // 
            // ingredient_listbox2
            // 
            this.ingredient_listbox2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient_listbox2.FormattingEnabled = true;
            this.ingredient_listbox2.ItemHeight = 34;
            this.ingredient_listbox2.Location = new System.Drawing.Point(475, 175);
            this.ingredient_listbox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingredient_listbox2.Name = "ingredient_listbox2";
            this.ingredient_listbox2.Size = new System.Drawing.Size(421, 276);
            this.ingredient_listbox2.TabIndex = 10;
            this.ingredient_listbox2.Click += new System.EventHandler(this.listbox_Click);
            // 
            // ingredient_listbox1
            // 
            this.ingredient_listbox1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient_listbox1.FormattingEnabled = true;
            this.ingredient_listbox1.ItemHeight = 34;
            this.ingredient_listbox1.Items.AddRange(new object[] {
            "Ekmek seçilmedi",
            "Malzeme seçilmedi",
            "İçecek seçilmedi"});
            this.ingredient_listbox1.Location = new System.Drawing.Point(475, 17);
            this.ingredient_listbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingredient_listbox1.Name = "ingredient_listbox1";
            this.ingredient_listbox1.Size = new System.Drawing.Size(421, 140);
            this.ingredient_listbox1.TabIndex = 11;
            this.ingredient_listbox1.Click += new System.EventHandler(this.listbox_Click);
            // 
            // total_price_label
            // 
            this.total_price_label.AutoSize = true;
            this.total_price_label.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price_label.Location = new System.Drawing.Point(4, 441);
            this.total_price_label.Name = "total_price_label";
            this.total_price_label.Size = new System.Drawing.Size(175, 37);
            this.total_price_label.TabIndex = 22;
            this.total_price_label.Text = "Tutar: 0 Tl";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(13, 434);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(0, 31);
            this.price_label.TabIndex = 23;
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(911, 17);
            this.picturebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(251, 250);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 24;
            this.picturebox.TabStop = false;
            // 
            // add_sandwich_button
            // 
            this.add_sandwich_button.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_sandwich_button.Location = new System.Drawing.Point(911, 299);
            this.add_sandwich_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_sandwich_button.Name = "add_sandwich_button";
            this.add_sandwich_button.Size = new System.Drawing.Size(251, 74);
            this.add_sandwich_button.TabIndex = 26;
            this.add_sandwich_button.Text = "Siparişe Ekle";
            this.add_sandwich_button.UseVisualStyleBackColor = true;
            this.add_sandwich_button.Click += new System.EventHandler(this.add_sandwich_button_Click);
            // 
            // complete_order_button
            // 
            this.complete_order_button.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complete_order_button.Location = new System.Drawing.Point(911, 395);
            this.complete_order_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.complete_order_button.Name = "complete_order_button";
            this.complete_order_button.Size = new System.Drawing.Size(251, 74);
            this.complete_order_button.TabIndex = 27;
            this.complete_order_button.Text = "Siparişi Tamamla";
            this.complete_order_button.UseVisualStyleBackColor = true;
            this.complete_order_button.Click += new System.EventHandler(this.complete_order_button_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1193, 523);
            this.tabcontrol.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.amount_label);
            this.tabPage1.Controls.Add(this.amount_numeric);
            this.tabPage1.Controls.Add(this.extra_ingredients_panel);
            this.tabPage1.Controls.Add(this.bread_label);
            this.tabPage1.Controls.Add(this.complete_order_button);
            this.tabPage1.Controls.Add(this.bread_size_combobox);
            this.tabPage1.Controls.Add(this.add_sandwich_button);
            this.tabPage1.Controls.Add(this.bread_combobox);
            this.tabPage1.Controls.Add(this.picturebox);
            this.tabPage1.Controls.Add(this.main_ingredient_label);
            this.tabPage1.Controls.Add(this.main_ingredient_combobox);
            this.tabPage1.Controls.Add(this.total_price_label);
            this.tabPage1.Controls.Add(this.hollow_bread_label);
            this.tabPage1.Controls.Add(this.hollow_bread_checkbox);
            this.tabPage1.Controls.Add(this.extra_ingredient_label);
            this.tabPage1.Controls.Add(this.beverage_label);
            this.tabPage1.Controls.Add(this.beverage_combobox);
            this.tabPage1.Controls.Add(this.ingredient_listbox2);
            this.tabPage1.Controls.Add(this.ingredient_listbox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1185, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sandviç Seçimi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.Location = new System.Drawing.Point(11, 389);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(89, 31);
            this.amount_label.TabIndex = 29;
            this.amount_label.Text = "Miktar";
            // 
            // amount_numeric
            // 
            this.amount_numeric.Font = new System.Drawing.Font("MV Boli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_numeric.Location = new System.Drawing.Point(112, 388);
            this.amount_numeric.Margin = new System.Windows.Forms.Padding(4);
            this.amount_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount_numeric.Name = "amount_numeric";
            this.amount_numeric.Size = new System.Drawing.Size(356, 42);
            this.amount_numeric.TabIndex = 0;
            this.amount_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount_numeric.ValueChanged += new System.EventHandler(this.amount_numeric_ValueChanged);
            // 
            // extra_ingredients_panel
            // 
            this.extra_ingredients_panel.AutoScroll = true;
            this.extra_ingredients_panel.Location = new System.Drawing.Point(12, 270);
            this.extra_ingredients_panel.Margin = new System.Windows.Forms.Padding(4);
            this.extra_ingredients_panel.Name = "extra_ingredients_panel";
            this.extra_ingredients_panel.Size = new System.Drawing.Size(456, 103);
            this.extra_ingredients_panel.TabIndex = 28;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.warning_label);
            this.tabPage2.Controls.Add(this.create_button);
            this.tabPage2.Controls.Add(this.type_combobox);
            this.tabPage2.Controls.Add(this.price_textbox);
            this.tabPage2.Controls.Add(this.name_textbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1185, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün ekleme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.create_button.Location = new System.Drawing.Point(21, 140);
            this.create_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(204, 46);
            this.create_button.TabIndex = 3;
            this.create_button.Text = "Ürün Oluştur";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // type_combobox
            // 
            this.type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Items.AddRange(new object[] {
            "Ürün tipi seçiniz",
            "Ekmek",
            "Ana malzeme",
            "İçecek",
            "Ek Malzeme"});
            this.type_combobox.Location = new System.Drawing.Point(21, 100);
            this.type_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(204, 34);
            this.type_combobox.TabIndex = 2;
            // 
            // price_textbox
            // 
            this.price_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price_textbox.Location = new System.Drawing.Point(21, 62);
            this.price_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(204, 32);
            this.price_textbox.TabIndex = 1;
            this.price_textbox.Text = "Ürün fiyatı giriniz";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_textbox.Location = new System.Drawing.Point(21, 25);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(204, 32);
            this.name_textbox.TabIndex = 0;
            this.name_textbox.Text = "Ürün adı giriniz";
            // 
            // warning_label
            // 
            this.warning_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warning_label.Location = new System.Drawing.Point(244, 28);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(207, 161);
            this.warning_label.TabIndex = 29;
            this.warning_label.Text = "Uygulama klasörüne ürünle aynı adda bir görsel eklemeyi unumayınız.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 544);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.price_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_numeric)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bread_label;
        private System.Windows.Forms.ComboBox bread_size_combobox;
        private System.Windows.Forms.ComboBox bread_combobox;
        private System.Windows.Forms.Label main_ingredient_label;
        private System.Windows.Forms.ComboBox main_ingredient_combobox;
        private System.Windows.Forms.Label hollow_bread_label;
        private System.Windows.Forms.CheckBox hollow_bread_checkbox;
        private System.Windows.Forms.Label extra_ingredient_label;
        private System.Windows.Forms.Label beverage_label;
        private System.Windows.Forms.ComboBox beverage_combobox;
        private System.Windows.Forms.ListBox ingredient_listbox2;
        private System.Windows.Forms.ListBox ingredient_listbox1;
        private System.Windows.Forms.Label total_price_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button add_sandwich_button;
        private System.Windows.Forms.Button complete_order_button;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.FlowLayoutPanel extra_ingredients_panel;
        private System.Windows.Forms.NumericUpDown amount_numeric;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label warning_label;
    }
}

