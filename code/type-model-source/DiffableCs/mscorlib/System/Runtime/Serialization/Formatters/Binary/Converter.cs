namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000422")]
internal sealed class Converter
{
	[Token(Token = "0x4001065")]
	private static int primitiveTypeEnumLength; //Field offset: 0x0
	[Token(Token = "0x4001066")]
	private static Type[] typeA; //Field offset: 0x8
	[Token(Token = "0x4001067")]
	private static Type[] arrayTypeA; //Field offset: 0x10
	[Token(Token = "0x4001068")]
	private static String[] valueA; //Field offset: 0x18
	[Token(Token = "0x4001069")]
	private static TypeCode[] typeCodeA; //Field offset: 0x20
	[Token(Token = "0x400106A")]
	private static InternalPrimitiveTypeE[] codeA; //Field offset: 0x28
	[Token(Token = "0x400106B")]
	internal static Type typeofISerializable; //Field offset: 0x30
	[Token(Token = "0x400106C")]
	internal static Type typeofString; //Field offset: 0x38
	[Token(Token = "0x400106D")]
	internal static Type typeofConverter; //Field offset: 0x40
	[Token(Token = "0x400106E")]
	internal static Type typeofBoolean; //Field offset: 0x48
	[Token(Token = "0x400106F")]
	internal static Type typeofByte; //Field offset: 0x50
	[Token(Token = "0x4001070")]
	internal static Type typeofChar; //Field offset: 0x58
	[Token(Token = "0x4001071")]
	internal static Type typeofDecimal; //Field offset: 0x60
	[Token(Token = "0x4001072")]
	internal static Type typeofDouble; //Field offset: 0x68
	[Token(Token = "0x4001073")]
	internal static Type typeofInt16; //Field offset: 0x70
	[Token(Token = "0x4001074")]
	internal static Type typeofInt32; //Field offset: 0x78
	[Token(Token = "0x4001075")]
	internal static Type typeofInt64; //Field offset: 0x80
	[Token(Token = "0x4001076")]
	internal static Type typeofSByte; //Field offset: 0x88
	[Token(Token = "0x4001077")]
	internal static Type typeofSingle; //Field offset: 0x90
	[Token(Token = "0x4001078")]
	internal static Type typeofTimeSpan; //Field offset: 0x98
	[Token(Token = "0x4001079")]
	internal static Type typeofDateTime; //Field offset: 0xA0
	[Token(Token = "0x400107A")]
	internal static Type typeofUInt16; //Field offset: 0xA8
	[Token(Token = "0x400107B")]
	internal static Type typeofUInt32; //Field offset: 0xB0
	[Token(Token = "0x400107C")]
	internal static Type typeofUInt64; //Field offset: 0xB8
	[Token(Token = "0x400107D")]
	internal static Type typeofObject; //Field offset: 0xC0
	[Token(Token = "0x400107E")]
	internal static Type typeofSystemVoid; //Field offset: 0xC8
	[Token(Token = "0x400107F")]
	internal static Assembly urtAssembly; //Field offset: 0xD0
	[Token(Token = "0x4001080")]
	internal static string urtAssemblyString; //Field offset: 0xD8
	[Token(Token = "0x4001081")]
	internal static Type typeofTypeArray; //Field offset: 0xE0
	[Token(Token = "0x4001082")]
	internal static Type typeofObjectArray; //Field offset: 0xE8
	[Token(Token = "0x4001083")]
	internal static Type typeofStringArray; //Field offset: 0xF0
	[Token(Token = "0x4001084")]
	internal static Type typeofBooleanArray; //Field offset: 0xF8
	[Token(Token = "0x4001085")]
	internal static Type typeofByteArray; //Field offset: 0x100
	[Token(Token = "0x4001086")]
	internal static Type typeofCharArray; //Field offset: 0x108
	[Token(Token = "0x4001087")]
	internal static Type typeofDecimalArray; //Field offset: 0x110
	[Token(Token = "0x4001088")]
	internal static Type typeofDoubleArray; //Field offset: 0x118
	[Token(Token = "0x4001089")]
	internal static Type typeofInt16Array; //Field offset: 0x120
	[Token(Token = "0x400108A")]
	internal static Type typeofInt32Array; //Field offset: 0x128
	[Token(Token = "0x400108B")]
	internal static Type typeofInt64Array; //Field offset: 0x130
	[Token(Token = "0x400108C")]
	internal static Type typeofSByteArray; //Field offset: 0x138
	[Token(Token = "0x400108D")]
	internal static Type typeofSingleArray; //Field offset: 0x140
	[Token(Token = "0x400108E")]
	internal static Type typeofTimeSpanArray; //Field offset: 0x148
	[Token(Token = "0x400108F")]
	internal static Type typeofDateTimeArray; //Field offset: 0x150
	[Token(Token = "0x4001090")]
	internal static Type typeofUInt16Array; //Field offset: 0x158
	[Token(Token = "0x4001091")]
	internal static Type typeofUInt32Array; //Field offset: 0x160
	[Token(Token = "0x4001092")]
	internal static Type typeofUInt64Array; //Field offset: 0x168
	[Token(Token = "0x4001093")]
	internal static Type typeofMarshalByRefObject; //Field offset: 0x170

	[Address(RVA = "0x1F1B850", Offset = "0x1F1AC50", Length = "0xBE7")]
	[Token(Token = "0x6001F00")]
	private static Converter() { }

	[Address(RVA = "0x1F19590", Offset = "0x1F18990", Length = "0x19C")]
	[Token(Token = "0x6001EF7")]
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	[Address(RVA = "0x1F19770", Offset = "0x1F18B70", Length = "0xCE")]
	[Token(Token = "0x6001EFF")]
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x1F19840", Offset = "0x1F18C40", Length = "0x658")]
	[Token(Token = "0x6001EF5")]
	private static void InitArrayTypeA() { }

	[Address(RVA = "0x1F19EA0", Offset = "0x1F192A0", Length = "0x1C1")]
	[Token(Token = "0x6001EFD")]
	private static void InitCodeA() { }

	[Address(RVA = "0x1F1A070", Offset = "0x1F19470", Length = "0x643")]
	[Token(Token = "0x6001EF4")]
	private static void InitTypeA() { }

	[Address(RVA = "0x1F1A6C0", Offset = "0x1F19AC0", Length = "0x1AB")]
	[Token(Token = "0x6001EFB")]
	private static void InitTypeCodeA() { }

	[Address(RVA = "0x1F1A870", Offset = "0x1F19C70", Length = "0x35C")]
	[Token(Token = "0x6001EF9")]
	private static void InitValueA() { }

	[Address(RVA = "0x1F1ABD0", Offset = "0x1F19FD0", Length = "0x2E9")]
	[Token(Token = "0x6001EF8")]
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	[Address(RVA = "0x1F1AEC0", Offset = "0x1F1A2C0", Length = "0x2C")]
	[Token(Token = "0x6001EF1")]
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x1F1AF30", Offset = "0x1F1A330", Length = "0xCC")]
	[Token(Token = "0x6001EF3")]
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x1F1B000", Offset = "0x1F1A400", Length = "0x11C")]
	[Token(Token = "0x6001EF0")]
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	[Address(RVA = "0x1F1B120", Offset = "0x1F1A520", Length = "0xCC")]
	[Token(Token = "0x6001EFA")]
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x1F1B1F0", Offset = "0x1F1A5F0", Length = "0x283")]
	[Token(Token = "0x6001EFE")]
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	[Address(RVA = "0x1F1B6F0", Offset = "0x1F1AAF0", Length = "0xCC")]
	[Token(Token = "0x6001EF6")]
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x1F1B480", Offset = "0x1F1A880", Length = "0x26E")]
	[Token(Token = "0x6001EFC")]
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x1F1B7C0", Offset = "0x1F1ABC0", Length = "0x44")]
	[Token(Token = "0x6001EF2")]
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

}

