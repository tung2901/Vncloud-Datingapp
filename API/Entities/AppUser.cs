namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set;}
        public string Username { get; set; }
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
    }
}