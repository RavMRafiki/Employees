﻿
namespace pracownicy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.radioButton_praca = new System.Windows.Forms.RadioButton();
            this.radioButton_zlecenie = new System.Windows.Forms.RadioButton();
            this.radioButton_dzielo = new System.Windows.Forms.RadioButton();
            this.employeeList = new System.Windows.Forms.ListBox();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBoxUmowa = new System.Windows.Forms.GroupBox();
            this.buttonSaveToXml = new System.Windows.Forms.Button();
            this.buttonReadFromXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            this.groupBoxUmowa.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(164, 31);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(265, 22);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(164, 63);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(265, 22);
            this.textBox_surname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pensja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stanowisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rodzaj umowy";
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(164, 95);
            this.dateTimePicker_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_birthday.TabIndex = 8;
            this.dateTimePicker_birthday.MaxDate = System.DateTime.Now.AddYears(-18);
            this.dateTimePicker_birthday.MinDate = System.DateTime.Now.AddYears(-100);
            // 
            // comboBox_position
            // 
            this.comboBox_position.DataSource = System.Enum.GetValues(typeof(Employee.Position));
            this.comboBox_position.Location = new System.Drawing.Point(164, 159);
            this.comboBox_position.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(265, 24);
            this.comboBox_position.TabIndex = 9;
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Location = new System.Drawing.Point(164, 127);
            this.numericUpDown_salary.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(267, 22);
            this.numericUpDown_salary.TabIndex = 11;
            // 
            // radioButton_praca
            // 
            this.radioButton_praca.AutoSize = true;
            this.radioButton_praca.Location = new System.Drawing.Point(18, 22);
            this.radioButton_praca.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_praca.Name = "radioButton_praca";
            this.radioButton_praca.Size = new System.Drawing.Size(127, 21);
            this.radioButton_praca.TabIndex = 12;
            this.radioButton_praca.Text = "Umowa o pracę";
            this.radioButton_praca.UseVisualStyleBackColor = true;
            // 
            // radioButton_zlecenie
            // 
            this.radioButton_zlecenie.AutoSize = true;
            this.radioButton_zlecenie.Location = new System.Drawing.Point(18, 51);
            this.radioButton_zlecenie.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_zlecenie.Name = "radioButton_zlecenie";
            this.radioButton_zlecenie.Size = new System.Drawing.Size(131, 21);
            this.radioButton_zlecenie.TabIndex = 13;
            this.radioButton_zlecenie.Text = "Umowa zlecenie";
            this.radioButton_zlecenie.UseVisualStyleBackColor = true;
            // 
            // radioButton_dzielo
            // 
            this.radioButton_dzielo.AutoSize = true;
            this.radioButton_dzielo.Location = new System.Drawing.Point(18, 80);
            this.radioButton_dzielo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_dzielo.Name = "radioButton_dzielo";
            this.radioButton_dzielo.Size = new System.Drawing.Size(128, 21);
            this.radioButton_dzielo.TabIndex = 14;
            this.radioButton_dzielo.Text = "Umowa o dzieło";
            this.radioButton_dzielo.UseVisualStyleBackColor = true;
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.ItemHeight = 16;
            this.employeeList.Location = new System.Drawing.Point(439, 23);
            this.employeeList.Margin = new System.Windows.Forms.Padding(4);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(615, 372);
            this.employeeList.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(164, 322);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(265, 28);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "Zapisz";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBoxUmowa
            // 
            this.groupBoxUmowa.Controls.Add(this.radioButton_praca);
            this.groupBoxUmowa.Controls.Add(this.radioButton_zlecenie);
            this.groupBoxUmowa.Controls.Add(this.radioButton_dzielo);
            this.groupBoxUmowa.Location = new System.Drawing.Point(164, 190);
            this.groupBoxUmowa.Name = "groupBoxUmowa";
            this.groupBoxUmowa.Size = new System.Drawing.Size(265, 125);
            this.groupBoxUmowa.TabIndex = 17;
            this.groupBoxUmowa.TabStop = false;
            // 
            // buttonSaveToXml
            // 
            this.buttonSaveToXml.Location = new System.Drawing.Point(299, 357);
            this.buttonSaveToXml.Name = "buttonSaveToXml";
            this.buttonSaveToXml.Size = new System.Drawing.Size(130, 28);
            this.buttonSaveToXml.TabIndex = 18;
            this.buttonSaveToXml.Text = "Zapisz Plik";
            this.buttonSaveToXml.UseVisualStyleBackColor = true;
            this.buttonSaveToXml.Click += new System.EventHandler(this.SaveToXml);
            // 
            // buttonReadFromXml
            // 
            this.buttonReadFromXml.Location = new System.Drawing.Point(164, 357);
            this.buttonReadFromXml.Name = "buttonReadFromXml";
            this.buttonReadFromXml.Size = new System.Drawing.Size(129, 28);
            this.buttonReadFromXml.TabIndex = 19;
            this.buttonReadFromXml.Text = "Wczytaj Plik";
            this.buttonReadFromXml.UseVisualStyleBackColor = true;
            this.buttonReadFromXml.Click += new System.EventHandler(this.ReadFormXml);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 405);
            this.Controls.Add(this.buttonReadFromXml);
            this.Controls.Add(this.buttonSaveToXml);
            this.Controls.Add(this.groupBoxUmowa);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.numericUpDown_salary);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            this.groupBoxUmowa.ResumeLayout(false);
            this.groupBoxUmowa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.RadioButton radioButton_praca;
        private System.Windows.Forms.RadioButton radioButton_zlecenie;
        private System.Windows.Forms.RadioButton radioButton_dzielo;
        private System.Windows.Forms.ListBox employeeList;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBoxUmowa;
        private System.Windows.Forms.Button buttonSaveToXml;
        private System.Windows.Forms.Button buttonReadFromXml;
    }
}

