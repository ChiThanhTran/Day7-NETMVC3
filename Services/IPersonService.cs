using NETMVCDAY1.Models;
namespace NETMVCDAY1.Services;
public interface IPersonService
{
    List<Person> GetAll();
    Person GetOne(int index);
    void Create(Person person);
    void Update(int index , Person person);
    void Delete(int index);
}

