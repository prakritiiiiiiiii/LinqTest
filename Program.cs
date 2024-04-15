using LinqTest.Model;
using System.Collections;
using System.Collections.Generic;

//Queue<string> names = new Queue<string>();
//names.Enqueue("NASA");
//names.Enqueue("ASA");
//names.Enqueue("PASA");
//names.Enqueue("LASA");

//Console.WriteLine(names.Peek());
//Console.WriteLine(names.Dequeue());
//Console.WriteLine(names.Dequeue());
//Console.WriteLine(names.Dequeue());
//Console.WriteLine(names.Dequeue());





//Dictionary<string,string> Contacts = new Dictionary<string,string>();
//Contacts.Add("Nikhil", "9818123456");
//Contacts.Add("Sikhil", "9818123457");
//Contacts.Add("Dinesh", "9818123458");
//Contacts.Add("Dinesh1", "9818123458");
//Contacts.Add("Tinesh", "9818123459");
//Contacts.Add("Prashant", "9818123050");
//Contacts.Add("Ashant", "98189876549");




//foreach (var contact in Contacts)
//{
//    Console.WriteLine(contact.Key + " : " + contact.Value);
//}

//bool hasPrashant = Contacts.ContainsKey("Prashant");

//if(hasPrashant == true)
//{
//    Console.WriteLine("There is Prashant in Contact book");
//}
//else
//{
//    Console.WriteLine("No Prashant ws found.");
//}

//Contacts.Remove("Prashant");


//foreach (var contact in Contacts)
//{
//    Console.WriteLine(contact.Key + " : " + contact.Value);
//}
//hasPrashant = Contacts.ContainsKey("Prashant");
//if (hasPrashant)
//{
//    Console.WriteLine("There is Prashant in Contact book");
//}
//else
//{
//    Console.WriteLine("No Prashant was found.");
//}






//List


List<Student> students = new List<Student>();
students.Add(new Student(1, "Prashant Bhandari", 67, "BCA", "Biratmode", 67000, new DateTime(2033, 02, 12)));
students.Add(new Student(2, "Nikhil Uprety", 38, "BCA", "Chitwan", 77000, new DateTime(2023, 11, 11)));
students.Add(new Student(3, "Dinesh Bhandari", 60, "BSc", "Kathmandu", 33000, new DateTime(2022, 12, 9)));
students.Add(new Student(4, "Rashmi Joshi", 11, "BCA", "Pokhara", 80000, new DateTime(2013, 9, 12)));
students.Add(new Student(5, "Uttam Rai", 69, "BBA", "Palpa", 57000, new DateTime(2022, 2, 10)));
students.Add(new Student(6, "Rajan Khanal", 22, "BBA", "Pokhara", 97000, new DateTime(2038, 9, 10))); ;


var collection = students.Where(x => x.Faculty == "BBA" || x.Faculty == "BCA").OrderBy(x => x.StudentName).ToList();

foreach (var student in collection)
{
    Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Rollno + " " + student.Faculty + " " + student.Address + " " + student.Fees + " " + student.JoinedDate);
}










////aggregate

//var collection = students.Where(x => x.Fees > 50000 && x.Address == "Pokhara"  ).ToList();

//foreach (var student in collection)
//{
//  Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Rollno + " " + student.Faculty + " " + student.Address + " " + student.Fees + " " + student.JoinedDate);

//}




//total fees using aggregate

//var group = students.First().Fees + students.Last().Fees;
//Console.WriteLine(group);


//var data = students.First();
//var data2 = students.Last();
//var result = data.Fees + data2.Fees;
//Console.WriteLine(result);













//var group =  students.OrderBy(x => x.Faculty).GroupBy(x=>x.Faculty);
//foreach (var studentg  in group)
//{
//    Console.WriteLine("Faculty : "+studentg.Key + " Total :" + studentg.Count() + "Total Fee :" + studentg.Sum(x => x.Fees) + "Max Fee" +  studentg.Max(x => x.Fees));
//    Console.WriteLine("-------------------------------------------------------");
//    foreach(var student in studentg)
//    {
//        Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Rollno + " " + student.Faculty + " " + student.Address + " " + student.Fees + " " + student.JoinedDate);
//    }
//    Console.WriteLine("-------------------------------------------------------");
//}




//var result = students.Take(2).Skip(1).ToList();
//foreach (var student in result)
//{
//    Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Rollno + " " + student.Faculty + " " + student.Address + " " + student.Fees + " " + student.JoinedDate);

//}




//var result = students.Select(x => x.Faculty).Distinct().ToList();

//foreach (var student in result)
//{
//   Console.WriteLine(student);
//}







//foreach (var student in students)
//{
//    Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Rollno + " " + student.Faculty + " " + student.Address + " " + student.Fees + " " + student.JoinedDate );
//}

//var result = students.Where( x => x.Faculty == "MCA" && x.StudentName.StartsWith("R")).ToList();


//foreach (var student in result)
//{
//    Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Rollno + " " + student.Faculty + " " + student.Address + " " + student.Fees + " " + student.JoinedDate);
//}





//static void PrintTable(List<Student> students)
//{
//    Console.WriteLine("┌─────┬───────────────────┬────────┬──────────┬─────────────────┬──────┬───────────────┐");
//    Console.WriteLine("│ ID  │ Name              │ Rollno │ Faculty  │ Address         │ Fees │ Joined Date   │");
//    Console.WriteLine("├─────┼───────────────────┼────────┼──────────┼─────────────────┼──────┼───────────────┤");

//    foreach (var student in students)
//    {
//        Console.WriteLine($"│ {student.StudentId,-4}│ {student.StudentName,-18}│ {student.Rollno,-7}│ {student.Faculty,-9}│ {student.Address,-16}│ {student.Fees,-5}│ {student.JoinedDate.ToString("yyyy-MM-dd"),-14}│");
//    }

//    Console.WriteLine("└─────┴───────────────────┴────────┴──────────┴─────────────────┴──────┴───────────────┘");
//}








//printfirst3

//var results = students.Take(3).ToList();
//PrintTable(results);




//fee min

//var result = students.Sum(x => x.Fees);

//Console.WriteLine(result);


















//where
//var details = students.Where(x => x.Faculty == "BCA" && x.Address== "Chitwan" ).ToList();
//PrintTable(details);



//bca std name rollno
//var details = students.Where(x => x.Faculty == "BCA").Select(x => new Studentdetails{ StudentName = x.StudentName, StudentRoll = x.Rollno }).ToList();

//foreach (var student in details)
//{
//    Console.WriteLine("Name :{0} Roll: {1}", student.StudentName, student.StudentRoll);
//}









//DateTime dateTime = DateTime.Now;

//Console.WriteLine(dateTime);
//Console.WriteLine("-------------------------");


//// Specific date

//DateTime specificDate = new DateTime(2001, 10, 2);

//var difference = dateTime - specificDate;
//Console.WriteLine(difference);

//var year = specificDate.Year;

//Console.WriteLine(year);
//Console.WriteLine(specificDate.ToString());
//Console.WriteLine("-------------------------");



//DateTime start = DateTime.Now;
//DateTime end = new DateTime(2001, 10, 2);

//TimeSpan diff = end - start;

//Console.WriteLine($"Difference in days: {diff.TotalDays}");
//Console.WriteLine($"Difference in hours: {diff.TotalHours}");
//Console.WriteLine($"Difference in minutes: {diff.TotalMinutes}");
//Console.WriteLine($"Difference in seconds: {diff.TotalSeconds}");





//String name = "Prakriti";
//String surname = "Uprety";
//String fullname = string.Concat(name, " ", surname);
//Console.WriteLine(fullname);
//Console.WriteLine(name.Length);
//Console.WriteLine(surname.Length);
//Console.WriteLine(fullname.Length);

//string sub = fullname.Substring(9);
//Console.WriteLine(sub);

//int index = fullname.IndexOf(surname);
//Console.WriteLine(index);

//string upper = fullname.ToUpper();
//string lower = fullname.ToLower();
//Console.WriteLine(upper);
//Console.WriteLine(lower);
//string replaced = fullname.Replace(name, "Nikhil"); // "Hello Universe"
//Console.WriteLine(replaced);

//string intern = "prakriti,prashant,rajan,nikhil,uttam";
//string[] internArray = intern.Split(",");

//String fatname = "          Prakriti          ";
//String trimname = fatname.TrimEnd();
//Console.WriteLine(trimname);

//bool startWith = fullname.EndsWith("Uprety");
//Console.WriteLine(startWith);

//String Description = "These are just a few examples, and there are many more methods available in the string class for various string operations.";

//Console.WriteLine(Description.Contains("Available",StringComparison.OrdinalIgnoreCase));
//Console.WriteLine(Description.Contains("THERE", StringComparison.Ordinal));
//Console.WriteLine(Description.Contains("experiment"));
//Console.WriteLine(Description.Contains("colin"));
//Console.WriteLine(Description.Contains("These are just a few examples"));

//string str1 = "Hello";
//string str2 = "hello";
//bool isEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // true
//int comparisonResult = str1.CompareTo(str2); // 0 (equal)
//Console.WriteLine(comparisonResult);
//Console.WriteLine(isEqual);

//string age = "23";
//string formatted = string.Format("Name: {0}, Age: {1}", name, age);
//Console.WriteLine(formatted);

//string joinName = string.Join(",", internArray);
//Console.WriteLine(joinName);

//string paddedname = name.PadLeft(22, '-');
//Console.WriteLine(paddedname);
//string str = "Hello";
//string paddedLeft = str.PadLeft(10, '-'); // "-----Hello"
//string paddedRight = str.PadRight(10, '-'); // "Hello-----"

//Console.WriteLine(paddedRight);
//Console.WriteLine(paddedLeft);
//char[] charArray = fullname.ToCharArray();
//foreach (char c in charArray)
//{
//    Console.WriteLine(c);
//}

//List<int> marks = new List<int>();
//marks.Add(9);
//marks.Add(9);
//marks.Add(9);
//marks.Add(9);
//marks.Add(19);
//marks.Add(90);
//marks.Add(41);
//marks.Add(52);
//marks.Add(52);
//marks.Add(83);
//marks.Add(24);
//marks.Add(24);
//marks.Add(75);
//marks.Add(26);
//marks.Add(26);
//marks.Add(77);
//marks.Add(28);
//marks.Add(19);
//marks.Add(19);
//marks.Add(60);
//marks.Add(91);

//List<int> marks2 = new List<int>();
//marks2.Add(9);
//marks2.Add(9);
//marks2.Add(9);
//marks2.Add(9);
//marks2.Add(19);
//marks2.Add(91);
//marks2.Add(41);
//marks2.Add(53);
//marks2.Add(53);
//marks2.Add(83);
//marks2.Add(25);
//marks2.Add(25);
//marks2.Add(75);
//marks2.Add(25);
//marks2.Add(29);
//marks2.Add(77);
//marks2.Add(29);
//marks2.Add(19);
//marks2.Add(19);
//marks2.Add(65);
//marks2.Add(91);


////displaynumber

//DisplayNumber result = marks.Aggregate(new DisplayNumber { From0to20 = 0, From20to50 = 0, From50to80 = 0, Above80 = 0 }, (acc, current) =>
//{
//    if (current > 0 && current <= 20)
//    {
//        acc.From0to20++;
//    }
//    else if (current > 20 && current <= 50)
//    {
//        acc.From20to50++;
//    }
//    else if (current > 50 && current <= 80)
//    {
//        acc.From50to80++;
//    }
//    else
//    {
//        acc.Above80++;
//    }

//    return acc;
//});

//Console.WriteLine("From 0 -> 20 : " + result.From0to20);
//Console.WriteLine("From 20 -> 50 : " + result.From20to50);
//Console.WriteLine("From 50 -> 80 : " + result.From50to80);
//Console.WriteLine("Above 80 : " + result.Above80);





////oddevenresult

////var oddevenresult = marks.Aggregate(new OddEvenResult { OddCount = 0, EvenCount = 0 }, (acc, curr) =>
////{
////    if (curr % 2 == 0)
////    {
////        acc.EvenCount++;
////    }
////    else
////    {
////        acc.OddCount++;
////    }
////    return acc;
////});

////Console.WriteLine("Even:" + oddevenresult.EvenCount);
////Console.WriteLine("Odd:" + oddevenresult.OddCount);





















////var sum = marks2.Aggregate(1, (acc, current) =>
////{
////    return acc * current;
////});

////Console.WriteLine(sum);


////where ____________________________________________

////var myMarks = marks.Where(x => x > 40 && x < 80).ToList();
////foreach(var mark in myMarks)
////{
////    Console.WriteLine(mark);
////}



////select_______________________________________________

////var myMarks = marks.Select(x => x * 2);
////foreach(var mark in myMarks)
////{
////    Console.WriteLine(mark);
////}



////var marksAscending = marks.OrderBy(x => x);
////foreach (var mark in marksAscending)
////{
////    Console.WriteLine(mark);    
////}
////var DistinctMarks = marks.Where(x=> x> 20 && x<30).Distinct().OrderBy(x=>x).ToList();

////foreach (var mark in DistinctMarks)
////{
////    Console.WriteLine(mark);
////}

////var groupedMarks = marks.GroupBy(m => m);

////foreach (var group in groupedMarks)
////{
////    Console.WriteLine($"Key: {group.Key}, Count: {group.Count()}");
////}

////var groupedMarks = marks.GroupBy(x => x);
////foreach (IGrouping<int,int> groupedMark in groupedMarks)
////{
////    Console.WriteLine($"Key : {groupedMark.Key}, Count: {groupedMark.Count()}");
////    foreach (var mark in groupedMark)
////    {
////        Console.WriteLine(mark);
////    }
////    Console.WriteLine("------------------------------");
//}

//var filteredmarks = marks.Where(x => x > 40).ToList();
//var subtractedmarks = filteredmarks.Select(x => x -10).ToList();
//var chunkmarks = marks.Chunk(3);

//Console.WriteLine(totalmarks);
//foreach (var chunk in chunkmarks)
//{
//    Console.WriteLine("------------------");
//    foreach (var mark in chunk)
//    {
//        Console.WriteLine(mark);
//    }
//}