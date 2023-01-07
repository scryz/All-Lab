using System.Text.RegularExpressions;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input1 = File.ReadAllLines(@"1.txt");
            Regex regex1 = new Regex(@"(^a$)|(^a{6}$)|(^a aa a$)");
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
                    Console.WriteLine("2. Есть совпадение: " + input2[i]);
                }
                else
                {
                    Console.WriteLine("2. Совпадений не найдено");
                }
            }

            string[] input3 = File.ReadAllLines(@"3.txt");
            Regex regex3 = new Regex(@"^(([aA-zZ]+[-_][aA-zZ0-9]+)|([aA-zZ0-9]+))[@]((\w+)|(\w[\w-]+))[.]\w+$");
            for (int i = 0; i < input3.Length; i++)
            {
                if (regex3.IsMatch(input3[i]))
                {
                    Console.WriteLine("3. Есть совпадение: " + input3[i]);
                }
                else
                {
                    Console.WriteLine("3. Совпадений не найдено");
                }
            }



            /*5a. Найти: (([^0-9]+[.])(?:[уУ][л][.]\s+)?([А-Яа-я]+(\-[А-Яа-я]+)?)?\s+(?:[дД][.]\s+)?(\d+(?:[/\-]\d+)?))
            
              5b. Найти: (^[\d]+[.])
                  Заменить: (пусто)

              5c. Найти: (\s{1,}<((/)?[a-z0-9]+)>)
                  Заменить:   (<\2>)

              5d. Найти: (((\s+)?)<([^<]+)>([^<]+)<([^<]+)>)
                  Заменить: (\2<\4>\5</\4>)
            */




            string dopz1 = "Добро пожаловать в наш магазин, вот наши цены: 1 кг. яблоки - 90 руб., 2 кг. апельсины - 130 руб. Также в ассортименте орехи в следующей фасовке: 0.5 кг. миндаль - 500 руб";
                Regex regex = new Regex(@"((?:\d+)?[.]?\d+)?\sкг[.]\s(\w+)\s-\s(\d+)\sруб[.]?");
                var products = regex.Matches(dopz1);
                foreach (Match product in products)
                {
                    foreach (Match Products in regex.Matches(product.Value))
                    {
                        var SplitProduct = Products.Groups;
                        Console.WriteLine("dopz 1. " + SplitProduct[2] + " " + Convert.ToDouble(SplitProduct[3].Value) / Convert.ToDouble(SplitProduct[1].Value.Replace('.', ',')) + " руб/кг");


                    }

                }

                var dopz2 = File.ReadAllText(@"dop2.txt");
                Regex regexd2 = new Regex(@".((https://)|(http://)|(ftp://))?(www)[.]?([^-\s][\w-_]+[.]){1,4}\w+.");
                var url = regexd2.Matches(dopz2);
                string del = "";
                foreach (Match urls in url)
                {
                    del += $"{urls.Value.Trim()}:{urls.Index}\n";
                }
                File.WriteAllText("Ссылки.txt", del);
                Console.WriteLine("dopz 2. " + del);

            }
        }
    }




