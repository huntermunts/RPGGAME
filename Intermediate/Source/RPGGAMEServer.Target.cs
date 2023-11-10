using UnrealBuildTool;

public class RPGGAMEServerTarget : TargetRules
{
	public RPGGAMEServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("RPGGAME");
	}
}
