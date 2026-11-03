namespace UnityEngine.Rendering;

[Token(Token = "0x2000126")]
internal struct ProbeDilationSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400055F")]
	public bool enableDilation; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000560")]
	public float dilationDistance; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000561")]
	public float dilationValidityThreshold; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000562")]
	public int dilationIterations; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000563")]
	public bool squaredDistWeighting; //Field offset: 0x10

	[Address(RVA = "0x2C14D60", Offset = "0x2C14160", Length = "0x1D")]
	[Token(Token = "0x6000A49")]
	internal void SetDefaults() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A4A")]
	internal void UpgradeFromTo(SettingsVersion from, SettingsVersion to) { }

}

