namespace UnityEngine.InputSystem.Utilities;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
[Token(Token = "0x2000241")]
public class DisplayStringFormatAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C79")]
	private string <formatString>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170005F4")]
	public string formatString
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001515")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001516")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6001517")]
	public DisplayStringFormatAttribute(string formatString) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001515")]
	public string get_formatString() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001516")]
	public void set_formatString(string value) { }

}

