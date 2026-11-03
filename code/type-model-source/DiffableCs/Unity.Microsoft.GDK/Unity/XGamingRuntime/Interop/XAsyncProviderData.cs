namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002CF")]
internal struct XAsyncProviderData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000788")]
	internal IntPtr async; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000789")]
	internal ulong bufferSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400078A")]
	internal IntPtr buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400078B")]
	internal IntPtr context; //Field offset: 0x18

}

