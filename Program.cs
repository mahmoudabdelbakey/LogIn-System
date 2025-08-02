using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Log_in__System
{
    internal class Program
    {
        static string[] usernameOfAllUsers = new string[87956978];
        static string[] passwordOfAllUsers = new string[87956978];

        static void Border()
        {
            Console.WriteLine("*--------------------------*");
            Console.WriteLine("  ------------------------");
            Console.WriteLine("  |\tLogIn System.  \t |");
            Console.WriteLine("  ------------------------");
            Console.WriteLine("*--------------------------*");

        }
        static void DisplayMenu()
        {
            Console.WriteLine("What are you want ? ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1- Log In.");
            Console.WriteLine("2- Edit profile.");
            Console.WriteLine("3- Delete account. ");
            Console.WriteLine("4- Display all usernames");
            Console.WriteLine();
            Console.Write("Choose number :- ");
        }
        static int Num()//Number to select choose in menu
        {

            bool chooseNum = true;
            int num = 0;

            while (chooseNum)
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num >= 1 && num <= 4)
                    {
                        Console.Clear();
                        chooseNum = false;

                    }
                    else
                    {
                        Console.Write("Ops , Please choose correct number :- ");
                    }
                }
                else
                {
                    Console.Write("Ops , Please choose correct number :- ");
                }
            }

            return num;
        }
        
        
       
        

        static void LogIn(int i)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("|\t  LogIn.  \t |");
            Console.WriteLine("--------------------------");



            string[] birthday = new string[3];
            bool logInFlag = true;
            string username;
            string password;
            string anthorInfo;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Log In :- ");

            while (logInFlag)
            {

                Console.WriteLine();
                Console.Write("Enter username :- ");
                username = DisplayName();
                try
                {
                    for (int j = 0; j < usernameOfAllUsers.Length; j++)
                    {
                        if (usernameOfAllUsers != null)
                        {

                            if (usernameOfAllUsers[j] == username)
                            {
                                throw new FormatException("This username used in advance :- ");
                            }
                        }

                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.WriteLine();
                password = TryPassword();

                while (logInFlag)
                {

                    usernameOfAllUsers[i] = username;
                    passwordOfAllUsers[i] = password;
                    i++;
                    break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Do you want to anthorInfo any other information(YES or NO ) ? :- ");
                Console.WriteLine();
                while (logInFlag)
                {

                anthorInfo = AnthorInfo();// if you want enter other information
                anthorInfo = anthorInfo.ToLower();
                if (anthorInfo == "yes")
                {
                    Console.Write("Enter your name :- ");
                    username = DisplayName();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("Enter your birthday in form (DD/MM/YYYY) :- ");
                    birthday = Birthday();
                    Console.WriteLine();

                    int day = int.Parse(birthday[0]);
                    bool birthdayFlag = true;
                    while (birthdayFlag)
                    {
                        if (int.TryParse(birthday[0], out day))
                        {
                            if (day >= 1 && day <= 31)
                                break;
                            else
                            {
                                Console.WriteLine("please,Enter your birthday correct in form (DD/MM/YYYY) :- ");
                                birthday = Birthday();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("please,Enter your birthday correct in form (DD/MM/YYYY) :- ");
                            birthday = Birthday();
                            Console.WriteLine();

                        }
                        Console.WriteLine(birthday);
                        break;

                    }
                    while (logInFlag)
                    {
                        if (int.TryParse(birthday[1], out int manth))
                        {
                            if (manth >= 1 && manth <= 12)
                                break;
                            else
                            {
                                Console.WriteLine("please,Enter your birthday correct in form (DD/MM/YYYY) :- ");
                                birthday = Birthday();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("please,Enter your birthday correct in form (DD/MM/YYYY) :- ");
                            birthday = Birthday();
                            Console.WriteLine();
                        }
                        break;
                    }
                    while (logInFlag)
                    {
                        if (int.TryParse(birthday[2], out int year))
                        {
                            if (year >= 1922 && year <= 2025)
                                break;
                            else
                            {
                                Console.WriteLine("please,Enter your birthday correct in form (DD/MM/YYYY) :- ");
                                birthday = Birthday();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("please,Enter your birthday correct in form (DD/MM/YYYY) :- ");
                            birthday = Birthday();
                            Console.WriteLine();
                        }

                        break;
                    }
                }else if (anthorInfo != "no")
                {
                    Console.Write("Invalid input please enter ( YES or NO ):- ");
                    continue;

                }
                    break;
                }

                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter any key to continue...");
                Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                break;
            }
        }
        static void EditProfile()//edit username and password in your account
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("|\tEdit Profile.  \t |");
            Console.WriteLine("--------------------------");
            string username;
            string username1;

            string password;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Edit profile :- ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter username :- ");
            username = DisplayName();
            bool editUsernameFlag = true;

            while (editUsernameFlag)
            {

                for (int j = 0; j < usernameOfAllUsers.Length; j++)
                {
                    if (usernameOfAllUsers[j] == username)
                    {
                        editUsernameFlag = false;
                    }

                }
                if (editUsernameFlag == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry , Username is wrong.");
                    Console.Write("Please enter correct username:- ");
                    username = DisplayName();
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            password = TryPassword();
            bool editPasswordFlag = true;
            while (editPasswordFlag)
            {

                for (int j = 0; j < usernameOfAllUsers.Length; j++)
                {
                    if (passwordOfAllUsers[j] == password)
                    {
                        editPasswordFlag = false;
                    }

                }
                if (editPasswordFlag == true)
                {
                    Console.WriteLine("Sorry , password is wrong.");
                    password = TryPassword();
                    Console.WriteLine();

                }

            }
            for (int j = 0; j < usernameOfAllUsers.Length; j++)
            {
                if (usernameOfAllUsers[j] == username && passwordOfAllUsers[j] == password)
                {
                    Console.Write("Enter new username :- ");
                    username1 = DisplayName();
                    try
                    {
                        for (int i = 0; i < usernameOfAllUsers.Length; i++)
                        {
                            if (usernameOfAllUsers != null)
                            {

                                if (usernameOfAllUsers[i] == username1)
                                {
                                    throw new FormatException("No ,This username is used:- ");
                                }
                            }

                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine(ex.Message);
                        j=0;
                        continue;
                    }
                    Console.WriteLine();
                    password = TryPassword();
                    usernameOfAllUsers[j] = username1;
                    passwordOfAllUsers[j] = password;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Task completed successfully");
                    Console.WriteLine();
                    Console.WriteLine($"New username is {username1}");
                    Console.WriteLine();
                    Console.WriteLine();

                }

            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void DeleteAccount()//Delete your Account if you know old username and old password
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("|\tDelete Account.\t  |");
            Console.WriteLine("--------------------------"); string username;
            string password;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Delete Account :- ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter username :- ");
            username = DisplayName();
            bool DeleteUsernameFlag = true;
            while (DeleteUsernameFlag)
            {
                for (int j = 0; j < usernameOfAllUsers.Length; j++)
                {
                    if (usernameOfAllUsers[j] != null)
                    {
                        if (usernameOfAllUsers[j] == username)
                        {
                            DeleteUsernameFlag = false;
                            continue;
                        }
                    }

                }
                if (DeleteUsernameFlag == true)
                {
                    Console.WriteLine("Sorry , Username is wrong.");
                    username = DisplayName();
                    Console.WriteLine();
                }

            }

            password = TryPassword();
            bool DeletePasswordFlag = true;
            while (DeletePasswordFlag)
            {

                for (int j = 0; j < usernameOfAllUsers.Length; j++)
                {
                    if (usernameOfAllUsers[j] != null)
                    {
                        if (passwordOfAllUsers[j] == password)
                        {
                            DeletePasswordFlag = false;
                            continue;
                        }

                    }
                }
                if (DeletePasswordFlag == true)
                {
                    Console.WriteLine("Sorry ,Password is wrong.");
                    password = TryPassword();
                    Console.WriteLine();
                }

                usernameOfAllUsers = usernameOfAllUsers.Where(x => x != username).ToArray();
                passwordOfAllUsers = passwordOfAllUsers.Where(x => x != password).ToArray();
                Console.WriteLine();
                Console.WriteLine($"Your account {username} are delete");
                Console.WriteLine();
                break;

            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void DisplayAllUsernames()// show all Username 
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("|    Display Accounts.\t |");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Display all usernames:-");
            Console.WriteLine();
            Array.Sort(usernameOfAllUsers);
            for (int j = 0; j < usernameOfAllUsers.Length; j++)
            {

                if (usernameOfAllUsers[j] != null)
                {
                    Console.WriteLine(usernameOfAllUsers[j]);
                }


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

        }
        static bool AreYouNeedDoAnythingAgain(bool importantFlag)
        {
            string anthorInfo;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Are you need do anything again (YES or NO ):- ");
            while (importantFlag)
            {
            anthorInfo = AnthorInfo();
            Console.WriteLine();
            Console.Clear();
            anthorInfo = anthorInfo.ToLower();
            if (anthorInfo == "yes")
            {
            }
            else if (anthorInfo == "no")
            {
                Console.WriteLine("\t\t\t\t\t--------------THANK YOU--------------");
                Console.WriteLine("\t\t\t\t\t--------------THE<>END!--------------");
                importantFlag = false;
            }
            else
            {
                Console.Write("Invalid input please enter ( YES or NO ):- ");
                    continue;
            }
                break;
            }
            return importantFlag;
        }
        static string DisplayName()//solve problem in username  
        {
            string username;
            while (true)
            {

                username = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(username))
                {
                    Console.WriteLine();
                    Console.Write("Invalid input,Please try again :-  ");
                    continue;
                }
                try
                {
                    int number = int.Parse(username);
                    Console.WriteLine();
                    Console.Write("Enter name ,Not number :- ");
                }
                catch (FormatException)
                {
                    return username;
                }
            }
        }
        static string TryPassword()//solve problem in password  
        {
            string password;
            while (true)
            {
                Console.Write("Enter your password :- ");
                password = Console.ReadLine();
                Console.WriteLine();
                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.WriteLine("Invalid input, please try again. ");
                    Console.WriteLine();
                    continue;
                }
                break;
            }
            return password;
        }
        static string[] Birthday()
        {
            while (true)
            {
                string[] birthday = Console.ReadLine().Split('/');//Birthday in DD/MM/YYYY
                try
                {
                    int day = int.Parse(birthday[0]);
                    int month = int.Parse(birthday[1]);
                    int year = int.Parse(birthday[2]);
                    return birthday;

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Your birthday in form (DD/MM/YYYY). ");
                    Console.WriteLine();
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The numbers should be intger.");
                    Console.WriteLine();
                    continue;
                }

            }
        }


        static string AnthorInfo()
        {
            string anthorInfo;
            while (true)
            {

                anthorInfo = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(anthorInfo))
                {
                    Console.WriteLine();
                    Console.Write("Invalid input,Please try again ( YES or NO ) :-  ");
                    continue;
                }
                try
                {
                    int number = int.Parse(anthorInfo);
                    Console.WriteLine();
                    Console.Write("Invalid input please enter ( YES or NO ):- ");
                }
                catch (FormatException)
                {
                    return anthorInfo;
                }
            }
        }
        static void Main(string[] args)
        {
            
            bool importantFlag = true;
            int i = 0;
            //Border();
            //LogIn(i);
            i++;
            while (importantFlag)
            {
                Border();
                DisplayMenu();//Menu
                int num = Num();//choose number in menu

                switch (num)
                {
                    case 1:

                        LogIn(i);
                        i++;
                        break;
                    case 2:
                        EditProfile();
                        break;
                    case 3:
                        DeleteAccount();
                        break;
                    case 4:
                        DisplayAllUsernames();
                        break;

                }

                importantFlag = AreYouNeedDoAnythingAgain(importantFlag);

            }
            Console.ReadLine();
        }
    }
}
