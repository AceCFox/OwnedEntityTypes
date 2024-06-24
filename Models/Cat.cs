using System.Security.Cryptography.X509Certificates;

namespace OwnedEntityTypes.Models
{
    public class Cat:Entity
    {
        public int Age { get; set; }
        public string FurLength { get; set; } = "short";
    }
}
