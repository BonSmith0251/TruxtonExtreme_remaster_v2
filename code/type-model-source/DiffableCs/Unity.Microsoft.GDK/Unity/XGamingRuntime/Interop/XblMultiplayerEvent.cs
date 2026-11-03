namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000315")]
internal struct XblMultiplayerEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400089F")]
	internal readonly int Result; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008A0")]
	internal readonly UTF8StringPtr ErrorMessage; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008A1")]
	internal readonly IntPtr Context; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008A2")]
	internal readonly XblMultiplayerEventType EventType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008A3")]
	internal readonly XblMultiplayerEventArgsHandle EventArgsHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008A4")]
	internal readonly XblMultiplayerSessionType SessionType; //Field offset: 0x28

}

