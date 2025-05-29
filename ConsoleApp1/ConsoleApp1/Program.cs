using System;

class Program
{
    static void Main()
    {
        string[] MyArray = new string[]{}; 

        bool run = true;
        
        while (run)
        {
            Start_app.Start();
            string inp_user = Console.ReadLine();
            switch(inp_user)
            {
                case "1":
                    Console.WriteLine(string.Join(", ", MyArray));
                    break;
                case "2":
                    Console.WriteLine("Enter your number for add to array : ");
                    string arr_inp = Console.ReadLine();
                    List<string> add_list = MyArray.ToList();
                    add_list.Add(arr_inp);
                    MyArray = add_list.ToArray();
                    break;
                case "3":
                    Console.WriteLine("Enter your index as left to right for delete : ");
                    int del_inp = 1 - Int32.Parse(Console.ReadLine());
                    List<string> del_list = MyArray.ToList();
                    del_list.RemoveAt(del_inp);
                    MyArray = del_list.ToArray();
                    break;
                case "4":
                    Console.WriteLine("The program has stopped.");
                    run = false;
                    break;
            }
        }

    }
}

class Start_app
{
    public static void Start(){
        Console.WriteLine("""
        Welcome to my app !
          Menu :
            1. Show array
            2. Add number
            3. Delete number
            4. Exit
        
          Select (1_4) :
        """);
    }
}