namespace UnityEngine.Rendering;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20001D9")]
internal struct HashFNV1A32
{
	[Token(Token = "0x4000929")]
	private const uint k_Prime = 16777619; //Field offset: 0x0
	[Token(Token = "0x400092A")]
	private const uint k_OffsetBasis = 2166136261; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400092B")]
	private uint m_Hash; //Field offset: 0x0

	[Token(Token = "0x170001D6")]
	public int value
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000E52")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2C5EF40", Offset = "0x2C5E340", Length = "0xD")]
	[Token(Token = "0x6000E49")]
	public void Append(in int input) { }

	[Address(RVA = "0x2C5EF40", Offset = "0x2C5E340", Length = "0xD")]
	[Token(Token = "0x6000E4A")]
	public void Append(in uint input) { }

	[Address(RVA = "0x2C5F060", Offset = "0x2C5E460", Length = "0x14")]
	[Token(Token = "0x6000E4B")]
	public void Append(in bool input) { }

	[Address(RVA = "0x2C5EF00", Offset = "0x2C5E300", Length = "0x31")]
	[Token(Token = "0x6000E4C")]
	public void Append(in float input) { }

	[Address(RVA = "0x2C5F080", Offset = "0x2C5E480", Length = "0x3A")]
	[Token(Token = "0x6000E4D")]
	public void Append(in double input) { }

	[Address(RVA = "0x2C5F0C0", Offset = "0x2C5E4C0", Length = "0x5A")]
	[Token(Token = "0x6000E4E")]
	public void Append(in Vector2 input) { }

	[Address(RVA = "0x2C5EF50", Offset = "0x2C5E350", Length = "0x7A")]
	[Token(Token = "0x6000E4F")]
	public void Append(in Vector3 input) { }

	[Address(RVA = "0x2C5EFD0", Offset = "0x2C5E3D0", Length = "0x88")]
	[Token(Token = "0x6000E50")]
	public void Append(in Vector4 input) { }

	[Address(RVA = "0x81A600", Offset = "0x819A00", Length = "0xDD")]
	[Token(Token = "0x6000E51")]
	public void Append(T input) { }

	[Address(RVA = "0x2C5F120", Offset = "0x2C5E520", Length = "0x6")]
	[Token(Token = "0x6000E48")]
	public static HashFNV1A32 Create() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000E52")]
	public int get_value() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000E53")]
	public virtual int GetHashCode() { }

}

