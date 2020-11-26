using System;
using Verse;

namespace WeatherOverlay
{
    public static class TemperatureCheck
    {
        public static float SeasonalTempChange(int tile)
        {
            return Math.Abs(SWWO_TempTuning.SeasonalTempVariationCurve.Evaluate(Find.WorldGrid.DistanceFromEquatorNormalized(tile)));
        }
    }
}
