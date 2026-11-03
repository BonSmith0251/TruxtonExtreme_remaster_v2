namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000426")]
internal sealed class WriteObjectInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010B5")]
	internal int objectInfoId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010B6")]
	internal object obj; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010B7")]
	internal Type objectType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010B8")]
	internal bool isSi; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40010B9")]
	internal bool isNamed; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40010BA")]
	internal bool isTyped; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x40010BB")]
	internal bool isArray; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010BC")]
	internal SerializationInfo si; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010BD")]
	internal SerObjectInfoCache cache; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010BE")]
	internal Object[] memberData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40010BF")]
	internal ISerializationSurrogate serializationSurrogate; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40010C0")]
	internal StreamingContext context; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40010C1")]
	internal SerObjectInfoInit serObjectInfoInit; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40010C2")]
	internal long objectId; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40010C3")]
	internal long assemId; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40010C4")]
	private string binderTypeName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40010C5")]
	private string binderAssemblyString; //Field offset: 0x80

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001F3E")]
	internal WriteObjectInfo() { }

	[Address(RVA = "0x1F2C660", Offset = "0x1F2BA60", Length = "0x17D")]
	[Token(Token = "0x6001F46")]
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	[Address(RVA = "0x1F2C7E0", Offset = "0x1F2BBE0", Length = "0x27")]
	[Token(Token = "0x6001F4A")]
	internal string GetAssemblyString() { }

	[Address(RVA = "0x1F2C810", Offset = "0x1F2BC10", Length = "0xD9")]
	[Token(Token = "0x6001F4D")]
	internal void GetMemberInfo(out String[] outMemberNames, out Type[] outMemberTypes, out Object[] outMemberData) { }

	[Address(RVA = "0x1F2C8F0", Offset = "0x1F2BCF0", Length = "0x1D6")]
	[Token(Token = "0x6001F4C")]
	internal Type GetMemberType(MemberInfo objMember) { }

	[Address(RVA = "0x1F2CAD0", Offset = "0x1F2BED0", Length = "0x155")]
	[Token(Token = "0x6001F4E")]
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	[Address(RVA = "0x1F2CC30", Offset = "0x1F2C030", Length = "0x24")]
	[Token(Token = "0x6001F49")]
	internal string GetTypeFullName() { }

	[Address(RVA = "0x1F2CC60", Offset = "0x1F2C060", Length = "0x3E3")]
	[Token(Token = "0x6001F48")]
	private void InitMemberInfo() { }

	[Address(RVA = "0x1F2D050", Offset = "0x1F2C450", Length = "0x143")]
	[Token(Token = "0x6001F47")]
	private void InitNoMembers() { }

	[Address(RVA = "0x1F2D7B0", Offset = "0x1F2CBB0", Length = "0x890")]
	[Token(Token = "0x6001F42")]
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	[Address(RVA = "0x1F2D1A0", Offset = "0x1F2C5A0", Length = "0x60A")]
	[Token(Token = "0x6001F44")]
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	[Address(RVA = "0x1F2E050", Offset = "0x1F2D450", Length = "0x385")]
	[Token(Token = "0x6001F45")]
	private void InitSiWrite() { }

	[Address(RVA = "0x1F2E3E0", Offset = "0x1F2D7E0", Length = "0x93")]
	[Token(Token = "0x6001F40")]
	private void InternalInit() { }

	[Address(RVA = "0x1F2E480", Offset = "0x1F2D880", Length = "0x3C")]
	[Token(Token = "0x6001F4B")]
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	[Address(RVA = "0x1F2E4C0", Offset = "0x1F2D8C0", Length = "0x2A")]
	[Token(Token = "0x6001F3F")]
	internal void ObjectEnd() { }

	[Address(RVA = "0x1F2E4F0", Offset = "0x1F2D8F0", Length = "0x23")]
	[Token(Token = "0x6001F4F")]
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

	[Address(RVA = "0x1F2E5C0", Offset = "0x1F2D9C0", Length = "0xAB")]
	[Token(Token = "0x6001F41")]
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	[Address(RVA = "0x1F2E520", Offset = "0x1F2D920", Length = "0x9E")]
	[Token(Token = "0x6001F43")]
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

}

