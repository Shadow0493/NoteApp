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
    public partial class FormMain : Form
    {
        private static List<Note> notes = new List<Note>();
        private Project _project;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ComboBoxCategory.SelectedIndex = 0;
            _project = ProjectManager.LoadFromFile();

            for (int i = 0; i < _project.Projects.Count(); i++)
            {
                ListBoxNotes.Items.Add(_project.Projects[i].Title);
            }
        }
        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormAddEdit = new FormAddEdit();
            FormAddEdit.ShowDialog();

            if (FormAddEdit.DialogResult == DialogResult.OK)
            {
                var updatedNote = FormAddEdit.Note;

                notes.Add(updatedNote);
                var title = updatedNote.Title;
                ListBoxNotes.Items.Add(title);
            }
            else
            {
                return;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxNotes.SelectedIndex;
            var selectedNote = notes[selectedIndex];
            var FormAddEdit = new FormAddEdit();
            FormAddEdit.Note = selectedNote;
            FormAddEdit.ShowDialog();
            if(FormAddEdit.DialogResult == DialogResult.OK)
            {
                var updatedNote = FormAddEdit.Note;
                ListBoxNotes.Items.RemoveAt(selectedIndex);
                notes.RemoveAt(selectedIndex);
                notes.Insert(selectedIndex, updatedNote);
                var title = updatedNote.Title;
                ListBoxNotes.Items.Insert(selectedIndex, title);
            }
            else
            {
                return;
            }
        }

        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxNotes.SelectedIndex;
            notes.RemoveAt(selectedIndex);
            ListBoxNotes.Items.RemoveAt(selectedIndex);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _project.Projects = notes;
            ProjectManager.SaveToFile(_project);
        }

        private void ListBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxNotes.SelectedIndex;
            if (selectedIndex != -1)
            {
                LabelTitle.Text = notes[selectedIndex].Title;
                LabelCategory.Text = notes[selectedIndex].Category.ToString();
                DateTimePickerCreated.Value = notes[selectedIndex].Created;
                DateTimePickerModified.Value = notes[selectedIndex].Updated;
                TextBoxText.Text = notes[selectedIndex].Text;
            }
            else
            {
                LabelTitle.Text = "";
                LabelCategory.Text = "";
                DateTimePickerCreated.Value = DateTime.Now;
                DateTimePickerModified.Value = DateTime.Now;
                TextBoxText.Text = "";
            }
        }
    }
}
