namespace System.Buffers;

[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
[Token(Token = "0x2000628")]
internal sealed class ArrayPoolEventSource : EventSource
{
	[Token(Token = "0x2000629")]
	public enum BufferAllocatedReason : int
	{
		Pooled = 0,
		OverMaximumSize = 1,
		PoolExhausted = 2,
	}

	[Token(Token = "0x40018B2")]
	internal static readonly ArrayPoolEventSource Log; //Field offset: 0x0

	[Address(RVA = "0x1FD3610", Offset = "0x1FD2A10", Length = "0xFB")]
	[Token(Token = "0x6002DE3")]
	private static ArrayPoolEventSource() { }

	[Address(RVA = "0x1FD3710", Offset = "0x1FD2B10", Length = "0xAD")]
	[Token(Token = "0x6002DDD")]
	private ArrayPoolEventSource() { }

	[Address(RVA = "0x1FD3380", Offset = "0x1FD2780", Length = "0x105")]
	[Event(2, Level = EventLevel::Informational (4))]
	[Token(Token = "0x6002DDF")]
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, BufferAllocatedReason reason) { }

	[Address(RVA = "0x1FD3490", Offset = "0x1FD2890", Length = "0xE8")]
	[Event(1, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x6002DDE")]
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Address(RVA = "0x1FD3580", Offset = "0x1FD2980", Length = "0x27")]
	[Event(3, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x6002DE0")]
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	[Address(RVA = "0x1FD35E0", Offset = "0x1FD29E0", Length = "0x27")]
	[Event(4, Level = EventLevel::Informational (4))]
	[Token(Token = "0x6002DE1")]
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId) { }

	[Address(RVA = "0x1FD35B0", Offset = "0x1FD29B0", Length = "0x22")]
	[Event(5, Level = EventLevel::Informational (4))]
	[Token(Token = "0x6002DE2")]
	internal void BufferTrimPoll(int milliseconds, int pressure) { }

}

