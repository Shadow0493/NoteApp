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
        /// Текущая заметка
        /// </summary>
        private int _currentNote;
        /// <summary>
        /// Сеттер и геттер для списка заметок
        /// </summary>
        public List<Note> Projects { get => _projects; set => _projects = value; } //цикл. сложность = 2
        /// <summary>
        /// Сеттер и геттер для текущей заметки
        /// </summary>
        public int CurrentNote { get => _currentNote; set => _currentNote = value; }
        /// <summary>
        /// Сортировка по времени изменения
        /// </summary>
        /// <returns></returns>
        public List<Note> Sort()
        {
            return Projects.OrderByDescending(n => n.Updated).ToList();
        }
        /// <summary>
        /// Сортировка по категории заметки и по времени изменения
        /// </summary>
        /// <param name="noteCategory"></param>
        /// <returns></returns>
        public List<Note> Sort(NoteCategory noteCategory)
        {
            return Projects.Where(n => n.Category == noteCategory).OrderByDescending(n => n.Updated).ToList();
        }
    }
}
