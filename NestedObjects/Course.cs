using System;
using System.Collections.Generic;
using System.Text;

namespace NestedObjects
{
    public class Course
    {
        /// <summary>
        /// The course ID
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// The title for the course
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Describes the course
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of course credits
        /// </summary>
        public int Credits { get; set; }
    }
}
