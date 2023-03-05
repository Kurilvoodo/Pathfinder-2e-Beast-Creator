using System.Reflection;
using System.Text;

namespace Pf2e_Creature_Creator.CreatureProperties
{
    public class Skills
    {
        public int? Acrobatics { get; set; }
        public int? Athletics { get; set; }
        public int? Aracana { get; set; }
        public int? Crafting { get; set; }
        public int? Deception { get; set; }
        public int? Diplomacy { get; set; }
        public int? Intimidation { get; set; }
        public int? Medicine { get; set; }
        public int? Nature { get; set; }
        public int? Occultism { get; set; }
        public int? Perfomance { get; set; }
        public int? Religion { get; set; }
        public int? Society { get; set; }
        public int? Stealth { get; set; }
        public int? Survival { get; set; }
        public int? Thievery { get; set; }

        public PropertyIncreasment? AcrobaticsProp { get; set; }
        public PropertyIncreasment? AthleticsProp { get; set; }
        public PropertyIncreasment? AracanaProp { get; set; }
        public PropertyIncreasment? CraftingProp { get; set; }
        public PropertyIncreasment? DeceptionProp { get; set; }
        public PropertyIncreasment? DiplomacyProp { get; set; }
        public PropertyIncreasment? IntimidationProp { get; set; }
        public PropertyIncreasment? MedicineProp { get; set; }
        public PropertyIncreasment? NatureProp { get; set; }
        public PropertyIncreasment? OccultismProp { get; set; }
        public PropertyIncreasment? PerfomanceProp { get; set; }
        public PropertyIncreasment? ReligionProp { get; set; }
        public PropertyIncreasment? SocietyProp { get; set; }
        public PropertyIncreasment? StealthProp { get; set; }
        public PropertyIncreasment? SurvivalProp { get; set; }
        public PropertyIncreasment? ThieveryProp { get; set; }
        public override string ToString()
        {
            StringBuilder response = new StringBuilder();

            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo propertyInfo in properties.Where(x =>
            {
                return !x.GetType().Equals(typeof(PropertyIncreasment));
            }))
            {
                _ = response.Append(propertyInfo.GetValue(this, null).ToString());
                response.Append(" ");
            }

            return response.ToString();
        }
    }
}