// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GAME_JAM_GIT_HUBTarget : TargetRules
{
	public GAME_JAM_GIT_HUBTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "GAME_JAM_GIT_HUB" } );
	}
}
