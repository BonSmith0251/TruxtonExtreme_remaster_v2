namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C0")]
internal struct XAppBroadcastStatus
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000758")]
	internal bool canStartBroadcast; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000759")]
	internal bool isAnyAppBroadcasting; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400075A")]
	internal bool isCaptureResourceUnavailable; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x400075B")]
	internal bool isGameStreamInProgress; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400075C")]
	internal bool isGpuConstrained; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x400075D")]
	internal bool isAppInactive; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400075E")]
	internal bool isBlockedForApp; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x400075F")]
	internal bool isDisabledByUser; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000760")]
	internal bool isDisabledBySystem; //Field offset: 0x8

}

