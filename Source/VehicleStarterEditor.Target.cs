// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class VehicleStarterEditorTarget : TargetRules
{
	public VehicleStarterEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;

        ExtraModuleNames.AddRange( new string[] { "VehicleStarter" } );
	}
}
