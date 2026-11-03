namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C7")]
internal struct XAppCaptureVideoCaptureSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000781")]
	internal uint width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000782")]
	internal uint height; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000783")]
	internal ulong maxRecordTimespanDurationInMs; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000784")]
	internal XAppCaptureVideoEncoding encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000785")]
	internal XAppCaptureVideoColorFormat colorFormat; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000786")]
	internal bool isCaptureByGamesAllowed; //Field offset: 0x12

}

