namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
[Token(Token = "0x2000032")]
public struct AllocatorHelper : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000075")]
	private readonly T* m_allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000076")]
	private AllocatorHandle m_backingAllocator; //Field offset: 0x0

	[Token(Token = "0x1700001E")]
	public T Allocator
	{
		[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
		[Token(Token = "0x60000D9")]
		 get { } //Length: 36
	}

	[Address(RVA = "0x1C4E270", Offset = "0x1C4D670", Length = "0x9F")]
	[ExcludeFromBurstCompatTesting("CreateAllocator is unburstable")]
	[Token(Token = "0x60000DA")]
	public AllocatorHelper`1(AllocatorHandle backingAllocator, bool isGlobal = false, int globalIndex = 0) { }

	[Address(RVA = "0x1C4DFB0", Offset = "0x1C4D3B0", Length = "0x97")]
	[ExcludeFromBurstCompatTesting("DestroyAllocator is unburstable")]
	[Token(Token = "0x60000DB")]
	public override void Dispose() { }

	[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
	[Token(Token = "0x60000D9")]
	public T get_Allocator() { }

}

