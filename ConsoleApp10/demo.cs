//namespace ConsoleApp10;

////class Student
////{

////}

//public partial class Point
//{
//    public int x { get; set; }
//    public int y { get; set; }
//    public Point(int x)
//    {
//        this.x = x;
//    }
//    public Point()
//    {

//    }
//    public Point(int x, int y) : this(x)
//    {
//        this.y = y;
//    }
//    public override string ToString()
//        => $"X:{x}-Y:{y}";
 
//}




//public partial class Point
//{
//    public static Point operator +(Point a, Point b)
//    {
//        Point temp = new Point();
//        temp.x = a.x + b.x;
//        temp.y = a.y + b.y;
//        return temp;
//    }
//    public static Point operator -(Point a, Point b)
//    {
//        Point temp = new Point();
//        temp.x = a.x - b.x;
//        temp.y = a.y - b.y;
//        return temp;
//    }
//    public static Point operator *(Point a, Point b)
//    {
//        Point temp = new Point();
//        temp.x = a.x * b.x;
//        temp.y = a.y * b.y;
//        return temp;
//    }
//    public static Point operator /(Point a, Point b)
//    {
//        Point temp = new Point();
//        if (b.x == 0 || b.y == 0)
//        {
//            throw new DivideByZeroException("X ve ya Y  0-olamaz");
//        }
//        temp.x = a.x / b.x;
//        temp.y = a.y / b.y;
//        return temp;
//    }
//    public void dangeriousmethod()
//    {
//        int[] array = new int[2];
//        array[0] = 0;
//        array[1] = 1;
//        Console.WriteLine(array[2]);
//    }
//}











