using UnrealBuildTool;

public class DecPracticeServerTarget : TargetRules
{
	public DecPracticeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DecPractice");
	}
}
