namespace System.Runtime.InteropServices;

[Token(Token = "0x200045B")]
public static class Marshal
{
	[CompilerGenerated]
	[Token(Token = "0x200045E")]
	private sealed class <>c
	{
		[Token(Token = "0x400122E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400122F")]
		public static Func<Dictionary`2<ValueTuple`2<Type, String>, ICustomMarshaler>> <>9__201_0; //Field offset: 0x8

		[Address(RVA = "0x1F437F0", Offset = "0x1F42BF0", Length = "0x67")]
		[Token(Token = "0x60020A7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60020A8")]
		public <>c() { }

		[Address(RVA = "0x1F43450", Offset = "0x1F42850", Length = "0x86")]
		[Token(Token = "0x60020A9")]
		internal Dictionary<ValueTuple`2<Type, String>, ICustomMarshaler> <GetCustomMarshalerInstance>b__201_0() { }

	}

	[Token(Token = "0x200045D")]
	public class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple`2<Type, String>>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60020A6")]
		public MarshalerInstanceKeyComparer() { }

		[Address(RVA = "0x1F39010", Offset = "0x1F38410", Length = "0x58")]
		[Token(Token = "0x60020A4")]
		public override bool Equals(ValueTuple<Type, String> lhs, ValueTuple<Type, String> rhs) { }

		[Address(RVA = "0x1F39070", Offset = "0x1F38470", Length = "0x3A")]
		[Token(Token = "0x60020A5")]
		public override int GetHashCode(ValueTuple<Type, String> key) { }

	}

	[Token(Token = "0x200045C")]
	public sealed class SecureStringAllocator : MulticastDelegate
	{

		[Address(RVA = "0x1C117D0", Offset = "0x1C10BD0", Length = "0xA6")]
		[Token(Token = "0x60020A2")]
		public SecureStringAllocator(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60020A3")]
		public override IntPtr Invoke(int len) { }

	}

	[Token(Token = "0x400122A")]
	public static readonly int SystemMaxDBCSCharSize; //Field offset: 0x0
	[Token(Token = "0x400122B")]
	public static readonly int SystemDefaultCharSize; //Field offset: 0x4
	[Token(Token = "0x400122C")]
	internal static Dictionary<ValueTuple`2<Type, String>, ICustomMarshaler> MarshalerInstanceCache; //Field offset: 0x8
	[Token(Token = "0x400122D")]
	internal static readonly object MarshalerInstanceCacheLock; //Field offset: 0x10

	[Address(RVA = "0x1F38D20", Offset = "0x1F38120", Length = "0xA9")]
	[Token(Token = "0x60020A1")]
	private static Marshal() { }

	[Address(RVA = "0x1F36C40", Offset = "0x1F36040", Length = "0x5")]
	[Token(Token = "0x6002062")]
	public static IntPtr AllocCoTaskMem(int cb) { }

	[Address(RVA = "0x1F36C60", Offset = "0x1F36060", Length = "0x52")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6002064")]
	public static IntPtr AllocHGlobal(int cb) { }

	[Address(RVA = "0x1F36C50", Offset = "0x1F36050", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6002063")]
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[Address(RVA = "0x1F36CC0", Offset = "0x1F360C0", Length = "0x102")]
	[Token(Token = "0x6002076")]
	private static void ClearUnicode(IntPtr ptr) { }

	[Address(RVA = "0x1F36DD0", Offset = "0x1F361D0", Length = "0x145")]
	[Token(Token = "0x6002069")]
	public static void Copy(Byte[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x1F37120", Offset = "0x1F36520", Length = "0xF3")]
	[Token(Token = "0x600206A")]
	public static void Copy(Int16[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x1F36F20", Offset = "0x1F36320", Length = "0xF3")]
	[Token(Token = "0x600206B")]
	public static void Copy(Int32[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x1F37520", Offset = "0x1F36920", Length = "0xF2")]
	[Token(Token = "0x600206F")]
	public static void Copy(IntPtr source, Byte[] destination, int startIndex, int length) { }

	[Address(RVA = "0x1F37220", Offset = "0x1F36620", Length = "0xF3")]
	[Token(Token = "0x6002070")]
	public static void Copy(IntPtr source, Char[] destination, int startIndex, int length) { }

	[Address(RVA = "0x1F37320", Offset = "0x1F36720", Length = "0xF3")]
	[Token(Token = "0x6002071")]
	public static void Copy(IntPtr source, Int32[] destination, int startIndex, int length) { }

	[Address(RVA = "0x1F37420", Offset = "0x1F36820", Length = "0xF3")]
	[Token(Token = "0x6002072")]
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	[Address(RVA = "0x1F37020", Offset = "0x1F36420", Length = "0xF3")]
	[Token(Token = "0x600206C")]
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x1F38DE0", Offset = "0x1F381E0", Length = "0x7D")]
	[Token(Token = "0x600206D")]
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	[Address(RVA = "0x1F38DD0", Offset = "0x1F381D0", Length = "0x5")]
	[Token(Token = "0x600206E")]
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, Void* fixed_destination_element) { }

	[Address(RVA = "0x1F38E70", Offset = "0x1F38270", Length = "0x7D")]
	[Token(Token = "0x6002065")]
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x1F38EF0", Offset = "0x1F382F0", Length = "0xDE")]
	[Token(Token = "0x6002068")]
	internal static void copy_to_unmanaged(Byte[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x1F38E60", Offset = "0x1F38260", Length = "0x5")]
	[Token(Token = "0x6002066")]
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, Void* fixed_source_element) { }

	[Address(RVA = "0x1F37620", Offset = "0x1F36A20", Length = "0x5")]
	[Token(Token = "0x6002073")]
	public static void FreeBSTR(IntPtr ptr) { }

	[Address(RVA = "0x1F37630", Offset = "0x1F36A30", Length = "0x5")]
	[Token(Token = "0x6002074")]
	public static void FreeCoTaskMem(IntPtr ptr) { }

	[Address(RVA = "0x1F37640", Offset = "0x1F36A40", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002075")]
	public static void FreeHGlobal(IntPtr hglobal) { }

	[Address(RVA = "0x1F37650", Offset = "0x1F36A50", Length = "0x888")]
	[Token(Token = "0x60020A0")]
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	[Address(RVA = "0x1F37EF0", Offset = "0x1F372F0", Length = "0x281")]
	[Token(Token = "0x600209B")]
	public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t) { }

	[Address(RVA = "0x864100", Offset = "0x863500", Length = "0xD4")]
	[Token(Token = "0x600209C")]
	public static TDelegate GetDelegateForFunctionPointer(IntPtr ptr) { }

	[Address(RVA = "0x1F37EE0", Offset = "0x1F372E0", Length = "0x5")]
	[Token(Token = "0x600209A")]
	private static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t) { }

	[Address(RVA = "0x1F38190", Offset = "0x1F37590", Length = "0x94")]
	[Token(Token = "0x600209E")]
	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	[Address(RVA = "0x864370", Offset = "0x863770", Length = "0xD6")]
	[Token(Token = "0x600209F")]
	public static IntPtr GetFunctionPointerForDelegate(TDelegate d) { }

	[Address(RVA = "0x1F38180", Offset = "0x1F37580", Length = "0x5")]
	[Token(Token = "0x600209D")]
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	[Address(RVA = "0x1F38230", Offset = "0x1F37630", Length = "0xC")]
	[Token(Token = "0x6002078")]
	public static int GetHRForException(Exception e) { }

	[Address(RVA = "0x1F38240", Offset = "0x1F37640", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600207A")]
	public static int GetLastWin32Error() { }

	[Address(RVA = "0x1F38250", Offset = "0x1F37650", Length = "0x5")]
	[Token(Token = "0x6002079")]
	public static bool IsComObject(object o) { }

	[Address(RVA = "0x1F38260", Offset = "0x1F37660", Length = "0x5")]
	[Token(Token = "0x600207B")]
	public static IntPtr OffsetOf(Type t, string fieldName) { }

	[Address(RVA = "0x1F38270", Offset = "0x1F37670", Length = "0x5")]
	[Token(Token = "0x600207C")]
	public static string PtrToStringAnsi(IntPtr ptr) { }

	[Address(RVA = "0x1F38280", Offset = "0x1F37680", Length = "0x5")]
	[Token(Token = "0x600207D")]
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	[Address(RVA = "0x1F38290", Offset = "0x1F37690", Length = "0x5")]
	[Token(Token = "0x600207E")]
	public static string PtrToStringUni(IntPtr ptr) { }

	[Address(RVA = "0x1F382A0", Offset = "0x1F376A0", Length = "0x5")]
	[Token(Token = "0x600207F")]
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[Address(RVA = "0x864570", Offset = "0x863970", Length = "0xD4")]
	[Token(Token = "0x6002081")]
	public static T PtrToStructure(IntPtr ptr) { }

	[Address(RVA = "0x1F382B0", Offset = "0x1F376B0", Length = "0x5")]
	[ComVisible(True)]
	[Token(Token = "0x6002080")]
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	[Address(RVA = "0x1F382E0", Offset = "0x1F376E0", Length = "0x13")]
	[Token(Token = "0x6002082")]
	public static byte ReadByte(IntPtr ptr) { }

	[Address(RVA = "0x1F382C0", Offset = "0x1F376C0", Length = "0x1A")]
	[Token(Token = "0x6002083")]
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	[Address(RVA = "0x1F38300", Offset = "0x1F37700", Length = "0x4A")]
	[Token(Token = "0x6002084")]
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[Address(RVA = "0x1F38360", Offset = "0x1F37760", Length = "0x94")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002086")]
	public static int Release(IntPtr pUnk) { }

	[Address(RVA = "0x1F38350", Offset = "0x1F37750", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002085")]
	private static int ReleaseInternal(IntPtr pUnk) { }

	[Address(RVA = "0x1F38400", Offset = "0x1F37800", Length = "0x83")]
	[Token(Token = "0x600208E")]
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	[Address(RVA = "0x1F38490", Offset = "0x1F37890", Length = "0x164")]
	[Token(Token = "0x6002090")]
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[Address(RVA = "0x1F38600", Offset = "0x1F37A00", Length = "0x27F")]
	[Token(Token = "0x600208F")]
	internal static IntPtr SecureStringToUnicode(SecureString s, SecureStringAllocator allocator) { }

	[Address(RVA = "0x1F38880", Offset = "0x1F37C80", Length = "0x5")]
	[Token(Token = "0x6002087")]
	public static int SizeOf(Type t) { }

	[Address(RVA = "0x8647D0", Offset = "0x863BD0", Length = "0x78")]
	[Token(Token = "0x6002088")]
	public static int SizeOf() { }

	[Address(RVA = "0x864850", Offset = "0x863C50", Length = "0x96")]
	[Token(Token = "0x6002089")]
	public static int SizeOf(T structure) { }

	[Address(RVA = "0x1F38FD0", Offset = "0x1F383D0", Length = "0x30")]
	[Token(Token = "0x6002067")]
	private static bool skip_fixed(Array array, int startIndex) { }

	[Address(RVA = "0x1F38890", Offset = "0x1F37C90", Length = "0x5")]
	[Token(Token = "0x600208A")]
	private static IntPtr StringToHGlobalAnsi(Char* s, int length) { }

	[Address(RVA = "0x1F388A0", Offset = "0x1F37CA0", Length = "0x76")]
	[Token(Token = "0x600208B")]
	public static IntPtr StringToHGlobalAnsi(string s) { }

	[Address(RVA = "0x1F389A0", Offset = "0x1F37DA0", Length = "0x5")]
	[Token(Token = "0x600208C")]
	private static IntPtr StringToHGlobalUni(Char* s, int length) { }

	[Address(RVA = "0x1F38920", Offset = "0x1F37D20", Length = "0x76")]
	[Token(Token = "0x600208D")]
	public static IntPtr StringToHGlobalUni(string s) { }

	[Address(RVA = "0x1F389B0", Offset = "0x1F37DB0", Length = "0x5")]
	[ComVisible(True)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6002091")]
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	[Address(RVA = "0x864AF0", Offset = "0x863EF0", Length = "0x9C")]
	[Token(Token = "0x6002092")]
	public static void StructureToPtr(T structure, IntPtr ptr, bool fDeleteOld) { }

	[Address(RVA = "0x864CB0", Offset = "0x8640B0", Length = "0x57")]
	[Token(Token = "0x6002094")]
	public static IntPtr UnsafeAddrOfPinnedArrayElement(T[] arr, int index) { }

	[Address(RVA = "0x1F389C0", Offset = "0x1F37DC0", Length = "0x5")]
	[Token(Token = "0x6002093")]
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	[Address(RVA = "0x1F389D0", Offset = "0x1F37DD0", Length = "0x24")]
	[Token(Token = "0x6002095")]
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	[Address(RVA = "0x1F38A00", Offset = "0x1F37E00", Length = "0x45")]
	[Token(Token = "0x6002096")]
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	[Address(RVA = "0x1F38A50", Offset = "0x1F37E50", Length = "0x39")]
	[Token(Token = "0x6002097")]
	public static void WriteInt32(IntPtr ptr, int val) { }

	[Address(RVA = "0x1F38A90", Offset = "0x1F37E90", Length = "0x3C")]
	[Token(Token = "0x6002098")]
	public static void WriteInt64(IntPtr ptr, long val) { }

	[Address(RVA = "0x1F38AD0", Offset = "0x1F37ED0", Length = "0x101")]
	[Token(Token = "0x6002099")]
	public static void WriteIntPtr(IntPtr ptr, IntPtr val) { }

	[Address(RVA = "0x1F38BE0", Offset = "0x1F37FE0", Length = "0x139")]
	[Token(Token = "0x6002077")]
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

}

