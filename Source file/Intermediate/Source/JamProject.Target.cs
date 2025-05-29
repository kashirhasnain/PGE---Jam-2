using UnrealBuildTool;

public class JamProjectTarget : TargetRules
{
	public JamProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("JamProject");
	}
}
