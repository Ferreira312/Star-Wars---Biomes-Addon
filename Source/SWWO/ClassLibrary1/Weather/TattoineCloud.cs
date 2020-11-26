using UnityEngine;
using Verse;

namespace WeatherOverlay
{
    [StaticConstructorOnStartup]
    public class WeatherOverlay_TattoineCloud : SkyOverlay
    {
        public static readonly Material TattoineCloudOverlayWorld = new Material(MatLoader.LoadMat("Weather/FogOverlayWorld", -1));

        public WeatherOverlay_TattoineCloud()
        {

            this.worldOverlayMat = WeatherOverlay_TattoineCloud.TattoineCloudOverlayWorld;
                        
            this.worldPanDir1 = new Vector2(-1f, -0.26f);
            this.worldPanDir2 = new Vector2(-1f, -0.24f);
            this.worldOverlayPanSpeed1 = 0.00800000037997961f;
            this.worldOverlayPanSpeed2 = 0.0120000001043081f;
        }
    }
}
