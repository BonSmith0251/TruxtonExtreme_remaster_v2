namespace System.Xml.Linq;

[Token(Token = "0x200001C")]
public sealed class XName : IEquatable<XName>, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000045")]
	private XNamespace _ns; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000046")]
	private string _localName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000047")]
	private int _hashCode; //Field offset: 0x20

	[Token(Token = "0x1700001D")]
	public string LocalName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600009F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001E")]
	public XNamespace Namespace
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001F")]
	public string NamespaceName
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x240D4F0", Offset = "0x240C8F0", Length = "0xD0")]
	[Token(Token = "0x600009E")]
	internal XName(XNamespace ns, string localName) { }

	[Address(RVA = "0x240D5D0", Offset = "0x240C9D0", Length = "0x2C")]
	[Token(Token = "0x60000AB")]
	internal XName() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60000A6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x240D160", Offset = "0x240C560", Length = "0x1C3")]
	[Token(Token = "0x60000A3")]
	public static XName Get(string expandedName) { }

	[Address(RVA = "0x240D330", Offset = "0x240C730", Length = "0xE8")]
	[Token(Token = "0x60000A4")]
	public static XName Get(string localName, string namespaceName) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600009F")]
	public string get_LocalName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000A0")]
	public XNamespace get_Namespace() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x60000A1")]
	public string get_NamespaceName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60000A7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60000A8")]
	public static bool op_Equality(XName left, XName right) { }

	[Address(RVA = "0x240D600", Offset = "0x240CA00", Length = "0xF")]
	[CLSCompliant(False)]
	[Token(Token = "0x60000A5")]
	public static XName op_Implicit(string expandedName) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60000A9")]
	private override bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	[Address(RVA = "0x240D420", Offset = "0x240C820", Length = "0x3E")]
	[Token(Token = "0x60000AA")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x240D460", Offset = "0x240C860", Length = "0x81")]
	[Token(Token = "0x60000A2")]
	public virtual string ToString() { }

}

