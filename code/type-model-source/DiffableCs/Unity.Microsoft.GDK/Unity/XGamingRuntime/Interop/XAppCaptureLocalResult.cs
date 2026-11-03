namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C6")]
internal struct XAppCaptureLocalResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000779")]
	internal IntPtr clipHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400077A")]
	internal ulong fileSizeInBytes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400077B")]
	internal SYSTEMTIME clipStartTimestamp; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400077C")]
	internal ulong durationInMilliseconds; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400077D")]
	internal uint width; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400077E")]
	internal uint height; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400077F")]
	internal XAppCaptureVideoEncoding encoding; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000780")]
	internal XAppCaptureVideoColorFormat colorFormat; //Field offset: 0x31

}

