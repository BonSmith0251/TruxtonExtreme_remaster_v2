namespace UnityEngine.Rendering.RenderGraphModule;

[IsReadOnly]
[Token(Token = "0x200029A")]
internal struct ResourceHandle : IEquatable<ResourceHandle>
{
	[Token(Token = "0x4000B97")]
	private const uint kValidityMask = 4294901760; //Field offset: 0x0
	[Token(Token = "0x4000B98")]
	private const uint kIndexMask = 65535; //Field offset: 0x0
	[Token(Token = "0x4000B9C")]
	private static uint s_CurrentValidBit; //Field offset: 0x0
	[Token(Token = "0x4000B9D")]
	private static uint s_SharedResourceValidBit; //Field offset: 0x4
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B99")]
	private readonly uint m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B9A")]
	private readonly int m_Version; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B9B")]
	private readonly RenderGraphResourceType m_Type; //Field offset: 0x8

	[Token(Token = "0x17000257")]
	public int index
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[Token(Token = "0x60012B9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700025B")]
	public bool IsVersioned
	{
		[Address(RVA = "0x2CAAA30", Offset = "0x2CA9E30", Length = "0x9")]
		[Token(Token = "0x60012C2")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000258")]
	public int iType
	{
		[Address(RVA = "0x2CAAA40", Offset = "0x2CA9E40", Length = "0x43")]
		[Token(Token = "0x60012BA")]
		 get { } //Length: 67
	}

	[Token(Token = "0x1700025A")]
	public RenderGraphResourceType type
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60012BC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000259")]
	public int version
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60012BB")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2CAA8B0", Offset = "0x2CA9CB0", Length = "0x4E")]
	[Token(Token = "0x60012C4")]
	private static ResourceHandle() { }

	[Address(RVA = "0x2CAA900", Offset = "0x2CA9D00", Length = "0xB2")]
	[Token(Token = "0x60012BD")]
	internal ResourceHandle(int value, RenderGraphResourceType type, bool shared) { }

	[Address(RVA = "0x2CAA9C0", Offset = "0x2CA9DC0", Length = "0x66")]
	[Token(Token = "0x60012BE")]
	internal ResourceHandle(in ResourceHandle h, int version) { }

	[Address(RVA = "0x2CAA670", Offset = "0x2CA9A70", Length = "0x70")]
	[Token(Token = "0x60012C3")]
	public override bool Equals(ResourceHandle hdl) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x60012B9")]
	public int get_index() { }

	[Address(RVA = "0x2CAAA30", Offset = "0x2CA9E30", Length = "0x9")]
	[Token(Token = "0x60012C2")]
	public bool get_IsVersioned() { }

	[Address(RVA = "0x2CAAA40", Offset = "0x2CA9E40", Length = "0x43")]
	[Token(Token = "0x60012BA")]
	public int get_iType() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60012BC")]
	public RenderGraphResourceType get_type() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60012BB")]
	public int get_version() { }

	[Address(RVA = "0x2CAA6E0", Offset = "0x2CA9AE0", Length = "0x48")]
	[Token(Token = "0x60012C0")]
	public bool IsNull() { }

	[Address(RVA = "0x2CAA730", Offset = "0x2CA9B30", Length = "0x8E")]
	[Token(Token = "0x60012BF")]
	public bool IsValid() { }

	[Address(RVA = "0x2CAA7C0", Offset = "0x2CA9BC0", Length = "0xE7")]
	[Token(Token = "0x60012C1")]
	public static void NewFrame(int executionIndex) { }

}

