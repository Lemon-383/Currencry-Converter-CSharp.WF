namespace Currency_CSharp
{
    partial class MainForm
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
            this.lbl_srcCrncValue = new System.Windows.Forms.Label();
            this.numTB_srcCrncValue = new System.Windows.Forms.NumericUpDown();
            this.pnl_crncRates = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_convRes = new System.Windows.Forms.FlowLayoutPanel();
            this.cBox_srcCrnc = new System.Windows.Forms.ComboBox();
            this.btn_addCrnc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTB_srcCrncValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_srcCrncValue
            // 
            this.lbl_srcCrncValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_srcCrncValue.AutoSize = true;
            this.lbl_srcCrncValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_srcCrncValue.Location = new System.Drawing.Point(12, 202);
            this.lbl_srcCrncValue.Name = "lbl_srcCrncValue";
            this.lbl_srcCrncValue.Size = new System.Drawing.Size(48, 17);
            this.lbl_srcCrncValue.TabIndex = 10;
            this.lbl_srcCrncValue.Text = "Value:";
            // 
            // numTB_srcCrncValue
            // 
            this.numTB_srcCrncValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numTB_srcCrncValue.DecimalPlaces = 2;
            this.numTB_srcCrncValue.Location = new System.Drawing.Point(64, 202);
            this.numTB_srcCrncValue.Name = "numTB_srcCrncValue";
            this.numTB_srcCrncValue.Size = new System.Drawing.Size(63, 20);
            this.numTB_srcCrncValue.TabIndex = 1;
            this.numTB_srcCrncValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTB_srcCrncValue.ValueChanged += new System.EventHandler(this.numTB_srcCrncValue_ValueChanged);
            // 
            // pnl_crncRates
            // 
            this.pnl_crncRates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_crncRates.AutoScroll = true;
            this.pnl_crncRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_crncRates.Enabled = false;
            this.pnl_crncRates.Location = new System.Drawing.Point(133, 12);
            this.pnl_crncRates.Name = "pnl_crncRates";
            this.pnl_crncRates.Size = new System.Drawing.Size(166, 239);
            this.pnl_crncRates.TabIndex = 24;
            // 
            // pnl_convRes
            // 
            this.pnl_convRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_convRes.AutoScroll = true;
            this.pnl_convRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_convRes.Enabled = false;
            this.pnl_convRes.Location = new System.Drawing.Point(307, 12);
            this.pnl_convRes.Name = "pnl_convRes";
            this.pnl_convRes.Size = new System.Drawing.Size(165, 239);
            this.pnl_convRes.TabIndex = 25;
            // 
            // cBox_srcCrnc
            // 
            this.cBox_srcCrnc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBox_srcCrnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cBox_srcCrnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBox_srcCrnc.FormattingEnabled = true;
            this.cBox_srcCrnc.Location = new System.Drawing.Point(12, 12);
            this.cBox_srcCrnc.Name = "cBox_srcCrnc";
            this.cBox_srcCrnc.Size = new System.Drawing.Size(115, 184);
            this.cBox_srcCrnc.TabIndex = 0;
            this.cBox_srcCrnc.Text = "Source Currency";
            this.cBox_srcCrnc.SelectedIndexChanged += new System.EventHandler(this.cBox_srcCrnc_SelectedIndexChanged);
            // 
            // btn_addCrnc
            // 
            this.btn_addCrnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addCrnc.Location = new System.Drawing.Point(12, 228);
            this.btn_addCrnc.Name = "btn_addCrnc";
            this.btn_addCrnc.Size = new System.Drawing.Size(115, 23);
            this.btn_addCrnc.TabIndex = 0;
            this.btn_addCrnc.TabStop = false;
            this.btn_addCrnc.Text = "Add Currency";
            this.btn_addCrnc.UseVisualStyleBackColor = true;
            this.btn_addCrnc.Click += new System.EventHandler(this.btn_addCrnc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btn_addCrnc);
            this.Controls.Add(this.cBox_srcCrnc);
            this.Controls.Add(this.pnl_convRes);
            this.Controls.Add(this.pnl_crncRates);
            this.Controls.Add(this.numTB_srcCrncValue);
            this.Controls.Add(this.lbl_srcCrncValue);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTB_srcCrncValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_srcCrncValue;
        private System.Windows.Forms.NumericUpDown numTB_srcCrncValue;
        private System.Windows.Forms.FlowLayoutPanel pnl_crncRates;
        private System.Windows.Forms.FlowLayoutPanel pnl_convRes;
        private System.Windows.Forms.ComboBox cBox_srcCrnc;
        private System.Windows.Forms.Button btn_addCrnc;
    }
}

