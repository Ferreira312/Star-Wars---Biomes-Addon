using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Dathomir : BiomeWorker
    {
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature < -10f)
			{
				return 0f;
			}
			if (tile.rainfall < 340f)
			{
				return 0f;
			}
			return 4f + (-tile.temperature - 3f) + (tile.rainfall - 600f) / 709.7f;
		}
	}
}
