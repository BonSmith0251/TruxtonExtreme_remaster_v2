namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200018F")]
public class XblMultiplayerConnectionAddressDeviceTokenPair
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000379")]
	private readonly string <ConnectionAddress>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400037A")]
	private readonly XblDeviceToken <DeviceToken>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000136")]
	public string ConnectionAddress
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008BB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000137")]
	public XblDeviceToken DeviceToken
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008BC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B86FE0", Offset = "0x2B863E0", Length = "0x123")]
	[Token(Token = "0x60008BA")]
	internal XblMultiplayerConnectionAddressDeviceTokenPair(XblMultiplayerConnectionAddressDeviceTokenPair interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008BB")]
	public string get_ConnectionAddress() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008BC")]
	public XblDeviceToken get_DeviceToken() { }

}

