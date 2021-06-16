namespace SerialsForms
{
    partial class WorkForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.genreFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.serialsDataGridView = new System.Windows.Forms.DataGridView();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.genreFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialsDataGridView)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1016, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "выберете статус",
            "Завершен",
            "Продолжается"});
            this.statusComboBox.Location = new System.Drawing.Point(924, 27);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(145, 24);
            this.statusComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Страна";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Категория";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 400);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(16, 449);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Год от:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "До:";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(1116, 12);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(133, 43);
            this.loginButton.TabIndex = 18;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(3, 277);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(111, 21);
            this.checkBox12.TabIndex = 27;
            this.checkBox12.Text = "Фантастика";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(3, 252);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(73, 21);
            this.checkBox11.TabIndex = 26;
            this.checkBox11.Text = "Ужасы";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(3, 227);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(87, 21);
            this.checkBox10.TabIndex = 25;
            this.checkBox10.Text = "Триллер";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(3, 202);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(70, 21);
            this.checkBox9.TabIndex = 24;
            this.checkBox9.Text = "Спорт";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(3, 177);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(121, 21);
            this.checkBox8.TabIndex = 23;
            this.checkBox8.Text = "Приключения";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 152);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(106, 21);
            this.checkBox7.TabIndex = 22;
            this.checkBox7.Text = "Мелодрама";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(3, 127);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(96, 21);
            this.checkBox6.TabIndex = 21;
            this.checkBox6.Text = "Криминал";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 102);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(88, 21);
            this.checkBox5.TabIndex = 20;
            this.checkBox5.Text = "Комедия";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 77);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 21);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.Text = "История";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 52);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Драма";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 27);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 21);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Детектив";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 2);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Боевик";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // genreFlowLayoutPanel
            // 
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox1);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox2);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox3);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox4);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox5);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox6);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox7);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox8);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox9);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox10);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox11);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox12);
            this.genreFlowLayoutPanel.Controls.Add(this.checkBox13);
            this.genreFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.genreFlowLayoutPanel.Location = new System.Drawing.Point(9, 22);
            this.genreFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreFlowLayoutPanel.Name = "genreFlowLayoutPanel";
            this.genreFlowLayoutPanel.Size = new System.Drawing.Size(131, 345);
            this.genreFlowLayoutPanel.TabIndex = 3;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(4, 304);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(88, 21);
            this.checkBox13.TabIndex = 21;
            this.checkBox13.Text = "Фэнтези";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // countryComboBox
            // 
            this.countryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "выберете страну",
            "Россия",
            "Великобритания",
            "США",
            "Япония"});
            this.countryComboBox.Location = new System.Drawing.Point(772, 27);
            this.countryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(145, 24);
            this.countryComboBox.TabIndex = 9;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "выберете категорию",
            "Сериал",
            "Мультсериал",
            "Аниме"});
            this.categoryComboBox.Location = new System.Drawing.Point(604, 27);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(161, 24);
            this.categoryComboBox.TabIndex = 11;
            // 
            // serialsDataGridView
            // 
            this.serialsDataGridView.AllowUserToAddRows = false;
            this.serialsDataGridView.AllowUserToDeleteRows = false;
            this.serialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serialsDataGridView.Location = new System.Drawing.Point(7, 22);
            this.serialsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serialsDataGridView.Name = "serialsDataGridView";
            this.serialsDataGridView.ReadOnly = true;
            this.serialsDataGridView.RowHeadersWidth = 51;
            this.serialsDataGridView.Size = new System.Drawing.Size(1091, 551);
            this.serialsDataGridView.TabIndex = 0;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.serialsDataGridView);
            this.resultsGroupBox.Location = new System.Drawing.Point(145, 62);
            this.resultsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsGroupBox.Size = new System.Drawing.Size(1104, 580);
            this.resultsGroupBox.TabIndex = 12;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Результаты поиска";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTextBox.Location = new System.Drawing.Point(147, 23);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(311, 26);
            this.valueTextBox.TabIndex = 19;
            this.valueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valueTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(483, 23);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 655);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.genreFlowLayoutPanel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск сериалов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.genreFlowLayoutPanel.ResumeLayout(false);
            this.genreFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialsDataGridView)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel genreFlowLayoutPanel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView serialsDataGridView;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox checkBox13;
    }
}

