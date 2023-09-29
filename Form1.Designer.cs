namespace check
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_about = new System.Windows.Forms.GroupBox();
            this.textBox_percent = new System.Windows.Forms.TextBox();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_percent = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label_info = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.button_addToCart = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_total = new System.Windows.Forms.GroupBox();
            this.textBox_inCassa = new System.Windows.Forms.TextBox();
            this.label_inCassa = new System.Windows.Forms.Label();
            this.textBox_percentInTotal = new System.Windows.Forms.TextBox();
            this.label_percentInTotal = new System.Windows.Forms.Label();
            this.textBox_priceInTotal = new System.Windows.Forms.TextBox();
            this.label_priceInTotal = new System.Windows.Forms.Label();
            this.groupBox_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_about
            // 
            this.groupBox_about.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox_about.Controls.Add(this.textBox_percent);
            this.groupBox_about.Controls.Add(this.numericUpDown_amount);
            this.groupBox_about.Controls.Add(this.textBox_price);
            this.groupBox_about.Controls.Add(this.textBox_name);
            this.groupBox_about.Controls.Add(this.label_percent);
            this.groupBox_about.Controls.Add(this.label_amount);
            this.groupBox_about.Controls.Add(this.label_price);
            this.groupBox_about.Controls.Add(this.label_name);
            this.groupBox_about.Location = new System.Drawing.Point(13, 12);
            this.groupBox_about.Name = "groupBox_about";
            this.groupBox_about.Size = new System.Drawing.Size(200, 144);
            this.groupBox_about.TabIndex = 0;
            this.groupBox_about.TabStop = false;
            this.groupBox_about.Text = "Сведения о товаре";
            // 
            // textBox_percent
            // 
            this.textBox_percent.Location = new System.Drawing.Point(88, 114);
            this.textBox_percent.Name = "textBox_percent";
            this.textBox_percent.Size = new System.Drawing.Size(100, 23);
            this.textBox_percent.TabIndex = 7;
            this.textBox_percent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_number_KeyPress);
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Location = new System.Drawing.Point(94, 87);
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown_amount.TabIndex = 6;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(94, 58);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 23);
            this.textBox_price.TabIndex = 5;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_number_KeyPress);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(94, 22);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 23);
            this.textBox_name.TabIndex = 4;
            // 
            // label_percent
            // 
            this.label_percent.AutoSize = true;
            this.label_percent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_percent.Location = new System.Drawing.Point(0, 114);
            this.label_percent.Name = "label_percent";
            this.label_percent.Size = new System.Drawing.Size(82, 21);
            this.label_percent.TabIndex = 3;
            this.label_percent.Text = "Скидка %:";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_amount.Location = new System.Drawing.Point(0, 86);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(96, 21);
            this.label_amount.TabIndex = 2;
            this.label_amount.Text = "Количество:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_price.Location = new System.Drawing.Point(7, 56);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(50, 21);
            this.label_price.TabIndex = 1;
            this.label_price.Text = "Цена:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(7, 22);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(81, 21);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Название:";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info.Location = new System.Drawing.Point(12, 159);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(221, 25);
            this.label_info.TabIndex = 1;
            this.label_info.Text = "Информация о товарах:";
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(13, 187);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_info.Size = new System.Drawing.Size(221, 181);
            this.textBox_info.TabIndex = 2;
            this.textBox_info.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_addToCart
            // 
            this.button_addToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_addToCart.Location = new System.Drawing.Point(17, 380);
            this.button_addToCart.Name = "button_addToCart";
            this.button_addToCart.Size = new System.Drawing.Size(217, 34);
            this.button_addToCart.TabIndex = 3;
            this.button_addToCart.Text = "Добавить товар в корзину";
            this.button_addToCart.UseVisualStyleBackColor = true;
            this.button_addToCart.Click += new System.EventHandler(this.button_addToCart_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(17, 420);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(102, 61);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Очистить корзину";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.Location = new System.Drawing.Point(125, 420);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(102, 61);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // groupBox_total
            // 
            this.groupBox_total.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox_total.Controls.Add(this.textBox_inCassa);
            this.groupBox_total.Controls.Add(this.label_inCassa);
            this.groupBox_total.Controls.Add(this.textBox_percentInTotal);
            this.groupBox_total.Controls.Add(this.label_percentInTotal);
            this.groupBox_total.Controls.Add(this.textBox_priceInTotal);
            this.groupBox_total.Controls.Add(this.label_priceInTotal);
            this.groupBox_total.Location = new System.Drawing.Point(17, 487);
            this.groupBox_total.Name = "groupBox_total";
            this.groupBox_total.Size = new System.Drawing.Size(200, 100);
            this.groupBox_total.TabIndex = 6;
            this.groupBox_total.TabStop = false;
            this.groupBox_total.Text = "Итоговые расчеты";
            // 
            // textBox_inCassa
            // 
            this.textBox_inCassa.Location = new System.Drawing.Point(118, 74);
            this.textBox_inCassa.Name = "textBox_inCassa";
            this.textBox_inCassa.ReadOnly = true;
            this.textBox_inCassa.Size = new System.Drawing.Size(79, 23);
            this.textBox_inCassa.TabIndex = 12;
            // 
            // label_inCassa
            // 
            this.label_inCassa.AutoSize = true;
            this.label_inCassa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_inCassa.Location = new System.Drawing.Point(-1, 73);
            this.label_inCassa.Name = "label_inCassa";
            this.label_inCassa.Size = new System.Drawing.Size(61, 21);
            this.label_inCassa.TabIndex = 11;
            this.label_inCassa.Text = "В кассу";
            // 
            // textBox_percentInTotal
            // 
            this.textBox_percentInTotal.Location = new System.Drawing.Point(118, 48);
            this.textBox_percentInTotal.Name = "textBox_percentInTotal";
            this.textBox_percentInTotal.ReadOnly = true;
            this.textBox_percentInTotal.Size = new System.Drawing.Size(79, 23);
            this.textBox_percentInTotal.TabIndex = 10;
            // 
            // label_percentInTotal
            // 
            this.label_percentInTotal.AutoSize = true;
            this.label_percentInTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_percentInTotal.Location = new System.Drawing.Point(1, 48);
            this.label_percentInTotal.Name = "label_percentInTotal";
            this.label_percentInTotal.Size = new System.Drawing.Size(112, 21);
            this.label_percentInTotal.TabIndex = 9;
            this.label_percentInTotal.Text = "Сумма скидки";
            // 
            // textBox_priceInTotal
            // 
            this.textBox_priceInTotal.Location = new System.Drawing.Point(121, 21);
            this.textBox_priceInTotal.Name = "textBox_priceInTotal";
            this.textBox_priceInTotal.ReadOnly = true;
            this.textBox_priceInTotal.Size = new System.Drawing.Size(79, 23);
            this.textBox_priceInTotal.TabIndex = 8;
            // 
            // label_priceInTotal
            // 
            this.label_priceInTotal.AutoSize = true;
            this.label_priceInTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_priceInTotal.Location = new System.Drawing.Point(3, 19);
            this.label_priceInTotal.Name = "label_priceInTotal";
            this.label_priceInTotal.Size = new System.Drawing.Size(122, 21);
            this.label_priceInTotal.TabIndex = 8;
            this.label_priceInTotal.Text = "Сумма за товар";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 642);
            this.Controls.Add(this.groupBox_total);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_addToCart);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.groupBox_about);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_about.ResumeLayout(false);
            this.groupBox_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox_total.ResumeLayout(false);
            this.groupBox_total.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_about;
        private TextBox textBox_percent;
        private NumericUpDown numericUpDown_amount;
        private TextBox textBox_price;
        private TextBox textBox_name;
        private Label label_percent;
        private Label label_amount;
        private Label label_price;
        private Label label_name;
        private BindingSource bindingSource1;
        private Label label_info;
        private TextBox textBox_info;
        private Button button_addToCart;
        private Button button_clear;
        private Button button_exit;
        private GroupBox groupBox_total;
        private TextBox textBox_inCassa;
        private Label label_inCassa;
        private TextBox textBox_percentInTotal;
        private Label label_percentInTotal;
        private TextBox textBox_priceInTotal;
        private Label label_priceInTotal;
    }
}