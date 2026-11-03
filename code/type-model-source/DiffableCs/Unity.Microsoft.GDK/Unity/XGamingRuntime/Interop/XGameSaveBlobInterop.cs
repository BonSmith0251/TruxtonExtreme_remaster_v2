namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000358")]
internal struct XGameSaveBlobInterop
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000995")]
	internal XGameSaveBlobInfo info; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000996")]
	internal IntPtr data; //Field offset: 0x10

}

