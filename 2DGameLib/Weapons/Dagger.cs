namespace _2DGameLib.Weapons
{
    public class Dagger : DefenseItem
    {
        public override string Name
        {
            get { return "Dagger"; }
        }

        public override int Damage
        {
            get { return 45; }
        }

        public override string Description
        {
            get { return "The sharpest dagger ever made."; }
        }
    }
}