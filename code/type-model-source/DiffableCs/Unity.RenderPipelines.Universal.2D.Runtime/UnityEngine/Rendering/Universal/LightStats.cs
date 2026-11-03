namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000032")]
internal struct LightStats
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000100")]
	public int totalLights; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000101")]
	public int totalShadowLights; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000102")]
	public int totalShadows; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000103")]
	public int totalNormalMapUsage; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000104")]
	public int totalVolumetricUsage; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000105")]
	public int totalVolumetricShadowUsage; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000106")]
	public uint blendStylesUsed; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000107")]
	public uint blendStylesWithLights; //Field offset: 0x1C

	[Token(Token = "0x1700003C")]
	public bool useLights
	{
		[Address(RVA = "0x2B8B030", Offset = "0x2B8A430", Length = "0x7")]
		[Token(Token = "0x6000148")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000040")]
	public bool useNormalMap
	{
		[Address(RVA = "0x2D27D20", Offset = "0x2D27120", Length = "0x8")]
		[Token(Token = "0x600014C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700003D")]
	public bool useShadows
	{
		[Address(RVA = "0x2D27D30", Offset = "0x2D27130", Length = "0x8")]
		[Token(Token = "0x6000149")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700003E")]
	public bool useVolumetricLights
	{
		[Address(RVA = "0x22160F0", Offset = "0x22154F0", Length = "0x8")]
		[Token(Token = "0x600014A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700003F")]
	public bool useVolumetricShadowLights
	{
		[Address(RVA = "0x2D27D40", Offset = "0x2D27140", Length = "0x8")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2B8B030", Offset = "0x2B8A430", Length = "0x7")]
	[Token(Token = "0x6000148")]
	public bool get_useLights() { }

	[Address(RVA = "0x2D27D20", Offset = "0x2D27120", Length = "0x8")]
	[Token(Token = "0x600014C")]
	public bool get_useNormalMap() { }

	[Address(RVA = "0x2D27D30", Offset = "0x2D27130", Length = "0x8")]
	[Token(Token = "0x6000149")]
	public bool get_useShadows() { }

	[Address(RVA = "0x22160F0", Offset = "0x22154F0", Length = "0x8")]
	[Token(Token = "0x600014A")]
	public bool get_useVolumetricLights() { }

	[Address(RVA = "0x2D27D40", Offset = "0x2D27140", Length = "0x8")]
	[Token(Token = "0x600014B")]
	public bool get_useVolumetricShadowLights() { }

}

