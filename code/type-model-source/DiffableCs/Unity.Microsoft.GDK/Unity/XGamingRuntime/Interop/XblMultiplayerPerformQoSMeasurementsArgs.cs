namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200031B")]
internal struct XblMultiplayerPerformQoSMeasurementsArgs
{
	[CompilerGenerated]
	[Token(Token = "0x200031C")]
	private sealed class <>c
	{
		[Token(Token = "0x40008BF")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40008C0")]
		public static Func<XblMultiplayerConnectionAddressDeviceTokenPair, DisposableCollection, XblMultiplayerConnectionAddressDeviceTokenPair> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x2B9F570", Offset = "0x2B9E970", Length = "0x67")]
		[Token(Token = "0x600117F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001180")]
		public <>c() { }

		[Address(RVA = "0x2B9F370", Offset = "0x2B9E770", Length = "0xB3")]
		[Token(Token = "0x6001181")]
		internal XblMultiplayerConnectionAddressDeviceTokenPair <.ctor>b__3_0(XblMultiplayerConnectionAddressDeviceTokenPair x, DisposableCollection dc) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008BD")]
	private readonly XblMultiplayerConnectionAddressDeviceTokenPair* remoteClients; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008BE")]
	internal readonly SizeT remoteClientsSize; //Field offset: 0x8

	[Address(RVA = "0x2BB67D0", Offset = "0x2BB5BD0", Length = "0x155")]
	[Token(Token = "0x600117E")]
	internal XblMultiplayerPerformQoSMeasurementsArgs(XblMultiplayerPerformQoSMeasurementsArgs publicObject, DisposableCollection disposableCollection) { }

	[Address(RVA = "0x9E7110", Offset = "0x9E6510", Length = "0x57")]
	[Token(Token = "0x600117D")]
	internal T[] GetRemoteClients(Func<XblMultiplayerConnectionAddressDeviceTokenPair, T> ctor) { }

}

