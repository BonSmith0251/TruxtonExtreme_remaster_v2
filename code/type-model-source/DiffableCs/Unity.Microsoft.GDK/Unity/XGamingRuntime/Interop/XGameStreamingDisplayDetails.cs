namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000361")]
internal struct XGameStreamingDisplayDetails
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009AB")]
	internal uint preferredWidth; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009AC")]
	internal uint preferredHeight; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009AD")]
	internal RECT safeArea; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009AE")]
	internal uint maxPixels; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40009AF")]
	internal uint maxWidth; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009B0")]
	internal uint maxHeight; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009B1")]
	internal XGameStreamingVideoFlags flags; //Field offset: 0x24

}

