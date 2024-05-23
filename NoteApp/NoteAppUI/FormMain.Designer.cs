namespace NoteAppUI
{
    partial class FormMain
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
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.GroupBoxChoosing = new System.Windows.Forms.GroupBox();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ListBoxNotes = new System.Windows.Forms.ListBox();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.LabelCategoryChoose = new System.Windows.Forms.Label();
            this.GroupBoxShow = new System.Windows.Forms.GroupBox();
            this.TextBoxText = new System.Windows.Forms.TextBox();
            this.DateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.LabelModified = new System.Windows.Forms.Label();
            this.DateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelCategoryShow = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.MenuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.GroupBoxChoosing.SuspendLayout();
            this.GroupBoxShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(895, 33);
            this.MenuStripMain.TabIndex = 7;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem
            // 
            this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 36);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.GroupBoxChoosing);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.GroupBoxShow);
            this.SplitContainerMain.Size = new System.Drawing.Size(895, 508);
            this.SplitContainerMain.SplitterDistance = 298;
            this.SplitContainerMain.TabIndex = 8;
            // 
            // GroupBoxChoosing
            // 
            this.GroupBoxChoosing.AutoSize = true;
            this.GroupBoxChoosing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupBoxChoosing.Controls.Add(this.ButtonRemove);
            this.GroupBoxChoosing.Controls.Add(this.ButtonEdit);
            this.GroupBoxChoosing.Controls.Add(this.ButtonAdd);
            this.GroupBoxChoosing.Controls.Add(this.ListBoxNotes);
            this.GroupBoxChoosing.Controls.Add(this.ComboBoxCategory);
            this.GroupBoxChoosing.Controls.Add(this.LabelCategoryChoose);
            this.GroupBoxChoosing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxChoosing.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxChoosing.Name = "GroupBoxChoosing";
            this.GroupBoxChoosing.Size = new System.Drawing.Size(298, 508);
            this.GroupBoxChoosing.TabIndex = 0;
            this.GroupBoxChoosing.TabStop = false;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRemove.BackgroundImage = global::NoteAppUI.Properties.Resources.note;
            this.ButtonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRemove.Location = new System.Drawing.Point(109, 466);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(49, 39);
            this.ButtonRemove.TabIndex = 5;
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonEdit.BackgroundImage = global::NoteAppUI.Properties.Resources.notebook;
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonEdit.Location = new System.Drawing.Point(61, 466);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(42, 39);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAdd.BackgroundImage = global::NoteAppUI.Properties.Resources.add;
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonAdd.Location = new System.Drawing.Point(13, 466);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(42, 39);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // ListBoxNotes
            // 
            this.ListBoxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxNotes.FormattingEnabled = true;
            this.ListBoxNotes.ItemHeight = 20;
            this.ListBoxNotes.Location = new System.Drawing.Point(13, 56);
            this.ListBoxNotes.Name = "ListBoxNotes";
            this.ListBoxNotes.Size = new System.Drawing.Size(279, 404);
            this.ListBoxNotes.TabIndex = 2;
            this.ListBoxNotes.SelectedIndexChanged += new System.EventHandler(this.ListBoxNotes_SelectedIndexChanged);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "All",
            "Work",
            "Home",
            "Health And Sport",
            "People",
            "Documents",
            "Finance",
            "Various"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(137, 19);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxCategory.TabIndex = 1;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // LabelCategoryChoose
            // 
            this.LabelCategoryChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategoryChoose.AutoSize = true;
            this.LabelCategoryChoose.Location = new System.Drawing.Point(6, 22);
            this.LabelCategoryChoose.Name = "LabelCategoryChoose";
            this.LabelCategoryChoose.Size = new System.Drawing.Size(125, 20);
            this.LabelCategoryChoose.TabIndex = 0;
            this.LabelCategoryChoose.Text = "Show Category: ";
            // 
            // GroupBoxShow
            // 
            this.GroupBoxShow.AutoSize = true;
            this.GroupBoxShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupBoxShow.Controls.Add(this.TextBoxText);
            this.GroupBoxShow.Controls.Add(this.DateTimePickerModified);
            this.GroupBoxShow.Controls.Add(this.LabelModified);
            this.GroupBoxShow.Controls.Add(this.DateTimePickerCreated);
            this.GroupBoxShow.Controls.Add(this.LabelCreated);
            this.GroupBoxShow.Controls.Add(this.LabelCategory);
            this.GroupBoxShow.Controls.Add(this.LabelCategoryShow);
            this.GroupBoxShow.Controls.Add(this.LabelTitle);
            this.GroupBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxShow.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxShow.MaximumSize = new System.Drawing.Size(2000, 1500);
            this.GroupBoxShow.Name = "GroupBoxShow";
            this.GroupBoxShow.Size = new System.Drawing.Size(593, 508);
            this.GroupBoxShow.TabIndex = 17;
            this.GroupBoxShow.TabStop = false;
            // 
            // TextBoxText
            // 
            this.TextBoxText.Location = new System.Drawing.Point(11, 111);
            this.TextBoxText.Multiline = true;
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.ReadOnly = true;
            this.TextBoxText.Size = new System.Drawing.Size(570, 385);
            this.TextBoxText.TabIndex = 7;
            // 
            // DateTimePickerModified
            // 
            this.DateTimePickerModified.Enabled = false;
            this.DateTimePickerModified.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerModified.Location = new System.Drawing.Point(317, 79);
            this.DateTimePickerModified.Name = "DateTimePickerModified";
            this.DateTimePickerModified.Size = new System.Drawing.Size(135, 26);
            this.DateTimePickerModified.TabIndex = 6;
            // 
            // LabelModified
            // 
            this.LabelModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelModified.AutoSize = true;
            this.LabelModified.Location = new System.Drawing.Point(234, 84);
            this.LabelModified.Name = "LabelModified";
            this.LabelModified.Size = new System.Drawing.Size(77, 20);
            this.LabelModified.TabIndex = 5;
            this.LabelModified.Text = "Modified: ";
            // 
            // DateTimePickerCreated
            // 
            this.DateTimePickerCreated.Enabled = false;
            this.DateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerCreated.Location = new System.Drawing.Point(90, 79);
            this.DateTimePickerCreated.Name = "DateTimePickerCreated";
            this.DateTimePickerCreated.Size = new System.Drawing.Size(138, 26);
            this.DateTimePickerCreated.TabIndex = 4;
            // 
            // LabelCreated
            // 
            this.LabelCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Location = new System.Drawing.Point(10, 83);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(74, 20);
            this.LabelCreated.TabIndex = 3;
            this.LabelCreated.Text = "Created: ";
            // 
            // LabelCategory
            // 
            this.LabelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(94, 53);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(0, 20);
            this.LabelCategory.TabIndex = 2;
            // 
            // LabelCategoryShow
            // 
            this.LabelCategoryShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategoryShow.AutoSize = true;
            this.LabelCategoryShow.Location = new System.Drawing.Point(7, 53);
            this.LabelCategoryShow.Name = "LabelCategoryShow";
            this.LabelCategoryShow.Size = new System.Drawing.Size(81, 20);
            this.LabelCategoryShow.TabIndex = 1;
            this.LabelCategoryShow.Text = "Category: ";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(7, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(195, 37);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Не выбрано";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 544);
            this.Controls.Add(this.SplitContainerMain);
            this.Controls.Add(this.MenuStripMain);
            this.MainMenuStrip = this.MenuStripMain;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel1.PerformLayout();
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            this.SplitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.GroupBoxChoosing.ResumeLayout(false);
            this.GroupBoxChoosing.PerformLayout();
            this.GroupBoxShow.ResumeLayout(false);
            this.GroupBoxShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.GroupBox GroupBoxChoosing;
        private System.Windows.Forms.GroupBox GroupBoxShow;
        private System.Windows.Forms.DateTimePicker DateTimePickerModified;
        private System.Windows.Forms.Label LabelModified;
        private System.Windows.Forms.DateTimePicker DateTimePickerCreated;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelCategoryShow;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.Label LabelCategoryChoose;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ListBox ListBoxNotes;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxText;
    }
}

