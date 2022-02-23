
namespace _20211220_SandwichWorld
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.return_button = new System.Windows.Forms.Button();
            this.complete_order_button = new System.Windows.Forms.Button();
            this.sandwiches_listbox = new System.Windows.Forms.ListBox();
            this.delete_sandwich_button = new System.Windows.Forms.Button();
            this.total_price_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(12, 230);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(93, 23);
            this.return_button.TabIndex = 0;
            this.return_button.Text = "Return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // complete_order_button
            // 
            this.complete_order_button.Location = new System.Drawing.Point(12, 259);
            this.complete_order_button.Name = "complete_order_button";
            this.complete_order_button.Size = new System.Drawing.Size(221, 23);
            this.complete_order_button.TabIndex = 1;
            this.complete_order_button.Text = "Complete Order";
            this.complete_order_button.UseVisualStyleBackColor = true;
            this.complete_order_button.Click += new System.EventHandler(this.complete_order_button_Click);
            // 
            // sandwiches_listbox
            // 
            this.sandwiches_listbox.FormattingEnabled = true;
            this.sandwiches_listbox.ItemHeight = 16;
            this.sandwiches_listbox.Location = new System.Drawing.Point(12, 12);
            this.sandwiches_listbox.Name = "sandwiches_listbox";
            this.sandwiches_listbox.Size = new System.Drawing.Size(221, 180);
            this.sandwiches_listbox.TabIndex = 2;
            // 
            // delete_sandwich_button
            // 
            this.delete_sandwich_button.Location = new System.Drawing.Point(111, 230);
            this.delete_sandwich_button.Name = "delete_sandwich_button";
            this.delete_sandwich_button.Size = new System.Drawing.Size(122, 23);
            this.delete_sandwich_button.TabIndex = 3;
            this.delete_sandwich_button.Text = "Delete Sandwich";
            this.delete_sandwich_button.UseVisualStyleBackColor = true;
            this.delete_sandwich_button.Click += new System.EventHandler(this.delete_sandwich_button_Click);
            // 
            // total_price_label
            // 
            this.total_price_label.AutoSize = true;
            this.total_price_label.Location = new System.Drawing.Point(12, 201);
            this.total_price_label.Name = "total_price_label";
            this.total_price_label.Size = new System.Drawing.Size(46, 17);
            this.total_price_label.TabIndex = 4;
            this.total_price_label.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 293);
            this.Controls.Add(this.total_price_label);
            this.Controls.Add(this.delete_sandwich_button);
            this.Controls.Add(this.sandwiches_listbox);
            this.Controls.Add(this.complete_order_button);
            this.Controls.Add(this.return_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button complete_order_button;
        private System.Windows.Forms.ListBox sandwiches_listbox;
        private System.Windows.Forms.Button delete_sandwich_button;
        private System.Windows.Forms.Label total_price_label;
    }
}