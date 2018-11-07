using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    public class Component
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double QuestimatedHours { get; set; }
    }
}