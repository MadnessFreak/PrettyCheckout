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
            this._textBoxDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxPrice = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._textBoxID = new PrettyCheckout.Dialogs.Controls.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonAccept
            // 
            this._buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAccept.Location = new System.Drawing.Point(282, 258);
            this._buttonAccept.Name = "_buttonAccept";
            this._buttonAccept.Size = new System.Drawing.Size(100, 30);
            this._buttonAccept.TabIndex = 5;
            this._buttonAccept.Text = "Übernehmen";
            this._buttonAccept.UseVisualStyleBackColor = true;
            this._buttonAccept.Click += new System.EventHandler(this._buttonAccept_Click);
            // 
            // _groupBox1
            // 
            this._groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox1.Controls.Add(this._textBoxDesc);
            this._groupBox1.Controls.Add(this.label4);
            this._groupBox1.Controls.Add(this._textBoxPrice);
            this._groupBox1.Controls.Add(this._textBoxName);
            this._groupBox1.Controls.Add(this._textBoxID);
            this._groupBox1.Controls.Add(this.label2);
            this._groupBox1.Controls.Add(this.label1);
            this._groupBox1.Controls.Add(this.label3);
            this._groupBox1.Location = new System.Drawing.Point(12, 12);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(370, 238);
            this._groupBox1.TabIndex = 6;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "Produkt";
            // 
            // _textBoxDesc
            // 
            this._textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxDesc.Location = new System.Drawing.Point(132, 123);
            this._textBoxDesc.Multiline = true;
            this._textBoxDesc.Name = "_textBoxDesc";
            this._textBoxDesc.Size = new System.Drawing.Size(221, 96);
            this._textBoxDesc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Beschreibung:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxPrice
            // 
            this._textBoxPrice.AllowGroupSeparator = false;
            this._textBoxPrice.AllowNegativeSign = false;
            this._textBoxPrice.AllowSpace = false;
            this._textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxPrice.Location = new System.Drawing.Point(132, 91);
            this._textBoxPrice.Name = "_textBoxPrice";
            this._textBoxPrice.Size = new System.Drawing.Size(221, 26);
            this._textBoxPrice.TabIndex = 3;
            this._textBoxPrice.UseCurrency = false;
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
            this.label2.Text = "Preis:";
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
            // FormProductView
            // 
            this.AcceptButton = this._buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 302);
            this.Controls.Add(this._buttonAccept);
            this.Controls.Add(this._groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProductView";
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
        private Controls.NumericTextBox _textBoxPrice;
        private Controls.NumericTextBox _textBoxID;
    }
}