namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x2000238")]
internal static class ArrayHelpers
{
	[CompilerGenerated]
	[Token(Token = "0x2000239")]
	private sealed class <>c__DisplayClass33_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C71")]
		public TValue secondValue; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014FC")]
		public <>c__DisplayClass33_0`1() { }

		[Address(RVA = "0xA722F0", Offset = "0xA716F0", Length = "0x31")]
		[Token(Token = "0x60014FD")]
		internal bool <Merge>b__0(TValue x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200023A")]
	private sealed class <>c__DisplayClass34_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C72")]
		public IEqualityComparer<TValue> comparer; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014FE")]
		public <>c__DisplayClass34_0`1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200023B")]
	private sealed class <>c__DisplayClass34_1
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C73")]
		public TValue secondValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C74")]
		public <>c__DisplayClass34_0<TValue> CS$<>8__locals1; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014FF")]
		public <>c__DisplayClass34_1`1() { }

		[Address(RVA = "0xA72510", Offset = "0xA71910", Length = "0x102")]
		[Token(Token = "0x6001500")]
		internal bool <Merge>b__0(TValue x) { }

	}


	[Address(RVA = "0x71F060", Offset = "0x71E460", Length = "0x111")]
	[Token(Token = "0x60014DF")]
	public static int Append(ref TValue[] array, TValue value) { }

	[Address(RVA = "0x71E940", Offset = "0x71DD40", Length = "0x3B4")]
	[Token(Token = "0x60014E0")]
	public static int Append(ref TValue[] array, IEnumerable<TValue> values) { }

	[Address(RVA = "0x71C900", Offset = "0x71BD00", Length = "0x213")]
	[Token(Token = "0x60014E3")]
	public static int AppendListWithCapacity(ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10) { }

	[Address(RVA = "0x71CE20", Offset = "0x71C220", Length = "0xD6")]
	[Token(Token = "0x60014E1")]
	public static int AppendToImmutable(ref TValue[] array, TValue[] values) { }

	[Address(RVA = "0x71D060", Offset = "0x71C460", Length = "0xE5")]
	[Token(Token = "0x60014E2")]
	public static int AppendWithCapacity(ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10) { }

	[Address(RVA = "0x71E3B0", Offset = "0x71D7B0", Length = "0x158")]
	[Token(Token = "0x60014E4")]
	public static int AppendWithCapacity(ref NativeArray<TValue>& array, ref int count, TValue value, int capacityIncrement = 10, Allocator allocator = 4) { }

	[Address(RVA = "0x71F6A0", Offset = "0x71EAA0", Length = "0x26")]
	[Extension]
	[Token(Token = "0x60014CF")]
	public static void Clear(TValue[] array, ref int count) { }

	[Address(RVA = "0x71F6D0", Offset = "0x71EAD0", Length = "0x14")]
	[Extension]
	[Token(Token = "0x60014CD")]
	public static void Clear(TValue[] array) { }

	[Address(RVA = "0x71F6F0", Offset = "0x71EAF0", Length = "0x13")]
	[Extension]
	[Token(Token = "0x60014CE")]
	public static void Clear(TValue[] array, int count) { }

	[Address(RVA = "0x71F710", Offset = "0x71EB10", Length = "0x21D")]
	[Token(Token = "0x60014F5")]
	public static TValue[] Clone(TValue[] array) { }

	[Address(RVA = "0x71FDA0", Offset = "0x71F1A0", Length = "0xB1")]
	[Token(Token = "0x60014D2")]
	public static bool Contains(TValue[] array, TValue value) { }

	[Address(RVA = "0x71FA20", Offset = "0x71EE20", Length = "0x95")]
	[Extension]
	[Token(Token = "0x60014D5")]
	public static bool ContainsReference(TFirst[] array, int startIndex, int count, TSecond value) { }

	[Address(RVA = "0x71FAC0", Offset = "0x71EEC0", Length = "0x9E")]
	[Extension]
	[Token(Token = "0x60014D4")]
	public static bool ContainsReference(TFirst[] array, int count, TSecond value) { }

	[Address(RVA = "0x71FB60", Offset = "0x71EF60", Length = "0xCC")]
	[Extension]
	[Token(Token = "0x60014D3")]
	public static bool ContainsReference(TValue[] array, TValue value) { }

	[Address(RVA = "0x71FF20", Offset = "0x71F320", Length = "0x83")]
	[Token(Token = "0x60014F4")]
	public static TValue[] Copy(TValue[] array) { }

	[Address(RVA = "0x71FFB0", Offset = "0x71F3B0", Length = "0x11E")]
	[Token(Token = "0x60014D1")]
	public static void DuplicateWithCapacity(ref TValue[] array, int count, int capacity, int capacityIncrement = 10) { }

	[Address(RVA = "0x7201D0", Offset = "0x71F5D0", Length = "0x172")]
	[Token(Token = "0x60014D0")]
	public static void EnsureCapacity(ref TValue[] array, int count, int capacity, int capacityIncrement = 10) { }

	[Address(RVA = "0x721A80", Offset = "0x720E80", Length = "0x179")]
	[Token(Token = "0x60014F2")]
	public static bool Erase(ref TValue[] array, TValue value) { }

	[Address(RVA = "0x721620", Offset = "0x720A20", Length = "0xAA")]
	[Token(Token = "0x60014EF")]
	public static void EraseAt(ref TValue[] array, int index) { }

	[Address(RVA = "0x720350", Offset = "0x71F750", Length = "0x63")]
	[Token(Token = "0x60014F3")]
	public static void EraseAtByMovingTail(TValue[] array, ref int count, int index) { }

	[Address(RVA = "0x7213C0", Offset = "0x7207C0", Length = "0x99")]
	[Token(Token = "0x60014F1")]
	public static void EraseAtWithCapacity(NativeArray<TValue> array, ref int count, int index) { }

	[Address(RVA = "0x720C00", Offset = "0x720000", Length = "0x6D")]
	[Extension]
	[Token(Token = "0x60014F0")]
	public static void EraseAtWithCapacity(TValue[] array, ref int count, int index) { }

	[Address(RVA = "0x7218A0", Offset = "0x720CA0", Length = "0xAC")]
	[Token(Token = "0x60014F9")]
	public static void EraseSliceWithCapacity(ref TValue[] array, ref int length, int index, int count) { }

	[Address(RVA = "0x721F80", Offset = "0x721380", Length = "0xA4")]
	[Token(Token = "0x60014E8")]
	public static int GrowBy(ref TValue[] array, int count) { }

	[Address(RVA = "0x722030", Offset = "0x721430", Length = "0x115")]
	[Token(Token = "0x60014E9")]
	public static int GrowBy(ref NativeArray<TValue>& array, int count, Allocator allocator = 4) { }

	[Address(RVA = "0x722150", Offset = "0x721550", Length = "0x8A")]
	[Token(Token = "0x60014EA")]
	public static int GrowWithCapacity(ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10) { }

	[Address(RVA = "0x7221E0", Offset = "0x7215E0", Length = "0x92")]
	[Token(Token = "0x60014EB")]
	public static int GrowWithCapacity(ref NativeArray<TValue>& array, ref int count, int growBy, int capacityIncrement = 10, Allocator allocator = 4) { }

	[Address(RVA = "0x722440", Offset = "0x721840", Length = "0xBA")]
	[Extension]
	[Token(Token = "0x60014D6")]
	public static bool HaveDuplicateReferences(TFirst[] first, int index, int count) { }

	[Address(RVA = "0x722500", Offset = "0x721900", Length = "0x1CB")]
	[Token(Token = "0x60014D7")]
	public static bool HaveEqualElements(TValue[] first, TValue[] second, int count = 2147483647) { }

	[Address(RVA = "0x722F80", Offset = "0x722380", Length = "0x10E")]
	[Extension]
	[Token(Token = "0x60014D9")]
	public static int IndexOf(TValue[] array, Predicate<TValue> predicate) { }

	[Address(RVA = "0x723090", Offset = "0x722490", Length = "0xD8")]
	[Token(Token = "0x60014D8")]
	public static int IndexOf(TValue[] array, TValue value, int startIndex = 0, int count = -1) { }

	[Address(RVA = "0x722B80", Offset = "0x721F80", Length = "0x138")]
	[Extension]
	[Token(Token = "0x60014DA")]
	public static int IndexOf(TValue[] array, Predicate<TValue> predicate, int startIndex = 0, int count = -1) { }

	[Address(RVA = "0x722840", Offset = "0x721C40", Length = "0x78")]
	[Extension]
	[Token(Token = "0x60014DB")]
	public static int IndexOfReference(TFirst[] array, TSecond value, int count = -1) { }

	[Address(RVA = "0x7228C0", Offset = "0x721CC0", Length = "0x63")]
	[Extension]
	[Token(Token = "0x60014DC")]
	public static int IndexOfReference(TFirst[] array, TSecond value, int startIndex, int count) { }

	[Address(RVA = "0x722AB0", Offset = "0x721EB0", Length = "0xC3")]
	[Extension]
	[Token(Token = "0x60014DD")]
	public static int IndexOfValue(TValue[] array, TValue value, int startIndex = 0, int count = -1) { }

	[Address(RVA = "0x723710", Offset = "0x722B10", Length = "0x1CB")]
	[Token(Token = "0x60014E5")]
	public static void InsertAt(ref TValue[] array, int index, TValue value) { }

	[Address(RVA = "0x7233C0", Offset = "0x7227C0", Length = "0xE2")]
	[Token(Token = "0x60014E6")]
	public static void InsertAtWithCapacity(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10) { }

	[Address(RVA = "0x723B90", Offset = "0x722F90", Length = "0xC2")]
	[Token(Token = "0x60014EC")]
	public static TValue[] Join(TValue value, TValue[] values) { }

	[Address(RVA = "0x7244B0", Offset = "0x7238B0", Length = "0xC")]
	[Extension]
	[Token(Token = "0x60014CC")]
	public static int LengthSafe(TValue[] array) { }

	[Address(RVA = "0x724A50", Offset = "0x723E50", Length = "0x1CE")]
	[Token(Token = "0x60014ED")]
	public static TValue[] Merge(TValue[] first, TValue[] second) { }

	[Address(RVA = "0x7244C0", Offset = "0x7238C0", Length = "0x302")]
	[Token(Token = "0x60014EE")]
	public static TValue[] Merge(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer) { }

	[Address(RVA = "0x724DF0", Offset = "0x7241F0", Length = "0x1D0")]
	[Token(Token = "0x60014F8")]
	public static void MoveSlice(TValue[] array, int sourceIndex, int destinationIndex, int count) { }

	[Address(RVA = "0x724FD0", Offset = "0x7243D0", Length = "0x261")]
	[Token(Token = "0x60014E7")]
	public static void PutAtIfNotSet(ref TValue[] array, int index, Func<TValue> valueFn) { }

	[Address(RVA = "0x7253B0", Offset = "0x7247B0", Length = "0x120")]
	[Token(Token = "0x60014DE")]
	public static void Resize(ref NativeArray<TValue>& array, int newSize, Allocator allocator) { }

	[Address(RVA = "0x7256D0", Offset = "0x724AD0", Length = "0x11C")]
	[Token(Token = "0x60014F6")]
	public static TNew[] Select(TOld[] array, Func<TOld, TNew> converter) { }

	[Address(RVA = "0x725F70", Offset = "0x725370", Length = "0x33")]
	[Token(Token = "0x60014F7")]
	private static void Swap(ref TValue first, ref TValue second) { }

	[Address(RVA = "0x725C10", Offset = "0x725010", Length = "0x7A")]
	[Extension]
	[Token(Token = "0x60014FA")]
	public static void SwapElements(TValue[] array, int index1, int index2) { }

	[Address(RVA = "0x725DA0", Offset = "0x7251A0", Length = "0x26")]
	[Extension]
	[Token(Token = "0x60014FB")]
	public static void SwapElements(NativeArray<TValue> array, int index1, int index2) { }

}

