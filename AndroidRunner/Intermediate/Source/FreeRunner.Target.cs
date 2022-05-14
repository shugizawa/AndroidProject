using UnrealBuildTool;

public class FreeRunnerTarget : TargetRules
{
	public FreeRunnerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FreeRunner");
	}
}
