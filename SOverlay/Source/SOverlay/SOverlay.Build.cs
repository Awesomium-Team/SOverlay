// Copyright 2022 Awesomium team LLC. All Rights Reserved.

using UnrealBuildTool;

public class SOverlay : ModuleRules
{
	public SOverlay(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(new string[] { });
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"Steamworks"
			}
		);
	}
}
