using XmlTask1.Models;

namespace XmlTask1.services
{
    public interface ICrudService
    {
        List<Person> GetAll();
        Person? GetById(int id);
        void Add(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}
