namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D6")]
internal struct XblAchievementProgression
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007AD")]
	private readonly IntPtr requirements; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007AE")]
	private readonly SizeT requirementsCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007AF")]
	internal readonly TimeT timeUnlocked; //Field offset: 0x10

	[Address(RVA = "0x9E6CF0", Offset = "0x9E60F0", Length = "0x4D")]
	[Token(Token = "0x6000FBC")]
	internal T[] GetRequirements(Func<XblAchievementRequirement, T> ctor) { }

}

