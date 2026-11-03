namespace System.Xml.Serialization;

[Token(Token = "0x2000102")]
internal sealed class TypeMember
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000601")]
	private Type type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000602")]
	private string member; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000C23")]
	internal TypeMember(Type type, string member) { }

	[Address(RVA = "0x2545E80", Offset = "0x2545280", Length = "0xE0")]
	[Token(Token = "0x6000C25")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2545F70", Offset = "0x2545370", Length = "0x90")]
	[Token(Token = "0x6000C26")]
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	[Address(RVA = "0x2546000", Offset = "0x2545400", Length = "0x5A")]
	[Token(Token = "0x6000C24")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2546060", Offset = "0x2545460", Length = "0x61")]
	[Token(Token = "0x6000C27")]
	public virtual string ToString() { }

}

