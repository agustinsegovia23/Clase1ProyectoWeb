public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public User()
    {
        
    }
    public User(string name, string surname)
    {
        Name = name;
        Surname = surname;   
    }
    public string fullName(){
        return $"{Name} {Surname}";
    }
}