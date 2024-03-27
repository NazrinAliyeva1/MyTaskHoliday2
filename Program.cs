
////
//using System;
//class Program
//{
//    static void Main()
//    {
//        string[] languages = { "C", "Python", "JavaScript", "C++" };

//        string secim;

//        do
//        {
//            Console.WriteLine("Seciminizi daxil edin:");
//            secim = Console.ReadLine();

//            if (secim == "1")
//            {
//                foreach (string s in languages)
//                {
//                    Console.WriteLine(s);
//                }
//            }
//            else if (secim == "2")
//            {
//                Console.WriteLine("Ad daxil edin:");
//                string newName = Console.ReadLine();

//                if (IsValidLangName(newName, languages))
//                {
//                    string[] tempArray = new string[languages.Length + 1];
//                    for (int i = 0; i < languages.Length; i++)
//                    {
//                        tempArray[i] = languages[i];
//                    }
//                    tempArray[tempArray.Length - 1] = newName;
//                    languages = tempArray;

//                    Console.WriteLine("Daxil etdiyiniz ad ugurla yerlesdirildi!");

//                }

//            }
//            else if (secim == "3")
//            {
//                Console.WriteLine("Ad daxil edin:");
//                string strName = Console.ReadLine();

//                bool IfLangExist = false;

//                foreach (string language in languages)
//                {
//                    if (language == strName)
//                    {
//                        IfLangExist = true;
//                        break;
//                    }

//                }
//                if (IfLangExist)
//                {
//                    Console.WriteLine("Var");
//                }
//                else
//                {
//                    Console.WriteLine("Yoxdur");
//                }

//            }
//            else if (secim == "4")
//            {
//                Console.WriteLine("Gostermek istediyiniz indeksi daxil edin:");
//                string input = Console.ReadLine();

//                bool parsedSuccesfully = int.TryParse(input, out int index);

//                if (parsedSuccesfully)
//                {
//                    if (index >= 0 && index < languages.Length)
//                    {
//                        Console.WriteLine(languages[index]);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Gostermek istediyiniz dil movcud deyil.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Giris etibarsizdir. Tam eded daxil edin.");
//                }
//            }
//            else if (secim == "0")
//            {
//                Console.WriteLine("Proqram sonlandirildi");
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Zehmet olmasa dogru bir secim edin (1,2,3,4,0).");
//            }
//        } while (secim != "0");
//    }
//    static bool IsValidLangName(string name, string[] langs)
//    {
//        if (name.Length <= 2 || StartsWithDigit(name) || LanguageNameRepeatCheck(name, langs))
//        {
//            Console.WriteLine("Daxil etdiyiniz ad uygun deyil!");
//            return false;
//        }
//        return true;
//    }

//    static bool StartsWithDigit(string str)
//    {
//        char firstChar = str[0];
//        if (firstChar >= '0' && firstChar <= '9')

//            return true;
//        return false;
//    }
//    static bool LanguageNameRepeatCheck(string langName, string[] langs)
//    {
//        foreach (string addedName in langs)
//        {
//            if (addedName == langName)
//            {
//                return true;
//            }
//        }
//        return false;
//    }

//}



//ikinci usulla-list yaratmaqla

//using System;
//class Program
//{
//    static void Main()
//    {

//        // create a list
//        List<string> languages = new List<string> { "C", "Python", "JavaScript", "C++" };


//        string secim;
//        do
//        {

//            Console.WriteLine("Seciminizi daxil edin: ");
//            secim = Console.ReadLine();




//            if (secim == "1")
//            {
//                Console.WriteLine("Siyahidaki butun adlar.");
//                foreach (var dil in languages)
//                {
//                    Console.WriteLine(dil);
//                }

//            }
//            else if (secim == "2")
//            {
//                Console.WriteLine("Ad daxil edin: ");
//                string yeniDil = Console.ReadLine();

//                if (IsValidDilAdi(yeniDil, languages))
//                {
//                    languages.Add(yeniDil);
//                    Console.WriteLine("Yeni dil liste ugurla yerlesdirildi.");
//                }

//            }

//            else if (secim == "3")
//            {
//                Console.WriteLine("Ad daxil edin: ");
//                string arananDil = Console.ReadLine();


//                // Dil adının listede olup olmadığını kontrol et

//                if (languages.Contains(arananDil))
//                {
//                    Console.WriteLine("Var");
//                }
//                else
//                {
//                    Console.WriteLine("Yoxdur");
//                }


//            }

//            else if (secim == "4")
//            {
//                Console.WriteLine("Gostermek istediyiniz indeksi daxil edin: ");
//                int index = Convert.ToInt32(Console.ReadLine());


//                if (index >= 0 && index < languages.Count)
//                {
//                    Console.WriteLine(languages[index]);
//                }
//                else
//                {
//                    Console.WriteLine("Göstermek istediğiniz dil mevcud deyil");
//                }
//            }
//            else if (secim == "0")
//            {
//                Console.WriteLine("Proses sonlandirildi.");
//            }


//        } while (secim != "0");



//        static bool IsValidDilAdi(string dilAdi, List<string> diller)
//        {
//            if (string.IsNullOrEmpty(dilAdi) || char.IsDigit(dilAdi[0]) || dilAdi.Length <= 2 || LanguageNameRepeatCheck(dilAdi, diller))
//            {
//                Console.WriteLine("Daxil etdiyiniz ad uygun deyil.");
//                return false;

//            }
//            return true;

//        }

//        static bool LanguageNameRepeatCheck(string dilAdi, List<string> diller)
//        {
//            foreach (string dil in diller)
//            {
//                if (dil == dilAdi)
//                {
//                    return true; // Dil adı listede varsa, tekrarlanmis demekdir, bu sebebden true et
//                }
//            }
//            return false; // Dil adı listede yoxdursa, tekrarlanmayib demekdir, bu sebebden false et
//        }
//    }
//}












