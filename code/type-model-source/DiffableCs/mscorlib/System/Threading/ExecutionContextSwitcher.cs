namespace System.Threading;

[Token(Token = "0x2000223")]
internal struct ExecutionContextSwitcher
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F6")]
	internal Reader outerEC; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009F7")]
	internal bool outerECBelongsToScope; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009F8")]
	internal object hecsw; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009F9")]
	internal Thread thread; //Field offset: 0x18

	[Address(RVA = "0x209DC20", Offset = "0x209D020", Length = "0xA3")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600124F")]
	internal void Undo() { }

	[Address(RVA = "0x209DC00", Offset = "0x209D000", Length = "0x1A")]
	[HandleProcessCorruptedStateExceptions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600124E")]
	internal bool UndoNoThrow() { }

}

