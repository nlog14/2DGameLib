namespace _2DGameLib.Weapons
{
    class Sword : AttackItem
    {
        public override string Name
        {
            get { return "Sword"; }
        }

        public override int Damage
        {
            get { return 30; }
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