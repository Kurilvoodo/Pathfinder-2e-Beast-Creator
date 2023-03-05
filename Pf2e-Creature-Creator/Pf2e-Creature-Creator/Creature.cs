using Pf2e_Creature_Creator.CreatureProperties;

namespace Pf2e_Creature_Creator
{
    public class Creature
    {
        public BaseChars BaseCharacteristics { get; set; }
        public List<Skills> CreatureSkills { get; set; }
        public CharacteristicMods Mods { get; set; }
        public bool Elite { get; set; }
    }
}