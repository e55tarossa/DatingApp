namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string  UserName { get; set; }

        

        //Tạo xong 2 này migration "Dotnet ef migrations add UserPasswordAdded
        //Xong tới update database 
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}