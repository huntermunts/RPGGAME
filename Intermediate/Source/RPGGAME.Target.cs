using UnrealBuildTool;

public class RPGGAMETarget : TargetRules
{
	public RPGGAMETarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("RPGGAME");
	}
}
