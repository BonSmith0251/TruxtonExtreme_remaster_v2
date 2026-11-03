namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000427")]
internal sealed class ReadObjectInfo
{
	[Token(Token = "0x40010C7")]
	internal static int readObjectInfoCounter; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010C6")]
	internal int objectInfoId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010C8")]
	internal Type objectType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010C9")]
	internal ObjectManager objectManager; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010CA")]
	internal int count; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40010CB")]
	internal bool isSi; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40010CC")]
	internal bool isNamed; //Field offset: 0x2D
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x40010CD")]
	internal bool isTyped; //Field offset: 0x2E
	[FieldOffset(Offset = "0x2F")]
	[Token(Token = "0x40010CE")]
	internal bool bSimpleAssembly; //Field offset: 0x2F
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010CF")]
	internal SerObjectInfoCache cache; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010D0")]
	internal String[] wireMemberNames; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010D1")]
	internal Type[] wireMemberTypes; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40010D2")]
	private int lastPosition; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40010D3")]
	internal ISerializationSurrogate serializationSurrogate; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40010D4")]
	internal StreamingContext context; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40010D5")]
	internal List<Type> memberTypesList; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40010D6")]
	internal SerObjectInfoInit serObjectInfoInit; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40010D7")]
	internal IFormatterConverter formatterConverter; //Field offset: 0x78

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001F50")]
	internal ReadObjectInfo() { }

	[Address(RVA = "0x1F26810", Offset = "0x1F25C10", Length = "0x259")]
	[Token(Token = "0x6001F5D")]
	internal void AddValue(string name, object value, ref SerializationInfo si, ref Object[] memberData) { }

	[Address(RVA = "0x1F26A70", Offset = "0x1F25E70", Length = "0x126")]
	[Token(Token = "0x6001F53")]
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	[Address(RVA = "0x1F26BA0", Offset = "0x1F25FA0", Length = "0x16A")]
	[Token(Token = "0x6001F55")]
	internal static ReadObjectInfo Create(Type objectType, String[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	[Address(RVA = "0x1F26D10", Offset = "0x1F26110", Length = "0x268")]
	[Token(Token = "0x6001F5B")]
	internal MemberInfo GetMemberInfo(string name) { }

	[Address(RVA = "0x1F26F80", Offset = "0x1F26380", Length = "0x1D6")]
	[Token(Token = "0x6001F63")]
	internal Type GetMemberType(MemberInfo objMember) { }

	[Address(RVA = "0x1F27160", Offset = "0x1F26560", Length = "0x660")]
	[Token(Token = "0x6001F62")]
	internal Type[] GetMemberTypes(String[] inMemberNames, Type objectType) { }

	[Address(RVA = "0x1F277D0", Offset = "0x1F26BD0", Length = "0x66")]
	[Token(Token = "0x6001F64")]
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	[Address(RVA = "0x1F27840", Offset = "0x1F26C40", Length = "0x19E")]
	[Token(Token = "0x6001F5C")]
	internal Type GetType(string name) { }

	[Address(RVA = "0x1F281A0", Offset = "0x1F275A0", Length = "0x10E")]
	[Token(Token = "0x6001F56")]
	internal void Init(Type objectType, String[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	[Address(RVA = "0x1F280E0", Offset = "0x1F274E0", Length = "0xBC")]
	[Token(Token = "0x6001F54")]
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	[Address(RVA = "0x1F279E0", Offset = "0x1F26DE0", Length = "0xFF")]
	[Token(Token = "0x6001F5E")]
	internal void InitDataStore(ref SerializationInfo si, ref Object[] memberData) { }

	[Address(RVA = "0x1F27AE0", Offset = "0x1F26EE0", Length = "0x2A5")]
	[Token(Token = "0x6001F5A")]
	private void InitMemberInfo() { }

	[Address(RVA = "0x1F27D90", Offset = "0x1F27190", Length = "0x6E")]
	[Token(Token = "0x6001F59")]
	private void InitNoMembers() { }

	[Address(RVA = "0x1F27E00", Offset = "0x1F27200", Length = "0x25A")]
	[Token(Token = "0x6001F57")]
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	[Address(RVA = "0x1F28060", Offset = "0x1F27460", Length = "0x7B")]
	[Token(Token = "0x6001F58")]
	private void InitSiRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001F51")]
	internal void ObjectEnd() { }

	[Address(RVA = "0x1F282B0", Offset = "0x1F276B0", Length = "0x87")]
	[Token(Token = "0x6001F60")]
	internal void PopulateObjectMembers(object obj, Object[] memberData) { }

	[Address(RVA = "0x1F28340", Offset = "0x1F27740", Length = "0x169")]
	[Token(Token = "0x6001F61")]
	private int Position(string name) { }

	[Address(RVA = "0x1F284B0", Offset = "0x1F278B0", Length = "0x8")]
	[Token(Token = "0x6001F52")]
	internal void PrepareForReuse() { }

	[Address(RVA = "0x1F284C0", Offset = "0x1F278C0", Length = "0xC9")]
	[Token(Token = "0x6001F5F")]
	internal void RecordFixup(long objectId, string name, long idRef) { }

}

