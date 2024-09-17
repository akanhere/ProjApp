using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagementApp.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<ProjectActivity> ProjectActivities { get; set; }

        public DateTime PlannedStartDate { get; set; }

        public DateTime PlannedEndDate { get; set; }
    }
}
