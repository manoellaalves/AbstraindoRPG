namespace AbstraindoRPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou com sua katana";
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + "ataque com força super afetiva com bonus de " + Bonus;
            } else {
                return this.Name + "ataque com força fraca de " + Bonus;
            }
        }
    }
}