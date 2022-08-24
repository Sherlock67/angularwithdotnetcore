using System.ComponentModel.DataAnnotations;

namespace Project2.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public int ShirtNo { get; set; }

        public string Name { get; set; }

        public int Goals { get; set; }
    }
}
