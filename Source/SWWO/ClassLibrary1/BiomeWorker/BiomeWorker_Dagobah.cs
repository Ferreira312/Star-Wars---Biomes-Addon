using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Dagobah : BiomeWorker
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
			if (tile.swampiness < 0.5f)
			{
				return 0f;
			}
			float tempAdjust = TemperatureCheck.SeasonalTempChange(tileID);
			if (tile.temperature + tempAdjust < 18f)
			{
				return 0f;
			}
			return (18f + (tile.temperature - 1f) + (tile.rainfall - 600f) / 200f + tile.swampiness * 3f) +1;
		}

	}
}
