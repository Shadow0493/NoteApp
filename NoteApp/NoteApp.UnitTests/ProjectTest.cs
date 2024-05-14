using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.UnitTests
{
    public class ProjectTest
    {
        [Test(Description = "Геттер должен передать правильное значение Project")]
        public void TestCategoryGet_PositiveUpdated()
        {
            var example_note1 = new Note("1", NoteCategory.Work, "");
            var example_note2 = new Note("2", NoteCategory.Home, "a");
            var expected = new List<Note>();
            expected.Add(example_note1);
            expected.Add(example_note2);
            Project project = new Project();
            project.Projects = expected;
            var actual = project.Projects;
            Assert.That(expected == actual, "Было получено не правильное значение");
        }

        [Test(Description = "Сеттер должен присвоить правильное значение Project")]
        public void TestCategorySet_CorrectUpdated()
        {
            var example_note1 = new Note("1", NoteCategory.Work, "");
            var example_note2 = new Note("2", NoteCategory.Home, "a");
            var expected = new List<Note>();
            expected.Add(example_note1);
            expected.Add(example_note2);
            Project project = new Project();
            project.Projects = expected;
            Assert.That(expected == project.Projects, "Было присвоено не правильное значение");
        }
    }
}
