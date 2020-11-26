using System;
using HugsLib;
using HugsLib.Settings;
using Verse;

namespace SWWO
{
	[StaticConstructorOnStartup]

	public class Settings : ModBase
	{

        public static SettingHandle<int> GasVelocity;

		public override string ModIdentifier
		{
			get
			{
				return "WeatherOverlay";
			}
		}

		public override void DefsLoaded()
		{
			GasVelocity = base.Settings.GetHandle<int>("gasVelocity", "Gas Velocity", string.Empty, 12, Validators.IntRangeValidator(0, 30), null);
						
		}

	}
}