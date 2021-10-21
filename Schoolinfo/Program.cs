using SchoolInfo;
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var school = new SchoolManager("Hay Aspet", 2005, "Tonoyan");
        Type myType = school.GetType();

        Console.WriteLine("---------------Members-------------");
        foreach (MemberInfo memberInfo in myType.GetMembers())
        {
            Console.WriteLine($"{memberInfo.MemberType} {memberInfo.Name}");
        }

        Console.WriteLine("---------------Methods-------------");
        object[] array = new object[] { "Pushkin", 2000, "Sargsyan" };
        MethodInfo[] methods = myType.GetMethods();
        methods[0].Invoke(school, null);

        MethodInfo[] methods2 = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        methods2[0].Invoke(school, null);




        foreach (MethodInfo method in myType.GetMethods())
        {
            Console.Write($"{method.ReturnType.Name} {method.Name} \n");
            ParameterInfo[] parameters = method.GetParameters();
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");

            }

        }

        Console.WriteLine("---------------Constructors-------------");
        foreach (ConstructorInfo constructors in myType.GetConstructors())
        {
            Console.Write(myType.Name + " (");
            ParameterInfo[] parameters = constructors.GetParameters();
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                if (i + 1 < parameters.Length)
                    Console.Write(", ");
            }
            Console.WriteLine(")");
        }
        Console.WriteLine("---------------Fields-------------:");
        foreach (FieldInfo field in myType.GetFields())
        {
            Console.WriteLine($"{field.FieldType} {field.Name}");
        }

        Console.WriteLine("---------------Properties-------------:");
        foreach (PropertyInfo property in myType.GetProperties())
        {
            Console.WriteLine($"{property.PropertyType} {property.Name}");
        }
    }
}