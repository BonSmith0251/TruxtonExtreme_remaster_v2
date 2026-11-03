namespace System.Data;

[EventSource(Name = "System.Data.DataCommonEventSource")]
[Token(Token = "0x2000027")]
internal class DataCommonEventSource : EventSource
{
	[Token(Token = "0x40000EB")]
	internal static readonly DataCommonEventSource Log; //Field offset: 0x0
	[Token(Token = "0x40000EC")]
	private static long s_nextScopeId; //Field offset: 0x8

	[Address(RVA = "0x2318830", Offset = "0x2317C30", Length = "0x7E")]
	[Token(Token = "0x6000330")]
	private static DataCommonEventSource() { }

	[Address(RVA = "0x23188B0", Offset = "0x2317CB0", Length = "0x7")]
	[Token(Token = "0x600032F")]
	public DataCommonEventSource() { }

	[Address(RVA = "0x2318740", Offset = "0x2317B40", Length = "0xCF")]
	[Event(2, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x6000329")]
	internal long EnterScope(string message) { }

	[Address(RVA = "0x7C6490", Offset = "0x7C5890", Length = "0xCA")]
	[NonEvent]
	[Token(Token = "0x600032A")]
	internal long EnterScope(string format, T1 arg1) { }

	[Address(RVA = "0x7C5BC0", Offset = "0x7C4FC0", Length = "0xF9")]
	[NonEvent]
	[Token(Token = "0x600032B")]
	internal long EnterScope(string format, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x7C5CC0", Offset = "0x7C50C0", Length = "0x126")]
	[NonEvent]
	[Token(Token = "0x600032C")]
	internal long EnterScope(string format, T1 arg1, T2 arg2, T3 arg3) { }

	[Address(RVA = "0x7C5EF0", Offset = "0x7C52F0", Length = "0x290")]
	[NonEvent]
	[Token(Token = "0x600032D")]
	internal long EnterScope(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[Address(RVA = "0x2318810", Offset = "0x2317C10", Length = "0x10")]
	[Event(3, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x600032E")]
	internal void ExitScope(long scopeId) { }

	[Address(RVA = "0x2318820", Offset = "0x2317C20", Length = "0x10")]
	[Event(1, Level = EventLevel::Informational (4))]
	[Token(Token = "0x6000322")]
	internal void Trace(string message) { }

	[Address(RVA = "0x7C8C10", Offset = "0x7C8010", Length = "0xC6")]
	[NonEvent]
	[Token(Token = "0x6000323")]
	internal void Trace(string format, T0 arg0) { }

	[Address(RVA = "0x7C7850", Offset = "0x7C6C50", Length = "0xF5")]
	[NonEvent]
	[Token(Token = "0x6000324")]
	internal void Trace(string format, T0 arg0, T1 arg1) { }

	[Address(RVA = "0x7C7A50", Offset = "0x7C6E50", Length = "0x11E")]
	[NonEvent]
	[Token(Token = "0x6000325")]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x7C7F40", Offset = "0x7C7340", Length = "0x28B")]
	[NonEvent]
	[Token(Token = "0x6000326")]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[Address(RVA = "0x7C8500", Offset = "0x7C7900", Length = "0x2DA")]
	[NonEvent]
	[Token(Token = "0x6000327")]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[Address(RVA = "0x7C7B70", Offset = "0x7C6F70", Length = "0x3C6")]
	[NonEvent]
	[Token(Token = "0x6000328")]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

}

