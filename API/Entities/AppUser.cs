namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }//encryp password using hash
        public byte[] PasswordSalt { get; set; }//encryp password using salt
    }
}