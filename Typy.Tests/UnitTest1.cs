using NUnit.Framework;
using System;

namespace Typy.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Diary diary = new Diary();
            diary.AddRating(9f);
            diary.AddRating(8f);
            diary.AddRating(7f);
            diary.AddRating(5f);
            diary.AddRating(3f);
            diary.AddRating(10f);
            
            


            DiaryStatistics stats = diary.ComputeStats(); // zmieniliœmy klasy na public (domyœlnie jest internal)


            Assert.AreEqual(10f, stats.MaxGrade);

        }

        public void PassByValueClass() 
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";
            SetName(diary);

            Assert.AreEqual("Marcin", diary.Name);
        }
     

        private void SetName(Diary diary)
        {
            diary.Name = "Marcin";
        }
    }
}