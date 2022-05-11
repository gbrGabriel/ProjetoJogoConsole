namespace ProjetoJogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Wizard()
        {

        }
        public override string Attack()
        {
            return $"{this.Name} Lançou magia";
        }
        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.Name} Lançou uma super magia +{bonus} de dano";
            }
            else
            {
                return $"{this.Name} Lançou magia +{bonus} de dano";
            }
        }
    }
}