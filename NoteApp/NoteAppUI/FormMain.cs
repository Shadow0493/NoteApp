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
            _project = ProjectManager.LoadFromFile();
            _project.Projects = _project.Sort();
            notes = _project.Projects;
            ComboBoxCategory.SelectedIndex = 0;
            ListBoxNotes.SelectedIndex = _project.CurrentNote;
        }
        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormAddEdit = new FormAddEdit();
            FormAddEdit.ShowDialog();

            if (FormAddEdit.DialogResult == DialogResult.OK)
            {
                var createdNote = FormAddEdit.Note;

                notes.Insert(0, createdNote);
                var title = createdNote.Title;
                ListBoxNotes.Items.Insert(0, title);
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
                notes.Insert(0, updatedNote);
                var title = updatedNote.Title;
                ListBoxNotes.Items.Insert(0,title);

            }
            else
            {
                return;
            }
        }

        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxNotes.SelectedIndex;
            if(selectedIndex != -1)
            {
                notes.RemoveAt(selectedIndex);
                ListBoxNotes.Items.RemoveAt(selectedIndex);
            }
            else
            {
                return;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _project.Projects = notes;
            _project.CurrentNote = ListBoxNotes.SelectedIndex;
            ProjectManager.SaveToFile(_project);
        }

        private void ListBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ListBoxNotes.SelectedIndex;
            _project.CurrentNote = selectedIndex;
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
                LabelTitle.Text = "Не выбрано";
                LabelCategory.Text = "";
                DateTimePickerCreated.Value = DateTime.Now;
                DateTimePickerModified.Value = DateTime.Now;
                TextBoxText.Text = "";
            }
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ComboBoxCategory.SelectedIndex;
           Project _notesCategory = new Project();
            ListBoxNotes.Items.Clear();
            switch (selectedIndex)
            {
                case 0:
                    for (int i = 0; i < _project.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_project.Projects[i].Title);
                    }
                    break;
                case 1:
                    _notesCategory.Projects = _project.Sort(NoteCategory.Work);
                    for (int i = 0; i < _notesCategory.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_notesCategory.Projects[i].Title);
                    }
                    break;
                case 2:
                    _notesCategory.Projects = _project.Sort(NoteCategory.Home);
                    for (int i = 0; i < _notesCategory.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_notesCategory.Projects[i].Title);
                    }
                    break;
                case 3:
                    _notesCategory.Projects = _project.Sort(NoteCategory.HealthAndSport);
                    for (int i = 0; i < _notesCategory.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_notesCategory.Projects[i].Title);
                    }
                    break;
                case 4:
                    _notesCategory.Projects = _project.Sort(NoteCategory.People);
                    for (int i = 0; i < _notesCategory.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_notesCategory.Projects[i].Title);
                    }
                    break;
                case 5:
                    _notesCategory.Projects = _project.Sort(NoteCategory.Documents);
                    for (int i = 0; i < _notesCategory.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_notesCategory.Projects[i].Title);
                    }
                    break;
                case 6:
                    _notesCategory.Projects = _project.Sort(NoteCategory.Finance);
                    for (int i = 0; i < _notesCategory.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_notesCategory.Projects[i].Title);
                    }
                    break;
                case 7:
                    _notesCategory.Projects = _project.Sort(NoteCategory.Various);
                    for (int i = 0; i < _notesCategory.Projects.Count(); i++)
                    {
                        ListBoxNotes.Items.Add(_notesCategory.Projects[i].Title);
                    }
                    break;
            }
        }
    }
}
