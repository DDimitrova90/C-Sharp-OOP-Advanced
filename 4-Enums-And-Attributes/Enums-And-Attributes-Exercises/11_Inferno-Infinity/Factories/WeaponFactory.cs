namespace _11_Inferno_Infinity.Factories
{
    using Models.Weapons;
    using System;
    using System.Collections.Generic;

    public class WeaponFactory
    {
        public IWeapon GetWeapon(List<string> inputArgs)
        {
            string[] weaponArgs = inputArgs[0].Split(' ');
            string rarity = weaponArgs[0];
            string weaponType = weaponArgs[1];
            string weaponName = inputArgs[1];

            switch (weaponType)
            {
                case "Axe":
                    return new Axe(rarity, weaponName);
                case "Sword":
                    return new Sword(rarity, weaponName);
                case "Knife":
                    return new Knife(rarity, weaponName);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
