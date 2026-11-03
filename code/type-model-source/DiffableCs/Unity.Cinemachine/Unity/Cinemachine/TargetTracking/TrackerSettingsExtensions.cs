namespace Unity.Cinemachine.TargetTracking;

[Extension]
[Token(Token = "0x2000196")]
public static class TrackerSettingsExtensions
{

	[Address(RVA = "0x28A5CE0", Offset = "0x28A50E0", Length = "0x4B")]
	[Extension]
	[Token(Token = "0x6000865")]
	internal static Vector3 GetEffectivePositionDamping(TrackerSettings s) { }

	[Address(RVA = "0x28A5D30", Offset = "0x28A5130", Length = "0xC4")]
	[Extension]
	[Token(Token = "0x6000866")]
	internal static Vector3 GetEffectiveRotationDamping(TrackerSettings s) { }

	[Address(RVA = "0x28A5E00", Offset = "0x28A5200", Length = "0x16F")]
	[Extension]
	[Token(Token = "0x6000864")]
	public static float GetMaxDampTime(TrackerSettings s) { }

}

