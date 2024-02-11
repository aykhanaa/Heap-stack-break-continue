
//AcademyWork

//int[] arr = { 1, 2, 3,6,8,9 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 3)
//    {
//        Console.WriteLine("Found -" + arr[i]);
//        break;
//    }

//}


//int[] arr = { 1, 2, 3, 6, 8, 9 };

//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)

//        count++;
//    {
//        if (count == 2)
//        {
//            Console.WriteLine("Found min 2 time- " + arr[i]);
//            break;
//        }
//    }
//}


//int n = 6;
//int count = 0;

//if (n < 2)
//{
//    Console.WriteLine("Ne sade, ne murekkeb");
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;

//            if (count == 3)
//            {
//                break;
//            }
//        }
//    }
//    if (count == 2)
//    {
//        Console.WriteLine("Sade");
//    }
//    else
//    {
//        Console.WriteLine("Murekkeb");
//    }
//}



//int a = 5;
//int b = a;

//b = 100;

//Console.WriteLine(a);
//Console.WriteLine(b);

//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = arr1;
//arr2[0] = 200;


//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 100;

//int[] arr2 = arr1;

//arr2[0] = arr1[0] + 5;

//arr2[0] = 200;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 100;

//int[] arr2 = arr1;

//arr2[0] = 200;

//arr2[0] = arr1[0] + arr2[0];

//Console.WriteLine(arr1[0]);
////Console.WriteLine(arr2[0]);

//string name = "test";
//string name2 = name;
//name2 = "salam";

//Console.WriteLine(name);
//Console.WriteLine(name2);

//string name1 = "salam";


//var age = "100";

//bool isMarried = false;

//int[] arr = { 1, 2, 3, 4, 5, };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;
//    }
//    if (arr[i] == 4)
//    {
//        break;
//    }
//    Console.WriteLine(arr[i]);

//}





//HomeWork






///1) n - ededinin faktorialini hesablayin.

//int n = 10;

//int result = 1;

//for (int i = n; i > 0; i--)
//{
//    result *= i;
////}
////Console.WriteLine(result);


///2) Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.

//int[] arr = { 1, 2, 4, 7, 8, 9 };
//int sum = 0;
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        sum += arr[i];
//    }
//}
//Console.WriteLine(sum * sum);


///3) n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin. Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir. Eks halda quvveti deil yazilsin.

//int n = 27;
//bool Quvvetidir = true;
//int count = 0;

//if (n < 0)
//{
//    Console.WriteLine("Quvveti deyil");
//}
//else
//{
//    for (int i = n; i > 1; i /= 2)
//    {
//        if (i % 2 !=0)
//        {
//            Console.WriteLine("Quvveti deyil");
//            Quvvetidir = false;
//            break;
//        }
//        count++;
//    }
//}
//    if (Quvvetidir == true)
//    {
//        Console.WriteLine(count);
//    }
