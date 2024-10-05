
// ثوابت
using static System.Net.WebRequestMethods;

const string USERNAME = "abd";
const string PASSWORD = "123";
string generatedOtp = "";

Console.WriteLine("Welcome to the Simple Login System!");

while (true)
{
    Console.Write("Enter Username: ");
    string inputUsername = Console.ReadLine();

    Console.Write("Enter Password: ");
    string inputPassword = Console.ReadLine();

    if ((inputUsername == null || inputUsername.Length == 0) || (inputPassword == null || inputPassword.Length == 0))
    {
        Console.WriteLine("Username or password cannot be empty.");
        continue;
    }

    if (inputUsername != USERNAME || inputPassword != PASSWORD)
    {
        Console.WriteLine("Invalid username or password. Access denied.");
        continue;
    }

    // انتبهت لازم استخدم دالة GenerateOTP() بدل من استخدامها كمتغير 
    //Random randomOTP = new Random();
    //int otp = randomOTP.Next(100000, 999999); // نحتاج 6 مراتب فقط
    //string generatedOTP = otp.ToString();
    //Console.WriteLine($"OTP is: {generatedOTP}");

    string generatedOTP()
    {
        Random randomOTP = new Random();
        string otp = "";
        for (int i = 0; i < 6; i++)
        {
            otp += randomOTP.Next(0, 10).ToString();
        }
        return otp;
    }

    generatedOtp = generatedOTP();
    Console.WriteLine($"OTP is: {generatedOtp}");

    Console.Write("Enter the OTP: ");
    string inputOTP = Console.ReadLine();

    if (inputOTP == generatedOtp)
    {
        Console.WriteLine("Success! You are logged in.");
        break;
    }
    else
    {
        Console.WriteLine("Invalid OTP. Access denied.");
        break;
    }
}
