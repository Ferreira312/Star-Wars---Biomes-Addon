using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Hoth : BiomeWorker
    {
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			float tempAdjust = TemperatureCheck.SeasonalTempChange(tileID);
			if (tile.temperature + tempAdjust > 3f)
			{
				return 0f;
			}
			return BiomeWorker_IceSheet.PermaIceScore(tile) + 1;
		}
	}
}
