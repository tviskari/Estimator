using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    public class Story
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double QuestimatedHours { get; set; }
        public List<Feature> Features { get; set; }
    }
}