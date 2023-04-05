using System;
using System.Collections.Generic;
using System.Text;

namespace MyCourse.Shared.Messages
{
    public class CourseNameChangedEvent
    {
        public string CourseId { get; set; }
        public string UpdatedName { get; set; }
    }
}
