namespace Currency_CSharp
{
    partial class AddCrncForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_crncName = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_calcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency code (ISO4217):";
            // 
            // tBox_crncName
            // 
            this.tBox_crncName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_crncName.Location = new System.Drawing.Point(191, 13);
            this.tBox_crncName.Name = "tBox_crncName";
            this.tBox_crncName.Size = new System.Drawing.Size(55, 20);
            this.tBox_crncName.TabIndex = 0;
            this.tBox_crncName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_crncName.TextChanged += new System.EventHandler(this.tBox_crncName_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(90, 53);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_calcel
            // 
            this.btn_calcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_calcel.Location = new System.Drawing.Point(171, 53);
            this.btn_calcel.Name = "btn_calcel";
            this.btn_calcel.Size = new System.Drawing.Size(75, 23);
            this.btn_calcel.TabIndex = 2;
            this.btn_calcel.Text = "Cancel";
            this.btn_calcel.UseVisualStyleBackColor = true;
            // 
            // AddCrncForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_calcel;
            this.ClientSize = new System.Drawing.Size(261, 88);
            this.Controls.Add(this.btn_calcel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tBox_crncName);
            this.Controls.Add(this.label1);
            this.Name = "AddCrncForm";
            this.Text = "Add Currency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_crncName;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_calcel;
    }
}