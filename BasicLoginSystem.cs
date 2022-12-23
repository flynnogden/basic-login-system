internal class Program
{
    private static void Main(string[] args)
    {
        string password = "1234";
        string username = "Member";
        string admin = "Flynn";

        byte passwordCount = 0;
        byte usernameCount = 0;
        bool usernameAccess = false;
        bool passwordAccess = false;
        bool adminAccess = false;

        Console.WriteLine("     -----------------");
        Console.WriteLine("    | Welcome to Anon |");
        Console.WriteLine("     -----------------");

        while (usernameAccess == false)
        {
            Console.Write("\nPlease enter your username: ");
            var usernameInput = Console.ReadLine();

            if (usernameInput == username)
            {
                usernameAccess = true;
                break;
            }

            else if (usernameInput == admin)
            {
                adminAccess = true;
                break;
            }

            else
            {
                if (usernameCount == 2)
                {
                    Console.WriteLine("\nUnfortunately, you have been locked out of the system for too many " +
                        "incorrect login attempts.");
                    return;
                }

                else
                {
                    usernameCount++;
                    Console.WriteLine($"\nSystem access denied, please try again.                             " +
                        $"                                (Attempts used: {usernameCount}/3)");
                    continue;
                }
            }
        }

        if (usernameAccess == true || adminAccess == true)
        {
            while (passwordAccess == false)
            {
                Console.Write("\nPlease enter your password: ");
                var passwordInput = Console.ReadLine();

                if (passwordInput == password)
                {
                    passwordAccess = true;
                }

                else
                {
                    if (passwordCount == 2)
                    {
                        Console.WriteLine("\nUnfortunately, you have been locked out of the system for " +
                            "too many incorrect login attempts.");
                        return;
                    }

                    else
                    {
                        passwordCount++;
                        Console.WriteLine($"\nSystem access denied, please try again.                        " +
                            $"                                   (Attempts used: {passwordCount}/3)");
                        continue;
                    }
                }
            }
        }

        if (adminAccess == true)
        {
            AdminPortal(admin);
        }

        else
        {
            UserPortal(username);
        }
    }
    public static void AdminPortal(string admin)
    {
        Thread.Sleep(1000);
        Console.WriteLine("\nEncrypting...");
        Thread.Sleep(2000);
        Console.WriteLine($"\nAccess to the admin portal has been granted.\n\nWelcome back, {admin}.");
    }
    public static void UserPortal(string username)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"\nAccess has been granted.\n\nWelcome back, {username}.");
    }
}
