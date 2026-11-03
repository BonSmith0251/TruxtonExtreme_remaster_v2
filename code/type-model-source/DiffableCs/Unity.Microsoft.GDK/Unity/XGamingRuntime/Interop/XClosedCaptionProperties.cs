namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002BE")]
internal struct XClosedCaptionProperties
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400074E")]
	internal XColor BackgroundColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400074F")]
	internal XColor FontColor; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000750")]
	internal XColor WindowColor; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000751")]
	internal XClosedCaptionFontEdgeAttribute FontEdgeAttribute; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000752")]
	internal XClosedCaptionFontStyle FontStyle; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000753")]
	internal float FontScale; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000754")]
	internal bool Enabled; //Field offset: 0x18

}

