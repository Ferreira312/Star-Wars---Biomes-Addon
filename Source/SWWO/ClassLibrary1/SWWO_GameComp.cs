using Verse;
using System;

namespace SWWO
{
    public class SWWO_GameComp : GameComponent
    {
        public static AxialTilt axialTilt = AxialTilt.Normal;
        public static WorldType worldType = WorldType.Vanilla;
        public static string worldPreset = "Planets.Vanilla";

        public static int subcount = 10;

        public SWWO_GameComp()
        {
        }

        public SWWO_GameComp(Game game)
        {
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref axialTilt, "axialTilt", AxialTilt.Normal, true);
            Scribe_Values.Look(ref worldType, "worldType", WorldType.Vanilla, true);
            Scribe_Values.Look(ref subcount, "subcount", 10, true);
            Scribe_Values.Look(ref worldPreset, "worldPreset", "Planets.Vanilla", true);
        }
    }

    public enum WorldType
    {
        Waterworld,
        Islands,
        Earthlike,
        Vanilla,
        Dry,
        VeryDry,
        Barren
    }

    public enum AxialTilt
    {
        VeryLow,
        Low,
        Normal,
        High,
        VeryHigh
    }

    public static class AxialTiltUtility
    {
        private static int cachedEnumValuesCount = -1;

        public static int EnumValuesCount
        {
            get
            {
                if (AxialTiltUtility.cachedEnumValuesCount < 0)
                {
                    AxialTiltUtility.cachedEnumValuesCount = Enum.GetNames(typeof(AxialTilt)).Length;
                }
                return AxialTiltUtility.cachedEnumValuesCount;
            }
        }
    }

    
}

