namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C2")]
internal struct XAppCaptureRecordClipResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000763")]
	internal string path; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000764")]
	internal long fileSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000765")]
	internal long startTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000766")]
	internal uint durationInMs; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000767")]
	internal uint width; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000768")]
	internal uint height; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000769")]
	internal XAppCaptureVideoEncoding encoding; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400076A")]
	internal uint startTimePreciseOffsetHns; //Field offset: 0x28

}

