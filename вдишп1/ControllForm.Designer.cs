namespace вдишп1
{
    partial class ControllForm
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
            this.Diagrammbutton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Diagrammbutton
            // 
            this.Diagrammbutton.Location = new System.Drawing.Point(12, 45);
            this.Diagrammbutton.Name = "Diagrammbutton";
            this.Diagrammbutton.Size = new System.Drawing.Size(87, 31);
            this.Diagrammbutton.TabIndex = 16;
            this.Diagrammbutton.Text = "Статистика";
            this.Diagrammbutton.UseVisualStyleBackColor = true;
            this.Diagrammbutton.Click += new System.EventHandler(this.DiagrammClick);
            // 
            // timetableButton
            // 
            this.timetableButton.Location = new System.Drawing.Point(12, 8);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(87, 31);
            this.timetableButton.TabIndex = 15;
            this.timetableButton.Text = "Расписания";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.TimeTable_Click);
            // 
            // ControllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 117);
            this.Controls.Add(this.Diagrammbutton);
            this.Controls.Add(this.timetableButton);
            this.Name = "ControllForm";
            this.Text = "ControllForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Diagrammbutton;
        private System.Windows.Forms.Button timetableButton;
    }
}