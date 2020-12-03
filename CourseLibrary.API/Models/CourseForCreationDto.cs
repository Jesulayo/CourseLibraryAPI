using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{ 
    //[CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title and description must be different")]
    public class CourseForCreationDto : CourseForModificationDto //: IValidatableObject
    {



        //[Required(ErrorMessage = "The title field shpuldn't be left empty")]
        //[MaxLength(100, ErrorMessage ="Maximum length is 100")]
        //public string Title { get; set; }

        //[MaxLength(1500, ErrorMessage = "Maximum length is 100")]
        //public string Description { get; set; }




        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Title == Description)
        //    {
        //        yield return new ValidationResult("Title and description should not be the same",
        //            new[] { "CourseForCreationDto" });
        //    }
        //}
    }
}
