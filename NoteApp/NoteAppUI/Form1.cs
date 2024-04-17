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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = NoteCategory.Various.ToString();
            Note note = new Note("Пример заметки", NoteCategory.Various, "Текст заметки");
            label4.Text = note.ToString();
            Note note1 = new Note("Пример заметки1", NoteCategory.Work, "Текст заметки1");
            List<Note> list = new List<Note>();
            list.Add(note);
            list.Add(note1);
            Project project = new Project(list);
            label6.Text = project.ToString();
        }
    }
}
