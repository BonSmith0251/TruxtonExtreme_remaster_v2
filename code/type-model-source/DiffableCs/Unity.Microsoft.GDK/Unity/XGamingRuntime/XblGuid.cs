namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200018E")]
public class XblGuid
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000378")]
	private readonly string <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000135")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008B9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B861F0", Offset = "0x2B855F0", Length = "0x3C")]
	[Token(Token = "0x60008B8")]
	internal XblGuid(XblGuid interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008B9")]
	public string get_Value() { }

}

