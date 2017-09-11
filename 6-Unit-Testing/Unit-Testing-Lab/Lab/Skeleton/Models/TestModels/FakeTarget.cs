namespace Skeleton.Models.TestModels
{
    using Interfaces;

    public class FakeTarget : ITarget
    {
        public int Health
        {
            get { return 10; }
        }

        public int GiveExperience()
        {
            return 10;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
        }
    }
}
