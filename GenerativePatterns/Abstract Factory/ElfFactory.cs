namespace GenerativePatterns.Abstract_Factory
{
    // Фабрика создания летящего героя с арбалетом
    public class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
