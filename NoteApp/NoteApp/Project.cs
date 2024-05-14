using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Project //цикл. сложность = 2
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        private List<Note> _projects;
        /// <summary>
        /// Сеттер и геттер для списка заметок
        /// </summary>
        public List<Note> Projects { get => _projects; set => _projects = value; } //цикл. сложность = 2
    }
}
