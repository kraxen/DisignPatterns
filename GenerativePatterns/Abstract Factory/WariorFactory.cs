namespace GenerativePatterns.Abstract_Factory
{
    // Фабрика создания бегущего героя с мечом
    public class WariorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
