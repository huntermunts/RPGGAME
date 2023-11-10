using UnrealBuildTool;

public class RPGGAMEEditorTarget : TargetRules
{
	public RPGGAMEEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("RPGGAME");
	}
}
