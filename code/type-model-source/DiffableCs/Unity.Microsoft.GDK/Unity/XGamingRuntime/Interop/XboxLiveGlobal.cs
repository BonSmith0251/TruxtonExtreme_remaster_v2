namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003BE")]
public static class XboxLiveGlobal
{

	[Address(RVA = "0x2BB8FB0", Offset = "0x2BB83B0", Length = "0x78")]
	[Token(Token = "0x6001280")]
	public static int XblGetScid(SByte** scid) { }

}

