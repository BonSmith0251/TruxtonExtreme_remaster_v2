namespace System.Xml.Serialization;

[Token(Token = "0x200011C")]
public class XmlReflectionMember
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400064D")]
	private bool isReturnValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400064E")]
	private string memberName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400064F")]
	private Type memberType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000650")]
	private XmlAttributes xmlAttributes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000651")]
	private Type declaringType; //Field offset: 0x30

	[Token(Token = "0x17000350")]
	internal Type DeclaringType
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000CBE")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000CBF")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700034C")]
	public bool IsReturnValue
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000CBA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700034D")]
	public string MemberName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000CBB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700034E")]
	public Type MemberType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000CBC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700034F")]
	public XmlAttributes XmlAttributes
	{
		[Address(RVA = "0x256A920", Offset = "0x2569D20", Length = "0x69")]
		[Token(Token = "0x6000CBD")]
		 get { } //Length: 105
	}

	[Address(RVA = "0x256A8B0", Offset = "0x2569CB0", Length = "0x6B")]
	[Token(Token = "0x6000CB9")]
	internal XmlReflectionMember(string name, Type type, XmlAttributes attributes) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000CBE")]
	internal Type get_DeclaringType() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000CBA")]
	public bool get_IsReturnValue() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000CBB")]
	public string get_MemberName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000CBC")]
	public Type get_MemberType() { }

	[Address(RVA = "0x256A920", Offset = "0x2569D20", Length = "0x69")]
	[Token(Token = "0x6000CBD")]
	public XmlAttributes get_XmlAttributes() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000CBF")]
	internal void set_DeclaringType(Type value) { }

}

