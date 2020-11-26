using System;
using Verse;

namespace SWWO
{
	public static class SWWO_Temp
	{
		public static SimpleCurve SeasonalTempVariationCurve;

		static SWWO_Temp()
		{
			SetSeasonalCurve();
		}

		public static void SetSeasonalCurve()
		{
			if (SWWO_GameComp.axialTilt == AxialTilt.VeryLow)
			{
				SimpleCurve veryLowTilt = new SimpleCurve()
				{
					{ new CurvePoint(0f, 0.75f), true },
					{ new CurvePoint(0.1f, 1f), true },
					{ new CurvePoint(1f, 7f), true }
				};
				SWWO_Temp.SeasonalTempVariationCurve = veryLowTilt;
			}
			else if (SWWO_GameComp.axialTilt == AxialTilt.Low)
			{
				SimpleCurve lowTilt = new SimpleCurve()
				{
					{ new CurvePoint(0f, 1.5f), true },
					{ new CurvePoint(0.1f, 2f), true },
					{ new CurvePoint(1f, 14f), true }
				};
				SWWO_Temp.SeasonalTempVariationCurve = lowTilt;
			}
			else if (SWWO_GameComp.axialTilt == AxialTilt.Normal)
			{
				SimpleCurve normalTilt = new SimpleCurve()
				{
					{ new CurvePoint(0f, 3f), true },
					{ new CurvePoint(0.1f, 4f), true },
					{ new CurvePoint(1f, 28f), true }
				};
				SWWO_Temp.SeasonalTempVariationCurve = normalTilt;
			}
			else if (SWWO_GameComp.axialTilt == AxialTilt.High)
			{
				SimpleCurve highTilt = new SimpleCurve()
				{
					{ new CurvePoint(0f, 4.5f), true },
					{ new CurvePoint(0.1f, 6f), true },
					{ new CurvePoint(1f, 42f), true }
				};
				SWWO_Temp.SeasonalTempVariationCurve = highTilt;
			}
			else
			{
				SimpleCurve veryHighTilt = new SimpleCurve()
				{
					{ new CurvePoint(0f, 6f), true },
					{ new CurvePoint(0.1f, 8f), true },
					{ new CurvePoint(1f, 56f), true }
				};
				SWWO_Temp.SeasonalTempVariationCurve = veryHighTilt;
			}
		}
	}
	public static class TemperatureCheck
	{
		public static float SeasonalTempChange(int tile)
		{
			return Math.Abs(SWWO_Temp.SeasonalTempVariationCurve.Evaluate(Find.WorldGrid.DistanceFromEquatorNormalized(tile)));
		}
	}

}

