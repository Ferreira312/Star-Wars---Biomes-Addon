using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
	public class BiomeWorker_YavinIV : BiomeWorker
	{
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature < 20f)
			{
				return 0f;
			}
			if (tile.rainfall < 1500f)
			{
				return 0f;
			}
			return 28f + (tile.temperature - 20f) * 1.5f + (tile.rainfall - 600f) / 165f;
		}
	}
}