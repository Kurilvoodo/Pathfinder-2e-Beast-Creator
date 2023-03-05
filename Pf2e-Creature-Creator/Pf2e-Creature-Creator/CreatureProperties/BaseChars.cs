namespace Pf2e_Creature_Creator.CreatureProperties
{
    public class BaseChars
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public int ArmorClass { get; set; }
        public int HP { get; set; }
        public int Perception { get; set; }
        public int FortitudeSavingThrow { get; set; }
        public int ReflexSavingThrow { get; set; }
        public int WillSavingThrow { get; set; }

        public PropertyIncreasment ArmorClassProperty { get; set; }
        public PropertyIncreasment HPProperty { get; set; }
        public PropertyIncreasment PerceptionProperty { get; set; }
        public PropertyIncreasment FortitudePropertyProperty { get; set; }
        public PropertyIncreasment ReflexPropertyProperty { get; set; }
        public PropertyIncreasment WillSavingPropertyProperty { get; set; }
    }
}