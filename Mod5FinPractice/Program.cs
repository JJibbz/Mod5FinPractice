using System.Drawing;
using System.Threading.Channels;

namespace Mod5FinPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Form();
            ShowResult(x);
        }
        static (string name, string lastName, int age, bool pet, int petQuant, string[] petName, string[] favColors) Form()
        {
            (string name, string lastName, int age, bool pet, int petQuant, string[] petName, string[] favColors) anketa = ("","",0,false,0,new string[0], new string[0]);
            Console.WriteLine("Введите ваше имя:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            anketa.lastName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст цифрами:");
            string age = Console.ReadLine();
            anketa.age = CheckNumber(age);
            Console.WriteLine("Введите количество любимых цветов цифрами:");
            string colors = Console.ReadLine();
            int colorQuant = CheckNumber(colors);
            anketa.favColors = Colors(colorQuant);
            Console.WriteLine("Есть ли у вас питомцы? Если есть введите 1, иначе введите 0");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                anketa.pet = true;
                if (anketa.pet == true)
                {
                    Console.WriteLine("Введите количество ваших питомцев цифрами:");
                    string pets = Console.ReadLine();
                    anketa.petQuant = CheckNumber(pets);
                    anketa.petName = PetArray(anketa.petQuant);
               
                }
            }
            else
            {
                if (a == 0)
                    anketa.pet = false;
                else
                    for (int i = a; i != 0 && i != 1; a = Convert.ToInt32(Console.ReadLine()))
                    {
                        Console.WriteLine("Некорректный ввод, введите 1 или 0 в зависимости от наличия питомца.");
                        Console.WriteLine("Есть ли у вас питомцы? Если есть введите 1, иначе введите 0");
                    }

            }
            return anketa; 
        }
        static string[] PetArray(int num) 
        {
            string[] petname = new string[num];
            for (int i = 0; i < petname.Length; i++)
            {
                Console.WriteLine("Введите имя питомца:");
                petname[i] = Console.ReadLine();
            }
            return petname;
        }
        static string[] Colors(int num) 
        {
            string[] favColors = new string[num];
            for (int i = 0; i < favColors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет:");
                favColors[i] = Console.ReadLine();
            }
            return favColors;
        }
        static void ShowResult((string name, string lastName, int age, bool pet, int petQuant, string[] petName, string[] favColors) person) 
        {
            Console.WriteLine($"Ваше имя: {person.name}. \nВаша фамилия: {person.lastName}. \nВаш возраст: {person.age}.");
            if (person.pet == true)
            {
                Console.WriteLine($"У вас есть {person.petQuant} питомц(а/ев)!");
                Console.WriteLine("Клички ваш(его/их) питомц(а/ев)");
                foreach (string item in person.petName)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Ваши любимые цвета:");
            foreach (string item in person.favColors)
            {
                Console.WriteLine(item);
            }
            
        }
        static int CheckNumber(string num1) 
        { 
            int corrnumb;
            bool result = int.TryParse(num1, out corrnumb);
            
                if (result == true)
                {
                    return corrnumb; 
                }
                else
                {
                 Console.WriteLine("Введены некорректные данные, пожалуйста используйте цифры для ввода");
                 Console.WriteLine("Повторите ввод");
                 num1 = Console.ReadLine();
                 int correct = CheckNumber(num1);
                 return correct;
                }
            
        }
    }
}
