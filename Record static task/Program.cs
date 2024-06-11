using Record_static_task;

User[] users = new User[3];
int userCount = 0;
while (userCount < users.Length)
{
    Console.WriteLine("Please enter fullname:");
    string fullname = Console.ReadLine();
    Console.WriteLine("Please enter email:");
    string email = Console.ReadLine();
    Console.WriteLine("Please enter password:");
    string password = Console.ReadLine();

    users[userCount] = new User(fullname,email, password);
    userCount++;
    Console.WriteLine("User added");
}
while (true)
{
    Console.WriteLine("1.Show all users \n" +"2.Get info by id\n" +"0.Quit");

    int command = Convert.ToInt32(Console.ReadLine());
    switch (command)
    {
        case 0:
            return;
        case 1:
            Console.WriteLine("All users:");
            for (int i = 0; i < userCount; i++)
            {
                users[i].GetInfo();
            }
            break;
        case 2:
            Console.WriteLine("Enter the id");
            int id = Convert.ToInt32(Console.ReadLine());
            int index = User.FindById(users, id);
            if (index != -1)
            {
                users[index].GetInfo();
            }
            else
            {
                Console.WriteLine("This user does not exist");
            }
            break;
        default:
            Console.WriteLine("Please enter the correct command");
            break;
    }
}