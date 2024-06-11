﻿
namespace Record_static_task;

public class User
{
    static int Id;
    public int id {  get; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password 
    {
        get {  return Password; }
        set
        {
            if (PasswordChecer(Password))
            Password = value;
        }
    }
    public User()
    {
        Id++;
        id = Id;

    }


    static bool PasswordChecer(string value)
    {
        if (value.Length < 8)
        {
            return false;
        }

        bool containsUpperCase = false;
        bool containsLowerCase = false;
        bool containsDigit = false;

        foreach (char c in value)
        {
            if (char.IsUpper(c))
            {
                containsUpperCase = true;
            }
            else if (char.IsLower(c))
            {
                containsLowerCase = true;
            }
            else if (char.IsDigit(c))
            {
                containsDigit = true;
            }
        }

        return containsUpperCase && containsLowerCase && containsDigit;
    }
    public string GetInfo(string id,string email ,string fullname)
    {
        return $" id : {id} email : {email} fullname : {fullname}";
    }
    public static int FindById(User[]users,int id)
    {
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i].id == id)
            {
                return i;
            }
        }
        return -1;
    }

  
}