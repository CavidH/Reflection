using Reflection.Models;

User t = new User()
{
    UserName ="Cavid" ,
    Email = "HCavid386@gmail.com"
};

// t.UserName = "Cavid";
// t.Email = "HCavid386@gmail.com";

Console.WriteLine("Username: " + t.GetValue("UserName") + "\nEmail: " + t.GetValue("Email"));