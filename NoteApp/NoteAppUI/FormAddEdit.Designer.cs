namespace NoteAppUI
{
    partial class FormAddEdit
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ListBoxText = new System.Windows.Forms.ListBox();
            this.DateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.LabelModified = new System.Windows.Forms.Label();
            this.DateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(684, 510);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(82, 30);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(596, 510);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(82, 30);
            this.ButtonOK.TabIndex = 9;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // ListBoxText
            // 
            this.ListBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxText.FormattingEnabled = true;
            this.ListBoxText.ItemHeight = 20;
            this.ListBoxText.Location = new System.Drawing.Point(12, 121);
            this.ListBoxText.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.ListBoxText.MinimumSize = new System.Drawing.Size(700, 200);
            this.ListBoxText.Name = "ListBoxText";
            this.ListBoxText.Size = new System.Drawing.Size(754, 384);
            this.ListBoxText.TabIndex = 8;
            // 
            // DateTimePickerModified
            // 
            this.DateTimePickerModified.Enabled = false;
            this.DateTimePickerModified.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerModified.Location = new System.Drawing.Point(328, 89);
            this.DateTimePickerModified.Name = "DateTimePickerModified";
            this.DateTimePickerModified.Size = new System.Drawing.Size(140, 26);
            this.DateTimePickerModified.TabIndex = 7;
            // 
            // LabelModified
            // 
            this.LabelModified.AutoSize = true;
            this.LabelModified.Location = new System.Drawing.Point(248, 89);
            this.LabelModified.Name = "LabelModified";
            this.LabelModified.Size = new System.Drawing.Size(73, 20);
            this.LabelModified.TabIndex = 6;
            this.LabelModified.Text = "Modified:";
            // 
            // DateTimePickerCreated
            // 
            this.DateTimePickerCreated.Enabled = false;
            this.DateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerCreated.Location = new System.Drawing.Point(93, 87);
            this.DateTimePickerCreated.Name = "DateTimePickerCreated";
            this.DateTimePickerCreated.Size = new System.Drawing.Size(137, 26);
            this.DateTimePickerCreated.TabIndex = 5;
            // 
            // LabelCreated
            // 
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Location = new System.Drawing.Point(13, 89);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(74, 20);
            this.LabelCreated.TabIndex = 4;
            this.LabelCreated.Text = "Created: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Work",
            "Home",
            "HealthAndSport",
            "People",
            "Documents",
            "Finance",
            "Various"});
            this.comboBox1.Location = new System.Drawing.Point(99, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 53);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(81, 20);
            this.LabelCategory.TabIndex = 2;
            this.LabelCategory.Text = "Category: ";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTitle.Location = new System.Drawing.Point(66, 13);
            this.TextBoxTitle.MaxLength = 50;
            this.TextBoxTitle.MinimumSize = new System.Drawing.Size(200, 20);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(700, 26);
            this.TextBoxTitle.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(13, 13);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(46, 20);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Title: ";
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ListBoxText);
            this.Controls.Add(this.DateTimePickerModified);
            this.Controls.Add(this.LabelModified);
            this.Controls.Add(this.DateTimePickerCreated);
            this.Controls.Add(this.LabelCreated);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelTitle);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormAddEdit";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.ListBox ListBoxText;
        private System.Windows.Forms.DateTimePicker DateTimePickerModified;
        private System.Windows.Forms.Label LabelModified;
        private System.Windows.Forms.DateTimePicker DateTimePickerCreated;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
    }
}