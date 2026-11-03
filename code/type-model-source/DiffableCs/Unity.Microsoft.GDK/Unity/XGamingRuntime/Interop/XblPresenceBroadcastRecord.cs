namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000327")]
internal struct XblPresenceBroadcastRecord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008EE")]
	internal readonly UTF8StringPtr broadcastId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008EF")]
	internal readonly Byte[] session; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008F0")]
	internal readonly XblPresenceBroadcastProvider provider; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40008F1")]
	internal readonly uint viewerCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008F2")]
	internal readonly TimeT startTime; //Field offset: 0x18

}

