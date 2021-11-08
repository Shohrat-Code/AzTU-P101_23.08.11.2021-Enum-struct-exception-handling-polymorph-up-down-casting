using System;
using System.Reflection;

namespace EnumStructPolymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enum and Struct
            //Console.WriteLine("Select the season:");
            //Console.WriteLine("1. Yaz");
            //Console.WriteLine("2. Yay");
            //Console.WriteLine("3. Payiz");
            //Console.WriteLine("4. Qis");

            //byte choise = Convert.ToByte(Console.ReadLine());

            //switch (choise)
            //{
            //    case (byte)Season.yaz:
            //        Console.WriteLine("Yaz");
            //        break;
            //    case (byte)Season.yay:
            //        Console.WriteLine("Yay");
            //        break;
            //    case (byte)Season.payiz:
            //        Console.WriteLine("Payiz");
            //        break;
            //    case (byte)Season.qis:
            //        Console.WriteLine("Qis");
            //        break;
            //    default:
            //        Console.WriteLine("Choose correct season");
            //        break;
            //}

            //string name = "Rasim";
            //Console.WriteLine(name.CompareString("rasim", Cases.CaseInSensative)); ;

            //MyInt32 myInt32 = new MyInt32("Int32", "int", "26513654");

            //Console.WriteLine(myInt32._alias);

            //Console.WriteLine(Int32.MaxValue);
            #endregion

            #region Exception handling
            //Console.WriteLine(Sum(5, 10));

            //Nullable<int> number = null;

            //Console.Write("Number 1:");
            ////int number1 = Convert.ToInt32(Console.ReadLine());
            //if (!int.TryParse(Console.ReadLine(), out int number1))
            //{
            //    Console.WriteLine("NUmber 1 must be interger");
            //    return;
            //}


            //Console.Write("Number 2:");
            //if (!int.TryParse(Console.ReadLine(), out int number2))
            //{
            //    Console.WriteLine("NUmber 2 must be interger");
            //    return;
            //}

            //Console.WriteLine(Sum(number1, number2));


            //try
            //{
            //    //Console.WriteLine("Number 1:");
            //    //int a = Convert.ToInt32(Console.ReadLine());
            //    //int b = 10 / a;
            //    //Console.WriteLine($"Number is {b}");

            //    int[] arr = new int[2];
            //    arr[0] = 15;
            //    arr[1] = 24;
            //    arr[2] = 78;

            //}
            //catch (DivideByZeroException zero)
            //{
            //    Console.WriteLine($"Devide by zero exception:{zero.Message}");
            //}
            //catch (FormatException format)
            //{
            //    Console.WriteLine($"Format exception:{format.Message}");
            //}
            //catch (IndexOutOfRangeException index)
            //{
            //    Console.WriteLine($"Index out exception:{index.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}

            #endregion

            #region Reflection
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine($"{assembly.Location} //// {assembly.FullName}");

            //Type[] types= assembly.GetTypes();

            //foreach (var type in types)
            //{
            //    Console.WriteLine($"Name: {type.Name}; Fullname: {type.FullName}; Base: {type.BaseType}; Assemble: {type.Assembly}");
            //}

            //Type type = typeof(A);
            //Console.WriteLine(type.Name);
            //Console.WriteLine("***********************");

            //PropertyInfo[] properties= type.GetProperties();
            //foreach (var item in properties)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.WriteLine("");
            //Console.WriteLine("--------------------------");

            //MethodInfo[] methods= type.GetMethods();
            //foreach (var item in methods)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region Polymorphism
           

            Shape[] shapes = new Shape[3];

            //Shape shape1 = new Circle();
            //shape1.Fill();

            //Circle circle = (Circle)shape1;
            Shape shape = new Shape();
            //shape.Fill();

            Circle circle = new Circle();
            //circle.Fill();

            Rectangle rectangle = new Rectangle();

            //rectangle.Fill();

            shapes[0] = shape;
            shapes[1] = circle;
            shapes[2] = rectangle;

            foreach (var item in shapes)
            {
                item.Fill();
                ((Circle)item).GetRadius();

                //if (item is Circle)
                //{
                //    Console.WriteLine(((Circle)item).GetRadius());
                //}

                //if (item is Rectangle)
                //{
                //    Console.WriteLine(((Rectangle)item).GetDiagonal());
                //}
            }

            #endregion
        }


        static int Sum(int? a, int? b)
        {
            if (a == null || b == null)
            {
                Console.WriteLine("You can not enter null value");
                return 0;
            }

            return (int)a + (int)b;
        }
    }

    //struct Coordinate
    //{
    //    public int x;
    //    public int y;

    //    public Coordinate(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}
    struct MyInt32
    {
        public string _name;
        public string _alias;
        public string _maxValue;
        public MyInt32(string name, string alias, string maxValue)
        {
            this._name = name;
            this._alias = alias;
            this._maxValue = maxValue;
        }

    }
    enum Season
    {
        yaz = 1,
        yay,
        payiz,
        qis
    }
    public enum Cases
    {
        CaseSensative,
        CaseInSensative,
        UpperCase,
        LowerCase
    }
    class A
    {
        public string name;
        public int Id { get; set; }
        public string Surname { get; set; }

        //public void Show()
        //{
        //    Console.WriteLine("Show");
        //}
        //public void get_Id()
        //{
        //    Console.WriteLine("jkdfvn");
        //}
    }
    class B : A
    {
        public string Address{ get; set; }
    }

    class Shape
    {
        public virtual void Fill()
        {
            Console.WriteLine("Fill shape");
        }
    }

    class Circle:Shape
    {
        public override void Fill()
        {
            Console.WriteLine("Fill circle"); ;
        }

        public int GetRadius()
        {
            return 15;
        }
    }

    class Rectangle : Shape {
        public override void Fill()
        {
            Console.WriteLine("Fill rectangle");
        }

        public int GetDiagonal()
        {
            return 32;
        }
    }
}
