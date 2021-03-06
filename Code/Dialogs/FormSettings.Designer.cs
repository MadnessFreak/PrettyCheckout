﻿namespace PrettyCheckout.Dialogs
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._groupBox2 = new System.Windows.Forms.GroupBox();
            this._textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonAccept = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this._checkBoxVat = new System.Windows.Forms.CheckBox();
            this._tabControl.SuspendLayout();
            this._tabPage1.SuspendLayout();
            this._groupBox2.SuspendLayout();
            this._groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabControl.Controls.Add(this._tabPage1);
            this._tabControl.Controls.Add(this.tabPage1);
            this._tabControl.Location = new System.Drawing.Point(16, 15);
            this._tabControl.Margin = new System.Windows.Forms.Padding(4);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(355, 423);
            this._tabControl.TabIndex = 0;
            // 
            // _tabPage1
            // 
            this._tabPage1.Controls.Add(this._groupBox2);
            this._tabPage1.Controls.Add(this._groupBox1);
            this._tabPage1.Location = new System.Drawing.Point(4, 25);
            this._tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this._tabPage1.Size = new System.Drawing.Size(347, 394);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "Allgemein";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _groupBox2
            // 
            this._groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox2.Controls.Add(this._textBoxDatabase);
            this._groupBox2.Controls.Add(this.label6);
            this._groupBox2.Controls.Add(this.label5);
            this._groupBox2.Location = new System.Drawing.Point(7, 198);
            this._groupBox2.Name = "_groupBox2";
            this._groupBox2.Size = new System.Drawing.Size(333, 123);
            this._groupBox2.TabIndex = 1;
            this._groupBox2.TabStop = false;
            this._groupBox2.Text = "Speicherort";
            // 
            // _textBoxDatabase
            // 
            this._textBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxDatabase.Location = new System.Drawing.Point(114, 85);
            this._textBoxDatabase.Name = "_textBoxDatabase";
            this._textBoxDatabase.Size = new System.Drawing.Size(198, 22);
            this._textBoxDatabase.TabIndex = 9;
            this._textBoxDatabase.Text = "ProductDatabase.xml";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pfad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 61);
            this.label5.TabIndex = 7;
            this.label5.Text = "Legt den relativen oder absoluten Speicherort für die Produktdatenbank fest.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _groupBox1
            // 
            this._groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox1.Controls.Add(this.label4);
            this._groupBox1.Controls.Add(this._textBoxCity);
            this._groupBox1.Controls.Add(this.label3);
            this._groupBox1.Controls.Add(this._textBoxStreet);
            this._groupBox1.Controls.Add(this.label2);
            this._groupBox1.Controls.Add(this._textBoxCompany);
            this._groupBox1.Controls.Add(this.label1);
            this._groupBox1.Location = new System.Drawing.Point(7, 7);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(333, 185);
            this._groupBox1.TabIndex = 0;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "Firmendaten";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 61);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diese Firmendaten werden genutzt, um sie auf Rechnungen zu drucken.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxCity
            // 
            this._textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxCity.Location = new System.Drawing.Point(114, 141);
            this._textBoxCity.Name = "_textBoxCity";
            this._textBoxCity.Size = new System.Drawing.Size(198, 22);
            this._textBoxCity.TabIndex = 5;
            this._textBoxCity.Text = "12345 Musterstadt";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLZ / Ort:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxStreet
            // 
            this._textBoxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxStreet.Location = new System.Drawing.Point(114, 113);
            this._textBoxStreet.Name = "_textBoxStreet";
            this._textBoxStreet.Size = new System.Drawing.Size(198, 22);
            this._textBoxStreet.TabIndex = 3;
            this._textBoxStreet.Text = "Musterstraße 1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Straße:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxCompany
            // 
            this._textBoxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxCompany.Location = new System.Drawing.Point(114, 85);
            this._textBoxCompany.Name = "_textBoxCompany";
            this._textBoxCompany.Size = new System.Drawing.Size(198, 22);
            this._textBoxCompany.TabIndex = 1;
            this._textBoxCompany.Text = "Musterfirma";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _buttonAccept
            // 
            this._buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAccept.Location = new System.Drawing.Point(272, 445);
            this._buttonAccept.Name = "_buttonAccept";
            this._buttonAccept.Size = new System.Drawing.Size(100, 30);
            this._buttonAccept.TabIndex = 6;
            this._buttonAccept.Text = "Übernehmen";
            this._buttonAccept.UseVisualStyleBackColor = true;
            this._buttonAccept.Click += new System.EventHandler(this.ButtonAcceptClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 394);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Zahlungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._checkBoxVat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mehrwertsteuer";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 61);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hier kannst du einstellen, ob die Mehrwertsteuer standartmäßig berehnet werden so" +
    "ll.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _checkBoxVat
            // 
            this._checkBoxVat.Location = new System.Drawing.Point(15, 85);
            this._checkBoxVat.Name = "_checkBoxVat";
            this._checkBoxVat.Size = new System.Drawing.Size(305, 23);
            this._checkBoxVat.TabIndex = 3;
            this._checkBoxVat.Text = "Mehrwertsteuer berechnen";
            this._checkBoxVat.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this._buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 487);
            this.Controls.Add(this._buttonAccept);
            this.Controls.Add(this._tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 525);
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this._tabControl.ResumeLayout(false);
            this._tabPage1.ResumeLayout(false);
            this._groupBox2.ResumeLayout(false);
            this._groupBox2.PerformLayout();
            this._groupBox1.ResumeLayout(false);
            this._groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.Button _buttonAccept;
        private System.Windows.Forms.GroupBox _groupBox1;
        private System.Windows.Forms.TextBox _textBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox _groupBox2;
        private System.Windows.Forms.TextBox _textBoxDatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _checkBoxVat;
        private System.Windows.Forms.Label label8;
    }
}