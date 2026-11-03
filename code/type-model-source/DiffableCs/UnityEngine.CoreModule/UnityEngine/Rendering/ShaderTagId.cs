namespace UnityEngine.Rendering;

[Token(Token = "0x20003F0")]
public struct ShaderTagId : IEquatable<ShaderTagId>
{
	[Token(Token = "0x4000CFE")]
	public static readonly ShaderTagId none; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CFF")]
	private int m_Id; //Field offset: 0x0

	[Token(Token = "0x1700046A")]
	internal int id
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6001E7C")]
		internal get { } //Length: 5
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6001E7D")]
		internal set { } //Length: 3
	}

	[Address(RVA = "0x30CC260", Offset = "0x30CB660", Length = "0x1E")]
	[Token(Token = "0x6001E7B")]
	public ShaderTagId(string name) { }

	[Address(RVA = "0x30CC1B0", Offset = "0x30CB5B0", Length = "0x81")]
	[Token(Token = "0x6001E7E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x6001E7F")]
	public override bool Equals(ShaderTagId other) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001E7C")]
	internal int get_id() { }

	[Address(RVA = "0x30CC240", Offset = "0x30CB640", Length = "0x15")]
	[Token(Token = "0x6001E80")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x306F930", Offset = "0x306ED30", Length = "0x8")]
	[Token(Token = "0x6001E81")]
	public static bool op_Equality(ShaderTagId tag1, ShaderTagId tag2) { }

	[Address(RVA = "0x30CC280", Offset = "0x30CB680", Length = "0x8")]
	[Token(Token = "0x6001E82")]
	public static bool op_Inequality(ShaderTagId tag1, ShaderTagId tag2) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001E7D")]
	internal void set_id(int value) { }

}

