namespace UnityEngine.Rendering;

[Token(Token = "0x20003DF")]
public struct RasterState : IEquatable<RasterState>
{
	[Token(Token = "0x4000CA7")]
	public static readonly RasterState defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CA8")]
	private CullMode m_CullingMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CA9")]
	private int m_OffsetUnits; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CAA")]
	private float m_OffsetFactor; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000CAB")]
	private byte m_DepthClip; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x4000CAC")]
	private byte m_Conservative; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000CAD")]
	private byte m_Padding1; //Field offset: 0xE
	[FieldOffset(Offset = "0xF")]
	[Token(Token = "0x4000CAE")]
	private byte m_Padding2; //Field offset: 0xF

	[Address(RVA = "0x30C3330", Offset = "0x30C2730", Length = "0x9E")]
	[Token(Token = "0x6001DC9")]
	private static RasterState() { }

	[Address(RVA = "0x30C33D0", Offset = "0x30C27D0", Length = "0x90")]
	[Token(Token = "0x6001DC5")]
	public RasterState(CullMode cullingMode = 2, int offsetUnits = 0, float offsetFactor = 0, bool depthClip = true) { }

	[Address(RVA = "0x30C3150", Offset = "0x30C2550", Length = "0x5E")]
	[Token(Token = "0x6001DC6")]
	public override bool Equals(RasterState other) { }

	[Address(RVA = "0x30C31B0", Offset = "0x30C25B0", Length = "0x10B")]
	[Token(Token = "0x6001DC7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30C32C0", Offset = "0x30C26C0", Length = "0x68")]
	[Token(Token = "0x6001DC8")]
	public virtual int GetHashCode() { }

}

