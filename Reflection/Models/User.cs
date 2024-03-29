﻿namespace Reflection.Models;

public class User
{
    public string UserName { get; set; }
    public string Email { get; set; }

    public string GetValue(string propName)
    {
        try
        {
            return this.GetType().GetProperty(propName).GetValue(this, null).ToString();
        }
        catch
        {
            return "This property does not exist";
        }
    }
}