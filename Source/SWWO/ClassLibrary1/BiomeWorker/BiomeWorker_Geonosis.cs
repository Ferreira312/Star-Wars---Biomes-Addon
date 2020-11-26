using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Geonosis : BiomeWorker
	{
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
			{
				return -100f;
			}
			if (tile.temperature < 30 && tile.rainfall >= 600f)
			{
				return 0f;
			}
			return tile.temperature /2 +1 ;
		}
	}
}

