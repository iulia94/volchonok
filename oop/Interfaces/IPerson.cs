using System;

namespace oop
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Gender { get; set; }
        DateTime BirthDate { get; set; }
        string Idnp { get; set; }
    }
}
