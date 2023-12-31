namespace Mod5FinPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static string Form(string name, string lastName, int age, bool pet, int petQuant, string[] petName, string[] favColors)
        {
            (string name, string lastName, int age, bool pet, int petQuant, string[] petName, string[] favColors) anketa;
            Console.WriteLine("Введите ваше имя:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            anketa.lastName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст цифрами:");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество любимых цветов цифрами:");
            int colorQuant = Convert.ToInt32(Console.ReadLine());
            anketa.favColors = new string[colorQuant];
            for (int i = 0; i <= favColors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет:");
                anketa.favColors[i] = Console.ReadLine();
            }
            Console.WriteLine("Есть ли у вас питомцы? Если есть введите 1, иначе введите 0");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                anketa.pet = true;
                if (anketa.pet == true)
                {
                    Console.WriteLine("Введите количество ваших питомцев цифрами:");
                    anketa.petQuant = Convert.ToInt32(Console.ReadLine());
                    string[] petname = new string[anketa.petQuant];
                    for (int i = 0; i <= petname.Length; i++)
                    {
                        Console.WriteLine("Введите имя питомца:");
                        petname[i] = Console.ReadLine();
                    }
                }
            }
            else
            {
                if (a == 0)
                    anketa.pet = false;
                else
                    for (int i = a; i != 0 && i != 1; a = Convert.ToInt32(Console.ReadLine()))
                        Console.WriteLine("Некорректный ввод, введите 1 или 0 в зависимости от наличия питомца.");


            }
        }
        static string[] PetArray(int num); { }
    }
}
