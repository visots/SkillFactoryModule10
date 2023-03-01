namespace Ex10_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var account = new Account();
            var user = new User();

            IUpdater<Account> updater = new UserService();

            var userService = new UserService();
            userService.Update(user);

        }
    }

    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater <in T>
    {
        void Update(T entity);
    }

    public class UserService : IUpdater<User> 
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}