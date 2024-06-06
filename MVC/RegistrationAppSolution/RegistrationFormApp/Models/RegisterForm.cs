namespace RegistrationFormApp.Models
{
    public class RegisterForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public string Gender { get; set; }
        // public string? Languages { get; set; }
        public string Languages { get; set; }
        public string LangCheckbox1 { get; set; }
        public string LangCheckbox2 { get; set; }
        public string LangCheckbox3 { get; set; }
        public string City { get; set; }
    }
}
