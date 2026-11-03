namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200019B")]
public class XblMultiplayerPerformQoSMeasurementsArgs
{
	[CompilerGenerated]
	[Token(Token = "0x200019C")]
	private sealed class <>c
	{
		[Token(Token = "0x40003D8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003D9")]
		public static Func<XblMultiplayerConnectionAddressDeviceTokenPair, XblMultiplayerConnectionAddressDeviceTokenPair> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B809E0", Offset = "0x2B7FDE0", Length = "0x67")]
		[Token(Token = "0x60008E5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008E6")]
		public <>c() { }

		[Address(RVA = "0x2B7FC00", Offset = "0x2B7F000", Length = "0x14E")]
		[Token(Token = "0x60008E7")]
		internal XblMultiplayerConnectionAddressDeviceTokenPair <.ctor>b__0_0(XblMultiplayerConnectionAddressDeviceTokenPair x) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003D7")]
	private readonly XblMultiplayerConnectionAddressDeviceTokenPair[] <RemoteClients>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000156")]
	public XblMultiplayerConnectionAddressDeviceTokenPair[] RemoteClients
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008E4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B87A90", Offset = "0x2B86E90", Length = "0x140")]
	[Token(Token = "0x60008E3")]
	internal XblMultiplayerPerformQoSMeasurementsArgs(XblMultiplayerPerformQoSMeasurementsArgs interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008E4")]
	public XblMultiplayerConnectionAddressDeviceTokenPair[] get_RemoteClients() { }

}

