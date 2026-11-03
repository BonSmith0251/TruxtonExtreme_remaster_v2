namespace System.Runtime.Serialization.Formatters.Binary;

[ComVisible(True)]
[Token(Token = "0x2000423")]
public sealed class BinaryFormatter
{
	[Token(Token = "0x400109B")]
	private static Dictionary<Type, TypeInformation> typeNameCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001094")]
	internal ISurrogateSelector m_surrogates; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001095")]
	internal StreamingContext m_context; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001096")]
	internal SerializationBinder m_binder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001097")]
	internal FormatterTypeStyle m_typeFormat; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001098")]
	internal FormatterAssemblyStyle m_assemblyFormat; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001099")]
	internal TypeFilterLevel m_securityLevel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400109A")]
	internal Object[] m_crossAppDomainArray; //Field offset: 0x40

	[Token(Token = "0x170003DD")]
	public FormatterAssemblyStyle AssemblyFormat
	{
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x6001F01")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003DE")]
	public override ISurrogateSelector SurrogateSelector
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001F02")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1F18300", Offset = "0x1F17700", Length = "0x84")]
	[Token(Token = "0x6001F0C")]
	private static BinaryFormatter() { }

	[Address(RVA = "0x1F18390", Offset = "0x1F17790", Length = "0x69")]
	[Token(Token = "0x6001F03")]
	public BinaryFormatter() { }

	[Address(RVA = "0x1F18400", Offset = "0x1F17800", Length = "0x5E")]
	[Token(Token = "0x6001F04")]
	public BinaryFormatter(ISurrogateSelector selector, StreamingContext context) { }

	[Address(RVA = "0x1F17CA0", Offset = "0x1F170A0", Length = "0x1D")]
	[Token(Token = "0x6001F05")]
	public override object Deserialize(Stream serializationStream) { }

	[Address(RVA = "0x1F17950", Offset = "0x1F16D50", Length = "0x32B")]
	[Token(Token = "0x6001F06")]
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	[Address(RVA = "0x1F17C80", Offset = "0x1F17080", Length = "0x1A")]
	[Token(Token = "0x6001F07")]
	public override object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	[Address(RVA = "0x1F17CC0", Offset = "0x1F170C0", Length = "0x272")]
	[Token(Token = "0x6001F0B")]
	internal static TypeInformation GetTypeInformation(Type type) { }

	[Address(RVA = "0x1F182E0", Offset = "0x1F176E0", Length = "0x1F")]
	[Token(Token = "0x6001F08")]
	public override void Serialize(Stream serializationStream, object graph) { }

	[Address(RVA = "0x1F17F40", Offset = "0x1F17340", Length = "0x1C")]
	[Token(Token = "0x6001F09")]
	public override void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	[Address(RVA = "0x1F17F60", Offset = "0x1F17360", Length = "0x37F")]
	[Token(Token = "0x6001F0A")]
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x6001F01")]
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001F02")]
	public override void set_SurrogateSelector(ISurrogateSelector value) { }

}

