using UnityEngine;
using Verse;

namespace WeatherOverlay
{
    [StaticConstructorOnStartup]
    public class WeatherOverlay_TattoineDust : SkyOverlay
    {
        public static readonly Material TattoineDustOverlayWorld = new Material(MatLoader.LoadMat("Weather/SnowOverlayWorld", -1));

        public WeatherOverlay_TattoineDust()
        {

            this.worldOverlayMat = WeatherOverlay_TattoineDust.TattoineDustOverlayWorld;

            this.worldPanDir1 = new Vector2(-1f, -0.26f);
            this.worldPanDir2 = new Vector2(-1f, -0.24f);
            this.worldOverlayPanSpeed1 = 0.02f;
            this.worldOverlayPanSpeed2 = 0.02f;
        }
    }
}