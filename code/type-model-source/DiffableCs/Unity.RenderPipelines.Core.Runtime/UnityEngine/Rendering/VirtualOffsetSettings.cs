namespace UnityEngine.Rendering;

[Token(Token = "0x2000127")]
internal struct VirtualOffsetSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000564")]
	public bool useVirtualOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Range(0, 0.95)]
	[Token(Token = "0x4000565")]
	public float validityThreshold; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Range(0, 1)]
	[Token(Token = "0x4000566")]
	public float outOfGeoOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Range(0, 2)]
	[Token(Token = "0x4000567")]
	public float searchMultiplier; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Range(-0.05, 0)]
	[Token(Token = "0x4000568")]
	public float rayOriginBias; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000569")]
	public LayerMask collisionMask; //Field offset: 0x14

	[Address(RVA = "0x2C1E5F0", Offset = "0x2C1D9F0", Length = "0x3D")]
	[Token(Token = "0x6000A4B")]
	internal void SetDefaults() { }

	[Address(RVA = "0x2C1E630", Offset = "0x2C1DA30", Length = "0x2F")]
	[Token(Token = "0x6000A4C")]
	internal void UpgradeFromTo(SettingsVersion from, SettingsVersion to) { }

}

