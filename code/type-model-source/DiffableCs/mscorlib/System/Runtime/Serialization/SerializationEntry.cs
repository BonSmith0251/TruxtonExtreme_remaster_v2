namespace System.Runtime.Serialization;

[IsReadOnly]
[Token(Token = "0x20003D7")]
public struct SerializationEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F23")]
	private readonly string _name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000F24")]
	private readonly object _value; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F25")]
	private readonly Type _type; //Field offset: 0x10

	[Token(Token = "0x170003A2")]
	public string Name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001D8D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003A1")]
	public object Value
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6001D8C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13115B0", Offset = "0x13109B0", Length = "0x4F")]
	[Token(Token = "0x6001D8B")]
	internal SerializationEntry(string entryName, object entryValue, Type entryType) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6001D8D")]
	public string get_Name() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6001D8C")]
	public object get_Value() { }

}

