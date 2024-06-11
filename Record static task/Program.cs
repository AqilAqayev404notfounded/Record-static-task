using Record_static_task;

User user = new User() ;

Console.WriteLine(user.id);
user.FullName = "Aqil";
user.Email = "asdddd@gmail.com";
user.Password = "12345678";

Console.WriteLine(user.GetInfo());  