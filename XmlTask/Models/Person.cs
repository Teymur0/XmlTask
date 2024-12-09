namespace XmlTask1.Models
{
    public class Person:BaseEntity
    {

        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public int Age { get; set; }
    }
}
