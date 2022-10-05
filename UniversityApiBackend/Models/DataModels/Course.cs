using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required, StringLength (500)]
        public string LongDescription { get; set; } = string.Empty;

        [Required]
        public string TargetAudiences { get; set; } = string.Empty;

        [Required]
        public string Objectives { get; set; } = string.Empty;

        [Required]
        public string Requirements { get; set; } = string.Empty;

        [Required]
        public virtual string LevelTypeAsString
        {
            get
            {
                return this.levelType.ToString();
            }
            set
            {
                levelType = (levelTypes)Enum.Parse(typeof(levelTypes), value, true);
            }
        }
        public levelTypes levelType { get; set; }

        public enum levelTypes
        {
            Basic = 1,
            Intermediate = 2,
            Advance = 3
        }
    }
}
