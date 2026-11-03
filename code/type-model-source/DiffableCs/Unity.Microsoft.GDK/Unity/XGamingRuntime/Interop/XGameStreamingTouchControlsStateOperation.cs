namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200035F")]
internal struct XGameStreamingTouchControlsStateOperation
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A4")]
	internal XGameStreamingTouchControlsStateOperationKind operationKind; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A5")]
	internal string path; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009A6")]
	internal XGameStreamingTouchControlsStateValue value; //Field offset: 0x10

}

