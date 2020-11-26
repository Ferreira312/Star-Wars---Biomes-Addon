using UnityEngine;
using Verse;

namespace WeatherOverlay
{
    [StaticConstructorOnStartup]
    public class WeatherOverlay_BespinGasStorm : SkyOverlay
    {
        public static readonly Material BespinGasStormOverlayWorld = new Material(MatLoader.LoadMat("Weather/FogOverlayWorld", -1));

        public WeatherOverlay_BespinGasStorm()
        {

            this.worldOverlayMat = WeatherOverlay_BespinGasStorm.BespinGasStormOverlayWorld;

            this.worldPanDir1 = new Vector2(-1f, -0.26f);
            this.worldPanDir2 = new Vector2(-1f, -0.24f);
            this.worldOverlayPanSpeed1 = 0.0006f;
            this.worldOverlayPanSpeed2 = 0.0009f;
        }
    }

}
