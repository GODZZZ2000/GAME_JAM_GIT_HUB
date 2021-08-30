// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GAME_JAM_GIT_HUBEditorTarget : TargetRules
{
	public GAME_JAM_GIT_HUBEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "GAME_JAM_GIT_HUB" } );
	}
}
