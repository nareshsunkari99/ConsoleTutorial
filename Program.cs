using ConsoleTutorial.Casting;
using ConsoleTutorial.ClassObjectsDemo;
using ConsoleTutorial.ControlStatements;
using ConsoleTutorial.ExceptionHandling;
using ConsoleTutorial.MethodsDemo;
using ConsoleTutorial.OOPS;
using ConsoleTutorial.Variables;

class MyProgram
{
    static void Main()
    {
        // var number1 = (int)DemoOnVariables.ReadDemcimalInput();
        // var number2 = (int)DemoOnVariables.ReadDemcimalInput();
        //Console.WriteLine(number1+number2);
        //ifdemo.SimpleIf(number1, number2);
        //SwitchDemo.SwitchEx(20);
        //SwitchDemo.SwitchEx(280);
        //var input = Console.ReadLine();
        //Demoloops.fordemo(input);
        //DemoCasting demoCasting = new DemoCasting();
        //var demoCasting =new DemoCasting();
        //DemoCasting demoCasting = new();
        //var longint=demoCasting.ImplicitCasting(22);
        //var inttype=demoCasting.ExplicitCasting(23);
        //  int resultout=0;
        //  string myData = "";
        //  FunctionsDemo functionsDemo= new();
        //  functionsDemo.DemoOut(out resultout, 24, 35,out myData);
        //var result=  functionsDemo.SumSub(25, 24);
        //  int a = 10;
        //  functionsDemo.Demo(ref a);
        //for (int i = 0; ;i++)
        //{
        //    InstanceClass instanceClass = new InstanceClass(20, 30);
        //}
        //Console.WriteLine( instanceClass.sum());
        //SingleInheritance singleInheritance = new SingleInheritance();
        //singleInheritance.FromInheritanceDemo();
        //singleInheritance.FromSingleInheritance();

        //InheritanceDemo inheritanceDemo = new InheritanceDemo();
        //inheritanceDemo.FromInheritanceDemo();

        //InheritanceDemo inheritanceDemo1 = new SingleInheritance();
        //inheritanceDemo1.FromInheritanceDemo();

        // Error SingleInheritance singleInheritance1 = new InheritanceDemo();

        //MultiLevel multiLevel = new MultiLevel();
        //multiLevel.FromInheritanceDemo(); // base
        //multiLevel.FromSingleInheritance(); // base
        //multiLevel.FromMultiLevelInheritance();// child

        //FileOperations fileOperations = new();
        //fileOperations.FromInheritanceDemo();
        //fileOperations.Write("test");
        //fileOperations.Read();



        //Polymorphisam polymorphisam = new Polymorphisam();
        //polymorphisam.MethodOverloadingDemo(10);
        //polymorphisam.MethodOverloadingDemo(10,20);
        //polymorphisam.MethodOverloadingDemo("sana");

        //MyBase myBase = new MyBase();
        //myBase.MyMethod();

        //MyDerived myDerived =new MyDerived();
        //myDerived.MyMethod();

        //MyDerived1 myDerived1 = new MyDerived1();
        //myDerived1.MyMethod();

        //MyBase myBase1 = new MyDerived1();
        //myBase1.MyMethod();

        //Implementor implementor = new();
        //implementor.Implemented();
        //implementor.Details();

        ExceptionHandlingDemo exceptionHandlingDemo = new();
      Console.WriteLine(  exceptionHandlingDemo.Division(20,0));

        Console.WriteLine(exceptionHandlingDemo.Division(20, 10));

    }
}
