namespace _11_Inferno_Infinity.Core
{
    using Factories;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandIntepreter
    {
        private WeaponFactory weaponFactory;
        private GemFactory gemFactory;
        private readonly IList<IWeapon> weapons;

        public CommandIntepreter()
        {
            this.IsRunning = true;
            this.weaponFactory = new WeaponFactory();
            this.gemFactory = new GemFactory();
            this.weapons = new List<IWeapon>();
        }

        public bool IsRunning { get; private set; }

        public void ReadCommand(string input)
        {
            List<string> inputArgs = input.Split(';').ToList();
            string command = inputArgs[0];
            inputArgs = inputArgs.Skip(1).ToList();

            switch (command)
            {
                case "Create":
                    this.weapons.Add(weaponFactory.GetWeapon(inputArgs));
                    break;
                case "Add":
                    Add(inputArgs);
                    break;
                case "Remove":
                    Remove(inputArgs);
                    break;
                case "Print":
                    string result = Print(inputArgs);
                    Console.WriteLine(result);
                    break;
                case "END":
                    this.IsRunning = false;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private string Print(List<string> inputArgs)
        {
            string weaponName = inputArgs[0];
            IWeapon weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
            weapon.CalculateStats();
            return weapon.ToString();
        }

        private void Remove(List<string> inputArgs)
        {
            string weaponName = inputArgs[0];
            int index = int.Parse(inputArgs[1]);

            IWeapon weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
            weapon.RemoveGem(index);
        }

        private void Add(List<string> inputArgs)
        {
            string weaponName = inputArgs[0];
            int index = int.Parse(inputArgs[1]);

            IWeapon weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
            IGem gem = gemFactory.GetGem(inputArgs[2]);
            weapon.AddGem(index, gem);  
        }
    }
}
