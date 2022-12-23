using System.Text.RegularExpressions;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input1 = File.ReadAllLines(@"1.txt");
            

            Regex regex1 = new Regex(@"(^a$)|(^a{6}$)|(^a{1}\s{1}a{2}\s{1}a{1}$)");
            for (int i = 0; i < input1.Length; i++)
            {
                if (regex1.IsMatch(input1[i]))
                {
                    Console.WriteLine("1. Есть совпадение: " + input1[i]);
                }
                else
                {
                    Console.WriteLine("1. Совпадений не найдено");
                }
            }
            

            string[] input2 = File.ReadAllLines(@"2.txt");

            Regex regex2 = new Regex(@"^([а-яА-Яa-zA-Z0-9]{5,})$");
            for (int i = 0; i < input2.Length; i++)
            {
                if (regex2.IsMatch(input2[i]))
                {
                    Console.WriteLine("2. Есть совпадение" + input2[i]);
                }
                else
                {
                    Console.WriteLine("2. Совпадений не найдено");
                }
            }

            string[] input3 = File.ReadAllLines(@"3.txt");
            Regex regex3 = new Regex(@".+[@].+[.].");
            for (int i = 0; i < input3.Length; i++)
            {
                if (regex3.IsMatch(input3[i]))
                {
                    Console.WriteLine("3. Есть совпадение" + input3[i]);
                }
                else
                {
                    Console.WriteLine("3. Совпадений не найдено");
                }
            }

            string[] input4a = File.ReadAllLines(@"4a.txt");
            Regex regex4a = new Regex(@"^(ул\D\s)?(\S+)\s(д\D\s)?(\d{1,3}(/\d{1,3})?)$");
            for (int i = 0; i < input4a.Length; i++)
            {
                if (regex4a.IsMatch(input4a[i]))

                {
                    Console.WriteLine("4a. " + input4a[i]);
                }
                else
                {
                    Console.WriteLine("4a. Совпадений не найдено");
                }
            }

            string dop1 = "Добро пожаловать в наш магазин, вот наши цены: 1 кг. яблоки - 90 руб., 2 кг. апельсины - 130 руб. Также в ассортименте орехи в следующей фасовке: 0.5 кг. миндаль - 500 руб";
            Regex regex = new Regex(@"((?:\d+)?\.?\d+)?\sкг\.\s(\w+)\s\-\s(\d+)\sруб\.?");
            var products = regex.Matches(dop1);
            foreach (Match product in products)
            {
                foreach (Match Products in regex.Matches(product.Value))
                {
                    var SplitProduct = Products.Groups;
                    Console.WriteLine($"{SplitProduct[2]} - {Convert.ToDouble(SplitProduct[3].Value) / Convert.ToDouble(SplitProduct[1].Value.Replace('.', ','))} руб/кг");
                }

            }


        }
    }
}

