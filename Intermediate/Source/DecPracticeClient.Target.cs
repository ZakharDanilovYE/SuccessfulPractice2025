using UnrealBuildTool;

public class DecPracticeClientTarget : TargetRules
{
	public DecPracticeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DecPractice");
	}
}
