namespace Jogo.RPG.Entities
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
            return this.Name + "Lançou  sua magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + "Lançou com bonus de ataque " + Bonus;
            }
            else
            {

                return this.Name + "Lançou com força fraca " + Bonus;
            }

        }
    }
}
