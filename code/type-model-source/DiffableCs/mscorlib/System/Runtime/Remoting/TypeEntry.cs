namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200035F")]
public class TypeEntry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E1E")]
	private string assembly_name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E1F")]
	private string type_name; //Field offset: 0x18

	[Token(Token = "0x170002DB")]
	public string AssemblyName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001B35")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001B36")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002DC")]
	public string TypeName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001B37")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001B38")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001B34")]
	protected TypeEntry() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001B35")]
	public string get_AssemblyName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001B37")]
	public string get_TypeName() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001B36")]
	public void set_AssemblyName(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001B38")]
	public void set_TypeName(string value) { }

}

