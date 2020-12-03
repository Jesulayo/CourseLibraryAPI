using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    public class CourseForUpdateDto : CourseForModificationDto
    {
        [Required(ErrorMessage ="Description cannot be left blank")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
