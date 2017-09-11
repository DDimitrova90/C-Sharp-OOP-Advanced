namespace Skeleton.Models.TestModels
{
    using Interfaces;

    public class FakeWeapon : IWeapon
    {
        public int AttackPoints
        {
            get { return 10; }
        }

        public int DurabilityPoints
        {
            get { return 10; }
        }

        public void Attack(ITarget target)
        {
        }
    }
}
