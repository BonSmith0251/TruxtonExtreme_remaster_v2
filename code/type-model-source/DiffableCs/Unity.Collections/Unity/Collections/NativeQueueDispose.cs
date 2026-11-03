namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x20000B9")]
internal struct NativeQueueDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003E2")]
	public UnsafeQueue<Int32>* m_QueueData; //Field offset: 0x0

	[Address(RVA = "0x28C89A0", Offset = "0x28C7DA0", Length = "0x39")]
	[Token(Token = "0x60008D9")]
	public void Dispose() { }

}

