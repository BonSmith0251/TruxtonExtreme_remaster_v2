namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
[Token(Token = "0x2000017")]
public sealed class JsonArrayAttribute : JsonContainerAttribute
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400002A")]
	private bool _allowNullItems; //Field offset: 0x68

	[Token(Token = "0x17000005")]
	public bool AllowNullItems
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[Token(Token = "0x600001B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600001C")]
	public JsonArrayAttribute() { }

	[Address(RVA = "0x20C7FE0", Offset = "0x20C73E0", Length = "0x26")]
	[Token(Token = "0x600001D")]
	public JsonArrayAttribute(bool allowNullItems) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x600001E")]
	public JsonArrayAttribute(string id) { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x600001A")]
	public bool get_AllowNullItems() { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[Token(Token = "0x600001B")]
	public void set_AllowNullItems(bool value) { }

}

