namespace Newtonsoft.Json;

[AttributeUsage(1036, AllowMultiple = False)]
[Token(Token = "0x2000024")]
public sealed class JsonObjectAttribute : JsonContainerAttribute
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000043")]
	private MemberSerialization _memberSerialization; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000044")]
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x6C
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000045")]
	internal Nullable<Required> _itemRequired; //Field offset: 0x74
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000046")]
	internal Nullable<NullValueHandling> _itemNullValueHandling; //Field offset: 0x7C

	[Token(Token = "0x1700001B")]
	public NullValueHandling ItemNullValueHandling
	{
		[Address(RVA = "0x20CD1C0", Offset = "0x20CC5C0", Length = "0x3D")]
		[Token(Token = "0x60000A6")]
		 get { } //Length: 61
		[Address(RVA = "0x20CD280", Offset = "0x20CC680", Length = "0x5B")]
		[Token(Token = "0x60000A7")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700001C")]
	public Required ItemRequired
	{
		[Address(RVA = "0x20CD200", Offset = "0x20CC600", Length = "0x37")]
		[Token(Token = "0x60000A8")]
		 get { } //Length: 55
		[Address(RVA = "0x20CD2E0", Offset = "0x20CC6E0", Length = "0x5B")]
		[Token(Token = "0x60000A9")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000019")]
	public MemberSerialization MemberSerialization
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x60000A3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001A")]
	public MissingMemberHandling MissingMemberHandling
	{
		[Address(RVA = "0x20CD240", Offset = "0x20CC640", Length = "0x37")]
		[Token(Token = "0x60000A4")]
		 get { } //Length: 55
		[Address(RVA = "0x20CD340", Offset = "0x20CC740", Length = "0x5B")]
		[Token(Token = "0x60000A5")]
		 set { } //Length: 91
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60000AA")]
	public JsonObjectAttribute() { }

	[Address(RVA = "0x20CD190", Offset = "0x20CC590", Length = "0x24")]
	[Token(Token = "0x60000AB")]
	public JsonObjectAttribute(MemberSerialization memberSerialization) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x60000AC")]
	public JsonObjectAttribute(string id) { }

	[Address(RVA = "0x20CD1C0", Offset = "0x20CC5C0", Length = "0x3D")]
	[Token(Token = "0x60000A6")]
	public NullValueHandling get_ItemNullValueHandling() { }

	[Address(RVA = "0x20CD200", Offset = "0x20CC600", Length = "0x37")]
	[Token(Token = "0x60000A8")]
	public Required get_ItemRequired() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x60000A2")]
	public MemberSerialization get_MemberSerialization() { }

	[Address(RVA = "0x20CD240", Offset = "0x20CC640", Length = "0x37")]
	[Token(Token = "0x60000A4")]
	public MissingMemberHandling get_MissingMemberHandling() { }

	[Address(RVA = "0x20CD280", Offset = "0x20CC680", Length = "0x5B")]
	[Token(Token = "0x60000A7")]
	public void set_ItemNullValueHandling(NullValueHandling value) { }

	[Address(RVA = "0x20CD2E0", Offset = "0x20CC6E0", Length = "0x5B")]
	[Token(Token = "0x60000A9")]
	public void set_ItemRequired(Required value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x60000A3")]
	public void set_MemberSerialization(MemberSerialization value) { }

	[Address(RVA = "0x20CD340", Offset = "0x20CC740", Length = "0x5B")]
	[Token(Token = "0x60000A5")]
	public void set_MissingMemberHandling(MissingMemberHandling value) { }

}

