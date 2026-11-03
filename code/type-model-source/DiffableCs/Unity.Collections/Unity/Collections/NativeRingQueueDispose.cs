namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x20000C1")]
internal struct NativeRingQueueDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003EC")]
	public UnsafeRingQueue<Int32>* m_QueueData; //Field offset: 0x0

	[Address(RVA = "0x28C8AE0", Offset = "0x28C7EE0", Length = "0x39")]
	[Token(Token = "0x6000900")]
	public void Dispose() { }

}

