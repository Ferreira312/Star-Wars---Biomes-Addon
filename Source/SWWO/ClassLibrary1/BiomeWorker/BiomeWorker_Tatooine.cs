using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Tatooine : BiomeWorker
    {
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.rainfall < 170f)
			{
				return 0f;
			}
			if (tile.temperature > 0f && (tile.rainfall / tile.temperature < 16f))
			{
				return 0f;
			}
			return (tile.temperature + 0.0002f) + 1;
		}
	}
}
