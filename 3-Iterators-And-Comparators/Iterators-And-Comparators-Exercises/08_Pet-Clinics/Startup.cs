namespace _08_Pet_Clinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            int commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');
                string command = commandArgs[0];

                if (commandArgs.Length > 3)
                {
                    command = commandArgs[1];

                    if (command == "Pet")
                    {
                        CreatePet(commandArgs.Skip(2).ToArray(), pets);
                    }
                    else if (command == "Clinic")
                    {
                        try
                        {
                            CreateClinic(commandArgs.Skip(2).ToArray(), clinics);
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                    }
                }
                else
                {
                    if (command == "Add")
                    {
                        try
                        {
                            bool result = Add(commandArgs.Skip(1).ToArray(), pets, clinics);
                            Console.WriteLine(result);
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                    }
                    else if (command == "Release")
                    {
                        try
                        {
                            bool result = Release(commandArgs.Skip(1).ToArray(), clinics);
                            Console.WriteLine(result);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                    }
                    else if (command == "HasEmptyRooms")
                    {
                        try
                        {
                            bool result = HasEmptyRooms(commandArgs.Skip(1).ToArray(), clinics);
                            Console.WriteLine(result);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                        
                    }
                    else if (command == "Print")
                    {
                        try
                        {
                            Print(commandArgs.Skip(1).ToArray(), clinics);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                    }
                }
            }
        }

        private static void Print(string[] commandArgs, List<Clinic> clinics)
        {
            string clinicName = commandArgs[0];
            Clinic clinic = clinics.FirstOrDefault(c => c.Name == clinicName);

            if (commandArgs.Length == 1)
            {
                Console.WriteLine(clinic.PrintAll());
            }
            else if (commandArgs.Length == 2)
            {
                int room = int.Parse(commandArgs[1]);
                Console.WriteLine(clinic.PrintRoom(room));
            }
        }

        private static bool HasEmptyRooms(string[] commandArgs, List<Clinic> clinics)
        {
            string clinicName = commandArgs[0];
            Clinic clinic = clinics.FirstOrDefault(c => c.Name == clinicName);

            return clinic.HasEmptyRooms();
        }

        private static bool Release(string[] commandArgs, List<Clinic> clinics)
        {
            string clinicName = commandArgs[0];
            Clinic clinic = clinics.FirstOrDefault(c => c.Name == clinicName);

            return clinic.ReleasePet();
        }

        private static bool Add(string[] commandArgs, List<Pet> pets, List<Clinic> clinics)
        {
            string petsName = commandArgs[0];
            string clinicsName = commandArgs[1];

            Clinic clinic = clinics.FirstOrDefault(c => c.Name == clinicsName);
            Pet pet = pets.FirstOrDefault(p => p.Name == petsName);

            if (clinic == null || pet == null)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return clinic.AddPet(pet);
        }

        private static void CreateClinic(string[] clinicArgs, List<Clinic> clinics)
        {
            string name = clinicArgs[0];
            int roomsCount = int.Parse(clinicArgs[1]);
            List<Pet> rooms = new List<Pet>();

            for (int i = 0; i < roomsCount; i++)
            {
                rooms.Add(null);
            }

            Clinic clinic = new Clinic(name, rooms);
            clinics.Add(clinic);
        }

        private static void CreatePet(string[] petArgs, List<Pet> pets)
        {
            string name = petArgs[0];
            int age = int.Parse(petArgs[1]);
            string kind = petArgs[2];

            Pet pet = new Pet(name, age, kind);
            pets.Add(pet);
        }
    }
}
