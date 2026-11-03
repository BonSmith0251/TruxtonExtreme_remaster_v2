namespace Unity.Collections;

[Token(Token = "0x200004B")]
public struct DoubleRewindableAllocators : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BB")]
	private RewindableAllocator* Pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BC")]
	private AllocatorHelper<RewindableAllocator> UpdateAllocatorHelper0; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BD")]
	private AllocatorHelper<RewindableAllocator> UpdateAllocatorHelper1; //Field offset: 0x18

	[Token(Token = "0x17000037")]
	public RewindableAllocator Allocator
	{
		[Address(RVA = "0x28AF6E0", Offset = "0x28AEAE0", Length = "0x37")]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000039")]
	internal bool EnableBlockFree
	{
		[Address(RVA = "0x28AF720", Offset = "0x28AEB20", Length = "0x44")]
		[Token(Token = "0x60001F3")]
		internal get { } //Length: 68
		[Address(RVA = "0x28AF770", Offset = "0x28AEB70", Length = "0x72")]
		[Token(Token = "0x60001F4")]
		internal set { } //Length: 114
	}

	[Token(Token = "0x17000038")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x60001EF")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x28AF6C0", Offset = "0x28AEAC0", Length = "0x18")]
	[Token(Token = "0x60001F0")]
	public DoubleRewindableAllocators(AllocatorHandle backingAllocator, int initialSizeInBytes) { }

	[Address(RVA = "0x28AF420", Offset = "0x28AE820", Length = "0x61")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60001ED")]
	private void CheckIsCreated() { }

	[Address(RVA = "0x28AF490", Offset = "0x28AE890", Length = "0x96")]
	[Token(Token = "0x60001F2")]
	public override void Dispose() { }

	[Address(RVA = "0x28AF6E0", Offset = "0x28AEAE0", Length = "0x37")]
	[Token(Token = "0x60001EE")]
	public RewindableAllocator get_Allocator() { }

	[Address(RVA = "0x28AF720", Offset = "0x28AEB20", Length = "0x44")]
	[Token(Token = "0x60001F3")]
	internal bool get_EnableBlockFree() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[Token(Token = "0x60001EF")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x28AF530", Offset = "0x28AE930", Length = "0xFE")]
	[Token(Token = "0x60001F1")]
	public void Initialize(AllocatorHandle backingAllocator, int initialSizeInBytes) { }

	[Address(RVA = "0x28AF770", Offset = "0x28AEB70", Length = "0x72")]
	[Token(Token = "0x60001F4")]
	internal void set_EnableBlockFree(bool value) { }

	[Address(RVA = "0x28AF630", Offset = "0x28AEA30", Length = "0x86")]
	[Token(Token = "0x60001EC")]
	public void Update() { }

}

