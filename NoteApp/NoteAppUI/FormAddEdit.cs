using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class FormAddEdit : Form
    {
        private Note _note = new Note("", NoteCategory.Various, null);
        public Note Note
        {
            get { return _note; }
            set { _note = value;
                if (_note != null) {
                    TextBoxText.Text = _note.Text;
                    TextBoxTitle.Text = _note.Title;
                    ComboBoxCategory.SelectedIndex = ((int)_note.Category);
                }
            }
        }
        public FormAddEdit()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TextBoxText_TextChanged(object sender, EventArgs e)
        {
            _note.Text = TextBoxText.Text;
            _note.Updated = DateTime.Now;
        }

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            _note.Title = TextBoxTitle.Text;
            _note.Updated = DateTime.Now;
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _note.Category = (NoteCategory)ComboBoxCategory.SelectedIndex;
            _note.Updated = DateTime.Now;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
