namespace _2DGameLib.Weapons
{
    public class CrossBow : DefenseItem
    {
        public override string Name
        {
            get { return "Crossbow"; }
        }

        public override int Damage
        {
            get { return 60; }
        }

        public override string Description
        {
            get { return "Smoothest cross bow in existence!"; }
        }
    }
}