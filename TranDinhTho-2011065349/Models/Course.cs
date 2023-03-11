using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TranDinhTho_2011065349.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public String LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public String Place { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        [Required]
        public Byte CategoryId { get; set; }
    }
    
}