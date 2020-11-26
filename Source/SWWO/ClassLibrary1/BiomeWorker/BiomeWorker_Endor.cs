using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Endor : BiomeWorker
    {
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature <= 5f || tile.temperature > 18f)
			{
				return 0f;
			}
			if (tile.rainfall < 600f)
			{
				return 0f;
			}
			float tempAdjust = TemperatureCheck.SeasonalTempChange(tileID);
			if (tile.temperature + tempAdjust < 18f)
			{
				return 0f;
			}
			return (15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 100f);
		}
	}
}

