namespace Unity.Collections;

[BurstCompile]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000F4")]
public static class xxHash3
{
	[Token(Token = "0x20000FB")]
	public static class Hash128Long_00000A72$BurstDirectCall
	{
		[Token(Token = "0x4000494")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x28C7110", Offset = "0x28C6510", Length = "0x17A")]
		[Token(Token = "0x6000AC8")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x28C6F80", Offset = "0x28C6380", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000AC7")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x28C7290", Offset = "0x28C6690", Length = "0x326")]
		[Token(Token = "0x6000AC9")]
		public static void Invoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	}

	[Token(Token = "0x20000FA")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Hash128Long_00000A72$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x28C7680", Offset = "0x28C6A80", Length = "0xB5")]
		[Token(Token = "0x6000AC3")]
		public Hash128Long_00000A72$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x28C75C0", Offset = "0x28C69C0", Length = "0xBE")]
		[Token(Token = "0x6000AC5")]
		public override IAsyncResult BeginInvoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000AC6")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
		[Token(Token = "0x6000AC4")]
		public override void Invoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	}

	[Token(Token = "0x20000F9")]
	public static class Hash64Long_00000A6B$BurstDirectCall
	{
		[Token(Token = "0x4000493")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x28C78D0", Offset = "0x28C6CD0", Length = "0x17A")]
		[Token(Token = "0x6000AC1")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x28C7740", Offset = "0x28C6B40", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000AC0")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x28C7A50", Offset = "0x28C6E50", Length = "0x2DD")]
		[Token(Token = "0x6000AC2")]
		public static ulong Invoke(Byte* input, Byte* dest, long length, Byte* secret) { }

	}

	[Token(Token = "0x20000F8")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Hash64Long_00000A6B$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1E51CC0", Offset = "0x1E510C0", Length = "0xB5")]
		[Token(Token = "0x6000ABC")]
		public Hash64Long_00000A6B$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x28C7D30", Offset = "0x28C7130", Length = "0x6F")]
		[Token(Token = "0x6000ABE")]
		public override IAsyncResult BeginInvoke(Byte* input, Byte* dest, long length, Byte* secret, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[Address(RVA = "0x17C9A80", Offset = "0x17C8E80", Length = "0x28")]
		[Token(Token = "0x6000ABF")]
		public override ulong EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x6000ABD")]
		public override ulong Invoke(Byte* input, Byte* dest, long length, Byte* secret) { }

	}

	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x20000F6")]
	internal struct StreamingState
	{
		[Token(Token = "0x20000F7")]
		private struct StreamingStateData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400048A")]
			public ulong Acc; //Field offset: 0x0
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x400048B")]
			public byte Buffer; //Field offset: 0x40
			[FieldOffset(Offset = "0x140")]
			[Token(Token = "0x400048C")]
			public int IsHash64; //Field offset: 0x140
			[FieldOffset(Offset = "0x144")]
			[Token(Token = "0x400048D")]
			public int BufferedSize; //Field offset: 0x144
			[FieldOffset(Offset = "0x148")]
			[Token(Token = "0x400048E")]
			public int NbStripesSoFar; //Field offset: 0x148
			[FieldOffset(Offset = "0x150")]
			[Token(Token = "0x400048F")]
			public long TotalLength; //Field offset: 0x150
			[FieldOffset(Offset = "0x158")]
			[Token(Token = "0x4000490")]
			public ulong Seed; //Field offset: 0x158
			[FieldOffset(Offset = "0x160")]
			[Token(Token = "0x4000491")]
			public byte SecretKey; //Field offset: 0x160
			[FieldOffset(Offset = "0x21C")]
			[Token(Token = "0x4000492")]
			public byte _PadEnd; //Field offset: 0x21C

		}

		[Token(Token = "0x4000485")]
		private static readonly int SECRET_LIMIT; //Field offset: 0x0
		[Token(Token = "0x4000486")]
		private static readonly int NB_STRIPES_PER_BLOCK; //Field offset: 0x4
		[Token(Token = "0x4000487")]
		private static readonly int INTERNAL_BUFFER_SIZE; //Field offset: 0x8
		[Token(Token = "0x4000488")]
		private static readonly int INTERNAL_BUFFER_STRIPES; //Field offset: 0xC
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000489")]
		private StreamingStateData State; //Field offset: 0x0

		[Token(Token = "0x17000136")]
		private UInt64* Acc
		{
			[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
			[DebuggerStepThrough]
			[Token(Token = "0x6000AB5")]
			private get { } //Length: 4
		}

		[Token(Token = "0x17000137")]
		private Byte* Buffer
		{
			[Address(RVA = "0x1388FC0", Offset = "0x13883C0", Length = "0x5")]
			[DebuggerStepThrough]
			[Token(Token = "0x6000AB6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000138")]
		private Byte* SecretKey
		{
			[Address(RVA = "0x28CF610", Offset = "0x28CEA10", Length = "0x8")]
			[DebuggerStepThrough]
			[Token(Token = "0x6000AB7")]
			private get { } //Length: 8
		}

		[Address(RVA = "0x28CF4F0", Offset = "0x28CE8F0", Length = "0x95")]
		[Token(Token = "0x6000ABB")]
		private static StreamingState() { }

		[Address(RVA = "0x28CF590", Offset = "0x28CE990", Length = "0x7A")]
		[Token(Token = "0x6000AAF")]
		public StreamingState(bool isHash64, ulong seed = 0) { }

		[Address(RVA = "0x28CE300", Offset = "0x28CD700", Length = "0xB4")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000ABA")]
		private void CheckKeySize(int isHash64) { }

		[Address(RVA = "0x28CE3C0", Offset = "0x28CD7C0", Length = "0x427")]
		[Token(Token = "0x6000AB9")]
		private void ConsumeStripes(UInt64* acc, ref int nbStripesSoFar, Byte* input, long totalStripes, Byte* secret, int isHash64) { }

		[Address(RVA = "0x28CE7F0", Offset = "0x28CDBF0", Length = "0x245")]
		[Token(Token = "0x6000AB3")]
		public uint4 DigestHash128() { }

		[Address(RVA = "0x28CEA40", Offset = "0x28CDE40", Length = "0x1D4")]
		[Token(Token = "0x6000AB4")]
		public uint2 DigestHash64() { }

		[Address(RVA = "0x28CEC20", Offset = "0x28CE020", Length = "0x454")]
		[Token(Token = "0x6000AB8")]
		private void DigestLong(UInt64* acc, Byte* secret, int isHash64) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AB5")]
		private UInt64* get_Acc() { }

		[Address(RVA = "0x1388FC0", Offset = "0x13883C0", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AB6")]
		private Byte* get_Buffer() { }

		[Address(RVA = "0x28CF610", Offset = "0x28CEA10", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AB7")]
		private Byte* get_SecretKey() { }

		[Address(RVA = "0x28CF080", Offset = "0x28CE480", Length = "0x1C7")]
		[Token(Token = "0x6000AB0")]
		public void Reset(bool isHash64, ulong seed = 0) { }

		[Address(RVA = "0x28CF250", Offset = "0x28CE650", Length = "0x29D")]
		[Token(Token = "0x6000AB1")]
		public void Update(Void* input, int length) { }

		[Address(RVA = "0x9F9D80", Offset = "0x9F9180", Length = "0x97")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000AB2")]
		public void Update(in T input) { }

	}

	[Token(Token = "0x20000F5")]
	private struct ulong2
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000483")]
		public ulong x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000484")]
		public ulong y; //Field offset: 0x8

		[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
		[Token(Token = "0x6000AAE")]
		public ulong2(ulong x, ulong y) { }

	}

	[Token(Token = "0x400046E")]
	private const int STRIPE_LEN = 64; //Field offset: 0x0
	[Token(Token = "0x4000480")]
	private const int MIDSIZE_STARTOFFSET = 3; //Field offset: 0x0
	[Token(Token = "0x400047F")]
	private const int MIDSIZE_MAX = 240; //Field offset: 0x0
	[Token(Token = "0x400047E")]
	private const ulong PRIME64_5 = 2870177450012600261; //Field offset: 0x0
	[Token(Token = "0x400047D")]
	private const ulong PRIME64_4 = 9650029242287828579; //Field offset: 0x0
	[Token(Token = "0x400047C")]
	private const ulong PRIME64_3 = 1609587929392839161; //Field offset: 0x0
	[Token(Token = "0x400047B")]
	private const ulong PRIME64_2 = 14029467366897019727; //Field offset: 0x0
	[Token(Token = "0x400047A")]
	private const ulong PRIME64_1 = 11400714785074694791; //Field offset: 0x0
	[Token(Token = "0x4000479")]
	private const uint PRIME32_5 = 374761393; //Field offset: 0x0
	[Token(Token = "0x4000481")]
	private const int MIDSIZE_LASTOFFSET = 17; //Field offset: 0x0
	[Token(Token = "0x4000478")]
	private const uint PRIME32_3 = 3266489917; //Field offset: 0x0
	[Token(Token = "0x4000476")]
	private const uint PRIME32_1 = 2654435761; //Field offset: 0x0
	[Token(Token = "0x4000475")]
	private const int BLOCK_LEN = 1024; //Field offset: 0x0
	[Token(Token = "0x4000474")]
	private const int NB_ROUNDS = 16; //Field offset: 0x0
	[Token(Token = "0x4000473")]
	private const int SECRET_LASTACC_START = 7; //Field offset: 0x0
	[Token(Token = "0x4000472")]
	private const int SECRET_KEY_MIN_SIZE = 136; //Field offset: 0x0
	[Token(Token = "0x4000471")]
	private const int SECRET_KEY_SIZE = 192; //Field offset: 0x0
	[Token(Token = "0x4000470")]
	private const int SECRET_CONSUME_RATE = 8; //Field offset: 0x0
	[Token(Token = "0x400046F")]
	private const int ACC_NB = 8; //Field offset: 0x0
	[Token(Token = "0x4000477")]
	private const uint PRIME32_2 = 2246822519; //Field offset: 0x0
	[Token(Token = "0x4000482")]
	private const int SECRET_MERGEACCS_START = 11; //Field offset: 0x0

	[Address(RVA = "0x28D4CD0", Offset = "0x28D40D0", Length = "0x23")]
	[Token(Token = "0x6000AA3")]
	private static ulong Avalanche(ulong h64) { }

	[Address(RVA = "0x28D4C90", Offset = "0x28D4090", Length = "0x3B")]
	[Token(Token = "0x6000AA4")]
	private static ulong AvalancheH64(ulong h64) { }

	[Address(RVA = "0x28D50F0", Offset = "0x28D44F0", Length = "0xF4")]
	[Token(Token = "0x6000A79")]
	internal static void Avx2Accumulate(UInt64* acc, Byte* input, Byte* dest, Byte* secret, long nbStripes, int isHash64) { }

	[Address(RVA = "0x28D4D00", Offset = "0x28D4100", Length = "0x3EF")]
	[Token(Token = "0x6000A7A")]
	internal static void Avx2Accumulate512(UInt64* acc, Byte* input, Byte* dest, Byte* secret) { }

	[Address(RVA = "0x28D51F0", Offset = "0x28D45F0", Length = "0x29B")]
	[Token(Token = "0x6000A77")]
	internal static void Avx2HashLongInternalLoop(UInt64* acc, Byte* input, Byte* dest, long length, Byte* secret, int isHash64) { }

	[Address(RVA = "0x28D5490", Offset = "0x28D4890", Length = "0x4AA")]
	[Token(Token = "0x6000A78")]
	internal static void Avx2ScrambleAcc(UInt64* acc, Byte* secret) { }

	[Address(RVA = "0x28D5AA0", Offset = "0x28D4EA0", Length = "0x1D5")]
	[Token(Token = "0x6000AA9")]
	internal static void DefaultAccumulate(UInt64* acc, Byte* input, Byte* dest, Byte* secret, long nbStripes, int isHash64) { }

	[Address(RVA = "0x28D5940", Offset = "0x28D4D40", Length = "0x15B")]
	[Token(Token = "0x6000AAA")]
	internal static void DefaultAccumulate512(UInt64* acc, Byte* input, Byte* dest, Byte* secret, int isHash64) { }

	[Address(RVA = "0x28D5C80", Offset = "0x28D5080", Length = "0x348")]
	[Token(Token = "0x6000AA8")]
	private static void DefaultHashLongInternalLoop(UInt64* acc, Byte* input, Byte* dest, long length, Byte* secret, int isHash64) { }

	[Address(RVA = "0x28D5FD0", Offset = "0x28D53D0", Length = "0xD3")]
	[Token(Token = "0x6000AAB")]
	internal static void DefaultScrambleAcc(UInt64* acc, Byte* secret) { }

	[Address(RVA = "0x28D60B0", Offset = "0x28D54B0", Length = "0x33")]
	[Token(Token = "0x6000A95")]
	internal static void EncodeSecretKey(Byte* dst, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7330", Offset = "0x28D6730", Length = "0xC4")]
	[Token(Token = "0x6000A82")]
	public static uint4 Hash128(Void* input, Void* destination, long length, ulong seed) { }

	[Address(RVA = "0x28D71B0", Offset = "0x28D65B0", Length = "0xBE")]
	[Token(Token = "0x6000A81")]
	public static uint4 Hash128(Void* input, long length, ulong seed) { }

	[Address(RVA = "0x28D7270", Offset = "0x28D6670", Length = "0xBC")]
	[Token(Token = "0x6000A80")]
	public static uint4 Hash128(Void* input, Void* destination, long length) { }

	[Address(RVA = "0x9FFBC0", Offset = "0x9FEFC0", Length = "0x79")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000A7F")]
	public static uint4 Hash128(in T input) { }

	[Address(RVA = "0x28D7400", Offset = "0x28D6800", Length = "0xAE")]
	[Token(Token = "0x6000A7E")]
	public static uint4 Hash128(Void* input, long length) { }

	[Address(RVA = "0x28D60F0", Offset = "0x28D54F0", Length = "0x199")]
	[Token(Token = "0x6000A84")]
	internal static void Hash128Internal(Byte* input, Byte* dest, long length, Byte* secret, ulong seed, out uint4 result) { }

	[Address(RVA = "0x28D6290", Offset = "0x28D5690", Length = "0x33D")]
	[Token(Token = "0x6000A8F")]
	private static void Hash128Len0To16(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[Address(RVA = "0x28D65D0", Offset = "0x28D59D0", Length = "0x3FD")]
	[Token(Token = "0x6000A91")]
	private static void Hash128Len129To240(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[Address(RVA = "0x28D69D0", Offset = "0x28D5DD0", Length = "0x339")]
	[Token(Token = "0x6000A90")]
	private static void Hash128Len17To128(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[Address(RVA = "0x28D6D10", Offset = "0x28D6110", Length = "0xF7")]
	[Token(Token = "0x6000A8C")]
	private static void Hash128Len1To3(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[Address(RVA = "0x28D6E10", Offset = "0x28D6210", Length = "0xD8")]
	[Token(Token = "0x6000A8D")]
	private static void Hash128Len4To8(Byte* input, long len, Byte* secret, ulong seed, out uint4 result) { }

	[Address(RVA = "0x28D6EF0", Offset = "0x28D62F0", Length = "0x128")]
	[Token(Token = "0x6000A8E")]
	private static void Hash128Len9To16(Byte* input, long len, Byte* secret, ulong seed, out uint4 result) { }

	[Address(RVA = "0x28D71A0", Offset = "0x28D65A0", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(Hash128Long_00000A72$PostfixBurstDelegate))]
	[Token(Token = "0x6000A92")]
	private static void Hash128Long(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	[Address(RVA = "0x28D7020", Offset = "0x28D6420", Length = "0x17E")]
	[BurstCompile]
	[Token(Token = "0x6000AAD")]
	internal static void Hash128Long$BurstManaged(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	[Address(RVA = "0x28D80A0", Offset = "0x28D74A0", Length = "0xA4")]
	[Token(Token = "0x6000A7B")]
	public static uint2 Hash64(Void* input, long length) { }

	[Address(RVA = "0x9FFC40", Offset = "0x9FF040", Length = "0x5D")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000A7C")]
	public static uint2 Hash64(in T input) { }

	[Address(RVA = "0x28D7FE0", Offset = "0x28D73E0", Length = "0xB4")]
	[Token(Token = "0x6000A7D")]
	public static uint2 Hash64(Void* input, long length, ulong seed) { }

	[Address(RVA = "0x28D74B0", Offset = "0x28D68B0", Length = "0x2B6")]
	[Token(Token = "0x6000A83")]
	internal static ulong Hash64Internal(Byte* input, Byte* dest, long length, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7770", Offset = "0x28D6B70", Length = "0x1DD")]
	[Token(Token = "0x6000A88")]
	private static ulong Hash64Len0To16(Byte* input, long length, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7950", Offset = "0x28D6D50", Length = "0x185")]
	[Token(Token = "0x6000A8A")]
	private static ulong Hash64Len129To240(Byte* input, long length, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7AE0", Offset = "0x28D6EE0", Length = "0x20A")]
	[Token(Token = "0x6000A89")]
	private static ulong Hash64Len17To128(Byte* input, long length, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7CF0", Offset = "0x28D70F0", Length = "0x72")]
	[Token(Token = "0x6000A85")]
	private static ulong Hash64Len1To3(Byte* input, long len, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7D70", Offset = "0x28D7170", Length = "0x81")]
	[Token(Token = "0x6000A86")]
	private static ulong Hash64Len4To8(Byte* input, long length, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7E00", Offset = "0x28D7200", Length = "0x90")]
	[Token(Token = "0x6000A87")]
	private static ulong Hash64Len9To16(Byte* input, long length, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D7FD0", Offset = "0x28D73D0", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(Hash64Long_00000A6B$PostfixBurstDelegate))]
	[Token(Token = "0x6000A8B")]
	private static ulong Hash64Long(Byte* input, Byte* dest, long length, Byte* secret) { }

	[Address(RVA = "0x28D7E90", Offset = "0x28D7290", Length = "0x138")]
	[BurstCompile]
	[Token(Token = "0x6000AAC")]
	internal static ulong Hash64Long$BurstManaged(Byte* input, Byte* dest, long length, Byte* secret) { }

	[Address(RVA = "0x28D8150", Offset = "0x28D7550", Length = "0x104")]
	[Token(Token = "0x6000AA7")]
	internal static ulong MergeAcc(UInt64* acc, Byte* secret, ulong start) { }

	[Address(RVA = "0x28D8260", Offset = "0x28D7660", Length = "0x3E")]
	[Token(Token = "0x6000AA1")]
	private static ulong Mix16(Byte* input, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D82A0", Offset = "0x28D76A0", Length = "0x2B")]
	[Token(Token = "0x6000AA6")]
	private static ulong Mix2Acc(ulong acc0, ulong acc1, Byte* secret) { }

	[Address(RVA = "0x28D82D0", Offset = "0x28D76D0", Length = "0xE2")]
	[Token(Token = "0x6000AA2")]
	private static ulong2 Mix32(ulong2 acc, Byte* input_1, Byte* input_2, Byte* secret, ulong seed) { }

	[Address(RVA = "0x28D83C0", Offset = "0x28D77C0", Length = "0x24")]
	[Token(Token = "0x6000AA0")]
	private static ulong Mul128Fold64(ulong lhs, ulong rhs) { }

	[Address(RVA = "0x20304D0", Offset = "0x202F8D0", Length = "0x9")]
	[Token(Token = "0x6000A9A")]
	private static ulong Mul32To64(uint x, uint y) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000A97")]
	private static uint Read32LE(Void* addr) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000A99")]
	private static void Read32LE(Void* addr, uint value) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000A96")]
	private static ulong Read64LE(Void* addr) { }

	[Address(RVA = "0x2025B80", Offset = "0x2024F80", Length = "0x19")]
	[Token(Token = "0x6000A9D")]
	private static uint RotL32(uint x, int r) { }

	[Address(RVA = "0x28D83F0", Offset = "0x28D77F0", Length = "0x1A")]
	[Token(Token = "0x6000A9E")]
	private static ulong RotL64(ulong x, int r) { }

	[Address(RVA = "0x28D8480", Offset = "0x28D7880", Length = "0x52")]
	[Token(Token = "0x6000AA5")]
	private static ulong rrmxmx(ulong h64, ulong length) { }

	[Address(RVA = "0x1FD37C0", Offset = "0x1FD2BC0", Length = "0x5")]
	[Token(Token = "0x6000A9C")]
	private static uint Swap32(uint x) { }

	[Address(RVA = "0x28D8410", Offset = "0x28D7810", Length = "0x7")]
	[Token(Token = "0x6000A9B")]
	private static ulong Swap64(ulong x) { }

	[Address(RVA = "0x28D8420", Offset = "0x28D7820", Length = "0x12")]
	[Token(Token = "0x6000A93")]
	internal static uint2 ToUint2(ulong u) { }

	[Address(RVA = "0x28D8440", Offset = "0x28D7840", Length = "0x19")]
	[Token(Token = "0x6000A94")]
	internal static uint4 ToUint4(ulong ul0, ulong ul1) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000A98")]
	private static void Write64LE(Void* addr, ulong value) { }

	[Address(RVA = "0x28D8460", Offset = "0x28D7860", Length = "0x13")]
	[Token(Token = "0x6000A9F")]
	private static ulong XorShift64(ulong v64, int shift) { }

}

