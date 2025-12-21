using UnrealBuildTool;

public class DecPracticeTarget : TargetRules
{
	public DecPracticeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DecPractice");
	}
}
