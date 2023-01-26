namespace LAB_2
{
    partial class Form1
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
            this.PValueBox = new System.Windows.Forms.NumericUpDown();
            this.VValueBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.VComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TComboBox = new System.Windows.Forms.ComboBox();
            this.TValueBox = new System.Windows.Forms.NumericUpDown();
            this.GetAnswerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DownSTB = new System.Windows.Forms.TextBox();
            this.AccessibleSymbolsCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SValueTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Величина P (вероятность подбора пароля): ";
            // 
            // PValueBox
            // 
            this.PValueBox.DecimalPlaces = 10;
            this.PValueBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.PValueBox.Location = new System.Drawing.Point(328, 9);
            this.PValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.PValueBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.PValueBox.Name = "PValueBox";
            this.PValueBox.Size = new System.Drawing.Size(160, 23);
            this.PValueBox.TabIndex = 1;
            // 
            // VValueBox
            // 
            this.VValueBox.Location = new System.Drawing.Point(328, 48);
            this.VValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.VValueBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.VValueBox.Name = "VValueBox";
            this.VValueBox.Size = new System.Drawing.Size(160, 23);
            this.VValueBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Величина V (скорость подбора паролей):";
            // 
            // VComboBox
            // 
            this.VComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VComboBox.FormattingEnabled = true;
            this.VComboBox.Items.AddRange(new object[] {
            "минуту",
            "день",
            "неделю"});
            this.VComboBox.Location = new System.Drawing.Point(517, 48);
            this.VComboBox.Name = "VComboBox";
            this.VComboBox.Size = new System.Drawing.Size(168, 25);
            this.VComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(495, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "в";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Величина T (срок действия пароля):";
            // 
            // TComboBox
            // 
            this.TComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBox.FormattingEnabled = true;
            this.TComboBox.Items.AddRange(new object[] {
            "дней",
            "недель"});
            this.TComboBox.Location = new System.Drawing.Point(498, 91);
            this.TComboBox.Name = "TComboBox";
            this.TComboBox.Size = new System.Drawing.Size(187, 25);
            this.TComboBox.TabIndex = 8;
            // 
            // TValueBox
            // 
            this.TValueBox.Location = new System.Drawing.Point(328, 93);
            this.TValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.TValueBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.TValueBox.Name = "TValueBox";
            this.TValueBox.Size = new System.Drawing.Size(160, 23);
            this.TValueBox.TabIndex = 7;
            // 
            // GetAnswerButton
            // 
            this.GetAnswerButton.Location = new System.Drawing.Point(501, 3);
            this.GetAnswerButton.Name = "GetAnswerButton";
            this.GetAnswerButton.Size = new System.Drawing.Size(189, 33);
            this.GetAnswerButton.TabIndex = 9;
            this.GetAnswerButton.Text = "Получить ответ:";
            this.GetAnswerButton.UseVisualStyleBackColor = true;
            this.GetAnswerButton.Click += new System.EventHandler(this.GetAnswerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "S*";
            // 
            // DownSTB
            // 
            this.DownSTB.Location = new System.Drawing.Point(45, 162);
            this.DownSTB.Name = "DownSTB";
            this.DownSTB.ReadOnly = true;
            this.DownSTB.Size = new System.Drawing.Size(283, 23);
            this.DownSTB.TabIndex = 11;
            // 
            // AccessibleSymbolsCB
            // 
            this.AccessibleSymbolsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccessibleSymbolsCB.FormattingEnabled = true;
            this.AccessibleSymbolsCB.Items.AddRange(new object[] {
            "все нижние латинские буквы (26)",
            "все нижние и верхние латинские буквы (52)",
            "все нижние и верхние латинские буквы + цифры (62)"});
            this.AccessibleSymbolsCB.Location = new System.Drawing.Point(307, 124);
            this.AccessibleSymbolsCB.Name = "AccessibleSymbolsCB";
            this.AccessibleSymbolsCB.Size = new System.Drawing.Size(378, 25);
            this.AccessibleSymbolsCB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(16, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Выберите число используемых символов:";
            // 
            // SValueTB
            // 
            this.SValueTB.Location = new System.Drawing.Point(45, 189);
            this.SValueTB.Name = "SValueTB";
            this.SValueTB.ReadOnly = true;
            this.SValueTB.Size = new System.Drawing.Size(283, 23);
            this.SValueTB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(16, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 215);
            this.Controls.Add(this.SValueTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AccessibleSymbolsCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DownSTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GetAnswerButton);
            this.Controls.Add(this.TComboBox);
            this.Controls.Add(this.TValueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VComboBox);
            this.Controls.Add(this.VValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PValueBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PValueBox;
        private System.Windows.Forms.NumericUpDown VValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TComboBox;
        private System.Windows.Forms.NumericUpDown TValueBox;
        private System.Windows.Forms.Button GetAnswerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DownSTB;
        private System.Windows.Forms.ComboBox AccessibleSymbolsCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SValueTB;
        private System.Windows.Forms.Label label7;
    }
}

