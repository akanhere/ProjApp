using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagementApp.Models
{
    public class ProjectActivity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectActivityId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public string Details { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }


        public ICollection<Resource> Resources { get; set; }
    }
}
