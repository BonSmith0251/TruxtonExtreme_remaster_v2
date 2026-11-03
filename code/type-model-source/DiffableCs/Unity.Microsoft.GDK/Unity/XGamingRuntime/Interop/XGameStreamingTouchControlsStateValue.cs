namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200035E")]
internal struct XGameStreamingTouchControlsStateValue
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400099F")]
	internal XGameStreamingTouchControlsStateValueKind valueKind; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A0")]
	internal IntPtr stringValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A1")]
	internal double doubleValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A2")]
	internal bool boolValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A3")]
	internal uint integerValue; //Field offset: 0x8

}

