namespace PrettyCheckout.Dialogs
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._buttonSearch = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._buttonSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this._textBoxSearch);
            this.groupBox3.Controls.Add(this._listView);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 428);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produktsuche";
            // 
            // _listView
            // 
            this._listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this._listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._listView.FullRowSelect = true;
            this._listView.GridLines = true;
            this._listView.Location = new System.Drawing.Point(15, 103);
            this._listView.MultiSelect = false;
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(403, 311);
            this._listView.TabIndex = 2;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            this._listView.DoubleClick += new System.EventHandler(this._listView_DoubleClick);
            this._listView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._listView_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produkt";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preis";
            this.columnHeader4.Width = 75;
            // 
            // _textBoxSearch
            // 
            this._textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxSearch.Location = new System.Drawing.Point(18, 22);
            this._textBoxSearch.Name = "_textBoxSearch";
            this._textBoxSearch.Size = new System.Drawing.Size(319, 22);
            this._textBoxSearch.TabIndex = 0;
            this._textBoxSearch.TextChanged += new System.EventHandler(this._textBoxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name oder ID des Produktes eingeben, um dannach zu suchen.\r\nKlick auf das ausgewä" +
    "hlte Produkt, um es zu verwenden.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _buttonSearch
            // 
            this._buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSearch.Location = new System.Drawing.Point(343, 21);
            this._buttonSearch.Name = "_buttonSearch";
            this._buttonSearch.Size = new System.Drawing.Size(75, 25);
            this._buttonSearch.TabIndex = 1;
            this._buttonSearch.TabStop = false;
            this._buttonSearch.Text = "Suchen";
            this._buttonSearch.UseVisualStyleBackColor = true;
            this._buttonSearch.Click += new System.EventHandler(this._buttonSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 454);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suche";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView _listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox _textBoxSearch;
        private System.Windows.Forms.Button _buttonSearch;
        private System.Windows.Forms.Label label4;

    }
}