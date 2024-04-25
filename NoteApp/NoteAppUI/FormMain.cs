﻿using System;
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
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormAddEdit = new FormAddEdit();
            FormAddEdit.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }
    }
}
