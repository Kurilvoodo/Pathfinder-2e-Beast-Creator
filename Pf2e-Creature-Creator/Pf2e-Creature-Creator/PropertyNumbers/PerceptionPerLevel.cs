using Pf2e_Creature_Creator.CreatureProperties;


namespace Pf2e_Creature_Creator.PropertyNumbers
{
    static class PerceptionPerLevel//ToDo: Wrong Numbers
    {
        public static int GetPerceptionByLevel(int level, PropertyIncreasment prop)
        {
            switch (level)
            {
                case -1:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 0;

                        case PropertyIncreasment.High: return 3;

                        case PropertyIncreasment.Middle: return 2;

                        case PropertyIncreasment.Low: return 0;
                        default: return -4;
                    }
                    break;
                case 0:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 0;

                        case PropertyIncreasment.High: return 3;

                        case PropertyIncreasment.Middle: return 2;

                        case PropertyIncreasment.Low: return 0;
                        default: return -5;
                    }
                    break;
                case 1:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 5;

                        case PropertyIncreasment.High: return 4;

                        case PropertyIncreasment.Middle: return 3;

                        case PropertyIncreasment.Low: return 1;
                        default: return -5;
                    }
                    break;
                case 2:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 5;

                        case PropertyIncreasment.High: return 4;

                        case PropertyIncreasment.Middle: return 3;

                        case PropertyIncreasment.Low: return 1;
                        default: return -5;
                    }
                    break;
                case 3:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 5;

                        case PropertyIncreasment.High: return 4;

                        case PropertyIncreasment.Middle: return 3;

                        case PropertyIncreasment.Low: return 1;
                        default: return -5;
                    }
                    break;
                case 4:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 6;

                        case PropertyIncreasment.High: return 5;

                        case PropertyIncreasment.Middle: return 3;

                        case PropertyIncreasment.Low: return 2;
                        default: return -5;
                    }
                    break;
                case 5:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 6;

                        case PropertyIncreasment.High: return 5;

                        case PropertyIncreasment.Middle: return 4;

                        case PropertyIncreasment.Low: return 2;
                        default: return -5;
                    }
                    break;
                case 6:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 7;

                        case PropertyIncreasment.High: return 5;

                        case PropertyIncreasment.Middle: return 4;

                        case PropertyIncreasment.Low: return 2;
                        default: return -5;
                    }
                    break;
                case 7:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 7;

                        case PropertyIncreasment.High: return 6;

                        case PropertyIncreasment.Middle: return 4;

                        case PropertyIncreasment.Low: return 2;
                        default: return -5;
                    }
                    break;
                case 8:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 7;

                        case PropertyIncreasment.High: return 6;

                        case PropertyIncreasment.Middle: return 4;

                        case PropertyIncreasment.Low: return 3;
                        default: return -5;
                    }
                    break;
                case 9:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 7;

                        case PropertyIncreasment.High: return 6;

                        case PropertyIncreasment.Middle: return 4;

                        case PropertyIncreasment.Low: return 3;
                        default: return -5;
                    }
                    break;
                case 10:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 8;

                        case PropertyIncreasment.High: return 7;

                        case PropertyIncreasment.Middle: return 5;

                        case PropertyIncreasment.Low: return 3;
                        default: return -5;
                    }
                    break;
                case 11:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 8;

                        case PropertyIncreasment.High: return 7;

                        case PropertyIncreasment.Middle: return 5;

                        case PropertyIncreasment.Low: return 3;
                        default: return -5;
                    }
                    break;
                case 12:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 8;

                        case PropertyIncreasment.High: return 7;

                        case PropertyIncreasment.Middle: return 5;

                        case PropertyIncreasment.Low: return 4;
                        default: return -5;
                    }
                    break;
                case 13:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 9;

                        case PropertyIncreasment.High: return 8;

                        case PropertyIncreasment.Middle: return 5;

                        case PropertyIncreasment.Low: return 4;
                        default: return -5;
                    }
                    break;
                case 14:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 9;

                        case PropertyIncreasment.High: return 8;

                        case PropertyIncreasment.Middle: return 5;

                        case PropertyIncreasment.Low: return 4;
                        default: return -5;
                    }
                    break;
                case 15:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 9;

                        case PropertyIncreasment.High: return 8;

                        case PropertyIncreasment.Middle: return 6;

                        case PropertyIncreasment.Low: return 4;
                        default: return -5;
                    }
                    break;
                case 16:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 10;

                        case PropertyIncreasment.High: return 9;

                        case PropertyIncreasment.Middle: return 6;

                        case PropertyIncreasment.Low: return 5;
                        default: return -5;
                    }
                    break;
                case 17:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 10;

                        case PropertyIncreasment.High: return 9;

                        case PropertyIncreasment.Middle: return 6;

                        case PropertyIncreasment.Low: return 5;
                        default: return -5;
                    }
                    break;

                case 18:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 10;

                        case PropertyIncreasment.High: return 9;

                        case PropertyIncreasment.Middle: return 6;

                        case PropertyIncreasment.Low: return 5;
                        default: return -5;
                    }
                    break;

                case 19:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 11;

                        case PropertyIncreasment.High: return 10;

                        case PropertyIncreasment.Middle: return 6;

                        case PropertyIncreasment.Low: return 5;
                        default: return -5;
                    }
                    break;
                case 20:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 11;

                        case PropertyIncreasment.High: return 10;

                        case PropertyIncreasment.Middle: return 7;

                        case PropertyIncreasment.Low: return 6;
                        default: return -5;
                    }
                    break;
                case 21:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 11;

                        case PropertyIncreasment.High: return 10;

                        case PropertyIncreasment.Middle: return 7;

                        case PropertyIncreasment.Low: return 6;
                        default: return -5;
                    }
                    break;

                case 22:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 11;

                        case PropertyIncreasment.High: return 10;

                        case PropertyIncreasment.Middle: return 8;

                        case PropertyIncreasment.Low: return 6;
                        default: return -5;
                    }
                    break;

                case 23:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 11;

                        case PropertyIncreasment.High: return 10;

                        case PropertyIncreasment.Middle: return 8;

                        case PropertyIncreasment.Low: return 6;
                        default: return -5;
                    }
                    break;
                case 24:
                    switch (prop)
                    {
                        case PropertyIncreasment.Extreme: return 13;

                        case PropertyIncreasment.High: return 12;

                        case PropertyIncreasment.Middle: return 9;

                        case PropertyIncreasment.Low: return 7;
                        default: return -5;
                    }
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
    }
}
