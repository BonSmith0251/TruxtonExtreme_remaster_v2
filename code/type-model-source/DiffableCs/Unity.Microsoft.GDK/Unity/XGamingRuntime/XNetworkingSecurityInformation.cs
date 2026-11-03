namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200023F")]
public class XNetworkingSecurityInformation
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400063C")]
	private uint <EnabledHttpSecurityProtocolFlags>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400063D")]
	private XNetworkingThumbprint[] <Thumbprints>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700023A")]
	public uint EnabledHttpSecurityProtocolFlags
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000B97")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B98")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023B")]
	public XNetworkingThumbprint[] Thumbprints
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B99")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B9A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B9B")]
	public XNetworkingSecurityInformation() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000B97")]
	public uint get_EnabledHttpSecurityProtocolFlags() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B99")]
	public XNetworkingThumbprint[] get_Thumbprints() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B98")]
	public void set_EnabledHttpSecurityProtocolFlags(uint value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B9A")]
	public void set_Thumbprints(XNetworkingThumbprint[] value) { }

}

