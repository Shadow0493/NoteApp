using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class ProjectManager
    {
        /// <summary>
        /// Константа для хранения пути для сохранения и загрузки файла
        /// </summary>
        private const string _filename = "C:/Users/ataur/Documents/NoteApp.notes";
        /// <summary>
        /// Геттер для пути к файлу
        /// </summary>
        public static string Filename
        {
            get { return _filename; }
        }
       /// <summary>
       /// Метод для сохранения файла
       /// </summary>
       /// <param name="list"></param>
       /// <param name="filename"></param>
        public static void SaveToFile(Project list) 
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, list);
            }
        }
        /// <summary>
        /// Метод для загрузки файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Project LoadFromFile()
        {
            Project list = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(Filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                list = (Project)serializer.Deserialize<Project>(reader);
            }
            return list;
        }
    }
}
