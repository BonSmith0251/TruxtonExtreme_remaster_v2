namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000D")]
public static class AndroidJNI
{
	[Token(Token = "0x200000E")]
	private struct JStringBinding : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		private IntPtr javaString; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400001F")]
		private IntPtr chars; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000020")]
		private int length; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000021")]
		private bool ownsRef; //Field offset: 0x14

		[Address(RVA = "0x2FA6590", Offset = "0x2FA5990", Length = "0x48")]
		[Token(Token = "0x60000C9")]
		public override void Dispose() { }

		[Address(RVA = "0x2FA65E0", Offset = "0x2FA59E0", Length = "0x64")]
		[Token(Token = "0x60000C8")]
		public virtual string ToString() { }

	}


	[Address(RVA = "0x2F9FEA0", Offset = "0x2F9F2A0", Length = "0x80")]
	[Token(Token = "0x6000078")]
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9FE40", Offset = "0x2F9F240", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000079")]
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2F9FF80", Offset = "0x2F9F380", Length = "0x80")]
	[Token(Token = "0x600007E")]
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9FF20", Offset = "0x2F9F320", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600007F")]
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0060", Offset = "0x2F9F460", Length = "0x80")]
	[Token(Token = "0x6000082")]
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0000", Offset = "0x2F9F400", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000083")]
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0140", Offset = "0x2F9F540", Length = "0x80")]
	[Token(Token = "0x6000080")]
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA00E0", Offset = "0x2F9F4E0", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000081")]
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0220", Offset = "0x2F9F620", Length = "0x80")]
	[Token(Token = "0x6000076")]
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA01C0", Offset = "0x2F9F5C0", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000077")]
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0300", Offset = "0x2F9F700", Length = "0x80")]
	[Token(Token = "0x6000084")]
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA02A0", Offset = "0x2F9F6A0", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000085")]
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA03E0", Offset = "0x2F9F7E0", Length = "0x80")]
	[Token(Token = "0x6000074")]
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0380", Offset = "0x2F9F780", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000075")]
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA04C0", Offset = "0x2F9F8C0", Length = "0x80")]
	[Token(Token = "0x600007C")]
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0460", Offset = "0x2F9F860", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600007D")]
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA05A0", Offset = "0x2F9F9A0", Length = "0x80")]
	[Token(Token = "0x600007A")]
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0540", Offset = "0x2F9F940", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600007B")]
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0680", Offset = "0x2F9FA80", Length = "0x80")]
	[Token(Token = "0x600008E")]
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0620", Offset = "0x2F9FA20", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600008F")]
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0760", Offset = "0x2F9FB60", Length = "0x80")]
	[Token(Token = "0x6000094")]
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0700", Offset = "0x2F9FB00", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000095")]
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0840", Offset = "0x2F9FC40", Length = "0x80")]
	[Token(Token = "0x6000098")]
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA07E0", Offset = "0x2F9FBE0", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000099")]
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0920", Offset = "0x2F9FD20", Length = "0x80")]
	[Token(Token = "0x6000096")]
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA08C0", Offset = "0x2F9FCC0", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000097")]
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0A00", Offset = "0x2F9FE00", Length = "0x80")]
	[Token(Token = "0x600008C")]
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA09A0", Offset = "0x2F9FDA0", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600008D")]
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0AE0", Offset = "0x2F9FEE0", Length = "0x80")]
	[Token(Token = "0x600009A")]
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0A80", Offset = "0x2F9FE80", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600009B")]
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0BC0", Offset = "0x2F9FFC0", Length = "0x80")]
	[Token(Token = "0x600008A")]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0B60", Offset = "0x2F9FF60", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600008B")]
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0CA0", Offset = "0x2FA00A0", Length = "0x80")]
	[Token(Token = "0x6000092")]
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0C40", Offset = "0x2FA0040", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000093")]
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0D80", Offset = "0x2FA0180", Length = "0x80")]
	[Token(Token = "0x6000090")]
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA0D20", Offset = "0x2FA0120", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000091")]
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA1070", Offset = "0x2FA0470", Length = "0x64")]
	[Token(Token = "0x6000087")]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA10E0", Offset = "0x2FA04E0", Length = "0xB0")]
	[Token(Token = "0x6000086")]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[Address(RVA = "0x2FA0EF0", Offset = "0x2FA02F0", Length = "0x176")]
	[Token(Token = "0x6000088")]
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0E70", Offset = "0x2FA0270", Length = "0x71")]
	[ThreadSafe]
	[Token(Token = "0x6000089")]
	private static JStringBinding CallStaticStringMethodUnsafeInternal(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA0E00", Offset = "0x2FA0200", Length = "0x62")]
	[Token(Token = "0x60000C3")]
	private static void CallStaticStringMethodUnsafeInternal_Injected(IntPtr clazz, IntPtr methodID, jvalue* args, out JStringBinding ret) { }

	[Address(RVA = "0x2FA1470", Offset = "0x2FA0870", Length = "0xB0")]
	[Token(Token = "0x6000070")]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[Address(RVA = "0x2FA1400", Offset = "0x2FA0800", Length = "0x64")]
	[Token(Token = "0x6000071")]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA1280", Offset = "0x2FA0680", Length = "0x176")]
	[Token(Token = "0x6000072")]
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA1200", Offset = "0x2FA0600", Length = "0x71")]
	[ThreadSafe]
	[Token(Token = "0x6000073")]
	private static JStringBinding CallStringMethodUnsafeInternal(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA1190", Offset = "0x2FA0590", Length = "0x62")]
	[Token(Token = "0x60000C2")]
	private static void CallStringMethodUnsafeInternal_Injected(IntPtr obj, IntPtr methodID, jvalue* args, out JStringBinding ret) { }

	[Address(RVA = "0x2FA1560", Offset = "0x2FA0960", Length = "0xBC")]
	[ThreadSafe]
	[Token(Token = "0x600009C")]
	private static IntPtr ConvertToBooleanArray(Boolean[] array) { }

	[Address(RVA = "0x2FA1520", Offset = "0x2FA0920", Length = "0x33")]
	[Token(Token = "0x60000C4")]
	private static IntPtr ConvertToBooleanArray_Injected(ref ManagedSpanWrapper array) { }

	[Address(RVA = "0x2FA1620", Offset = "0x2FA0A20", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000065")]
	public static void DeleteLocalRef(IntPtr obj) { }

	[Address(RVA = "0x2FA1660", Offset = "0x2FA0A60", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000063")]
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x2FA16A0", Offset = "0x2FA0AA0", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x600005D")]
	public static void ExceptionClear() { }

	[Address(RVA = "0x2FA16D0", Offset = "0x2FA0AD0", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x600005C")]
	public static IntPtr ExceptionOccurred() { }

	[Address(RVA = "0x2FA1740", Offset = "0x2FA0B40", Length = "0x18F")]
	[ThreadSafe]
	[Token(Token = "0x600005A")]
	public static IntPtr FindClass(string name) { }

	[Address(RVA = "0x2FA1700", Offset = "0x2FA0B00", Length = "0x33")]
	[Token(Token = "0x60000BD")]
	private static IntPtr FindClass_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x2FA1920", Offset = "0x2FA0D20", Length = "0xBC")]
	[ThreadSafe]
	[Token(Token = "0x60000AF")]
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	[Address(RVA = "0x2FA18D0", Offset = "0x2FA0CD0", Length = "0x42")]
	[Token(Token = "0x60000C6")]
	private static void FromBooleanArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x2FA1A30", Offset = "0x2FA0E30", Length = "0xBC")]
	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	[Token(Token = "0x60000B0")]
	public static Byte[] FromByteArray(IntPtr array) { }

	[Address(RVA = "0x2FA19E0", Offset = "0x2FA0DE0", Length = "0x42")]
	[Token(Token = "0x60000C7")]
	private static void FromByteArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x2FA1AF0", Offset = "0x2FA0EF0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B2")]
	public static Char[] FromCharArray(IntPtr array) { }

	[Address(RVA = "0x2FA1B30", Offset = "0x2FA0F30", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B7")]
	public static Double[] FromDoubleArray(IntPtr array) { }

	[Address(RVA = "0x2FA1B70", Offset = "0x2FA0F70", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B6")]
	public static Single[] FromFloatArray(IntPtr array) { }

	[Address(RVA = "0x2FA1BB0", Offset = "0x2FA0FB0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B4")]
	public static Int32[] FromIntArray(IntPtr array) { }

	[Address(RVA = "0x2FA1BF0", Offset = "0x2FA0FF0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B5")]
	public static Int64[] FromLongArray(IntPtr array) { }

	[Address(RVA = "0x2FA1C30", Offset = "0x2FA1030", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x600005B")]
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[Address(RVA = "0x2FA1C70", Offset = "0x2FA1070", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B1")]
	public static SByte[] FromSByteArray(IntPtr array) { }

	[Address(RVA = "0x2FA1CB0", Offset = "0x2FA10B0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B3")]
	public static Int16[] FromShortArray(IntPtr array) { }

	[Address(RVA = "0x2FA1CF0", Offset = "0x2FA10F0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000B8")]
	public static int GetArrayLength(IntPtr array) { }

	[Address(RVA = "0x2FA1D90", Offset = "0x2FA1190", Length = "0x2AD")]
	[ThreadSafe]
	[Token(Token = "0x600006A")]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[Address(RVA = "0x2FA1D30", Offset = "0x2FA1130", Length = "0x52")]
	[Token(Token = "0x60000BE")]
	private static IntPtr GetMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	[Address(RVA = "0x2FA2040", Offset = "0x2FA1440", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000BA")]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[Address(RVA = "0x2FA2080", Offset = "0x2FA1480", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000069")]
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[Address(RVA = "0x2FA2120", Offset = "0x2FA1520", Length = "0x2AD")]
	[ThreadSafe]
	[Token(Token = "0x600006B")]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[Address(RVA = "0x2FA20C0", Offset = "0x2FA14C0", Length = "0x52")]
	[Token(Token = "0x60000BF")]
	private static IntPtr GetStaticMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	[Address(RVA = "0x2FA2480", Offset = "0x2FA1880", Length = "0x156")]
	[Token(Token = "0x600006E")]
	public static string GetStringChars(IntPtr str) { }

	[Address(RVA = "0x2FA2420", Offset = "0x2FA1820", Length = "0x51")]
	[ThreadSafe]
	[Token(Token = "0x600006F")]
	private static JStringBinding GetStringCharsInternal(IntPtr str) { }

	[Address(RVA = "0x2FA23D0", Offset = "0x2FA17D0", Length = "0x42")]
	[Token(Token = "0x60000C1")]
	private static void GetStringCharsInternal_Injected(IntPtr str, out JStringBinding ret) { }

	[Address(RVA = "0x2FA25E0", Offset = "0x2FA19E0", Length = "0x21")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000059")]
	private static void InvokeAction(Action action) { }

	[Address(RVA = "0x2FA2610", Offset = "0x2FA1A10", Length = "0x42")]
	[ThreadSafe]
	[Token(Token = "0x6000066")]
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	[Address(RVA = "0x2FA2660", Offset = "0x2FA1A60", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000060")]
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x2FA26A0", Offset = "0x2FA1AA0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000064")]
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[Address(RVA = "0x2FA2790", Offset = "0x2FA1B90", Length = "0x80")]
	[Token(Token = "0x6000067")]
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2FA26E0", Offset = "0x2FA1AE0", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x6000068")]
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Address(RVA = "0x2FA2740", Offset = "0x2FA1B40", Length = "0x50")]
	[ThreadSafe]
	[Token(Token = "0x60000B9")]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[Address(RVA = "0x2FA29E0", Offset = "0x2FA1DE0", Length = "0x9")]
	[Token(Token = "0x600006C")]
	public static IntPtr NewString(string chars) { }

	[Address(RVA = "0x2FA2850", Offset = "0x2FA1C50", Length = "0x18F")]
	[ThreadSafe]
	[Token(Token = "0x600006D")]
	private static IntPtr NewStringFromStr(string chars) { }

	[Address(RVA = "0x2FA2810", Offset = "0x2FA1C10", Length = "0x33")]
	[Token(Token = "0x60000C0")]
	private static IntPtr NewStringFromStr_Injected(ref ManagedSpanWrapper chars) { }

	[Address(RVA = "0x2FA29F0", Offset = "0x2FA1DF0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000062")]
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x2FA2A30", Offset = "0x2FA1E30", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x600005F")]
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[Address(RVA = "0x2FA2A70", Offset = "0x2FA1E70", Length = "0x31")]
	[ThreadSafe]
	[Token(Token = "0x600005E")]
	public static int PushLocalFrame(int capacity) { }

	[Address(RVA = "0x2FA2AB0", Offset = "0x2FA1EB0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000061")]
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[Address(RVA = "0x2FA2B30", Offset = "0x2FA1F30", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000058")]
	private static void ReleaseStringChars(JStringBinding str) { }

	[Address(RVA = "0x2FA2AF0", Offset = "0x2FA1EF0", Length = "0x33")]
	[Token(Token = "0x60000BC")]
	private static void ReleaseStringChars_Injected(in JStringBinding str) { }

	[Address(RVA = "0x2FA2B70", Offset = "0x2FA1F70", Length = "0x50")]
	[ThreadSafe]
	[Token(Token = "0x60000BB")]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	[Address(RVA = "0x2FA2BC0", Offset = "0x2FA1FC0", Length = "0xBC")]
	[Token(Token = "0x600009D")]
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	[Address(RVA = "0x2FA2CC0", Offset = "0x2FA20C0", Length = "0xBC")]
	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	[Token(Token = "0x600009E")]
	public static IntPtr ToByteArray(Byte[] array) { }

	[Address(RVA = "0x2FA2C80", Offset = "0x2FA2080", Length = "0x33")]
	[Token(Token = "0x60000C5")]
	private static IntPtr ToByteArray_Injected(ref ManagedSpanWrapper array) { }

	[Address(RVA = "0x2FA2D80", Offset = "0x2FA2180", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000A2")]
	public static IntPtr ToCharArray(Char* array, int length) { }

	[Address(RVA = "0x2FA2DC0", Offset = "0x2FA21C0", Length = "0x63")]
	[Token(Token = "0x60000A1")]
	public static IntPtr ToCharArray(Char[] array) { }

	[Address(RVA = "0x2FA2EA0", Offset = "0x2FA22A0", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000AC")]
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	[Address(RVA = "0x2FA2E30", Offset = "0x2FA2230", Length = "0x63")]
	[Token(Token = "0x60000AB")]
	public static IntPtr ToDoubleArray(Double[] array) { }

	[Address(RVA = "0x2FA2F50", Offset = "0x2FA2350", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000AA")]
	public static IntPtr ToFloatArray(Single* array, int length) { }

	[Address(RVA = "0x2FA2EE0", Offset = "0x2FA22E0", Length = "0x63")]
	[Token(Token = "0x60000A9")]
	public static IntPtr ToFloatArray(Single[] array) { }

	[Address(RVA = "0x2FA2F90", Offset = "0x2FA2390", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000A6")]
	public static IntPtr ToIntArray(Int32* array, int length) { }

	[Address(RVA = "0x2FA2FD0", Offset = "0x2FA23D0", Length = "0x63")]
	[Token(Token = "0x60000A5")]
	public static IntPtr ToIntArray(Int32[] array) { }

	[Address(RVA = "0x2FA30B0", Offset = "0x2FA24B0", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000A8")]
	public static IntPtr ToLongArray(Int64* array, int length) { }

	[Address(RVA = "0x2FA3040", Offset = "0x2FA2440", Length = "0x63")]
	[Token(Token = "0x60000A7")]
	public static IntPtr ToLongArray(Int64[] array) { }

	[Address(RVA = "0x2FA3170", Offset = "0x2FA2570", Length = "0x50")]
	[ThreadSafe]
	[Token(Token = "0x60000AD")]
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	[Address(RVA = "0x2FA30F0", Offset = "0x2FA24F0", Length = "0x77")]
	[Token(Token = "0x60000AE")]
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[Address(RVA = "0x2FA3230", Offset = "0x2FA2630", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000A0")]
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	[Address(RVA = "0x2FA31C0", Offset = "0x2FA25C0", Length = "0x63")]
	[Token(Token = "0x600009F")]
	public static IntPtr ToSByteArray(SByte[] array) { }

	[Address(RVA = "0x2FA32B0", Offset = "0x2FA26B0", Length = "0x63")]
	[Token(Token = "0x60000A3")]
	public static IntPtr ToShortArray(Int16[] array) { }

	[Address(RVA = "0x2FA3270", Offset = "0x2FA2670", Length = "0x40")]
	[ThreadSafe]
	[Token(Token = "0x60000A4")]
	public static IntPtr ToShortArray(Int16* array, int length) { }

}

