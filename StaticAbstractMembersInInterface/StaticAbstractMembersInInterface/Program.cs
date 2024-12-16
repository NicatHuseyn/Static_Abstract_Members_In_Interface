



////IWorker.A();
////_ =IWorker.B;


//// Worker class-ı ilə
//Worker.A();
//_ =Worker.B;

//IWorker.C();
//_ = IWorker.D;
//_ = IWorker._e;

//interface IWorker
//{
//    #region Static Abstarct Members
//    // Static Abstract Member Method
//    static abstract void A();

//    //Static Abstract Member Property
//    static abstract int B { get; }
//    #endregion


//    #region Static Members
//    // Static Member Method
//    static void C() { }

//    //Static Member Property
//    static string D { get; }

//    // Static Member Field
//    static string _e;
//    #endregion
//}


//class Worker : IWorker
//{
//    public static int B => throw new NotImplementedException();

//    public static void A()
//    {
//        throw new NotImplementedException();
//    }
//}





//#region Static Abstract Members in Generic structure


//Worker<XWorker> worker = new Worker<XWorker>();

//interface IWorker
//{
//    static abstract void A();
//    static abstract void B();

//    static abstract string C {  get; }
//    static abstract string D {  get; }

//    static void E() { }
//    static string F {  get; }
//}


//class Worker<T> where T :IWorker
//{
//    public Worker()
//    {
//        T.A();
//        T.B();
//        _= T.C;
//        _ = T.D;
//    }
//}


//class XWorker : IWorker
//{
//    public static string C => "C property";

//    public static string D => "D property";

//    public static void A()
//    {
//        Console.WriteLine("A Static Method");
//    }

//    public static void B()
//    {
//        Console.WriteLine("B Static Method");
//    }
//}

//#endregion 


//#region Static Abstract Members In Generic Structures
//MyClass<Test> myClass = new MyClass<Test>();


//class MyClass<T> where T : ITest, new()
//{
//    public MyClass()
//    {
//        T t1 = new();
//        T t2 = new();

//        _ = +t1;
//        _ = t1 + t2;
//        _ = t1 + new A();
//        _ = -t1;
//        _ = t1 - t2;
//        _ = t1 * t2;
//        _ = t1 / t2;
//        _ = t1 * new B();

//    }
//}


//class Test : ITest
//{
//    int ITest.Value => 5;

//    static int ITest.operator +(ITest test) => test.Value + 1;

//    static int ITest.operator +(ITest test, ITest test1) => test.Value + test1.Value;

//    static int ITest.operator +(ITest test, A a) => test.Value + a.a;

//    static int ITest.operator -(ITest test) => test.Value - 5;

//    static int ITest.operator -(ITest test, ITest test1) => test.Value - test1.Value;

//    static long ITest.operator *(ITest test, ITest test1) => test.Value * test1.Value;

//    static int ITest.operator *(ITest test, B b) => test.Value * b.b;

//    static decimal ITest.operator /(ITest test, ITest test1) => test.Value / test1.Value;
//}


//interface ITest
//{
//    int Value { get; }
//    static abstract int operator +(ITest test);
//    static abstract int operator -(ITest test);
//    static abstract int operator +(ITest test, ITest test1);
//    static abstract int operator -(ITest test, ITest test1);
//    static abstract long operator *(ITest test, ITest test1);
//    static abstract decimal operator /(ITest test, ITest test1);
//    static abstract int operator +(ITest test, A a);
//    static abstract int operator *(ITest test, B b);
//}
//class A { public int a; }
//class B { public int b; }

//#endregion



#region Static Abstract Members Operators' Explicit and Implicit Implementation


class Test : ITest<Test>
{
    public static implicit operator string(Test t) => "";

    public static implicit operator Test(string s) => new();

    public static implicit operator int(Test t) => 1;

    public static implicit operator Test(int i)=> new();

    public static implicit operator A(Test a) => new();

    public static implicit operator Test(A s) => new();
}



interface ITest<T> where T: ITest<T>
{
    static abstract implicit operator string(T t);
    static abstract implicit operator T(string s);
    static abstract implicit operator int(T t);
    static abstract implicit operator T(int i);
    static abstract implicit operator A(T a);
    static abstract implicit operator T(A s);
}
class A{ public int a; }

#endregion