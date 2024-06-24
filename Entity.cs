using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OwnedEntityTypes
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set;  }

        public Entity() { 
            Name = string.Empty;
            Description = Name + "Entity";
            Color = string.Empty;
        }
    }
}
