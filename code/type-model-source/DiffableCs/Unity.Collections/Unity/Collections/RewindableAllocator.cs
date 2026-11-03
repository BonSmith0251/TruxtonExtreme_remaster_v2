namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x20000D8")]
public struct RewindableAllocator : IAllocator, IDisposable
{
	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x20000DA")]
	public struct MemoryBlock : IDisposable
	{
		[Token(Token = "0x400042A")]
		public const int kMaximumAlignment = 16384; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042B")]
		public Byte* m_pointer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400042C")]
		public long m_bytes; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400042D")]
		public Union m_union; //Field offset: 0x10

		[Address(RVA = "0x28C7E70", Offset = "0x28C7270", Length = "0x112")]
		[Token(Token = "0x6000A05")]
		public MemoryBlock(long bytes) { }

		[Address(RVA = "0x28C7DA0", Offset = "0x28C71A0", Length = "0x46")]
		[Token(Token = "0x6000A08")]
		public bool Contains(IntPtr ptr) { }

		[Address(RVA = "0x28C7DF0", Offset = "0x28C71F0", Length = "0x61")]
		[Token(Token = "0x6000A07")]
		public override void Dispose() { }

		[Address(RVA = "0x28C7E60", Offset = "0x28C7260", Length = "0x7")]
		[Token(Token = "0x6000A06")]
		public void Rewind() { }

	}

	[Token(Token = "0x20000DC")]
	public static class Try_000009E0$BurstDirectCall
	{
		[Token(Token = "0x400042E")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x28CF7A0", Offset = "0x28CEBA0", Length = "0x168")]
		[Token(Token = "0x6000A0E")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x28CF620", Offset = "0x28CEA20", Length = "0x175")]
		[BurstDiscard]
		[Token(Token = "0x6000A0D")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x28CCE10", Offset = "0x28CC210", Length = "0x1E8")]
		[Token(Token = "0x6000A0F")]
		public static int Invoke(IntPtr state, ref Block block) { }

	}

	[Token(Token = "0x20000DB")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Try_000009E0$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x17A31D0", Offset = "0x17A25D0", Length = "0xA6")]
		[Token(Token = "0x6000A09")]
		public Try_000009E0$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x28CF910", Offset = "0x28CED10", Length = "0x97")]
		[Token(Token = "0x6000A0B")]
		public override IAsyncResult BeginInvoke(IntPtr state, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x6000A0C")]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000A0A")]
		public override int Invoke(IntPtr state, ref Block block) { }

	}

	[Token(Token = "0x20000D9")]
	public struct Union
	{
		[Token(Token = "0x4000424")]
		private const int currentBits = 40; //Field offset: 0x0
		[Token(Token = "0x4000425")]
		private const int currentOffset = 0; //Field offset: 0x0
		[Token(Token = "0x4000426")]
		private const long currentMask = 1099511627775; //Field offset: 0x0
		[Token(Token = "0x4000427")]
		private const int allocCountBits = 24; //Field offset: 0x0
		[Token(Token = "0x4000428")]
		private const int allocCountOffset = 40; //Field offset: 0x0
		[Token(Token = "0x4000429")]
		private const long allocCountMask = 16777215; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000423")]
		internal long m_long; //Field offset: 0x0

		[Token(Token = "0x1700012B")]
		internal long m_allocCount
		{
			[Address(RVA = "0x28D0E70", Offset = "0x28D0270", Length = "0xD")]
			[Token(Token = "0x6000A03")]
			internal get { } //Length: 13
			[Address(RVA = "0x28D0EA0", Offset = "0x28D02A0", Length = "0x15")]
			[Token(Token = "0x6000A04")]
			internal set { } //Length: 21
		}

		[Token(Token = "0x1700012A")]
		internal long m_current
		{
			[Address(RVA = "0x28D0E80", Offset = "0x28D0280", Length = "0x11")]
			[Token(Token = "0x6000A01")]
			internal get { } //Length: 17
			[Address(RVA = "0x28D0EC0", Offset = "0x28D02C0", Length = "0x1A")]
			[Token(Token = "0x6000A02")]
			internal set { } //Length: 26
		}

		[Address(RVA = "0x28D0E70", Offset = "0x28D0270", Length = "0xD")]
		[Token(Token = "0x6000A03")]
		internal long get_m_allocCount() { }

		[Address(RVA = "0x28D0E80", Offset = "0x28D0280", Length = "0x11")]
		[Token(Token = "0x6000A01")]
		internal long get_m_current() { }

		[Address(RVA = "0x28D0EA0", Offset = "0x28D02A0", Length = "0x15")]
		[Token(Token = "0x6000A04")]
		internal void set_m_allocCount(long value) { }

		[Address(RVA = "0x28D0EC0", Offset = "0x28D02C0", Length = "0x1A")]
		[Token(Token = "0x6000A02")]
		internal void set_m_current(long value) { }

	}

	[Token(Token = "0x4000416")]
	private const int kLog2MaxMemoryBlockSize = 26; //Field offset: 0x0
	[Token(Token = "0x4000417")]
	private const long kMaxMemoryBlockSize = 67108864; //Field offset: 0x0
	[Token(Token = "0x4000418")]
	private const long kMinMemoryBlockSize = 131072; //Field offset: 0x0
	[Token(Token = "0x4000419")]
	private const int kMaxNumBlocks = 64; //Field offset: 0x0
	[Token(Token = "0x400041A")]
	private const int kBlockBusyRewindMask = -2147483648; //Field offset: 0x0
	[Token(Token = "0x400041B")]
	private const int kBlockBusyAllocateMask = 2147483647; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400041C")]
	private Spinner m_spinner; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400041D")]
	private AllocatorHandle m_handle; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400041E")]
	private UnmanagedArray<MemoryBlock> m_block; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400041F")]
	private int m_last; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000420")]
	private int m_used; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000421")]
	private byte m_enableBlockFree; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000422")]
	private byte m_reachMaxBlockSize; //Field offset: 0x21

	[Token(Token = "0x17000121")]
	public int BlocksAllocated
	{
		[Address(RVA = "0x28CD000", Offset = "0x28CC400", Length = "0x6")]
		[Token(Token = "0x60009EF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000124")]
	internal long BytesAllocated
	{
		[Address(RVA = "0x28CD010", Offset = "0x28CC410", Length = "0x73")]
		[Token(Token = "0x60009F2")]
		internal get { } //Length: 115
	}

	[Token(Token = "0x17000120")]
	public bool EnableBlockFree
	{
		[Address(RVA = "0x28CD090", Offset = "0x28CC490", Length = "0x8")]
		[Token(Token = "0x60009ED")]
		 get { } //Length: 8
		[Address(RVA = "0x28CD170", Offset = "0x28CC570", Length = "0x6")]
		[Token(Token = "0x60009EE")]
		 set { } //Length: 6
	}

	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	[Token(Token = "0x17000125")]
	public override TryFunction Function
	{
		[Address(RVA = "0x28CD0A0", Offset = "0x28CC4A0", Length = "0x5A")]
		[Token(Token = "0x60009F5")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000126")]
	public override AllocatorHandle Handle
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60009F9")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x60009FA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000122")]
	public int InitialSizeInBytes
	{
		[Address(RVA = "0x28CD100", Offset = "0x28CC500", Length = "0x39")]
		[Token(Token = "0x60009F0")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000129")]
	public override bool IsAutoDispose
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60009FD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000128")]
	public override bool IsCustomAllocator
	{
		[Address(RVA = "0x28CD140", Offset = "0x28CC540", Length = "0xB")]
		[Token(Token = "0x60009FC")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000123")]
	internal long MaxMemoryBlockSize
	{
		[Address(RVA = "0x28CD150", Offset = "0x28CC550", Length = "0x6")]
		[Token(Token = "0x60009F1")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000127")]
	public override Allocator ToAllocator
	{
		[Address(RVA = "0x28CD160", Offset = "0x28CC560", Length = "0xB")]
		[Token(Token = "0x60009FB")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x8EF440", Offset = "0x8EE840", Length = "0x144")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60009FE")]
	public NativeArray<T> AllocateNativeArray(int length) { }

	[Address(RVA = "0x8EF590", Offset = "0x8EE990", Length = "0x1C9")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60009FF")]
	public NativeList<T> AllocateNativeList(int capacity) { }

	[Address(RVA = "0x28CC450", Offset = "0x28CB850", Length = "0x126")]
	[Token(Token = "0x60009F4")]
	public override void Dispose() { }

	[Address(RVA = "0x28CD000", Offset = "0x28CC400", Length = "0x6")]
	[Token(Token = "0x60009EF")]
	public int get_BlocksAllocated() { }

	[Address(RVA = "0x28CD010", Offset = "0x28CC410", Length = "0x73")]
	[Token(Token = "0x60009F2")]
	internal long get_BytesAllocated() { }

	[Address(RVA = "0x28CD090", Offset = "0x28CC490", Length = "0x8")]
	[Token(Token = "0x60009ED")]
	public bool get_EnableBlockFree() { }

	[Address(RVA = "0x28CD0A0", Offset = "0x28CC4A0", Length = "0x5A")]
	[Token(Token = "0x60009F5")]
	public override TryFunction get_Function() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60009F9")]
	public override AllocatorHandle get_Handle() { }

	[Address(RVA = "0x28CD100", Offset = "0x28CC500", Length = "0x39")]
	[Token(Token = "0x60009F0")]
	public int get_InitialSizeInBytes() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60009FD")]
	public override bool get_IsAutoDispose() { }

	[Address(RVA = "0x28CD140", Offset = "0x28CC540", Length = "0xB")]
	[Token(Token = "0x60009FC")]
	public override bool get_IsCustomAllocator() { }

	[Address(RVA = "0x28CD150", Offset = "0x28CC550", Length = "0x6")]
	[Token(Token = "0x60009F1")]
	internal long get_MaxMemoryBlockSize() { }

	[Address(RVA = "0x28CD160", Offset = "0x28CC560", Length = "0xB")]
	[Token(Token = "0x60009FB")]
	public override Allocator get_ToAllocator() { }

	[Address(RVA = "0x28CC580", Offset = "0x28CB980", Length = "0x103")]
	[Token(Token = "0x60009EC")]
	public void Initialize(int initialSizeInBytes, bool enableBlockFree = false) { }

	[Address(RVA = "0x28CC690", Offset = "0x28CBA90", Length = "0x169")]
	[Token(Token = "0x60009F3")]
	public void Rewind() { }

	[Address(RVA = "0x28CD170", Offset = "0x28CC570", Length = "0x6")]
	[Token(Token = "0x60009EE")]
	public void set_EnableBlockFree(bool value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x60009FA")]
	public override void set_Handle(AllocatorHandle value) { }

	[Address(RVA = "0x28CCA70", Offset = "0x28CBE70", Length = "0x396")]
	[Token(Token = "0x60009F7")]
	public override int Try(ref Block block) { }

	[Address(RVA = "0x28CCE10", Offset = "0x28CC210", Length = "0x1E8")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	[Token(Token = "0x60009F8")]
	internal static int Try(IntPtr state, ref Block block) { }

	[Address(RVA = "0x28CCA40", Offset = "0x28CBE40", Length = "0x23")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	[Token(Token = "0x6000A00")]
	internal static int Try$BurstManaged(IntPtr state, ref Block block) { }

	[Address(RVA = "0x28CC800", Offset = "0x28CBC00", Length = "0x238")]
	[Token(Token = "0x60009F6")]
	private int TryAllocate(ref Block block, int startIndex, int lastIndex, long alignedSize, long alignmentMask) { }

}

