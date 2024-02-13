string Login(string username, string password)
{
    if(username == "asdasd" && password == "asdasd123")
    {
        return "logic succesfull";
    }
    else 
    {

        return "username or password is wrong";
    
    }
}
Console.WriteLine("username");
string username = Console.ReadLine();
Console.WriteLine("password");
string password = Console.ReadLine();
string result = Login(username, password);
Console.WriteLine(result);