using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "Заметка";
            var Note = new Note("",NoteCategory.Various,"");
            Note.Title = expected;
            var actual = Note.Title;

            Assert.That(expected == actual, "Геттер Title возвращает неправильное название");
        }

        [Test(Description = "Присвоение неправильному названию больше 50 символов")]
        public void TestTitleSet_Longer50Symbols() 
        {
            var wrongTitle = "Название-Название-Название-Название-Название-Название";
            var TitleTest = new Note("", NoteCategory.Various, "");

            Assert.Throws<ArgumentException>(() => { TitleTest.Title = wrongTitle; }, 
                "Должно возникать исключение, если название длиннее 50 символов");
        }
        [Test(Description = "Присвоение не пустого значения короче 50 символов")]
        public void TestTitleSet_CorrectVal() 
        {
            var expected = "Название";

            var TitleTest = new Note("", NoteCategory.Various, "");
            TitleTest.Title = expected;
            var actual = TitleTest.Title;

            Assert.That(actual == expected, "Сеттер Title не присвоил правильное значение");
        }
        [Test(Description = "Сеттер должен присвоить значение 'Без названия'")]
        public void TestTitleSet_EmptyTitle() 
        {
            var expected = "Без названия";
            var TitleTest = new Note("", NoteCategory.Various, "");
            TitleTest.Title = "";
            var actual = TitleTest.Title;

            Assert.That(actual == expected, "Сеттер не присвоил значение 'Без названия'");
        }

        [Test(Description = "Позитивный тест геттера Category")]
        public void TestCategoryGet_PositiveCategory() 
        {
            var expected = NoteCategory.Home;
            var Note = new Note("", NoteCategory.Various, "");
            Note.Category = expected;
            var actual = Note.Category;

            Assert.That(expected == actual, "Геттер Title возвращает неправильное название");
        }
        [Test(Description = "Присвоение правильной категории")]
        public void TestCategorySet_CorrectCategory() 
        {
            var expected = NoteCategory.Home;
            var Note = new Note("", NoteCategory.Various, "");
            Note.Category = expected;

            Assert.That(expected == Note.Category, "Было присвоено не правильное значение");
        }

        [Test(Description = "Геттер должен передать правильное значение Text")]
        public void TestCategoryGet_PositiveText() 
        {
            var expected = "Текст";
            var Note = new Note("", NoteCategory.Various, "");
            Note.Text = expected;
            var actual = Note.Text;

            Assert.That(expected == actual, "Было получено не правильное значение");
        }

        [Test(Description = "Сеттер должен присвоить правильное значение Text")]
        public void TestCategorySet_CorrectText()
        {
            var expected = "Текст";
            var Note = new Note("", NoteCategory.Various, "");
            Note.Text = expected;

            Assert.That(expected == Note.Text, "Было присвоено не правильное значение");
        }

        [Test(Description = "Геттер должен передать правильное значение Created")]
        public void TestCategoryGet_PositiveCreated() 
        {
            var expected = DateTime.Now;
            var Note = new Note("", NoteCategory.Various, "");
            var actual = Note.Created;

            Assert.That(expected == actual, "Было получено не правильное значение");
        }

        [Test(Description = "Геттер должен передать правильное значение Updated")]
        public void TestCategoryGet_PositiveUpdated()
        {
            var expected = DateTime.Parse("12.12.2023");
            var Note = new Note("", NoteCategory.Various, "");
            Note.Updated = expected;
            var actual = Note.Updated;

            Assert.That(expected == actual, "Было получено не правильное значение");
        }

        [Test(Description = "Сеттер должен присвоить правильное значение Updated")]
        public void TestCategorySet_CorrectUpdated()
        {
            var expected = DateTime.Parse("12.12.2023");
            var Note = new Note("", NoteCategory.Various, "");
            Note.Updated = expected;

            Assert.That(expected == Note.Updated, "Было присвоено не правильное значение");
        }
    }
}
