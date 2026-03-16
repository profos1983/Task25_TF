
using EF_Prodject.Classes;
using AppContext = EF_Prodject.Classes.AppContext;

using (var db = new AppContext())
{
    var user1 = new User { Name = "Arthur", Role = "Admin" };
    var user2 = new User { Name = "Klim", Role = "User" };

    db.Users.Add(user1);
    db.Users.Add(user2);
    db.SaveChanges();
}
