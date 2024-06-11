//Sabitler
//Const  - compile time sabit
//Readonly - run time sabitlerdir


//Const - mutleq sekilde yaranan zaman deyer alalidir
//Readonly - sonradan deyer ala biler ama bir defe

//using ConsoleApp10;
//using System.Xml;

////Point point1 = new Point(1, 5);
////Point point2 = new Point(2, 3);

////Point point3 = point1 + point2;
////Console.WriteLine(point3);

//Point point4 = new Point(1, 5);
//Point point5 = new Point(2, 0);


//Partial Class Partial class bir classin 1 nece hisseye bolunmesi adlanir
//yalniz 1 namespace icersinde olurlar ve eyni access modifieri alirlar



//try
//{
//    //point4.dangeriousmethod();
//    Point point6 = point4 / point5;
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



using ConsoleApp10;

Student student1 = new Student(1, "Nazim", "Nazimli", new DateTime(1894, 1, 1));
Student student2 = new Student(2, "Fazil", "Fazilli", new DateTime(1894, 3, 5));
Student student3 = new Student(3, "Taci", "Tacirli", new DateTime(1894, 8, 11));

List<Student> students = new List<Student>() { student1, student2, student3 };

Group group = new Group(1, "Hababam sinifi", students);
Console.WriteLine(group[2]);
