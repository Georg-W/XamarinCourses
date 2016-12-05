using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CourseManager
    {
        private readonly Course[] courses;
        int currentIndex = 0;
        private readonly int lastIndex;

        public CourseManager()
        {
            courses = InitCourses();
            lastIndex = courses.Length - 1;
        }

        private Course[] InitCourses()
        {
            var initCourses = new Course[] {
                new Course()
                {
                    Title = "Android Dreams",
                    Description = "Provide Stuff",
                    Image = "Herrderringe"
                },
                new Course()
                {
                    Title = "iOS Dreams",
                    Description = "Provide Stuff",
                    Image = "diedrei"
                },
                new Course()
                {
                    Title = "Windows Dreams",
                    Description = "Provide Stuff",
                    Image = "java_ist_auch_eine_insel"
                }
            };
            return initCourses;
        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev()
        {
            if(currentIndex > 0)
            --currentIndex;
        }

        public void MoveNext()
        {
            if (currentIndex < lastIndex)
                ++currentIndex;
        }

        public Course Current
        {
            get { return courses[currentIndex]; }
        }

        public Boolean canMovePrev 
        {
            get { return currentIndex > 0; }
        }
        public Boolean canMoveNext
        {
            get { return currentIndex < lastIndex; }
        }
    }
}
