namespace UnityEngine;

[Token(Token = "0x200000F")]
internal class AndroidJNISafe
{

	[Address(RVA = "0x2F9DB60", Offset = "0x2F9CF60", Length = "0xC4")]
	[Token(Token = "0x60000EA")]
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9DC30", Offset = "0x2F9D030", Length = "0xC2")]
	[Token(Token = "0x60000E4")]
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9DD00", Offset = "0x2F9D100", Length = "0xD8")]
	[Token(Token = "0x60000E5")]
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9DDE0", Offset = "0x2F9D1E0", Length = "0xD7")]
	[Token(Token = "0x60000E6")]
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9DEC0", Offset = "0x2F9D2C0", Length = "0xBD")]
	[Token(Token = "0x60000EB")]
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9DF80", Offset = "0x2F9D380", Length = "0xC2")]
	[Token(Token = "0x60000E7")]
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E050", Offset = "0x2F9D450", Length = "0xC2")]
	[Token(Token = "0x60000E2")]
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E120", Offset = "0x2F9D520", Length = "0xC4")]
	[Token(Token = "0x60000E9")]
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E1F0", Offset = "0x2F9D5F0", Length = "0xC2")]
	[Token(Token = "0x60000E8")]
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E2C0", Offset = "0x2F9D6C0", Length = "0xC4")]
	[Token(Token = "0x60000E0")]
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E390", Offset = "0x2F9D790", Length = "0xC2")]
	[Token(Token = "0x60000DA")]
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E460", Offset = "0x2F9D860", Length = "0xD8")]
	[Token(Token = "0x60000DB")]
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E540", Offset = "0x2F9D940", Length = "0xD7")]
	[Token(Token = "0x60000DC")]
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E620", Offset = "0x2F9DA20", Length = "0xBD")]
	[Token(Token = "0x60000E1")]
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E6E0", Offset = "0x2F9DAE0", Length = "0xC2")]
	[Token(Token = "0x60000DD")]
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E7B0", Offset = "0x2F9DBB0", Length = "0xC2")]
	[Token(Token = "0x60000D8")]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E880", Offset = "0x2F9DC80", Length = "0x85")]
	[Token(Token = "0x60000D7")]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[Address(RVA = "0x2F9E910", Offset = "0x2F9DD10", Length = "0xC4")]
	[Token(Token = "0x60000DF")]
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9E9E0", Offset = "0x2F9DDE0", Length = "0xC2")]
	[Token(Token = "0x60000DE")]
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9EAB0", Offset = "0x2F9DEB0", Length = "0xE6")]
	[Token(Token = "0x60000D9")]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9EBA0", Offset = "0x2F9DFA0", Length = "0xE6")]
	[Token(Token = "0x60000E3")]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9EC90", Offset = "0x2F9E090", Length = "0x220")]
	[Token(Token = "0x60000CA")]
	public static void CheckException() { }

	[Address(RVA = "0x2F9EEC0", Offset = "0x2F9E2C0", Length = "0x37")]
	[Token(Token = "0x60000CD")]
	public static void DeleteLocalRef(IntPtr localref) { }

	[Address(RVA = "0x2F9EF00", Offset = "0x2F9E300", Length = "0x37")]
	[Token(Token = "0x60000CC")]
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	[Address(RVA = "0x2F9EF40", Offset = "0x2F9E340", Length = "0x4E")]
	[Token(Token = "0x60000D4")]
	public static IntPtr FindClass(string name) { }

	[Address(RVA = "0x2F9EF90", Offset = "0x2F9E390", Length = "0x4E")]
	[Token(Token = "0x60000F3")]
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	[Address(RVA = "0x2F9EFE0", Offset = "0x2F9E3E0", Length = "0x4E")]
	[Token(Token = "0x60000F1")]
	public static Byte[] FromByteArray(IntPtr array) { }

	[Address(RVA = "0x2F9F030", Offset = "0x2F9E430", Length = "0x6E")]
	[Token(Token = "0x60000EC")]
	public static Char[] FromCharArray(IntPtr array) { }

	[Address(RVA = "0x2F9F0A0", Offset = "0x2F9E4A0", Length = "0x6E")]
	[Token(Token = "0x60000ED")]
	public static Double[] FromDoubleArray(IntPtr array) { }

	[Address(RVA = "0x2F9F110", Offset = "0x2F9E510", Length = "0x6E")]
	[Token(Token = "0x60000EE")]
	public static Single[] FromFloatArray(IntPtr array) { }

	[Address(RVA = "0x2F9F180", Offset = "0x2F9E580", Length = "0x6E")]
	[Token(Token = "0x60000F4")]
	public static Int32[] FromIntArray(IntPtr array) { }

	[Address(RVA = "0x2F9F1F0", Offset = "0x2F9E5F0", Length = "0x6E")]
	[Token(Token = "0x60000EF")]
	public static Int64[] FromLongArray(IntPtr array) { }

	[Address(RVA = "0x2F9F260", Offset = "0x2F9E660", Length = "0x6E")]
	[Token(Token = "0x60000D3")]
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[Address(RVA = "0x2F9F2D0", Offset = "0x2F9E6D0", Length = "0x6E")]
	[Token(Token = "0x60000F2")]
	public static SByte[] FromSByteArray(IntPtr array) { }

	[Address(RVA = "0x2F9F340", Offset = "0x2F9E740", Length = "0x6E")]
	[Token(Token = "0x60000F0")]
	public static Int16[] FromShortArray(IntPtr array) { }

	[Address(RVA = "0x2F9F3B0", Offset = "0x2F9E7B0", Length = "0x69")]
	[Token(Token = "0x6000100")]
	public static int GetArrayLength(IntPtr array) { }

	[Address(RVA = "0x2F9F420", Offset = "0x2F9E820", Length = "0x4F")]
	[Token(Token = "0x60000D2")]
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	[Address(RVA = "0x2F9F470", Offset = "0x2F9E870", Length = "0x7B")]
	[Token(Token = "0x60000FF")]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[Address(RVA = "0x2F9F4F0", Offset = "0x2F9E8F0", Length = "0x6E")]
	[Token(Token = "0x60000D0")]
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	[Address(RVA = "0x2F9F560", Offset = "0x2F9E960", Length = "0x4F")]
	[Token(Token = "0x60000D1")]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[Address(RVA = "0x2F9F5B0", Offset = "0x2F9E9B0", Length = "0x4E")]
	[Token(Token = "0x60000CF")]
	public static string GetStringChars(IntPtr str) { }

	[Address(RVA = "0x2F9F600", Offset = "0x2F9EA00", Length = "0xC2")]
	[Token(Token = "0x60000D6")]
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[Address(RVA = "0x2F9F6D0", Offset = "0x2F9EAD0", Length = "0x4E")]
	[Token(Token = "0x60000CE")]
	public static IntPtr NewString(string chars) { }

	[Address(RVA = "0x2F9F720", Offset = "0x2F9EB20", Length = "0x41")]
	[Token(Token = "0x60000D5")]
	public static void PushLocalFrame(int capacity) { }

	[Address(RVA = "0x2F9F770", Offset = "0x2F9EB70", Length = "0x37")]
	[Token(Token = "0x60000CB")]
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	[Address(RVA = "0x2F9F7B0", Offset = "0x2F9EBB0", Length = "0xF7")]
	[Token(Token = "0x60000FD")]
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	[Address(RVA = "0x2F9F8B0", Offset = "0x2F9ECB0", Length = "0xFD")]
	[Token(Token = "0x60000FB")]
	public static IntPtr ToByteArray(Byte[] array) { }

	[Address(RVA = "0x2F9F9B0", Offset = "0x2F9EDB0", Length = "0x8F")]
	[Token(Token = "0x60000F6")]
	public static IntPtr ToCharArray(Char[] array) { }

	[Address(RVA = "0x2F9FA40", Offset = "0x2F9EE40", Length = "0x8F")]
	[Token(Token = "0x60000F7")]
	public static IntPtr ToDoubleArray(Double[] array) { }

	[Address(RVA = "0x2F9FAD0", Offset = "0x2F9EED0", Length = "0x8F")]
	[Token(Token = "0x60000F8")]
	public static IntPtr ToFloatArray(Single[] array) { }

	[Address(RVA = "0x2F9FB60", Offset = "0x2F9EF60", Length = "0x8F")]
	[Token(Token = "0x60000FE")]
	public static IntPtr ToIntArray(Int32[] array) { }

	[Address(RVA = "0x2F9FBF0", Offset = "0x2F9EFF0", Length = "0x8F")]
	[Token(Token = "0x60000F9")]
	public static IntPtr ToLongArray(Int64[] array) { }

	[Address(RVA = "0x2F9FC80", Offset = "0x2F9F080", Length = "0x9F")]
	[Token(Token = "0x60000F5")]
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	[Address(RVA = "0x2F9FD20", Offset = "0x2F9F120", Length = "0x8F")]
	[Token(Token = "0x60000FC")]
	public static IntPtr ToSByteArray(SByte[] array) { }

	[Address(RVA = "0x2F9FDB0", Offset = "0x2F9F1B0", Length = "0x8F")]
	[Token(Token = "0x60000FA")]
	public static IntPtr ToShortArray(Int16[] array) { }

}

