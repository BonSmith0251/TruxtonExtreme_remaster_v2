namespace System.Data.SqlTypes;

[Token(Token = "0x20000BE")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlXml : INullable, IXmlSerializable
{
	[Token(Token = "0x4000415")]
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; //Field offset: 0x0
	[Token(Token = "0x4000416")]
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; //Field offset: 0x8
	[Token(Token = "0x4000417")]
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; //Field offset: 0x10
	[Token(Token = "0x4000418")]
	private static MethodInfo s_createSqlReaderMethodInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000419")]
	private MethodInfo _createSqlReaderMethodInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400041A")]
	private bool _fNotNull; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400041B")]
	private Stream _stream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400041C")]
	private bool _firstCreateReader; //Field offset: 0x28

	[Token(Token = "0x1700017F")]
	private static MethodInfo CreateSqlReaderMethodInfo
	{
		[Address(RVA = "0x23A7810", Offset = "0x23A6C10", Length = "0x1CF")]
		[Token(Token = "0x6000A7A")]
		private get { } //Length: 463
	}

	[Token(Token = "0x17000180")]
	public override bool IsNull
	{
		[Address(RVA = "0x23A52E0", Offset = "0x23A46E0", Length = "0x8")]
		[Token(Token = "0x6000A7B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x23A75D0", Offset = "0x23A69D0", Length = "0x1FC")]
	[Token(Token = "0x6000A81")]
	private static SqlXml() { }

	[Address(RVA = "0x23A77D0", Offset = "0x23A6BD0", Length = "0x31")]
	[Token(Token = "0x6000A76")]
	public SqlXml() { }

	[Address(RVA = "0x23A6DB0", Offset = "0x23A61B0", Length = "0x1CC")]
	[Token(Token = "0x6000A77")]
	public XmlReader CreateReader() { }

	[Address(RVA = "0x23A6F80", Offset = "0x23A6380", Length = "0xDF")]
	[Token(Token = "0x6000A79")]
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	[Address(RVA = "0x23A7060", Offset = "0x23A6460", Length = "0x172")]
	[Token(Token = "0x6000A78")]
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false) { }

	[Address(RVA = "0x23A7810", Offset = "0x23A6C10", Length = "0x1CF")]
	[Token(Token = "0x6000A7A")]
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	[Address(RVA = "0x23A52E0", Offset = "0x23A46E0", Length = "0x8")]
	[Token(Token = "0x6000A7B")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x23A71E0", Offset = "0x23A65E0", Length = "0x6B")]
	[Token(Token = "0x6000A80")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x23A7250", Offset = "0x23A6650", Length = "0x2A")]
	[Token(Token = "0x6000A7C")]
	private void SetNull() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A7D")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x23A7280", Offset = "0x23A6680", Length = "0x1F1")]
	[Token(Token = "0x6000A7E")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	[Address(RVA = "0x23A7480", Offset = "0x23A6880", Length = "0x146")]
	[Token(Token = "0x6000A7F")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

