namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200018F")]
internal sealed class DebugInfo
{
	[Token(Token = "0x2000190")]
	private class DebugInfoComparer : IComparer<DebugInfo>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000851")]
		public DebugInfoComparer() { }

		[Address(RVA = "0x226E3D0", Offset = "0x226D7D0", Length = "0x36")]
		[Token(Token = "0x6000850")]
		private override int System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(DebugInfo d1, DebugInfo d2) { }

	}

	[Token(Token = "0x4000346")]
	private static readonly DebugInfoComparer s_debugComparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000341")]
	public int StartLine; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000342")]
	public int EndLine; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000343")]
	public int Index; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000344")]
	public string FileName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000345")]
	public bool IsClear; //Field offset: 0x28

	[Address(RVA = "0x226E7A0", Offset = "0x226DBA0", Length = "0x73")]
	[Token(Token = "0x600084F")]
	private static DebugInfo() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600084E")]
	public DebugInfo() { }

	[Address(RVA = "0x226E410", Offset = "0x226D810", Length = "0xE9")]
	[Token(Token = "0x600084C")]
	public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index) { }

	[Address(RVA = "0x226E500", Offset = "0x226D900", Length = "0x294")]
	[Token(Token = "0x600084D")]
	public virtual string ToString() { }

}

