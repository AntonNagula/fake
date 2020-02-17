namespace вдишп1
{
    partial class SelectedFrom
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
            this.dataTrain = new System.Windows.Forms.DataGridView();
            this.dataBus = new System.Windows.Forms.DataGridView();
            this.timetableButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTrain
            // 
            this.dataTrain.AllowUserToAddRows = false;
            this.dataTrain.AllowUserToDeleteRows = false;
            this.dataTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrain.Location = new System.Drawing.Point(102, 12);
            this.dataTrain.Name = "dataTrain";
            this.dataTrain.ReadOnly = true;
            this.dataTrain.Size = new System.Drawing.Size(805, 150);
            this.dataTrain.TabIndex = 1;
            // 
            // dataBus
            // 
            this.dataBus.AllowUserToAddRows = false;
            this.dataBus.AllowUserToDeleteRows = false;
            this.dataBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBus.Location = new System.Drawing.Point(102, 186);
            this.dataBus.Name = "dataBus";
            this.dataBus.ReadOnly = true;
            this.dataBus.Size = new System.Drawing.Size(805, 150);
            this.dataBus.TabIndex = 2;
            // 
            // timetableButton
            // 
            this.timetableButton.Location = new System.Drawing.Point(9, 12);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(87, 31);
            this.timetableButton.TabIndex = 17;
            this.timetableButton.Text = "Назад";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.Back);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Очистка списка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clean);
            // 
            // SelectedFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timetableButton);
            this.Controls.Add(this.dataBus);
            this.Controls.Add(this.dataTrain);
            this.Name = "SelectedFrom";
            this.Text = "SelectedFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dataTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTrain;
        private System.Windows.Forms.DataGridView dataBus;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.Button button1;
    }
}