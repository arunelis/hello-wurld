using System.Globalization;

namespace HelloWorld
{
    public class Homework
    {
        // module that combines name and surname
        // sArunas jusKEVICIUS -> Hello, Sarunas Juskevicius!
        public string SayNameLastname(string name, string lastname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastname))
            {
                return "Name cannot be empty";
            }

            return "Hello, " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastname.ToLower()) + "!";

        }

        // tiem kas nori kazko sudetingesnio ANTRAS MODULIS: is teksto isrenka ir grazina daugiausiai kartu panaudota raide
    }
}
