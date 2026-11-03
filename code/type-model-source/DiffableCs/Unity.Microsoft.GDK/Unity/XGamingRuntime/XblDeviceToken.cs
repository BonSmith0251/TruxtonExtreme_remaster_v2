namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200018D")]
public class XblDeviceToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000377")]
	private string <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000134")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008B6")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60008B7")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B861F0", Offset = "0x2B855F0", Length = "0x3C")]
	[Token(Token = "0x60008B5")]
	internal XblDeviceToken(XblDeviceToken interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008B6")]
	public string get_Value() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60008B7")]
	public void set_Value(string value) { }

}

