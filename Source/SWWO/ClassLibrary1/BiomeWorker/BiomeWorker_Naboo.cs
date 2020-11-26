using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Naboo : BiomeWorker
    {
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature < 15f)
			{
				return 0f;
			}
			if (tile.rainfall < 2000f)
			{
				return 0f;
			}
			if (tile.swampiness < 0.5f)
			{
				return 0f;
			}
			float tempAdjust = TemperatureCheck.SeasonalTempChange(tileID);
			if (tile.temperature - tempAdjust > 42f)
			{
				return 0f;
			}
			return 29f + (tile.temperature - 20f) * 50.7f + (tile.rainfall - 600f) / 165f + tile.swampiness * 3f ;
		}
	}
}
