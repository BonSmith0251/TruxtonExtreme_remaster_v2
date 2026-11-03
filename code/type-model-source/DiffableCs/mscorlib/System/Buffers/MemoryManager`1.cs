namespace System.Buffers;

[Token(Token = "0x200062C")]
public abstract class MemoryManager
{

	[Token(Token = "0x6002DE8")]
	public abstract Span<T> GetSpan() { }

	[Token(Token = "0x6002DE9")]
	public abstract MemoryHandle Pin(int elementIndex = 0) { }

	[Address(RVA = "0xD0D280", Offset = "0xD0C680", Length = "0x9")]
	[Token(Token = "0x6002DEA")]
	protected private override bool TryGetArray(out ArraySegment<T>& segment) { }

}

