using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Helpers
{
    public static class GetAge
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTimeOffset.Year;
            return age;
        }
    }
}
