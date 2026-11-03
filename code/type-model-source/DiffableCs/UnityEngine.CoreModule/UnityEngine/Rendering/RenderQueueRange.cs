namespace UnityEngine.Rendering;

[Token(Token = "0x20003EA")]
public struct RenderQueueRange : IEquatable<RenderQueueRange>
{
	[Token(Token = "0x4000CDE")]
	private const int k_MinimumBound = 0; //Field offset: 0x0
	[Token(Token = "0x4000CDF")]
	public static readonly int minimumBound; //Field offset: 0x0
	[Token(Token = "0x4000CE0")]
	private const int k_MaximumBound = 5000; //Field offset: 0x0
	[Token(Token = "0x4000CE1")]
	public static readonly int maximumBound; //Field offset: 0x4
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CDC")]
	private int m_LowerBound; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CDD")]
	private int m_UpperBound; //Field offset: 0x4

	[Token(Token = "0x1700045E")]
	public static RenderQueueRange all
	{
		[Address(RVA = "0x30C5630", Offset = "0x30C4A30", Length = "0x16")]
		[Token(Token = "0x6001E2A")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000461")]
	public int lowerBound
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6001E2D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700045F")]
	public static RenderQueueRange opaque
	{
		[Address(RVA = "0x30C5650", Offset = "0x30C4A50", Length = "0x16")]
		[Token(Token = "0x6001E2B")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000460")]
	public static RenderQueueRange transparent
	{
		[Address(RVA = "0x30C5670", Offset = "0x30C4A70", Length = "0x16")]
		[Token(Token = "0x6001E2C")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000462")]
	public int upperBound
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6001E2E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x30C55E0", Offset = "0x30C49E0", Length = "0x4E")]
	[Token(Token = "0x6001E33")]
	private static RenderQueueRange() { }

	[Address(RVA = "0x2FEFAC0", Offset = "0x2FEEEC0", Length = "0x12")]
	[Token(Token = "0x6001E2F")]
	public override bool Equals(RenderQueueRange other) { }

	[Address(RVA = "0x30C5510", Offset = "0x30C4910", Length = "0xB7")]
	[Token(Token = "0x6001E30")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30C5630", Offset = "0x30C4A30", Length = "0x16")]
	[Token(Token = "0x6001E2A")]
	public static RenderQueueRange get_all() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001E2D")]
	public int get_lowerBound() { }

	[Address(RVA = "0x30C5650", Offset = "0x30C4A50", Length = "0x16")]
	[Token(Token = "0x6001E2B")]
	public static RenderQueueRange get_opaque() { }

	[Address(RVA = "0x30C5670", Offset = "0x30C4A70", Length = "0x16")]
	[Token(Token = "0x6001E2C")]
	public static RenderQueueRange get_transparent() { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6001E2E")]
	public int get_upperBound() { }

	[Address(RVA = "0x30C55D0", Offset = "0x30C49D0", Length = "0xC")]
	[Token(Token = "0x6001E31")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30C5690", Offset = "0x30C4A90", Length = "0x75")]
	[Token(Token = "0x6001E32")]
	public static bool op_Equality(RenderQueueRange left, RenderQueueRange right) { }

}

