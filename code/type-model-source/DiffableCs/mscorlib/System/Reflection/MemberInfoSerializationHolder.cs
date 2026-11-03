namespace System.Reflection;

[Token(Token = "0x200050E")]
internal class MemberInfoSerializationHolder : ISerializable, IObjectReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001436")]
	private string m_memberName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001437")]
	private RuntimeType m_reflectedType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001438")]
	private string m_signature; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001439")]
	private string m_signature2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400143A")]
	private MemberTypes m_memberType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400143B")]
	private SerializationInfo m_info; //Field offset: 0x38

	[Address(RVA = "0x1F5FFE0", Offset = "0x1F5F3E0", Length = "0x37C")]
	[Token(Token = "0x60023D6")]
	internal MemberInfoSerializationHolder(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F5EF60", Offset = "0x1F5E360", Length = "0x5F")]
	[Token(Token = "0x60023D7")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F5EFC0", Offset = "0x1F5E3C0", Length = "0xD05")]
	[Token(Token = "0x60023D8")]
	public override object GetRealObject(StreamingContext context) { }

	[Address(RVA = "0x1F5FFB0", Offset = "0x1F5F3B0", Length = "0x28")]
	[Token(Token = "0x60023D4")]
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	[Address(RVA = "0x1F5FCD0", Offset = "0x1F5F0D0", Length = "0x2DF")]
	[Token(Token = "0x60023D5")]
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

}

