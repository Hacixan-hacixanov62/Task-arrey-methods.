
// Homework . Task 

//Method yazirsiz, Method stringden ibaret array ve char qebul edir. Method arrayin icerisinde gelen chardan 
//ne qederdirse onlarin sayini geriye qaytarsin.




int ResultOfNumber(string[] array, char a)
{
    int totalCount = 0;
    foreach (string str in array)
    {
        int charCount = 0;
        foreach(char c in str)
        {
            if (c == a)
            {
                charCount++;
            }
        }
        totalCount += charCount;

    }

    return totalCount;
}
string[] arr = { "city", "town" };
char a= 'c';

int count = ResultOfNumber(arr, a);
Console.WriteLine(count);








// Dersin Praktikasii.

//string WordBackwards(string word)
//{
//    char[] wordArrey = word.ToCharArray();
//    char[] wordBackwards = new char[0];

//    for ( int i =0; i < wordArrey.Length; i++)
//    {
//        Array.Resize(ref wordBackwards, word.Length + 1);
//        wordBackwards[i] = wordArrey[wordArrey.Length - 1 - i];

//    }
//    string result = new string(wordBackwards);
//    return result;
//}
////Console.WriteLine(WordBackwards("Salam"));


//void ReverseString(string input )
//{
//    char[] charArray = input.ToCharArray();
//    Array.Reverse(charArray);
//    string reversedString = new string(charArray);

//    Console.WriteLine(reversedString);

//}
//Console.WriteLine("please enter a string");
//string input = Console.ReadLine();
//ReverseString(input);


//string BackWords(string text)
//{
//    string result = " ";
//    for(var i=text.Length-1; i>=0;  i--)
//    {
//        result += text[i];
//    }
//    return result;
//}
//Console.WriteLine(BackWords("salam"));


//using System.Text;

//string name = "Reshad";

//name = "test";

// StringBuilder test = new("salam");

////test.Append("sagol");


//string data = Console.ReadLine();

//int result = int.Parse(data);

//Console.WriteLine(result);


//string data = Console.ReadLine();

//int responce ;

//bool isConvert = int.TryParse(data, out responce);

//if(isConvert)
//{
//    Console.WriteLine("Responce is----"+responce);

//}
//else
//{
//    Console.WriteLine("");

//}



//Data: string data = Console.ReadLine();

//int responce;

//bool isConvert = int.TryParse(data, out responce);

//if (isConvert)
//{
//    Console.WriteLine("Responce is----" + responce);

//}
//else
//{
//    Console.WriteLine("Format is wrong , please  add input again: ");
//    goto Data;
//}




//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye" };

//string[] arr2 = new string[8];

//string[] arr3 = new string[3] { "Ismayil", "Nesir", "Ayxan" };

//Console.WriteLine(names[names.Length-1]);

//Console.WriteLine(names[3]);

//for(int i=0; i<names.Length; i++)
//{
//    Console.WriteLine(i);

////}



//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);

//}


//foreach (var item in names)
//{

////}


//int[,] ums = { { 1, 2, 3 }, { 5, 6, 8 }, { 11, 22, 55 } };

//Console.WriteLine (nums[1.2]);


//int[,,] nums = { { { 3, 5 }, { 9, 0 }, { 150, 222 } }, { { 15044, 22 }, { 13, 21 }, { 1500, 22 } } };

//Console.WriteLine(nums[1,2,0]);



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye" };

//Console.WriteLine(names.Contains("Reshad"));




//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye" };

//var datas = names.Reverse().ToArray();
//Console.WriteLine(datas[datas.Length-1]);



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye" };

//var datas = names.Reverse().ToArray();

//foreach (var item in datas)
//{
//    Console.WriteLine(item);

////}



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye" };

//Array.Sort(names);

//foreach (var item in names)
//{
//    Console.WriteLine(item);

//}



//int[] nums = { 3, 5, 7, 8 };

//Array.Sort(nums);

//var datas = nums.Reverse().ToArray();

//foreach (var item in nums)
//{
//    Console.WriteLine(item);

//}



//int[] arr1 = { 1, 2, 3 }; 

//int[] arr2 = { 4, 5 };

//arr1.CopyTo(arr2, 0);



//int[] arr = { 1, 2, 3 };

//Array.Resize(ref arr, 5);

//arr[3] = 200;

//Console.WriteLine(arr[3]);


//string[] arr = { "sd", "sd" };

//Array.Resize(ref arr, 3);

//Console.WriteLine(arr[2]);



//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);  

//foreach (int item in arr2)
//{
//    Console.WriteLine( item );

//}

//arr1.CopyTo(arr2, 2);


//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);

//arr1.CopyTo(arr2, 2);

//foreach (int item in arr2)
//{
//    Console.WriteLine(item);

//}

////arr1.CopyTo(arr2, 2);



//int[] arr1 = { 1, 2, 3 };

//Array.Resize(ref arr1, 1);



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye" };

//var data = Array.Find(names, m => m == "Reshad");

//Console.WriteLine(data);



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye" };

//var data = Array.FindAll(names, m => m == "Reshad");

//foreach (var item in data)
//{
//    Console.WriteLine(item);

//}



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye","Reshad" };

//var data = Array.FindAll(names, m => m == "Reshad");

//Console.WriteLine(data.Length);





//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Fexriyye", "Reshad" };

//var data = Array.FindIndex(names, m => m == "Kamran");

//Console.WriteLine(data);



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide","Kamran" ,"Fexriyye", "Reshad" };

//var data = Array.FindLastIndex(names, m => m == "Kamran");

////Console.WriteLine(data);


//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide","Kamran" ,"Fexriyye", "Reshad" };

//var data = names.FirstOrDefault();

//Console.WriteLine(data);


//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var data = names.LastOrDefault();

//Console.WriteLine(data);



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var data = names.FirstOrDefault(m => m == "Kamran");

//Console.WriteLine(data);




//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var datas = names.All(m => m == "Reshad");

//Console.WriteLine(datas);




//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var datas = names.Any(m => m == "Reshad");

//Console.WriteLine(datas);




//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var data = Array.Exists(names, m => m == "Reshad");

//Console.WriteLine(data);



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var datas = names.Where(m => m == "Reshad").ToArray();

//foreach (var data in datas)
//{
//    Console.WriteLine(data);
//}



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var datas = names.OrderBy(m => m);

//foreach (var  item in datas)
//{
//    Console.WriteLine(item);

//}




//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//var datas = names.OrderByDescending(m => m);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);

//}



//string[] names = { "Hacixan", "Kamran", "Ilqar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye", "Reshad" };

//foreach (var item in names)
//{
//    Console.WriteLine(true);
//    break;

//}


//string[] names = { "Reshad", "Reshad", "Reshad" };

//bool CheckAllDatas(string[] datas, string str)
//{
//    int count = 0;

//    for(int i = 0; names.Length > i; i++)
//    {
//        if (names[i] == str)
//        {
//            count++;
//        }
//    }
//    if (count == names.Length)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//Console.WriteLine(CheckAllDatas(names, "Reshad"));


//DateTime date = DateTime.Now;

//Console.WriteLine(date);




//DateTime date = DateTime.Now.AddDays(10);

//Console.WriteLine(date);





//var date = DateTime.Now;

//Console.WriteLine(date.ToString ("MM-dd-yyyy  HH:mm "));




//var currentYear = DateTime.Now.Year;

//DateTime birthday = new DateTime(2002, 05, 25);

//var birthdayYear = DateTime.Now.Year;

//Console.WriteLine(currentYear -  birthdayYear);
