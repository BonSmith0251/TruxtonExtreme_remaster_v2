namespace UnityEngine.Android;

[Token(Token = "0x2000014")]
public class AndroidLocale
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000030")]
	private readonly string <country>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000031")]
	private readonly string <language>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000003")]
	public string country
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600010A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000004")]
	public string language
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600010B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600010C")]
	internal AndroidLocale(string _country, string _language) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600010A")]
	public string get_country() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600010B")]
	public string get_language() { }

}

