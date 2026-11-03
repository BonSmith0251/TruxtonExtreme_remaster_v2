namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200018C")]
internal sealed class TryCatchFinallyHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000337")]
	internal readonly int TryStartIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000338")]
	internal readonly int TryEndIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000339")]
	internal readonly int FinallyStartIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400033A")]
	internal readonly int FinallyEndIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400033B")]
	internal readonly int GotoEndTargetIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400033C")]
	private readonly ExceptionHandler[] _handlers; //Field offset: 0x28

	[Token(Token = "0x170001CC")]
	internal ExceptionHandler[] Handlers
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000844")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001CD")]
	internal bool IsCatchBlockExist
	{
		[Address(RVA = "0x1EC4360", Offset = "0x1EC3760", Length = "0x9")]
		[Token(Token = "0x6000845")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170001CB")]
	internal bool IsFinallyBlockExist
	{
		[Address(RVA = "0x2290630", Offset = "0x228FA30", Length = "0xB")]
		[Token(Token = "0x6000843")]
		internal get { } //Length: 11
	}

	[Address(RVA = "0x22905C0", Offset = "0x228F9C0", Length = "0x63")]
	[Token(Token = "0x6000846")]
	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	[Address(RVA = "0x2290550", Offset = "0x228F950", Length = "0x63")]
	[Token(Token = "0x6000847")]
	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	[Address(RVA = "0x2290170", Offset = "0x228F570", Length = "0x24B")]
	[Token(Token = "0x6000849")]
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000844")]
	internal ExceptionHandler[] get_Handlers() { }

	[Address(RVA = "0x1EC4360", Offset = "0x1EC3760", Length = "0x9")]
	[Token(Token = "0x6000845")]
	internal bool get_IsCatchBlockExist() { }

	[Address(RVA = "0x2290630", Offset = "0x228FA30", Length = "0xB")]
	[Token(Token = "0x6000843")]
	internal bool get_IsFinallyBlockExist() { }

	[Address(RVA = "0x22903C0", Offset = "0x228F7C0", Length = "0x185")]
	[Token(Token = "0x6000848")]
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

}

