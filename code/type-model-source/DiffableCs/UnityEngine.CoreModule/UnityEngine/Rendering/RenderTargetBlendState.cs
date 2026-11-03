namespace UnityEngine.Rendering;

[Token(Token = "0x20003ED")]
public struct RenderTargetBlendState : IEquatable<RenderTargetBlendState>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CEF")]
	private byte m_WriteMask; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000CF0")]
	private byte m_SourceColorBlendMode; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000CF1")]
	private byte m_DestinationColorBlendMode; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000CF2")]
	private byte m_SourceAlphaBlendMode; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CF3")]
	private byte m_DestinationAlphaBlendMode; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000CF4")]
	private byte m_ColorBlendOperation; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000CF5")]
	private byte m_AlphaBlendOperation; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x4000CF6")]
	private byte m_Padding; //Field offset: 0x7

	[Token(Token = "0x17000469")]
	public static RenderTargetBlendState defaultValue
	{
		[Address(RVA = "0x30C5FA0", Offset = "0x30C53A0", Length = "0xF")]
		[Token(Token = "0x6001E41")]
		 get { } //Length: 15
	}

	[Address(RVA = "0x30C5F70", Offset = "0x30C5370", Length = "0x2F")]
	[Token(Token = "0x6001E42")]
	public RenderTargetBlendState(ColorWriteMask writeMask = 15, BlendMode sourceColorBlendMode = 1, BlendMode destinationColorBlendMode = 0, BlendMode sourceAlphaBlendMode = 1, BlendMode destinationAlphaBlendMode = 0, BlendOp colorBlendOperation = 0, BlendOp alphaBlendOperation = 0) { }

	[Address(RVA = "0x30C5D80", Offset = "0x30C5180", Length = "0x4E")]
	[Token(Token = "0x6001E43")]
	public override bool Equals(RenderTargetBlendState other) { }

	[Address(RVA = "0x30C5DD0", Offset = "0x30C51D0", Length = "0xE0")]
	[Token(Token = "0x6001E44")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30C5FA0", Offset = "0x30C53A0", Length = "0xF")]
	[Token(Token = "0x6001E41")]
	public static RenderTargetBlendState get_defaultValue() { }

	[Address(RVA = "0x30C5EC0", Offset = "0x30C52C0", Length = "0xA7")]
	[Token(Token = "0x6001E45")]
	public virtual int GetHashCode() { }

}

