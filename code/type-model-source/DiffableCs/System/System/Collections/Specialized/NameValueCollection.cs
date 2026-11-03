namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001DC")]
public class NameValueCollection : NameObjectCollectionBase
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000708")]
	private String[] _all; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000709")]
	private String[] _allKeys; //Field offset: 0x60

	[Token(Token = "0x1700023E")]
	public string Item
	{
		[Address(RVA = "0x1D6CC10", Offset = "0x1D6C010", Length = "0x14")]
		[Token(Token = "0x6000BE2")]
		 get { } //Length: 20
		[Address(RVA = "0x2688670", Offset = "0x2687A70", Length = "0x14")]
		[Token(Token = "0x6000BE3")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700023F")]
	public string Item
	{
		[Address(RVA = "0x2688650", Offset = "0x2687A50", Length = "0x14")]
		[Token(Token = "0x6000BE6")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x2688570", Offset = "0x2687970", Length = "0x8C")]
	[Token(Token = "0x6000BD7")]
	public NameValueCollection() { }

	[Address(RVA = "0x2688500", Offset = "0x2687900", Length = "0x65")]
	[Token(Token = "0x6000BD9")]
	protected NameValueCollection(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2688600", Offset = "0x2687A00", Length = "0x49")]
	[Token(Token = "0x6000BE7")]
	internal NameValueCollection(DBNull dummy) { }

	[Address(RVA = "0x2688480", Offset = "0x2687880", Length = "0x72")]
	[Token(Token = "0x6000BD8")]
	public NameValueCollection(int capacity, IEqualityComparer equalityComparer) { }

	[Address(RVA = "0x2687B30", Offset = "0x2686F30", Length = "0x18B")]
	[Token(Token = "0x6000BDD")]
	public override void Add(string name, string value) { }

	[Address(RVA = "0x26881A0", Offset = "0x26875A0", Length = "0x94")]
	[Token(Token = "0x6000BDE")]
	public override string Get(string name) { }

	[Address(RVA = "0x2688090", Offset = "0x2687490", Length = "0x10B")]
	[Token(Token = "0x6000BE4")]
	public override string Get(int index) { }

	[Address(RVA = "0x2688650", Offset = "0x2687A50", Length = "0x14")]
	[Token(Token = "0x6000BE6")]
	public string get_Item(int index) { }

	[Address(RVA = "0x1D6CC10", Offset = "0x1D6C010", Length = "0x14")]
	[Token(Token = "0x6000BE2")]
	public string get_Item(string name) { }

	[Address(RVA = "0x2687CC0", Offset = "0x26870C0", Length = "0x1EB")]
	[Token(Token = "0x6000BDB")]
	private static string GetAsOneString(ArrayList list) { }

	[Address(RVA = "0x2687EB0", Offset = "0x26872B0", Length = "0xA9")]
	[Token(Token = "0x6000BDC")]
	private static String[] GetAsStringArray(ArrayList list) { }

	[Address(RVA = "0x2687F60", Offset = "0x2687360", Length = "0x8")]
	[Token(Token = "0x6000BE5")]
	public override string GetKey(int index) { }

	[Address(RVA = "0x2687F70", Offset = "0x2687370", Length = "0x118")]
	[Token(Token = "0x6000BDF")]
	public override String[] GetValues(string name) { }

	[Address(RVA = "0x2688240", Offset = "0x2687640", Length = "0x34")]
	[Token(Token = "0x6000BDA")]
	protected void InvalidateCachedArrays() { }

	[Address(RVA = "0x2688280", Offset = "0x2687680", Length = "0x4E")]
	[Token(Token = "0x6000BE1")]
	public override void Remove(string name) { }

	[Address(RVA = "0x26882D0", Offset = "0x26876D0", Length = "0x1A1")]
	[Token(Token = "0x6000BE0")]
	public override void Set(string name, string value) { }

	[Address(RVA = "0x2688670", Offset = "0x2687A70", Length = "0x14")]
	[Token(Token = "0x6000BE3")]
	public void set_Item(string name, string value) { }

}

