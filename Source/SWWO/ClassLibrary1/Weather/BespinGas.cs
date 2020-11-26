using UnityEngine;
using Verse;

namespace WeatherOverlay
{
    [StaticConstructorOnStartup]
    public class WeatherOverlay_BespinGas : SkyOverlay
    {
        public static readonly Material BespinGasOverlayWorld = new Material(MatLoader.LoadMat("Weather/FogOverlayWorld", -1));

        public WeatherOverlay_BespinGas()
        {
            this.worldOverlayMat = WeatherOverlay_BespinGas.BespinGasOverlayWorld;

            this.worldPanDir1 = new Vector2(1f, 0f);
            this.worldPanDir2 = new Vector2(-1f, 0f);
            this.worldOverlayPanSpeed1 = 0.0004f;
            this.worldOverlayPanSpeed2 = 0.0004f;
        }


    }
}
