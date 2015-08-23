namespace PrettyCheckout.Dialogs
{
    partial class FormSubtotal
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
            this._textBoxReturnMoney = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this._textBoxGiven = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this._textBoxTotalSum = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._buttonAccept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _textBoxReturnMoney
            // 
            this._textBoxReturnMoney.AllowGroupSeparator = false;
            this._textBoxReturnMoney.AllowNegativeSign = false;
            this._textBoxReturnMoney.AllowSpace = false;
            this._textBoxReturnMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxReturnMoney.Location = new System.Drawing.Point(221, 98);
            this._textBoxReturnMoney.Name = "_textBoxReturnMoney";
            this._textBoxReturnMoney.ReadOnly = true;
            this._textBoxReturnMoney.Size = new System.Drawing.Size(135, 26);
            this._textBoxReturnMoney.TabIndex = 3;
            this._textBoxReturnMoney.TabStop = false;
            this._textBoxReturnMoney.UseCurrency = true;
            // 
            // _textBoxGiven
            // 
            this._textBoxGiven.AllowGroupSeparator = false;
            this._textBoxGiven.AllowNegativeSign = false;
            this._textBoxGiven.AllowSpace = false;
            this._textBoxGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxGiven.Location = new System.Drawing.Point(221, 66);
            this._textBoxGiven.Name = "_textBoxGiven";
            this._textBoxGiven.Size = new System.Drawing.Size(135, 26);
            this._textBoxGiven.TabIndex = 0;
            this._textBoxGiven.UseCurrency = true;
            // 
            // _textBoxTotalSum
            // 
            this._textBoxTotalSum.AllowGroupSeparator = false;
            this._textBoxTotalSum.AllowNegativeSign = false;
            this._textBoxTotalSum.AllowSpace = false;
            this._textBoxTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxTotalSum.Location = new System.Drawing.Point(221, 24);
            this._textBoxTotalSum.Name = "_textBoxTotalSum";
            this._textBoxTotalSum.ReadOnly = true;
            this._textBoxTotalSum.Size = new System.Drawing.Size(135, 35);
            this._textBoxTotalSum.TabIndex = 2;
            this._textBoxTotalSum.TabStop = false;
            this._textBoxTotalSum.UseCurrency = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rückgeld:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gegeben:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gesamt:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._textBoxReturnMoney);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._textBoxGiven);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._textBoxTotalSum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechnung abschließen";
            // 
            // _buttonAccept
            // 
            this._buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAccept.Location = new System.Drawing.Point(282, 168);
            this._buttonAccept.Name = "_buttonAccept";
            this._buttonAccept.Size = new System.Drawing.Size(100, 30);
            this._buttonAccept.TabIndex = 1;
            this._buttonAccept.Text = "Übernehmen";
            this._buttonAccept.UseVisualStyleBackColor = true;
            this._buttonAccept.Click += new System.EventHandler(this._buttonAccept_Click);
            // 
            // FormSubtotal
            // 
            this.AcceptButton = this._buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 208);
            this.Controls.Add(this._buttonAccept);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSubtotal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zwischensumme";
            this.Load += new System.EventHandler(this.FormSubtotal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _buttonAccept;
        private Controls.NumericTextBox _textBoxReturnMoney;
        private Controls.NumericTextBox _textBoxGiven;
        private Controls.NumericTextBox _textBoxTotalSum;
    }
}