namespace UnityEngine.UIElements;

[Token(Token = "0x20002E2")]
internal struct TextureId
{
	[Token(Token = "0x4000BC2")]
	public static readonly TextureId invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BC1")]
	private readonly int m_Index; //Field offset: 0x0

	[Token(Token = "0x170003EE")]
	public int index
	{
		[Address(RVA = "0x340BE30", Offset = "0x340B230", Length = "0x5")]
		[Token(Token = "0x6001416")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x340BDE0", Offset = "0x340B1E0", Length = "0x39")]
	[Token(Token = "0x600141D")]
	private static TextureId() { }

	[Address(RVA = "0x340BE20", Offset = "0x340B220", Length = "0x6")]
	[Token(Token = "0x6001415")]
	public TextureId(int index) { }

	[Address(RVA = "0x340BCE0", Offset = "0x340B0E0", Length = "0x4B")]
	[Token(Token = "0x6001418")]
	public float ConvertToGpu() { }

	[Address(RVA = "0x340BD30", Offset = "0x340B130", Length = "0x97")]
	[Token(Token = "0x6001419")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x340BE30", Offset = "0x340B230", Length = "0x5")]
	[Token(Token = "0x6001416")]
	public int get_index() { }

	[Address(RVA = "0x2FF3D00", Offset = "0x2FF3100", Length = "0x9")]
	[Token(Token = "0x600141A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x340BDD0", Offset = "0x340B1D0", Length = "0x9")]
	[Token(Token = "0x6001417")]
	public bool IsValid() { }

	[Address(RVA = "0x306F930", Offset = "0x306ED30", Length = "0x8")]
	[Token(Token = "0x600141B")]
	public static bool op_Equality(TextureId left, TextureId right) { }

	[Address(RVA = "0x340BE40", Offset = "0x340B240", Length = "0x4F")]
	[Token(Token = "0x600141C")]
	public static bool op_Inequality(TextureId left, TextureId right) { }

}

