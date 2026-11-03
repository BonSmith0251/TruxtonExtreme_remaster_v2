namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200014A")]
public struct UnsafeText : INativeDisposable, IDisposable, IUTF8Bytes, INativeList<Byte>, IIndexable<Byte>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000545")]
	internal UntypedUnsafeList m_UntypedListData; //Field offset: 0x0

	[Token(Token = "0x170001A2")]
	public override int Capacity
	{
		[Address(RVA = "0x28D4340", Offset = "0x28D3740", Length = "0x64")]
		[IsReadOnly]
		[Token(Token = "0x6000DB3")]
		 get { } //Length: 100
		[Address(RVA = "0x28D44C0", Offset = "0x28D38C0", Length = "0x63")]
		[Token(Token = "0x6000DB4")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700019F")]
	public bool IsCreated
	{
		[Address(RVA = "0x28D43B0", Offset = "0x28D37B0", Length = "0x58")]
		[IsReadOnly]
		[Token(Token = "0x6000DA7")]
		 get { } //Length: 88
	}

	[Token(Token = "0x170001A0")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x28C6390", Offset = "0x28C5790", Length = "0x6E")]
		[IsReadOnly]
		[Token(Token = "0x6000DAC")]
		 get { } //Length: 110
	}

	[Token(Token = "0x170001A1")]
	public override byte Item
	{
		[Address(RVA = "0x28D4410", Offset = "0x28D3810", Length = "0x3E")]
		[Token(Token = "0x6000DAD")]
		 get { } //Length: 62
		[Address(RVA = "0x28D4530", Offset = "0x28D3930", Length = "0x4B")]
		[Token(Token = "0x6000DAE")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170001A3")]
	public override int Length
	{
		[Address(RVA = "0x28D4450", Offset = "0x28D3850", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000DB5")]
		 get { } //Length: 112
		[Address(RVA = "0x28D4580", Offset = "0x28D3980", Length = "0x97")]
		[Token(Token = "0x6000DB6")]
		 set { } //Length: 151
	}

	[Address(RVA = "0x28D4280", Offset = "0x28D3680", Length = "0xB8")]
	[Token(Token = "0x6000DA6")]
	public UnsafeText(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0x28D3BB0", Offset = "0x28D2FB0", Length = "0x5E")]
	[Token(Token = "0x6000DA8")]
	internal static UnsafeText* Alloc(AllocatorHandle allocator) { }

	[Address(RVA = "0x28D3C10", Offset = "0x28D3010", Length = "0x121")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000DBA")]
	private static void CheckCapacityInRange(int value, int length) { }

	[Address(RVA = "0x28D3D40", Offset = "0x28D3140", Length = "0x13F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000DB8")]
	private void CheckIndexInRange(int index) { }

	[Address(RVA = "0x28D3E80", Offset = "0x28D3280", Length = "0xA")]
	[Token(Token = "0x6000DB0")]
	public override void Clear() { }

	[Address(RVA = "0x28D3E90", Offset = "0x28D3290", Length = "0x55")]
	[Token(Token = "0x6000DAA")]
	public override void Dispose() { }

	[Address(RVA = "0x28D3EF0", Offset = "0x28D32F0", Length = "0x8C")]
	[Token(Token = "0x6000DAB")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x28D3F80", Offset = "0x28D3380", Length = "0x3D")]
	[Token(Token = "0x6000DAF")]
	public override byte ElementAt(int index) { }

	[Address(RVA = "0x28D3FC0", Offset = "0x28D33C0", Length = "0xDC")]
	[Token(Token = "0x6000DA9")]
	internal static void Free(UnsafeText* data) { }

	[Address(RVA = "0x28D4340", Offset = "0x28D3740", Length = "0x64")]
	[IsReadOnly]
	[Token(Token = "0x6000DB3")]
	public override int get_Capacity() { }

	[Address(RVA = "0x28D43B0", Offset = "0x28D37B0", Length = "0x58")]
	[IsReadOnly]
	[Token(Token = "0x6000DA7")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x28C6390", Offset = "0x28C5790", Length = "0x6E")]
	[IsReadOnly]
	[Token(Token = "0x6000DAC")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x28D4410", Offset = "0x28D3810", Length = "0x3E")]
	[Token(Token = "0x6000DAD")]
	public override byte get_Item(int index) { }

	[Address(RVA = "0x28D4450", Offset = "0x28D3850", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000DB5")]
	public override int get_Length() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000DB1")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x28D44C0", Offset = "0x28D38C0", Length = "0x63")]
	[Token(Token = "0x6000DB4")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x28D4530", Offset = "0x28D3930", Length = "0x4B")]
	[Token(Token = "0x6000DAE")]
	public override void set_Item(int index, byte value) { }

	[Address(RVA = "0x28D4580", Offset = "0x28D3980", Length = "0x97")]
	[Token(Token = "0x6000DB6")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x28D40A0", Offset = "0x28D34A0", Length = "0x89")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000DB9")]
	private void ThrowCopyError(CopyError error, string source) { }

	[Address(RVA = "0x28D4130", Offset = "0x28D3530", Length = "0x9A")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x6000DB7")]
	public virtual string ToString() { }

	[Address(RVA = "0x28D41D0", Offset = "0x28D35D0", Length = "0xA6")]
	[Token(Token = "0x6000DB2")]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

