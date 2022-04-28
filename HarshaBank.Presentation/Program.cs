﻿class Program
{
    static void Main()
    {
        //display title
        System.Console.WriteLine("**************Harsha Bank**************");

        //display heading
        System.Console.WriteLine("::Login Page::");

        //declare variables to store username and password
        string userName = null, password = null;

        //read userName from keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();


        //read password from keyboard only if username is entered
        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if (userName == "system" && password == "manager")
        {
            //declare variable to store menu choice
            int mainMenuChoice = -1;

            do
            { 
                //show main menu
                System.Console.WriteLine("\n:::Main menu:::");
                System.Console.WriteLine("1. Customer");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4, Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                //accept menu choice from keyboard
                System.Console.Write("Enter choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check choice
                switch (mainMenuChoice)
                {
                    case 1: CustomerMenu();  break;
                    case 2: AccountsMenu(); break;
                    case 3: //TO DO: Display customer menu
                        break;
                    case 4: //TO DO: Display customer menu
                        break;
                    case 5: //TO DO: Display customer menu
                        break;
                }
            }while(mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        //about to exit
        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
        

    }

    static void CustomerMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;

        //do-while
        do
        {
            //print customers menu
            System.Console.WriteLine("\n:::Customer menu:::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customer");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept customer menu choice
            System.Console.Write("Enter choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while(customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        //variable to store customers menu choice
        int accountsMenuChoice = -1;

        //do-while
        do
        {
            //print customers menu
            System.Console.WriteLine("\n:::Accounts menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept customer menu choice
            System.Console.Write("Enter choice: ");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (accountsMenuChoice != 0);
    }
}
