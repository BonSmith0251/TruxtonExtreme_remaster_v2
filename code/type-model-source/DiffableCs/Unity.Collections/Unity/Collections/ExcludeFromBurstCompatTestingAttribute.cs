namespace Unity.Collections;

[AttributeUsage(224)]
[Token(Token = "0x2000081")]
public class ExcludeFromBurstCompatTestingAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A9")]
	private string <Reason>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000A9")]
	public string Reason
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006CC")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006CD")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60006CE")]
	public ExcludeFromBurstCompatTestingAttribute(string _reason) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60006CC")]
	public string get_Reason() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60006CD")]
	public void set_Reason(string value) { }

}

