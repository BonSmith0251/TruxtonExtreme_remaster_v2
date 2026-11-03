namespace UnityEngine.Rendering;

[Token(Token = "0x20003EB")]
public struct RenderStateBlock : IEquatable<RenderStateBlock>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CE2")]
	private BlendState m_BlendState; //Field offset: 0x0
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000CE3")]
	private RasterState m_RasterState; //Field offset: 0x44
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000CE4")]
	private DepthState m_DepthState; //Field offset: 0x54
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x4000CE5")]
	private StencilState m_StencilState; //Field offset: 0x56
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000CE6")]
	private int m_StencilReference; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CE7")]
	private RenderStateMask m_Mask; //Field offset: 0x68

	[Token(Token = "0x17000463")]
	public BlendState blendState
	{
		[Address(RVA = "0x30C5D20", Offset = "0x30C5120", Length = "0x25")]
		[Token(Token = "0x6001E35")]
		 set { } //Length: 37
	}

	[Token(Token = "0x17000465")]
	public DepthState depthState
	{
		[Address(RVA = "0x30C5D50", Offset = "0x30C5150", Length = "0x5")]
		[Token(Token = "0x6001E37")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000468")]
	public RenderStateMask mask
	{
		[Address(RVA = "0x30C5CE0", Offset = "0x30C50E0", Length = "0x6")]
		[Token(Token = "0x6001E3C")]
		 get { } //Length: 6
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x6001E3D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000464")]
	public RasterState rasterState
	{
		[Address(RVA = "0x30C5D60", Offset = "0x30C5160", Length = "0x8")]
		[Token(Token = "0x6001E36")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000467")]
	public int stencilReference
	{
		[Address(RVA = "0x30C5CF0", Offset = "0x30C50F0", Length = "0x6")]
		[Token(Token = "0x6001E3A")]
		 get { } //Length: 6
		[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
		[Token(Token = "0x6001E3B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000466")]
	public StencilState stencilState
	{
		[Address(RVA = "0x30C5D00", Offset = "0x30C5100", Length = "0x13")]
		[Token(Token = "0x6001E38")]
		 get { } //Length: 19
		[Address(RVA = "0x30C5D70", Offset = "0x30C5170", Length = "0x10")]
		[Token(Token = "0x6001E39")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x30C5B60", Offset = "0x30C4F60", Length = "0x17E")]
	[Token(Token = "0x6001E34")]
	public RenderStateBlock(RenderStateMask mask) { }

	[Address(RVA = "0x30C5710", Offset = "0x30C4B10", Length = "0x22E")]
	[Token(Token = "0x6001E3E")]
	public override bool Equals(RenderStateBlock other) { }

	[Address(RVA = "0x30C5940", Offset = "0x30C4D40", Length = "0xF0")]
	[Token(Token = "0x6001E3F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30C5CE0", Offset = "0x30C50E0", Length = "0x6")]
	[Token(Token = "0x6001E3C")]
	public RenderStateMask get_mask() { }

	[Address(RVA = "0x30C5CF0", Offset = "0x30C50F0", Length = "0x6")]
	[Token(Token = "0x6001E3A")]
	public int get_stencilReference() { }

	[Address(RVA = "0x30C5D00", Offset = "0x30C5100", Length = "0x13")]
	[Token(Token = "0x6001E38")]
	public StencilState get_stencilState() { }

	[Address(RVA = "0x30C5A40", Offset = "0x30C4E40", Length = "0x117")]
	[Token(Token = "0x6001E40")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30C5D20", Offset = "0x30C5120", Length = "0x25")]
	[Token(Token = "0x6001E35")]
	public void set_blendState(BlendState value) { }

	[Address(RVA = "0x30C5D50", Offset = "0x30C5150", Length = "0x5")]
	[Token(Token = "0x6001E37")]
	public void set_depthState(DepthState value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x6001E3D")]
	public void set_mask(RenderStateMask value) { }

	[Address(RVA = "0x30C5D60", Offset = "0x30C5160", Length = "0x8")]
	[Token(Token = "0x6001E36")]
	public void set_rasterState(RasterState value) { }

	[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
	[Token(Token = "0x6001E3B")]
	public void set_stencilReference(int value) { }

	[Address(RVA = "0x30C5D70", Offset = "0x30C5170", Length = "0x10")]
	[Token(Token = "0x6001E39")]
	public void set_stencilState(StencilState value) { }

}

