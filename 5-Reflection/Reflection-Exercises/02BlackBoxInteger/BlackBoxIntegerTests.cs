namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    class BlackBoxIntegerTests
    {
        static void Main()
        {
            Type blackBoxType = typeof(BlackBoxInt);
            ConstructorInfo constructor = blackBoxType
                .GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic, 
                null, 
                new Type[] { typeof(int) }, 
                null);
            BlackBoxInt blackBoxInstance = (BlackBoxInt)constructor.Invoke(new object[] { 0 });

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandArgs = input.Split('_');
                string command = commandArgs[0];
                int value = int.Parse(commandArgs[1]);

                MethodInfo methodInfo = blackBoxType.GetMethod(command, BindingFlags.NonPublic | BindingFlags.Instance);
                methodInfo.Invoke(blackBoxInstance, new object[] { value });

                FieldInfo innerValueInfo = blackBoxType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).First();
                int result = (int)innerValueInfo.GetValue(blackBoxInstance);
                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
