﻿using Microsoft.Xna.Framework;
using System.ComponentModel;
using Terraria.ModLoader.Config;

// This file defines custom data type that represents Gradient data type that can be used in ModConfig classes.
namespace ExampleMod.Common.Configs.CustomDataTypes
{
	[TooltipKey("$Mods.ExampleMod.Configs.Common.Gradient.Tooltip")]
	public class Gradient
	{
		[TooltipKey("$Mods.ExampleMod.Configs.Common.Gradient.start.Tooltip")]
		[DefaultValue(typeof(Color), "0, 0, 255, 255")]
		public Color start = Color.Blue; // For sub-objects, you'll want to make sure to set defaults in constructor or field initializer.
		[TooltipKey("$Mods.ExampleMod.Configs.Common.Gradient.end.Tooltip")]
		[DefaultValue(typeof(Color), "255, 0, 0, 255")]
		public Color end = Color.Red;

		public override bool Equals(object obj) {
			if (obj is Gradient other)
				return start == other.start && end == other.end;
			return base.Equals(obj);
		}

		public override int GetHashCode() {
			return new { start, end }.GetHashCode();
		}
	}
}
