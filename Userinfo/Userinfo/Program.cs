using Userinfo.Services;

APIServices aPIServices = new APIServices();


Console.WriteLine("What do you want to see");
Console.WriteLine("\t\t 1. USERS");
Console.WriteLine("\t\t 2, POSTS");
Console.WriteLine("\t\t 3. COMMENTS");
var pick = Console.ReadLine();



if (int.TryParse(pick, out int userpick))
{
    switch (userpick)
    {
        case 1:
         
            Console.WriteLine("Okay!..Getting what you want in a moment..\n....\n......");
            var users = await aPIServices.GetAllUsers();
            break;
        case 2:
            Console.WriteLine("Okay!..Getting what you want in a moment..\n....\n......");
            var posts = await aPIServices.GetAllPosts();
            break;
        case 3:
            Console.WriteLine("Okay!..Getting what you want in a moment..\n....\n......");
            var comments = await aPIServices.GetAllComments();
            break;


        default:
            Console.WriteLine("Please Select From the available choices");
            break;
    }
    
    
}
else
{
    Console.WriteLine("Invalid option, try again!");
}




//foreach (user in user)
//{
//    console.writeline($"{}");
//}


