namespace PrettyCheckout.Dialogs
{
    partial class FormProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductView));
            this._buttonAccept = new System.Windows.Forms.Button();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this._radioButtonVat19 = new System.Windows.Forms.RadioButton();
            this._radioButtonVat7 = new System.Windows.Forms.RadioButton();
            this._radioButtonVatZero = new System.Windows.Forms.RadioButton();
            this._textBoxVat = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._textBoxPriceNet = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxPriceGross = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._textBoxID = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonAccept
            // 
            this._buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAccept.Location = new System.Drawing.Point(176, 359);
            this._buttonAccept.Name = "_buttonAccept";
            this._buttonAccept.Size = new System.Drawing.Size(100, 30);
            this._buttonAccept.TabIndex = 10;
            this._buttonAccept.Text = "Überprüfen";
            this._buttonAccept.UseVisualStyleBackColor = true;
            this._buttonAccept.Click += new System.EventHandler(this.ButtonAcceptClick);
            // 
            // _groupBox1
            // 
            this._groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox1.Controls.Add(this.label7);
            this._groupBox1.Controls.Add(this._radioButtonVat19);
            this._groupBox1.Controls.Add(this._radioButtonVat7);
            this._groupBox1.Controls.Add(this._radioButtonVatZero);
            this._groupBox1.Controls.Add(this._textBoxVat);
            this._groupBox1.Controls.Add(this.label6);
            this._groupBox1.Controls.Add(this._textBoxPriceNet);
            this._groupBox1.Controls.Add(this.label5);
            this._groupBox1.Controls.Add(this._textBoxDesc);
            this._groupBox1.Controls.Add(this.label4);
            this._groupBox1.Controls.Add(this._textBoxPriceGross);
            this._groupBox1.Controls.Add(this._textBoxName);
            this._groupBox1.Controls.Add(this._textBoxID);
            this._groupBox1.Controls.Add(this.label2);
            this._groupBox1.Controls.Add(this.label1);
            this._groupBox1.Controls.Add(this.label3);
            this._groupBox1.Location = new System.Drawing.Point(12, 12);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(370, 336);
            this._groupBox1.TabIndex = 6;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "Produkt";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "Steuersatz:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _radioButtonVat19
            // 
            this._radioButtonVat19.Location = new System.Drawing.Point(275, 191);
            this._radioButtonVat19.Name = "_radioButtonVat19";
            this._radioButtonVat19.Size = new System.Drawing.Size(55, 26);
            this._radioButtonVat19.TabIndex = 8;
            this._radioButtonVat19.Tag = "2";
            this._radioButtonVat19.Text = "19%";
            this._radioButtonVat19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._radioButtonVat19.UseVisualStyleBackColor = true;
            this._radioButtonVat19.CheckedChanged += new System.EventHandler(this.RadioButtonVatCheckedChanged);
            // 
            // _radioButtonVat7
            // 
            this._radioButtonVat7.Location = new System.Drawing.Point(214, 191);
            this._radioButtonVat7.Name = "_radioButtonVat7";
            this._radioButtonVat7.Size = new System.Drawing.Size(55, 26);
            this._radioButtonVat7.TabIndex = 7;
            this._radioButtonVat7.Tag = "1";
            this._radioButtonVat7.Text = "7%";
            this._radioButtonVat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._radioButtonVat7.UseVisualStyleBackColor = true;
            this._radioButtonVat7.CheckedChanged += new System.EventHandler(this.RadioButtonVatCheckedChanged);
            // 
            // _radioButtonVatZero
            // 
            this._radioButtonVatZero.Location = new System.Drawing.Point(153, 191);
            this._radioButtonVatZero.Name = "_radioButtonVatZero";
            this._radioButtonVatZero.Size = new System.Drawing.Size(55, 26);
            this._radioButtonVatZero.TabIndex = 6;
            this._radioButtonVatZero.Tag = "0";
            this._radioButtonVatZero.Text = "0%";
            this._radioButtonVatZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._radioButtonVatZero.UseVisualStyleBackColor = true;
            this._radioButtonVatZero.CheckedChanged += new System.EventHandler(this.RadioButtonVatCheckedChanged);
            // 
            // _textBoxVat
            // 
            this._textBoxVat.AllowGroupSeparator = false;
            this._textBoxVat.AllowNegativeSign = false;
            this._textBoxVat.AllowSpace = false;
            this._textBoxVat.Enabled = false;
            this._textBoxVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxVat.Location = new System.Drawing.Point(132, 158);
            this._textBoxVat.Name = "_textBoxVat";
            this._textBoxVat.Size = new System.Drawing.Size(221, 26);
            this._textBoxVat.TabIndex = 5;
            this._textBoxVat.UseCurrency = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mehrwertsteuer:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxPriceNet
            // 
            this._textBoxPriceNet.AllowGroupSeparator = false;
            this._textBoxPriceNet.AllowNegativeSign = false;
            this._textBoxPriceNet.AllowSpace = false;
            this._textBoxPriceNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxPriceNet.Location = new System.Drawing.Point(132, 126);
            this._textBoxPriceNet.Name = "_textBoxPriceNet";
            this._textBoxPriceNet.Size = new System.Drawing.Size(221, 26);
            this._textBoxPriceNet.TabIndex = 4;
            this._textBoxPriceNet.UseCurrency = false;
            this._textBoxPriceNet.TextChanged += new System.EventHandler(this.TextBoxPriceNetTextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preis (Netto):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxDesc
            // 
            this._textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxDesc.Location = new System.Drawing.Point(132, 223);
            this._textBoxDesc.Multiline = true;
            this._textBoxDesc.Name = "_textBoxDesc";
            this._textBoxDesc.Size = new System.Drawing.Size(221, 96);
            this._textBoxDesc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Beschreibung:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxPriceGross
            // 
            this._textBoxPriceGross.AllowGroupSeparator = false;
            this._textBoxPriceGross.AllowNegativeSign = false;
            this._textBoxPriceGross.AllowSpace = false;
            this._textBoxPriceGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxPriceGross.Location = new System.Drawing.Point(132, 91);
            this._textBoxPriceGross.Name = "_textBoxPriceGross";
            this._textBoxPriceGross.Size = new System.Drawing.Size(221, 26);
            this._textBoxPriceGross.TabIndex = 3;
            this._textBoxPriceGross.UseCurrency = false;
            this._textBoxPriceGross.TextChanged += new System.EventHandler(this.TextBoxPriceGrossTextChanged);
            // 
            // _textBoxName
            // 
            this._textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxName.Location = new System.Drawing.Point(132, 56);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(221, 26);
            this._textBoxName.TabIndex = 2;
            // 
            // _textBoxID
            // 
            this._textBoxID.AllowGroupSeparator = false;
            this._textBoxID.AllowNegativeSign = false;
            this._textBoxID.AllowSpace = false;
            this._textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxID.Location = new System.Drawing.Point(132, 21);
            this._textBoxID.Name = "_textBoxID";
            this._textBoxID.ReadOnly = true;
            this._textBoxID.Size = new System.Drawing.Size(221, 26);
            this._textBoxID.TabIndex = 1;
            this._textBoxID.TabStop = false;
            this._textBoxID.UseCurrency = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preis (Brutto):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produkt-ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(282, 359);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(100, 30);
            this._buttonCancel.TabIndex = 11;
            this._buttonCancel.Text = "Abbrechen";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // FormProductView
            // 
            this.AcceptButton = this._buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(394, 400);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonAccept);
            this.Controls.Add(this._groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProductView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produktansicht";
            this.Load += new System.EventHandler(this.FormProductView_Load);
            this._groupBox1.ResumeLayout(false);
            this._groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonAccept;
        private System.Windows.Forms.GroupBox _groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textBoxName;
        private Controls.NumericTextBox _textBoxPriceGross;
        private Controls.NumericTextBox _textBoxID;
        private Controls.NumericTextBox _textBoxVat;
        private System.Windows.Forms.Label label6;
        private Controls.NumericTextBox _textBoxPriceNet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton _radioButtonVat19;
        private System.Windows.Forms.RadioButton _radioButtonVat7;
        private System.Windows.Forms.RadioButton _radioButtonVatZero;
        private System.Windows.Forms.Button _buttonCancel;
    }
}