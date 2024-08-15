public class UserService
{
    public string Username { get; private set; }

    public void SetUsername(string username)
    {
        Username = username;
    }
}
