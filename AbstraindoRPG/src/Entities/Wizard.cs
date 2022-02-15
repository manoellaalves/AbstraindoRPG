namespace AbstraindoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + "lançou magia";
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + "lançou magia super afetiva com bonus de " + Bonus;
            } else {
                return this.Name + "Lançou magia com força fraca de " + Bonus;
            }
        }
    }
}