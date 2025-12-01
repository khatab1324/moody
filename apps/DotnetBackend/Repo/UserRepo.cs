public class UserRepo
{
    private readonly List<User> _users = new List<User> { new User() { Id = 1, Name = "khattab", Email = "khattab@email.com" }, new User() { Id = 2, Name = "khattab2", Email = "khattab2@email.com" } };
    public List<User> GetUsers() => _users;
}