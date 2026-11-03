namespace Unity.Collections;

[Extension]
[Token(Token = "0x200001A")]
public static class AllocatorManager
{
	[Token(Token = "0x2000031")]
	private static class AllocatorCache
	{
		[Token(Token = "0x4000073")]
		public static FunctionPointer<TryFunction> TryFunction; //Field offset: 0x0
		[Token(Token = "0x4000074")]
		public static TryFunction CachedFunction; //Field offset: 0x0

	}

	[Token(Token = "0x200001C")]
	internal struct AllocatorHandle : IAllocator, IDisposable, IEquatable<AllocatorHandle>, IComparable<AllocatorHandle>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001D")]
		public ushort Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400001E")]
		public ushort Version; //Field offset: 0x2

		[Token(Token = "0x17000004")]
		public override TryFunction Function
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x600007F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000005")]
		public override AllocatorHandle Handle
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x6000081")]
			 get { } //Length: 3
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[Token(Token = "0x6000082")]
			 set { } //Length: 3
		}

		[Token(Token = "0x17000008")]
		public override bool IsAutoDispose
		{
			[Address(RVA = "0x28A8030", Offset = "0x28A7430", Length = "0xAE")]
			[Token(Token = "0x6000085")]
			 get { } //Length: 174
		}

		[Token(Token = "0x17000007")]
		public override bool IsCustomAllocator
		{
			[Address(RVA = "0x28A80E0", Offset = "0x28A74E0", Length = "0x8")]
			[Token(Token = "0x6000084")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000002")]
		internal bool IsInstalled
		{
			[Address(RVA = "0x28A80F0", Offset = "0x28A74F0", Length = "0xAE")]
			[Token(Token = "0x6000076")]
			internal get { } //Length: 174
		}

		[Token(Token = "0x17000001")]
		internal TableEntry TableEntry
		{
			[Address(RVA = "0x28A81A0", Offset = "0x28A75A0", Length = "0x83")]
			[Token(Token = "0x6000075")]
			internal get { } //Length: 131
		}

		[Token(Token = "0x17000006")]
		public override Allocator ToAllocator
		{
			[Address(RVA = "0x28A8230", Offset = "0x28A7630", Length = "0xD")]
			[Token(Token = "0x6000083")]
			 get { } //Length: 13
		}

		[Token(Token = "0x17000003")]
		public int Value
		{
			[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
			[Token(Token = "0x600007B")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x9EF510", Offset = "0x9EE910", Length = "0x66")]
		[Token(Token = "0x600007D")]
		public Block AllocateBlock(int items) { }

		[Address(RVA = "0x28A7DD0", Offset = "0x28A71D0", Length = "0x92")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x600007E")]
		private static void CheckAllocatedSuccessfully(int error) { }

		[Address(RVA = "0x1F90280", Offset = "0x1F8F680", Length = "0x9")]
		[Token(Token = "0x6000091")]
		public override int CompareTo(AllocatorHandle other) { }

		[Address(RVA = "0x28A7E70", Offset = "0x28A7270", Length = "0x16")]
		[Token(Token = "0x6000086")]
		public override void Dispose() { }

		[Address(RVA = "0x28A7E90", Offset = "0x28A7290", Length = "0x16")]
		[Token(Token = "0x6000089")]
		public bool Equals(Allocator other) { }

		[Address(RVA = "0x60A240", Offset = "0x609640", Length = "0x7")]
		[Token(Token = "0x6000088")]
		public override bool Equals(AllocatorHandle other) { }

		[Address(RVA = "0x28A7EB0", Offset = "0x28A72B0", Length = "0xF1")]
		[Token(Token = "0x6000087")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600007F")]
		public override TryFunction get_Function() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000081")]
		public override AllocatorHandle get_Handle() { }

		[Address(RVA = "0x28A8030", Offset = "0x28A7430", Length = "0xAE")]
		[Token(Token = "0x6000085")]
		public override bool get_IsAutoDispose() { }

		[Address(RVA = "0x28A80E0", Offset = "0x28A74E0", Length = "0x8")]
		[Token(Token = "0x6000084")]
		public override bool get_IsCustomAllocator() { }

		[Address(RVA = "0x28A80F0", Offset = "0x28A74F0", Length = "0xAE")]
		[Token(Token = "0x6000076")]
		internal bool get_IsInstalled() { }

		[Address(RVA = "0x28A81A0", Offset = "0x28A75A0", Length = "0x83")]
		[Token(Token = "0x6000075")]
		internal TableEntry get_TableEntry() { }

		[Address(RVA = "0x28A8230", Offset = "0x28A7630", Length = "0xD")]
		[Token(Token = "0x6000083")]
		public override Allocator get_ToAllocator() { }

		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[Token(Token = "0x600007B")]
		public int get_Value() { }

		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[Token(Token = "0x600008A")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000077")]
		internal void IncrementVersion() { }

		[Address(RVA = "0x28A7FB0", Offset = "0x28A73B0", Length = "0x1C")]
		[Token(Token = "0x6000079")]
		internal void Install(TableEntry tableEntry) { }

		[Address(RVA = "0x60A360", Offset = "0x609760", Length = "0x7")]
		[Token(Token = "0x600008B")]
		public static bool op_Equality(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[Address(RVA = "0x28A8250", Offset = "0x28A7650", Length = "0x7")]
		[Token(Token = "0x600008E")]
		public static bool op_GreaterThan(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[Address(RVA = "0x28A8240", Offset = "0x28A7640", Length = "0x7")]
		[Token(Token = "0x6000090")]
		public static bool op_GreaterThanOrEqual(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[Address(RVA = "0x28A8260", Offset = "0x28A7660", Length = "0x11")]
		[Token(Token = "0x600007A")]
		public static AllocatorHandle op_Implicit(Allocator a) { }

		[Address(RVA = "0x28A8280", Offset = "0x28A7680", Length = "0x7")]
		[Token(Token = "0x600008C")]
		public static bool op_Inequality(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[Address(RVA = "0x28A82A0", Offset = "0x28A76A0", Length = "0x7")]
		[Token(Token = "0x600008D")]
		public static bool op_LessThan(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[Address(RVA = "0x28A8290", Offset = "0x28A7690", Length = "0x7")]
		[Token(Token = "0x600008F")]
		public static bool op_LessThanOrEqual(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000078")]
		internal void Rewind() { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000082")]
		public override void set_Handle(AllocatorHandle value) { }

		[Address(RVA = "0x28A7FD0", Offset = "0x28A73D0", Length = "0x5A")]
		[Token(Token = "0x6000080")]
		public override int Try(ref Block block) { }

		[Address(RVA = "0x9EF580", Offset = "0x9EE980", Length = "0x108")]
		[Token(Token = "0x600007C")]
		public int TryAllocateBlock(out Block block, int items) { }

	}

	[Token(Token = "0x2000028")]
	public struct Array16
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		internal T f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		internal T f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		internal T f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		internal T f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		internal T f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		internal T f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		internal T f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		internal T f7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		internal T f8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		internal T f9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		internal T f10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		internal T f11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000043")]
		internal T f12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		internal T f13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		internal T f14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000046")]
		internal T f15; //Field offset: 0x0

	}

	[Token(Token = "0x2000029")]
	public struct Array256
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		internal Array16<T> f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000048")]
		internal Array16<T> f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000049")]
		internal Array16<T> f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		internal Array16<T> f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004B")]
		internal Array16<T> f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		internal Array16<T> f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004D")]
		internal Array16<T> f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004E")]
		internal Array16<T> f7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		internal Array16<T> f8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		internal Array16<T> f9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		internal Array16<T> f10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000052")]
		internal Array16<T> f11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000053")]
		internal Array16<T> f12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000054")]
		internal Array16<T> f13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000055")]
		internal Array16<T> f14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000056")]
		internal Array16<T> f15; //Field offset: 0x0

	}

	[Token(Token = "0x200002B")]
	public struct Array32768 : IIndexable<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000067")]
		internal Array4096<T> f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		internal Array4096<T> f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		internal Array4096<T> f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		internal Array4096<T> f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		internal Array4096<T> f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		internal Array4096<T> f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		internal Array4096<T> f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006E")]
		internal Array4096<T> f7; //Field offset: 0x0

		[Token(Token = "0x1700001D")]
		public override int Length
		{
			[Address(RVA = "0xB44540", Offset = "0xB43940", Length = "0x6")]
			[Token(Token = "0x60000CC")]
			 get { } //Length: 6
			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60000CD")]
			 set { } //Length: 3
		}

		[Address(RVA = "0xB44410", Offset = "0xB43810", Length = "0xE8")]
		[Token(Token = "0x60000CE")]
		public override T ElementAt(int index) { }

		[Address(RVA = "0xB44540", Offset = "0xB43940", Length = "0x6")]
		[Token(Token = "0x60000CC")]
		public override int get_Length() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000CD")]
		public override void set_Length(int value) { }

	}

	[Token(Token = "0x200002A")]
	public struct Array4096
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000057")]
		internal Array256<T> f0; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000058")]
		internal Array256<T> f1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000059")]
		internal Array256<T> f2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005A")]
		internal Array256<T> f3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005B")]
		internal Array256<T> f4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		internal Array256<T> f5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005D")]
		internal Array256<T> f6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005E")]
		internal Array256<T> f7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005F")]
		internal Array256<T> f8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000060")]
		internal Array256<T> f9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000061")]
		internal Array256<T> f10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000062")]
		internal Array256<T> f11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000063")]
		internal Array256<T> f12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000064")]
		internal Array256<T> f13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000065")]
		internal Array256<T> f14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000066")]
		internal Array256<T> f15; //Field offset: 0x0

	}

	[Token(Token = "0x200001F")]
	internal struct Block : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000023")]
		public Range Range; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000024")]
		public int BytesPerItem; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000025")]
		public int AllocatedItems; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000026")]
		public byte Log2Alignment; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000027")]
		public byte Padding0; //Field offset: 0x19
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x4000028")]
		public ushort Padding1; //Field offset: 0x1A
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000029")]
		public uint Padding2; //Field offset: 0x1C

		[Token(Token = "0x1700000B")]
		public int Alignment
		{
			[Address(RVA = "0x28ABBE0", Offset = "0x28AAFE0", Length = "0xC")]
			[Token(Token = "0x6000095")]
			 get { } //Length: 12
			[Address(RVA = "0x28ABC10", Offset = "0x28AB010", Length = "0x4B")]
			[Token(Token = "0x6000096")]
			 set { } //Length: 75
		}

		[Token(Token = "0x1700000A")]
		public long AllocatedBytes
		{
			[Address(RVA = "0x28ABBF0", Offset = "0x28AAFF0", Length = "0xD")]
			[Token(Token = "0x6000094")]
			 get { } //Length: 13
		}

		[Token(Token = "0x17000009")]
		public long Bytes
		{
			[Address(RVA = "0x28ABC00", Offset = "0x28AB000", Length = "0xD")]
			[Token(Token = "0x6000093")]
			 get { } //Length: 13
		}

		[Address(RVA = "0x28AB9C0", Offset = "0x28AADC0", Length = "0x50")]
		[Token(Token = "0x600009A")]
		public void Allocate() { }

		[Address(RVA = "0x28ABA10", Offset = "0x28AAE10", Length = "0xBC")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x600009C")]
		private void CheckFailedToAllocate(int error) { }

		[Address(RVA = "0x28ABAD0", Offset = "0x28AAED0", Length = "0xBC")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x600009D")]
		private void CheckFailedToFree(int error) { }

		[Address(RVA = "0x28ABB90", Offset = "0x28AAF90", Length = "0x50")]
		[Token(Token = "0x6000097")]
		public override void Dispose() { }

		[Address(RVA = "0x28ABB90", Offset = "0x28AAF90", Length = "0x50")]
		[Token(Token = "0x600009B")]
		public void Free() { }

		[Address(RVA = "0x28ABBE0", Offset = "0x28AAFE0", Length = "0xC")]
		[Token(Token = "0x6000095")]
		public int get_Alignment() { }

		[Address(RVA = "0x28ABBF0", Offset = "0x28AAFF0", Length = "0xD")]
		[Token(Token = "0x6000094")]
		public long get_AllocatedBytes() { }

		[Address(RVA = "0x28ABC00", Offset = "0x28AB000", Length = "0xD")]
		[Token(Token = "0x6000093")]
		public long get_Bytes() { }

		[Address(RVA = "0x28ABC10", Offset = "0x28AB010", Length = "0x4B")]
		[Token(Token = "0x6000096")]
		public void set_Alignment(int value) { }

		[Address(RVA = "0x28AB9C0", Offset = "0x28AADC0", Length = "0x50")]
		[Token(Token = "0x6000098")]
		public int TryAllocate() { }

		[Address(RVA = "0x28ABB90", Offset = "0x28AAF90", Length = "0x50")]
		[Token(Token = "0x6000099")]
		public int TryFree() { }

	}

	[Token(Token = "0x200001D")]
	internal struct BlockHandle
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001F")]
		public ushort Value; //Field offset: 0x0

	}

	[Token(Token = "0x2000020")]
	internal interface IAllocator : IDisposable
	{

		[Token(Token = "0x1700000C")]
		public TryFunction Function
		{
			[Token(Token = "0x600009E")]
			 get { } //Length: 0
		}

		[Token(Token = "0x1700000D")]
		public AllocatorHandle Handle
		{
			[Token(Token = "0x60000A0")]
			 get { } //Length: 0
			[Token(Token = "0x60000A1")]
			 set { } //Length: 0
		}

		[Token(Token = "0x17000010")]
		public bool IsAutoDispose
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60000A4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700000F")]
		public bool IsCustomAllocator
		{
			[Token(Token = "0x60000A3")]
			 get { } //Length: 0
		}

		[Token(Token = "0x1700000E")]
		public Allocator ToAllocator
		{
			[Token(Token = "0x60000A2")]
			 get { } //Length: 0
		}

		[Token(Token = "0x600009E")]
		public TryFunction get_Function() { }

		[Token(Token = "0x60000A0")]
		public AllocatorHandle get_Handle() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60000A4")]
		public bool get_IsAutoDispose() { }

		[Token(Token = "0x60000A3")]
		public bool get_IsCustomAllocator() { }

		[Token(Token = "0x60000A2")]
		public Allocator get_ToAllocator() { }

		[Token(Token = "0x60000A1")]
		public void set_Handle(AllocatorHandle value) { }

		[Token(Token = "0x600009F")]
		public int Try(ref Block block) { }

	}

	[Token(Token = "0x2000030")]
	public static class Managed
	{
		[Token(Token = "0x4000072")]
		internal static TryFunction[] TryFunctionDelegates; //Field offset: 0x0

		[Address(RVA = "0x28C48C0", Offset = "0x28C3CC0", Length = "0x68")]
		[Token(Token = "0x60000D8")]
		private static Managed() { }

		[Address(RVA = "0x28C4700", Offset = "0x28C3B00", Length = "0xDA")]
		[ExcludeFromBurstCompatTesting("Uses managed delegate")]
		[Token(Token = "0x60000D6")]
		public static void RegisterDelegate(int index, TryFunction function) { }

		[Address(RVA = "0x28C47E0", Offset = "0x28C3BE0", Length = "0xD1")]
		[ExcludeFromBurstCompatTesting("Uses managed delegate")]
		[Token(Token = "0x60000D7")]
		public static void UnregisterDelegate(int index) { }

	}

	[Token(Token = "0x200001E")]
	internal struct Range : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		public IntPtr Pointer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000021")]
		public int Items; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000022")]
		public AllocatorHandle Allocator; //Field offset: 0xC

		[Address(RVA = "0x28C4930", Offset = "0x28C3D30", Length = "0x71")]
		[Token(Token = "0x6000092")]
		public override void Dispose() { }

	}

	[Token(Token = "0x200002C")]
	public sealed class SharedStatics
	{
		[Token(Token = "0x200002F")]
		public sealed class IsAutoDispose
		{
			[Token(Token = "0x4000071")]
			internal static readonly SharedStatic<Long1024> Ref; //Field offset: 0x0

			[Address(RVA = "0x28C4600", Offset = "0x28C3A00", Length = "0x5D")]
			[Token(Token = "0x60000D5")]
			private static IsAutoDispose() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60000D4")]
			public IsAutoDispose() { }

		}

		[Token(Token = "0x200002D")]
		public sealed class IsInstalled
		{
			[Token(Token = "0x400006F")]
			internal static readonly SharedStatic<Long1024> Ref; //Field offset: 0x0

			[Address(RVA = "0x28C4660", Offset = "0x28C3A60", Length = "0x5D")]
			[Token(Token = "0x60000D1")]
			private static IsInstalled() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60000D0")]
			public IsInstalled() { }

		}

		[Token(Token = "0x200002E")]
		public sealed class TableEntry
		{
			[Token(Token = "0x4000070")]
			internal static readonly SharedStatic<Array32768`1<TableEntry>> Ref; //Field offset: 0x0

			[Address(RVA = "0x28C55F0", Offset = "0x28C49F0", Length = "0x5D")]
			[Token(Token = "0x60000D3")]
			private static TableEntry() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60000D2")]
			public TableEntry() { }

		}


		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000CF")]
		public SharedStatics() { }

	}

	[BurstCompile]
	[Token(Token = "0x2000024")]
	public struct SlabAllocator : IAllocator, IDisposable
	{
		[Token(Token = "0x2000026")]
		public static class Try_000000B9$BurstDirectCall
		{
			[Token(Token = "0x4000034")]
			private static IntPtr Pointer; //Field offset: 0x0

			[Address(RVA = "0x28C5C30", Offset = "0x28C5030", Length = "0x168")]
			[Token(Token = "0x60000CA")]
			private static IntPtr GetFunctionPointer() { }

			[Address(RVA = "0x28C5AB0", Offset = "0x28C4EB0", Length = "0x175")]
			[BurstDiscard]
			[Token(Token = "0x60000C9")]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			[Address(RVA = "0x28C4AE0", Offset = "0x28C3EE0", Length = "0x1E8")]
			[Token(Token = "0x60000CB")]
			public static int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		[Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class Try_000000B9$PostfixBurstDelegate : MulticastDelegate
		{

			[Address(RVA = "0x17A31D0", Offset = "0x17A25D0", Length = "0xA6")]
			[Token(Token = "0x60000C5")]
			public Try_000000B9$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			[Address(RVA = "0x28C5DA0", Offset = "0x28C51A0", Length = "0x97")]
			[Token(Token = "0x60000C7")]
			public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

			[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
			[Token(Token = "0x60000C8")]
			public override int EndInvoke(IAsyncResult unnamed_param_0) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x60000C6")]
			public override int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002E")]
		internal AllocatorHandle m_handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002F")]
		internal Block Storage; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000030")]
		internal int Log2SlabSizeInBytes; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000031")]
		internal FixedList4096Bytes<Int32> Occupied; //Field offset: 0x30
		[FieldOffset(Offset = "0x1030")]
		[Token(Token = "0x4000032")]
		internal long budgetInBytes; //Field offset: 0x1030
		[FieldOffset(Offset = "0x1038")]
		[Token(Token = "0x4000033")]
		internal long allocatedBytes; //Field offset: 0x1038

		[Token(Token = "0x17000019")]
		public long AllocatedBytes
		{
			[Address(RVA = "0x28C4F00", Offset = "0x28C4300", Length = "0x8")]
			[Token(Token = "0x60000BB")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000018")]
		public long BudgetInBytes
		{
			[Address(RVA = "0x28C4F10", Offset = "0x28C4310", Length = "0x8")]
			[Token(Token = "0x60000BA")]
			 get { } //Length: 8
		}

		[Token(Token = "0x1700001C")]
		public override TryFunction Function
		{
			[Address(RVA = "0x28C4F20", Offset = "0x28C4320", Length = "0xD5")]
			[Token(Token = "0x60000C2")]
			 get { } //Length: 213
		}

		[Token(Token = "0x17000015")]
		public override AllocatorHandle Handle
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x60000B6")]
			 get { } //Length: 3
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[Token(Token = "0x60000B7")]
			 set { } //Length: 3
		}

		[Token(Token = "0x17000017")]
		public override bool IsCustomAllocator
		{
			[Address(RVA = "0x28A80E0", Offset = "0x28A74E0", Length = "0x8")]
			[Token(Token = "0x60000B9")]
			 get { } //Length: 8
		}

		[Token(Token = "0x1700001B")]
		internal int Slabs
		{
			[Address(RVA = "0x28C5010", Offset = "0x28C4410", Length = "0x13")]
			[Token(Token = "0x60000BE")]
			internal get { } //Length: 19
		}

		[Token(Token = "0x1700001A")]
		internal int SlabSizeInBytes
		{
			[Address(RVA = "0x28C5000", Offset = "0x28C4400", Length = "0xB")]
			[Token(Token = "0x60000BC")]
			internal get { } //Length: 11
			[Address(RVA = "0x28C5030", Offset = "0x28C4430", Length = "0x55")]
			[Token(Token = "0x60000BD")]
			internal set { } //Length: 85
		}

		[Token(Token = "0x17000016")]
		public override Allocator ToAllocator
		{
			[Address(RVA = "0x28A8230", Offset = "0x28A7630", Length = "0xD")]
			[Token(Token = "0x60000B8")]
			 get { } //Length: 13
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000C3")]
		public override void Dispose() { }

		[Address(RVA = "0x28C4F00", Offset = "0x28C4300", Length = "0x8")]
		[Token(Token = "0x60000BB")]
		public long get_AllocatedBytes() { }

		[Address(RVA = "0x28C4F10", Offset = "0x28C4310", Length = "0x8")]
		[Token(Token = "0x60000BA")]
		public long get_BudgetInBytes() { }

		[Address(RVA = "0x28C4F20", Offset = "0x28C4320", Length = "0xD5")]
		[Token(Token = "0x60000C2")]
		public override TryFunction get_Function() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000B6")]
		public override AllocatorHandle get_Handle() { }

		[Address(RVA = "0x28A80E0", Offset = "0x28A74E0", Length = "0x8")]
		[Token(Token = "0x60000B9")]
		public override bool get_IsCustomAllocator() { }

		[Address(RVA = "0x28C5010", Offset = "0x28C4410", Length = "0x13")]
		[Token(Token = "0x60000BE")]
		internal int get_Slabs() { }

		[Address(RVA = "0x28C5000", Offset = "0x28C4400", Length = "0xB")]
		[Token(Token = "0x60000BC")]
		internal int get_SlabSizeInBytes() { }

		[Address(RVA = "0x28A8230", Offset = "0x28A7630", Length = "0xD")]
		[Token(Token = "0x60000B8")]
		public override Allocator get_ToAllocator() { }

		[Address(RVA = "0x28C49B0", Offset = "0x28C3DB0", Length = "0xF7")]
		[Token(Token = "0x60000BF")]
		internal void Initialize(Block storage, int slabSizeInBytes, long budget) { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60000B7")]
		public override void set_Handle(AllocatorHandle value) { }

		[Address(RVA = "0x28C5030", Offset = "0x28C4430", Length = "0x55")]
		[Token(Token = "0x60000BD")]
		internal void set_SlabSizeInBytes(int value) { }

		[Address(RVA = "0x28C4CD0", Offset = "0x28C40D0", Length = "0x222")]
		[Token(Token = "0x60000C0")]
		public override int Try(ref Block block) { }

		[Address(RVA = "0x28C4AE0", Offset = "0x28C3EE0", Length = "0x1E8")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		[Token(Token = "0x60000C1")]
		public static int Try(IntPtr allocatorState, ref Block block) { }

		[Address(RVA = "0x28C4AB0", Offset = "0x28C3EB0", Length = "0x23")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		[Token(Token = "0x60000C4")]
		internal static int Try$BurstManaged(IntPtr allocatorState, ref Block block) { }

	}

	[BurstCompile]
	[Token(Token = "0x2000021")]
	public struct StackAllocator : IAllocator, IDisposable
	{
		[Token(Token = "0x2000023")]
		public static class Try_000000AB$BurstDirectCall
		{
			[Token(Token = "0x400002D")]
			private static IntPtr Pointer; //Field offset: 0x0

			[Address(RVA = "0x28C58A0", Offset = "0x28C4CA0", Length = "0x168")]
			[Token(Token = "0x60000B4")]
			private static IntPtr GetFunctionPointer() { }

			[Address(RVA = "0x28C5720", Offset = "0x28C4B20", Length = "0x175")]
			[BurstDiscard]
			[Token(Token = "0x60000B3")]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			[Address(RVA = "0x28C5230", Offset = "0x28C4630", Length = "0x1E8")]
			[Token(Token = "0x60000B5")]
			public static int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		[Token(Token = "0x2000022")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class Try_000000AB$PostfixBurstDelegate : MulticastDelegate
		{

			[Address(RVA = "0x17A31D0", Offset = "0x17A25D0", Length = "0xA6")]
			[Token(Token = "0x60000AF")]
			public Try_000000AB$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			[Address(RVA = "0x28C5A10", Offset = "0x28C4E10", Length = "0x97")]
			[Token(Token = "0x60000B1")]
			public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

			[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
			[Token(Token = "0x60000B2")]
			public override int EndInvoke(IAsyncResult unnamed_param_0) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x60000B0")]
			public override int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002A")]
		internal AllocatorHandle m_handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002B")]
		internal Block m_storage; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400002C")]
		internal long m_top; //Field offset: 0x28

		[Token(Token = "0x17000014")]
		public override TryFunction Function
		{
			[Address(RVA = "0x28C5510", Offset = "0x28C4910", Length = "0xD5")]
			[Token(Token = "0x60000AC")]
			 get { } //Length: 213
		}

		[Token(Token = "0x17000011")]
		public override AllocatorHandle Handle
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x60000A5")]
			 get { } //Length: 3
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[Token(Token = "0x60000A6")]
			 set { } //Length: 3
		}

		[Token(Token = "0x17000013")]
		public override bool IsCustomAllocator
		{
			[Address(RVA = "0x28A80E0", Offset = "0x28A74E0", Length = "0x8")]
			[Token(Token = "0x60000A8")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000012")]
		public override Allocator ToAllocator
		{
			[Address(RVA = "0x28A8230", Offset = "0x28A7630", Length = "0xD")]
			[Token(Token = "0x60000A7")]
			 get { } //Length: 13
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000AD")]
		public override void Dispose() { }

		[Address(RVA = "0x28C5510", Offset = "0x28C4910", Length = "0xD5")]
		[Token(Token = "0x60000AC")]
		public override TryFunction get_Function() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000A5")]
		public override AllocatorHandle get_Handle() { }

		[Address(RVA = "0x28A80E0", Offset = "0x28A74E0", Length = "0x8")]
		[Token(Token = "0x60000A8")]
		public override bool get_IsCustomAllocator() { }

		[Address(RVA = "0x28A8230", Offset = "0x28A7630", Length = "0xD")]
		[Token(Token = "0x60000A7")]
		public override Allocator get_ToAllocator() { }

		[Address(RVA = "0x28C51E0", Offset = "0x28C45E0", Length = "0x18")]
		[Token(Token = "0x60000A9")]
		public void Initialize(Block storage) { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60000A6")]
		public override void set_Handle(AllocatorHandle value) { }

		[Address(RVA = "0x28C5420", Offset = "0x28C4820", Length = "0xEF")]
		[Token(Token = "0x60000AA")]
		public override int Try(ref Block block) { }

		[Address(RVA = "0x28C5230", Offset = "0x28C4630", Length = "0x1E8")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		[Token(Token = "0x60000AB")]
		public static int Try(IntPtr allocatorState, ref Block block) { }

		[Address(RVA = "0x28C5200", Offset = "0x28C4600", Length = "0x23")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(TryFunction))]
		[Token(Token = "0x60000AE")]
		internal static int Try$BurstManaged(IntPtr allocatorState, ref Block block) { }

	}

	[Token(Token = "0x2000027")]
	public struct TableEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		internal IntPtr function; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000036")]
		internal IntPtr state; //Field offset: 0x8

	}

	[Token(Token = "0x200001B")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class TryFunction : MulticastDelegate
	{

		[Address(RVA = "0x17A31D0", Offset = "0x17A25D0", Length = "0xA6")]
		[Token(Token = "0x6000071")]
		public TryFunction(object object, IntPtr method) { }

		[Address(RVA = "0x28C5650", Offset = "0x28C4A50", Length = "0x97")]
		[Token(Token = "0x6000073")]
		public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback callback, object object) { }

		[Address(RVA = "0x28C56F0", Offset = "0x28C4AF0", Length = "0x2F")]
		[Token(Token = "0x6000074")]
		public override int EndInvoke(ref Block block, IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000072")]
		public override int Invoke(IntPtr allocatorState, ref Block block) { }

	}

	[Token(Token = "0x400000F")]
	public static readonly AllocatorHandle Invalid; //Field offset: 0x0
	[Token(Token = "0x4000015")]
	public const int kErrorNone = 0; //Field offset: 0x0
	[Token(Token = "0x4000016")]
	public const int kErrorBufferOverflow = -1; //Field offset: 0x0
	[Token(Token = "0x4000017")]
	public const ushort FirstUserIndex = 64; //Field offset: 0x0
	[Token(Token = "0x4000018")]
	public const ushort MaxNumCustomAllocators = 32768; //Field offset: 0x0
	[Token(Token = "0x4000010")]
	public static readonly AllocatorHandle None; //Field offset: 0x4
	[Token(Token = "0x4000011")]
	public static readonly AllocatorHandle Temp; //Field offset: 0x8
	[Token(Token = "0x4000012")]
	public static readonly AllocatorHandle TempJob; //Field offset: 0xC
	[Token(Token = "0x4000013")]
	public static readonly AllocatorHandle Persistent; //Field offset: 0x10
	[Token(Token = "0x4000014")]
	public static readonly AllocatorHandle AudioKernel; //Field offset: 0x14
	[Token(Token = "0x4000019")]
	internal static readonly ushort NumGlobalScratchAllocators; //Field offset: 0x18
	[Token(Token = "0x400001A")]
	internal static readonly ushort MaxNumGlobalAllocators; //Field offset: 0x1A
	[Token(Token = "0x400001B")]
	internal static readonly uint GlobalAllocatorBaseIndex; //Field offset: 0x1C
	[Token(Token = "0x400001C")]
	internal static readonly uint FirstGlobalScratchpadAllocatorIndex; //Field offset: 0x20

	[Address(RVA = "0x28A9120", Offset = "0x28A8520", Length = "0x148")]
	[Token(Token = "0x6000070")]
	private static AllocatorManager() { }

	[Address(RVA = "0x6E2EF0", Offset = "0x6E22F0", Length = "0xAD")]
	[Extension]
	[Token(Token = "0x600004F")]
	public static Void* Allocate(ref T t, int sizeOf, int alignOf, int items = 1) { }

	[Address(RVA = "0x6E2C00", Offset = "0x6E2000", Length = "0xB8")]
	[Extension]
	[Token(Token = "0x6000050")]
	internal static U* Allocate(ref T t, U u, int items) { }

	[Address(RVA = "0x6E2FA0", Offset = "0x6E23A0", Length = "0xCF")]
	[Token(Token = "0x6000056")]
	public static T* Allocate(AllocatorHandle handle, int items = 1) { }

	[Address(RVA = "0x28A82B0", Offset = "0x28A76B0", Length = "0x86")]
	[Token(Token = "0x6000055")]
	public static Void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	[Address(RVA = "0x28A9270", Offset = "0x28A8670", Length = "0x90")]
	[Token(Token = "0x600005D")]
	private static int allocate_block(ref Block block) { }

	[Address(RVA = "0x6E1AB0", Offset = "0x6E0EB0", Length = "0x1A4")]
	[Extension]
	[Token(Token = "0x600004D")]
	internal static Block AllocateBlock(ref T t, int sizeOf, int alignOf, int items) { }

	[Address(RVA = "0x6E19D0", Offset = "0x6E0DD0", Length = "0xD8")]
	[Extension]
	[Token(Token = "0x600004E")]
	internal static Block AllocateBlock(ref T t, U u, int items) { }

	[Address(RVA = "0x6E2C00", Offset = "0x6E2000", Length = "0xB8")]
	[Extension]
	[Token(Token = "0x6000051")]
	internal static Void* AllocateStruct(ref T t, U u, int items) { }

	[Address(RVA = "0x16C3B70", Offset = "0x16C2F70", Length = "0x4")]
	[BurstDiscard]
	[Token(Token = "0x600005B")]
	private static void CheckDelegate(ref bool useDelegate) { }

	[Address(RVA = "0x28A8340", Offset = "0x28A7740", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600006D")]
	internal static void CheckFailedToAllocate(int error) { }

	[Address(RVA = "0x28A83A0", Offset = "0x28A77A0", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600006E")]
	internal static void CheckFailedToFree(int error) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600006F")]
	internal static void CheckValid(AllocatorHandle handle) { }

	[Address(RVA = "0x28A8400", Offset = "0x28A7800", Length = "0x12")]
	[Token(Token = "0x600005A")]
	public static AllocatorHandle ConvertToAllocatorHandle(Allocator a) { }

	[Address(RVA = "0x6E31F0", Offset = "0x6E25F0", Length = "0xD6")]
	[ExcludeFromBurstCompatTesting("Register uses managed delegate")]
	[Token(Token = "0x6000069")]
	internal static T CreateAllocator(AllocatorHandle backingAllocator, bool isGlobal = false, int globalIndex = 0) { }

	[Address(RVA = "0x6E3360", Offset = "0x6E2760", Length = "0x7A")]
	[ExcludeFromBurstCompatTesting("Registration uses managed delegates")]
	[Extension]
	[Token(Token = "0x600006A")]
	internal static void DestroyAllocator(ref T t, AllocatorHandle backingAllocator) { }

	[Address(RVA = "0x28A9310", Offset = "0x28A8710", Length = "0x110")]
	[BurstDiscard]
	[Token(Token = "0x600005E")]
	private static void forward_mono_allocate_block(ref Block block, ref int error) { }

	[Address(RVA = "0x75B040", Offset = "0x75A440", Length = "0xCF")]
	[Extension]
	[Token(Token = "0x6000053")]
	internal static void Free(ref T t, Void* pointer, int sizeOf, int alignOf, int items) { }

	[Address(RVA = "0x6E43F0", Offset = "0x6E37F0", Length = "0xBD")]
	[Extension]
	[Token(Token = "0x6000054")]
	internal static void Free(ref T t, U* pointer, int items) { }

	[Address(RVA = "0x28A8420", Offset = "0x28A7820", Length = "0x90")]
	[Token(Token = "0x6000057")]
	public static void Free(AllocatorHandle handle, Void* pointer, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	[Address(RVA = "0x6E4C90", Offset = "0x6E4090", Length = "0xE2")]
	[Token(Token = "0x6000059")]
	public static void Free(AllocatorHandle handle, T* pointer, int items = 1) { }

	[Address(RVA = "0x28A84B0", Offset = "0x28A78B0", Length = "0x69")]
	[Token(Token = "0x6000058")]
	public static void Free(AllocatorHandle handle, Void* pointer) { }

	[Address(RVA = "0x75A580", Offset = "0x759980", Length = "0xCF")]
	[Extension]
	[Token(Token = "0x6000052")]
	internal static void FreeBlock(ref T t, ref Block block) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000062")]
	public static void Initialize() { }

	[Address(RVA = "0x28A8520", Offset = "0x28A7920", Length = "0x2E8")]
	[Token(Token = "0x6000063")]
	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, FunctionPointer<TryFunction> functionPointer, TryFunction function, bool IsAutoDispose = false) { }

	[Address(RVA = "0x28A8810", Offset = "0x28A7C10", Length = "0xD4")]
	[Token(Token = "0x6000064")]
	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, TryFunction function) { }

	[Address(RVA = "0x28A88F0", Offset = "0x28A7CF0", Length = "0x8")]
	[Token(Token = "0x600006C")]
	internal static bool IsCustomAllocator(AllocatorHandle allocator) { }

	[Address(RVA = "0x28A8900", Offset = "0x28A7D00", Length = "0xF")]
	[Token(Token = "0x600005F")]
	internal static Allocator LegacyOf(AllocatorHandle handle) { }

	[Address(RVA = "0x28A8910", Offset = "0x28A7D10", Length = "0x31A")]
	[Token(Token = "0x6000065")]
	internal static AllocatorHandle Register(IntPtr allocatorState, FunctionPointer<TryFunction> functionPointer, bool IsAutoDispose = false, bool isGlobal = false, int globalIndex = 0) { }

	[Address(RVA = "0x75B540", Offset = "0x75A940", Length = "0x233")]
	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	[Extension]
	[Token(Token = "0x6000066")]
	public static void Register(ref T t, bool IsAutoDispose = false, bool isGlobal = false, int globalIndex = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600006B")]
	public static void Shutdown() { }

	[Address(RVA = "0x28A8DB0", Offset = "0x28A81B0", Length = "0x326")]
	[Token(Token = "0x6000061")]
	public static int Try(ref Block block) { }

	[Address(RVA = "0x28A8C30", Offset = "0x28A8030", Length = "0x177")]
	[Token(Token = "0x6000060")]
	private static int TryLegacy(ref Block block) { }

	[Address(RVA = "0x75B780", Offset = "0x75AB80", Length = "0x360")]
	[Extension]
	[Token(Token = "0x6000067")]
	public static void UnmanagedUnregister(ref T t) { }

	[Address(RVA = "0x75C0A0", Offset = "0x75B4A0", Length = "0x159")]
	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	[Extension]
	[Token(Token = "0x6000068")]
	public static void Unregister(ref T t) { }

	[Address(RVA = "0x28A90E0", Offset = "0x28A84E0", Length = "0x3C")]
	[Token(Token = "0x600005C")]
	private static bool UseDelegate() { }

}

