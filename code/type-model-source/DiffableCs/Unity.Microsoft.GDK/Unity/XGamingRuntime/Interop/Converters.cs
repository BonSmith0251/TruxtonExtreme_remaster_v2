namespace Unity.XGamingRuntime.Interop;

[Extension]
[Token(Token = "0x20002A9")]
public static class Converters
{

	[Address(RVA = "0x2B8D010", Offset = "0x2B8C410", Length = "0x9F")]
	[Token(Token = "0x6000DDB")]
	public static string ByteArrayToString(Byte[] arr, int index, int count) { }

	[Address(RVA = "0x2B8CFA0", Offset = "0x2B8C3A0", Length = "0x6B")]
	[Token(Token = "0x6000DDA")]
	public static string ByteArrayToString(Byte[] arr) { }

	[Address(RVA = "0x2B8D0B0", Offset = "0x2B8C4B0", Length = "0xF3")]
	[Token(Token = "0x6000DD8")]
	public static string BytePointerToString(Byte* bytePointer, int length) { }

	[Address(RVA = "0x7AFE20", Offset = "0x7AF220", Length = "0x3F9")]
	[Token(Token = "0x6000DE0")]
	public static IntPtr ClassArrayToPtr(ClassType[] inputTypes, Func<ClassType, DisposableCollection, InteropStructType> converter, DisposableCollection disposableCollection, out SizeT arrayCount) { }

	[Address(RVA = "0x7B19B0", Offset = "0x7B0DB0", Length = "0x11C")]
	[Token(Token = "0x6000DE1")]
	public static InteropStructType[] ConvertArrayToFixedLength(ClassType[] classes, int length, Func<ClassType, InteropStructType> ctor) { }

	[Address(RVA = "0x2B8D1B0", Offset = "0x2B8C5B0", Length = "0x69")]
	[Token(Token = "0x6000DD1")]
	public static int GetSizeRequiredToEncodeStringToUTF8(string str) { }

	[Address(RVA = "0x2B8D220", Offset = "0x2B8C620", Length = "0x10A")]
	[Token(Token = "0x6000DD9")]
	public static string NullTerminatedBytePointerToString(Byte* bytePointer) { }

	[Address(RVA = "0x2B8D330", Offset = "0x2B8C730", Length = "0x3E")]
	[Extension]
	[Token(Token = "0x6000DD0")]
	public static IntPtr Offset(IntPtr ptr, long that) { }

	[Address(RVA = "0x7B58E0", Offset = "0x7B4CE0", Length = "0x12F")]
	[Token(Token = "0x6000DDD")]
	public static ClassType PtrToClass(IntPtr rawPtr, Func<InteropStructType, ClassType> ctor) { }

	[Address(RVA = "0x7B26D0", Offset = "0x7B1AD0", Length = "0x5D")]
	[Token(Token = "0x6000DDE")]
	public static ClassType[] PtrToClassArray(IntPtr rawPtr, SizeT count, Func<InteropStructType, ClassType> ctor) { }

	[Address(RVA = "0x7B24C0", Offset = "0x7B18C0", Length = "0x205")]
	[Token(Token = "0x6000DDF")]
	public static ClassType[] PtrToClassArray(IntPtr rawPtr, uint count, Func<InteropStructType, ClassType> ctor) { }

	[Address(RVA = "0x2B8D370", Offset = "0x2B8C770", Length = "0x1A4")]
	[Token(Token = "0x6000DDC")]
	public static string PtrToStringUTF8(IntPtr rawPtr) { }

	[Address(RVA = "0x2B8D520", Offset = "0x2B8C920", Length = "0x159")]
	[Token(Token = "0x6000DD3")]
	public static IntPtr StringArrayToUTF8StringArray(String[] strings, DisposableCollection disposableCollection, out SizeT count) { }

	[Address(RVA = "0x2B8D680", Offset = "0x2B8CA80", Length = "0x50E")]
	[Token(Token = "0x6000DD2")]
	public static DisposableBuffer StringArrayToUTF8StringArray(String[] strings) { }

	[Address(RVA = "0x2B8DD60", Offset = "0x2B8D160", Length = "0x8")]
	[Token(Token = "0x6000DD5")]
	public static Byte[] StringToNullTerminatedUTF8ByteArray(string str, int requiredByteArrayLength) { }

	[Address(RVA = "0x2B8DCC0", Offset = "0x2B8D0C0", Length = "0x92")]
	[Token(Token = "0x6000DD4")]
	public static Byte[] StringToNullTerminatedUTF8ByteArray(string str) { }

	[Address(RVA = "0x2B8DB90", Offset = "0x2B8CF90", Length = "0x125")]
	[Token(Token = "0x6000DD6")]
	private static Byte[] StringToNullTerminatedUTF8ByteArrayInternal(string str, int requiredByteArrayLength) { }

	[Address(RVA = "0x2B8DD70", Offset = "0x2B8D170", Length = "0x8F")]
	[Token(Token = "0x6000DD7")]
	public static void StringToNullTerminatedUTF8FixedPointer(string str, Byte* bytePointer, int length) { }

}

