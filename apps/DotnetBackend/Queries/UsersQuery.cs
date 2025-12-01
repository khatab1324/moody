public class UserQuery
{
    public List<User> getUserQuery(UserRepo repo) => repo.GetUsers();
}