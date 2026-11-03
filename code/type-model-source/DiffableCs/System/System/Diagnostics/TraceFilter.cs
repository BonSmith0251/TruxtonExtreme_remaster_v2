namespace System.Diagnostics;

[Token(Token = "0x20000FF")]
public abstract class TraceFilter
{

	[Token(Token = "0x600062D")]
	public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, Object[] args, object data1, Object[] data) { }

	[Address(RVA = "0x263E530", Offset = "0x263D930", Length = "0x4B")]
	[Token(Token = "0x600062E")]
	internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage) { }

}

