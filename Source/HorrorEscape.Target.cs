

using UnrealBuildTool;
using System.Collections.Generic;

public class HorrorEscapeTarget : TargetRules
{
	public HorrorEscapeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "HorrorEscape" } );
	}
}
