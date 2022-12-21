namespace WebApplication8.Models
{
    public class userData
    {
        public static List<user>? userList = new List<user>()
        {
            new user("Kate", "kate@gmail.com", "123", "admin"),
            new user("Paul", "paul@gmail.com", "123", "customer")
        };

    }
}

/*
["efge", "efge", "erewf", .....]
[10, 5, 3, 8, 4]
[
    {
        name:  kate
        email: kate@gmail.com
        password: 123
        role:  admin
    },
    {
        name:
        email:
        password:
        role:
    }
]  -->   [Object1, Object2, Object3 .....]  --> List of objects
*/