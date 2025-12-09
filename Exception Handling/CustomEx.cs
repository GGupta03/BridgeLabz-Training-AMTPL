using System;

namespace BridgeLabzApp.Exception_Handling
{
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }

    public class Registration
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Age must be 18 or above to register.");
            }
            else
            {
                Console.WriteLine("Registration successful!");
            }
        }
    }

    public class CustomEx   // Class added
    {
        public static void Main()
        {
            try
            {
                Registration reg = new Registration();
                reg.ValidateAge(16);
            }
            catch (AgeException ex)
            {
                Console.WriteLine("Custom Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }
        }
    }
}
