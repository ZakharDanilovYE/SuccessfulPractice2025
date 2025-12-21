using UnrealBuildTool;

public class DecPracticeEditorTarget : TargetRules
{
	public DecPracticeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DecPractice");
	}
}
