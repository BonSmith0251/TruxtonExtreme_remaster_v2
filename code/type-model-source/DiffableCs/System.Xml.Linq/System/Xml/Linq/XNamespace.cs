namespace System.Xml.Linq;

[Token(Token = "0x200001D")]
public sealed class XNamespace
{
	[Token(Token = "0x4000048")]
	private static XHashtable<WeakReference> s_namespaces; //Field offset: 0x0
	[Token(Token = "0x4000049")]
	private static WeakReference s_refNone; //Field offset: 0x8
	[Token(Token = "0x400004A")]
	private static WeakReference s_refXml; //Field offset: 0x10
	[Token(Token = "0x400004B")]
	private static WeakReference s_refXmlns; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004C")]
	private string _namespaceName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004D")]
	private int _hashCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004E")]
	private XHashtable<XName> _names; //Field offset: 0x20

	[Token(Token = "0x17000020")]
	public string NamespaceName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000021")]
	public static XNamespace None
	{
		[Address(RVA = "0x240DF10", Offset = "0x240D310", Length = "0x4F")]
		[Token(Token = "0x60000B0")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000022")]
	public static XNamespace Xml
	{
		[Address(RVA = "0x240DF60", Offset = "0x240D360", Length = "0x51")]
		[Token(Token = "0x60000B1")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000023")]
	public static XNamespace Xmlns
	{
		[Address(RVA = "0x240DFC0", Offset = "0x240D3C0", Length = "0x51")]
		[Token(Token = "0x60000B2")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x240DE10", Offset = "0x240D210", Length = "0xFF")]
	[Token(Token = "0x60000AC")]
	internal XNamespace(string namespaceName) { }

	[Address(RVA = "0x240D610", Offset = "0x240CA10", Length = "0x101")]
	[Token(Token = "0x60000BD")]
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60000B5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF48BF0", Offset = "0xF47FF0", Length = "0x17")]
	[Token(Token = "0x60000BB")]
	private static string ExtractLocalName(XName n) { }

	[Address(RVA = "0x240D720", Offset = "0x240CB20", Length = "0x74")]
	[Token(Token = "0x60000BC")]
	private static string ExtractNamespace(WeakReference r) { }

	[Address(RVA = "0x240DDA0", Offset = "0x240D1A0", Length = "0x6D")]
	[Token(Token = "0x60000B3")]
	public static XNamespace Get(string namespaceName) { }

	[Address(RVA = "0x240D9C0", Offset = "0x240CDC0", Length = "0x3D9")]
	[Token(Token = "0x60000BA")]
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000AD")]
	public string get_NamespaceName() { }

	[Address(RVA = "0x240DF10", Offset = "0x240D310", Length = "0x4F")]
	[Token(Token = "0x60000B0")]
	public static XNamespace get_None() { }

	[Address(RVA = "0x240DF60", Offset = "0x240D360", Length = "0x51")]
	[Token(Token = "0x60000B1")]
	public static XNamespace get_Xml() { }

	[Address(RVA = "0x240DFC0", Offset = "0x240D3C0", Length = "0x51")]
	[Token(Token = "0x60000B2")]
	public static XNamespace get_Xmlns() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60000B6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x240D940", Offset = "0x240CD40", Length = "0x75")]
	[Token(Token = "0x60000AE")]
	public XName GetName(string localName) { }

	[Address(RVA = "0x240D7A0", Offset = "0x240CBA0", Length = "0x198")]
	[Token(Token = "0x60000B9")]
	internal XName GetName(string localName, int index, int count) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60000B7")]
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	[Address(RVA = "0x240E020", Offset = "0x240D420", Length = "0x16")]
	[CLSCompliant(False)]
	[Token(Token = "0x60000B4")]
	public static XNamespace op_Implicit(string namespaceName) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x60000B8")]
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000AF")]
	public virtual string ToString() { }

}

