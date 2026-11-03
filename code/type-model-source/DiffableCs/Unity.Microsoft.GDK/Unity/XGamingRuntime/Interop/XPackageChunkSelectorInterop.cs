namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000373")]
internal struct XPackageChunkSelectorInterop
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D1")]
	internal XPackageChunkSelectorType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009D2")]
	internal IntPtr languageOrTagOrFeature; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009D3")]
	internal uint chunkId; //Field offset: 0x8

}

