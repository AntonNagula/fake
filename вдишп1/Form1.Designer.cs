namespace вдишп1
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
            this.dataTrain = new System.Windows.Forms.DataGridView();
            this.dataBus = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.EndPlace = new System.Windows.Forms.Label();
            this.StartPlace = new System.Windows.Forms.Label();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            this.DayCombo = new System.Windows.Forms.ComboBox();
            this.HourCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ChosenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTrain
            // 
            this.dataTrain.AllowUserToAddRows = false;
            this.dataTrain.AllowUserToDeleteRows = false;
            this.dataTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrain.Location = new System.Drawing.Point(93, 12);
            this.dataTrain.Name = "dataTrain";
            this.dataTrain.ReadOnly = true;
            this.dataTrain.Size = new System.Drawing.Size(805, 150);
            this.dataTrain.TabIndex = 0;
            // 
            // dataBus
            // 
            this.dataBus.AllowUserToAddRows = false;
            this.dataBus.AllowUserToDeleteRows = false;
            this.dataBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBus.Location = new System.Drawing.Point(93, 168);
            this.dataBus.Name = "dataBus";
            this.dataBus.ReadOnly = true;
            this.dataBus.Size = new System.Drawing.Size(805, 164);
            this.dataBus.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "XMLButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadXML);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Diagramm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Diagram);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 362);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(220, 362);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // EndPlace
            // 
            this.EndPlace.AutoSize = true;
            this.EndPlace.Location = new System.Drawing.Point(102, 346);
            this.EndPlace.Name = "EndPlace";
            this.EndPlace.Size = new System.Drawing.Size(99, 13);
            this.EndPlace.TabIndex = 7;
            this.EndPlace.Text = "Пункт назначения";
            // 
            // StartPlace
            // 
            this.StartPlace.AutoSize = true;
            this.StartPlace.Location = new System.Drawing.Point(229, 346);
            this.StartPlace.Name = "StartPlace";
            this.StartPlace.Size = new System.Drawing.Size(105, 13);
            this.StartPlace.TabIndex = 8;
            this.StartPlace.Text = "Пункт отправления";
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(0, 123);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(87, 31);
            this.FiltrButton.TabIndex = 9;
            this.FiltrButton.Text = "Find";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.Filtr_Cliclk);
            // 
            // YearCombo
            // 
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(347, 362);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(121, 21);
            this.YearCombo.TabIndex = 10;
            // 
            // MonthCombo
            // 
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Location = new System.Drawing.Point(474, 362);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(121, 21);
            this.MonthCombo.TabIndex = 11;
            // 
            // DayCombo
            // 
            this.DayCombo.FormattingEnabled = true;
            this.DayCombo.Location = new System.Drawing.Point(601, 362);
            this.DayCombo.Name = "DayCombo";
            this.DayCombo.Size = new System.Drawing.Size(121, 21);
            this.DayCombo.TabIndex = 12;
            // 
            // HourCombo
            // 
            this.HourCombo.FormattingEnabled = true;
            this.HourCombo.Location = new System.Drawing.Point(728, 362);
            this.HourCombo.Name = "HourCombo";
            this.HourCombo.Size = new System.Drawing.Size(121, 21);
            this.HourCombo.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "CSVButton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GetCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Год отправления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Месяц отправления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "День отправления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Час отправления";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(0, 160);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(87, 31);
            this.SelectButton.TabIndex = 19;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.Select_Click);
            // 
            // ChosenButton
            // 
            this.ChosenButton.Location = new System.Drawing.Point(0, 197);
            this.ChosenButton.Name = "ChosenButton";
            this.ChosenButton.Size = new System.Drawing.Size(87, 31);
            this.ChosenButton.TabIndex = 20;
            this.ChosenButton.Text = "Chosen";
            this.ChosenButton.UseVisualStyleBackColor = true;
            this.ChosenButton.Click += new System.EventHandler(this.Chosen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 549);
            this.Controls.Add(this.ChosenButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.HourCombo);
            this.Controls.Add(this.DayCombo);
            this.Controls.Add(this.MonthCombo);
            this.Controls.Add(this.YearCombo);
            this.Controls.Add(this.FiltrButton);
            this.Controls.Add(this.StartPlace);
            this.Controls.Add(this.EndPlace);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataBus);
            this.Controls.Add(this.dataTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTrain;
        private System.Windows.Forms.DataGridView dataBus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label EndPlace;
        private System.Windows.Forms.Label StartPlace;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.ComboBox MonthCombo;
        private System.Windows.Forms.ComboBox DayCombo;
        private System.Windows.Forms.ComboBox HourCombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button ChosenButton;
    }
}

