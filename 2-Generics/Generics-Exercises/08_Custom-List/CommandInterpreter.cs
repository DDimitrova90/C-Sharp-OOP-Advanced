namespace _08_Custom_List
{
    using System;

    public class CommandInterpreter
    {
        private CustomList<string> customList;

        public CommandInterpreter()
        {
            this.customList = new CustomList<string>();
            this.IsRunning = true;
        }

        public bool IsRunning { get; set; }

        public void InterpredCommand(string input)
        {
            string[] commandArgs = input.Split(' ');
            string command = commandArgs[0];

            switch (command)
            {
                case "Add":
                    string element = commandArgs[1];
                    customList.Add(element);
                    break;
                case "Remove":
                    int index = int.Parse(commandArgs[1]);
                    customList.Remove(index);
                    break;
                case "Contains":
                    element = commandArgs[1];
                    bool containsItem = customList.Contains(element);
                    if (containsItem)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    break;
                case "Swap":
                    int firstIndex = int.Parse(commandArgs[1]);
                    int secondIndex = int.Parse(commandArgs[2]);
                    customList.Swap(firstIndex, secondIndex);
                    break;
                case "Greater":
                    element = commandArgs[1];
                    int count = customList.CountGreaterThan(element);
                    Console.WriteLine(count);
                    break;
                case "Max":
                    string maxElement = customList.Max();
                    Console.WriteLine(maxElement);
                    break;
                case "Min":
                    string minElement = customList.Min();
                    Console.WriteLine(minElement);
                    break;
                case "Print":
                    Console.WriteLine(customList.ToString());
                    break;
                case "END":
                    this.IsRunning = false;
                    break;
            }
        }
    }
}
