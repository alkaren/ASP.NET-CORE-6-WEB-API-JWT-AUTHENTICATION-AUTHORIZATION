namespace BikeStores.MSSQL.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        { new UserModel() { Username = "alka_admin", EmailAddress = "alkarenichsan03@gmail.com",
            Password = "123qweasd", GivenName = "alka", Surname = "ichsan", Role = "Administrator" },
          new UserModel() { Username = "ica_seller", EmailAddress = "annisa99@gmail.com",
            Password = "123qweasd", GivenName = "ica", Surname = "annisa", Role = "Seller" }
        };
    }
}
