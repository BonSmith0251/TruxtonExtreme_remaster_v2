namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000314")]
internal struct XblMultiplayerConnectionAddressDeviceTokenPair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089D")]
	internal readonly UTF8StringPtr connectionAddress; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400089E")]
	internal readonly XblDeviceToken deviceToken; //Field offset: 0x8

	[Address(RVA = "0x2BB6540", Offset = "0x2BB5940", Length = "0x98")]
	[Token(Token = "0x6001178")]
	internal XblMultiplayerConnectionAddressDeviceTokenPair(XblMultiplayerConnectionAddressDeviceTokenPair publicObject, DisposableCollection disposableCollection) { }

}

