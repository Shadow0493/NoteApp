using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note : ICloneable, INotifyPropertyChanged
    {
        /// <summary>
        /// поле название заметки
        /// </summary>
        private string _title = "Без названия";
        /// <summary>
        /// поле категория заметки
        /// </summary>
        private NoteCategory _category;
        /// <summary>
        /// поле текст заметки
        /// </summary>
        private string _text;
        /// <summary>
        /// поле время создания заметки
        /// </summary>
        private readonly DateTime _created;
        /// <summary>
        /// поле время последнего изменения заметки
        /// </summary>
        private DateTime _updated;
        /// <summary>
        /// сеттер и геттер для названия заметки
        /// </summary>
        public string Title { get => _title; set 
            { if (value.Length <= 50 && value.Length > 0) 
                { _title = value; }
            else if (value.Length > 50) { throw new ArgumentException("Название не должно превышать 50 символов, а сейчас " + value); }
            else if (value.Length == 0) { throw new ArgumentException("Количество символов не должно равнятся 0"); }
            } 
        }
        /// <summary>
        /// сеттер и геттер для категории заметки
        /// </summary>
        public NoteCategory Category { get => _category; set => _category = value; }
        /// <summary>
        /// сеттер и геттер для текста заметки
        /// </summary>
        public string Text { get => _text; set => _text = value; }
        /// <summary>
        /// сеттер и геттер для времени создания заметки
        /// </summary>
        public DateTime Created { get => _created; }
        /// <summary>
        /// сеттер и геттер для времени последнего обновления
        /// </summary>
        public DateTime Updated { get => _updated; set 
            { _updated = DateTime.Now;
                OnPropertyChanged("Title");
                OnPropertyChanged("Category");
                OnPropertyChanged("Text");
            } 
        }
        /// <summary>
        /// Конструктор объекта заметки
        /// </summary>
        /// <param name="title"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        /// <param name="created"></param>
        /// <param name="updated"></param>
        public Note(string title, NoteCategory category, string text)
        {
            Title = title;
            Category = category;
            Text = text;
            _created = DateTime.Now;
            Updated = DateTime.Now;
        }
        /// <summary>
        /// Реализация IClonable, для копирования
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
        /// <summary>
        /// Реализация INotifiedPropertyChanged, для автоматического обновления времени изменения
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public override string ToString()
        {
            return $"{Title}; {Category}; {Text}; {Created}; {Updated}.";
        }
    }
}
