namespace UserRegistrationUsingLambda
{
    class Program
    {
        public static  void Main(string[] args) 
        {
            Console.WriteLine("!!!!!!!!!!!Welcome to User Registration Using Lambda!!!!!!!!!");
            Console.WriteLine("**************************");
            ValidationCode validationCode = new ValidationCode();
            validationCode.ValidateFirstName();
        }
    }
}