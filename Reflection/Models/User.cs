namespace Reflection.Models;

public class User
{
    public string UserName { get; set; }
    public string Email { get; set; }

    public string GetValue(string propName) => this.GetType().GetProperty(propName).GetValue(this, null).ToString();
}