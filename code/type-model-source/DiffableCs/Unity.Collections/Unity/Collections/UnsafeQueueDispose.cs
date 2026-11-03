namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000F0")]
internal struct UnsafeQueueDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000469")]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400046A")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x28D3190", Offset = "0x28D2590", Length = "0x92")]
	[Token(Token = "0x6000A64")]
	public void Dispose() { }

}

