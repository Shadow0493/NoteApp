using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        [Test(Description = "Геттер должен передать правильное значение Filename")]
        public void TestFilenameGet_Positive()
        {
            var expected = "C:/Users/ataur/Documents/NoteApp.notes";
            var actual = ProjectManager.Filename;

            Assert.That(expected == actual, "Было получено не правильное значение");
        }
        [Test(Description = "Метод сериализации должен сохранить правильное значение")]
        public void TestProjectManage_Save()
        {
            var expected = new Note("Task", NoteCategory.Work, "12345");
            var expected_list = new List<Note>();
            expected_list.Add(expected);
            var expected_project = new Project();
            expected_project.Projects = expected_list;
            Assert.DoesNotThrow(() => { ProjectManager.SaveToFile(expected_project); }, "Было сохранено не правильное значение"); ;
        }

        [Test(Description = "Метод десериализации должен загрузить значения")]
        public void TestProjectManage_Load() 
        {
            Assert.DoesNotThrow(() => { ProjectManager.LoadFromFile(); });
        }
    }
}
