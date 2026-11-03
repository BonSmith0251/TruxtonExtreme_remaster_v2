namespace System.Xml;

[Token(Token = "0x20000E0")]
public class XmlQualifiedName
{
	[Token(Token = "0x20000E1")]
	private sealed class HashCodeOfStringDelegate : MulticastDelegate
	{

		[Address(RVA = "0x24EA940", Offset = "0x24E9D40", Length = "0xB5")]
		[Token(Token = "0x6000B8D")]
		public HashCodeOfStringDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000B8E")]
		public override int Invoke(string s, int sLen, long additionalEntropy) { }

	}

	[Token(Token = "0x400059D")]
	private static HashCodeOfStringDelegate hashCodeDelegate; //Field offset: 0x0
	[Token(Token = "0x40005A1")]
	public static readonly XmlQualifiedName Empty; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400059E")]
	private string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400059F")]
	private string ns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A0")]
	private int hash; //Field offset: 0x20

	[Token(Token = "0x170002E0")]
	public bool IsEmpty
	{
		[Address(RVA = "0x255CC50", Offset = "0x255C050", Length = "0x34")]
		[Token(Token = "0x6000B7D")]
		 get { } //Length: 52
	}

	[Token(Token = "0x170002DF")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000B7B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002DE")]
	public string Namespace
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000B7A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x255C950", Offset = "0x255BD50", Length = "0x121")]
	[Token(Token = "0x6000B8C")]
	private static XmlQualifiedName() { }

	[Address(RVA = "0x255CB20", Offset = "0x255BF20", Length = "0x84")]
	[Token(Token = "0x6000B79")]
	public XmlQualifiedName(string name, string ns) { }

	[Address(RVA = "0x255CBB0", Offset = "0x255BFB0", Length = "0x92")]
	[Token(Token = "0x6000B77")]
	public XmlQualifiedName() { }

	[Address(RVA = "0x255CA80", Offset = "0x255BE80", Length = "0x92")]
	[Token(Token = "0x6000B78")]
	public XmlQualifiedName(string name) { }

	[Address(RVA = "0x255C080", Offset = "0x255B480", Length = "0x78")]
	[Token(Token = "0x6000B89")]
	internal void Atomize(XmlNameTable nameTable) { }

	[Address(RVA = "0x255C100", Offset = "0x255B500", Length = "0x71")]
	[Token(Token = "0x6000B8B")]
	internal XmlQualifiedName Clone() { }

	[Address(RVA = "0x255C180", Offset = "0x255B580", Length = "0x11C")]
	[Token(Token = "0x6000B7F")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x255CC50", Offset = "0x255C050", Length = "0x34")]
	[Token(Token = "0x6000B7D")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000B7B")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000B7A")]
	public string get_Namespace() { }

	[Address(RVA = "0x255C490", Offset = "0x255B890", Length = "0xF8")]
	[Token(Token = "0x6000B7C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x255C2A0", Offset = "0x255B6A0", Length = "0x1ED")]
	[Token(Token = "0x6000B83")]
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	[Address(RVA = "0x108EF90", Offset = "0x108E390", Length = "0x26")]
	[Token(Token = "0x6000B85")]
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	[Address(RVA = "0x255C590", Offset = "0x255B990", Length = "0x3F")]
	[Token(Token = "0x6000B86")]
	internal void Init(string name, string ns) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B84")]
	private static bool IsRandomizedHashingDisabled() { }

	[Address(RVA = "0x255CC90", Offset = "0x255C090", Length = "0x67")]
	[Token(Token = "0x6000B80")]
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	[Address(RVA = "0x255CD00", Offset = "0x255C100", Length = "0x9F")]
	[Token(Token = "0x6000B81")]
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	[Address(RVA = "0x255C5D0", Offset = "0x255B9D0", Length = "0x210")]
	[Token(Token = "0x6000B8A")]
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000B87")]
	internal void SetNamespace(string ns) { }

	[Address(RVA = "0x255C7F0", Offset = "0x255BBF0", Length = "0x5E")]
	[Token(Token = "0x6000B7E")]
	public virtual string ToString() { }

	[Address(RVA = "0x255C850", Offset = "0x255BC50", Length = "0x64")]
	[Token(Token = "0x6000B82")]
	public static string ToString(string name, string ns) { }

	[Address(RVA = "0x255C8C0", Offset = "0x255BCC0", Length = "0x8D")]
	[Token(Token = "0x6000B88")]
	internal void Verify() { }

}

