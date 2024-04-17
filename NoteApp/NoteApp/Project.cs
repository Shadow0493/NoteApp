using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        private List<Note> _projects;
        /// <summary>
        /// Сеттер и геттер для списка заметок
        /// </summary>
        public List<Note> Projects { get => _projects; set => _projects = value; }
        /// <summary>
        /// Конструктор для списка заметок
        /// </summary>
        /// <param name="projects"></param>
        public Project(List<Note> projects)
        {
            Projects = projects;
        }
        public override string ToString()
        {
            return $"{Projects.First().ToString()}; {Projects.Last().ToString()}";
        }
    }
}
