namespace _2DGameLib.Weapons
{
    public class Sword : AttackItem
    {
        public override string Name
        {
            get { return "Sword"; }
        }

        public override int Damage
        {
            get { return 75; }
        }

        public override string Description
        {
            get { return "A big sword"; }
        }

        public override int Range
        {
            get { return 50; }
        }
    }
}