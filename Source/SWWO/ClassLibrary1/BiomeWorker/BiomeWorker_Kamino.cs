using RimWorld;
using RimWorld.Planet;

namespace SWWO.Biomes
{
    public class BiomeWorker_Kamino : BiomeWorker
    {
		public override float GetScore(Tile tile, int tileID)
		{
            if (!tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature < 10f && tile.temperature > -1f )
            {
                return 0f;
            }
            if (tile.rainfall < 340f && tile.rainfall >= 320f)
            {
                return 0f;
            }
            return (-tile.temperature + 33) / -287f;


        }
	}
}
