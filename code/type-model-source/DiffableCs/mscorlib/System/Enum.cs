namespace System;

[ComVisible(True)]
[Token(Token = "0x2000189")]
public abstract class Enum : IComparable, IFormattable, IConvertible
{
	[Token(Token = "0x200018B")]
	private struct EnumResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005A2")]
		internal object parsedEnum; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005A3")]
		internal bool canThrow; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40005A4")]
		internal ParseFailureKind m_failure; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005A5")]
		internal string m_failureMessageID; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005A6")]
		internal string m_failureParameter; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005A7")]
		internal object m_failureMessageFormatArgument; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005A8")]
		internal Exception m_innerException; //Field offset: 0x28

		[Address(RVA = "0x2063760", Offset = "0x2062B60", Length = "0x1DD")]
		[Token(Token = "0x6000E2B")]
		internal Exception GetEnumParseException() { }

		[Address(RVA = "0x2063940", Offset = "0x2062D40", Length = "0x46")]
		[Token(Token = "0x6000E27")]
		internal void Init(bool canMethodThrow) { }

		[Address(RVA = "0x2063990", Offset = "0x2062D90", Length = "0x14")]
		[Token(Token = "0x6000E28")]
		internal void SetFailure(Exception unhandledException) { }

		[Address(RVA = "0x20639B0", Offset = "0x2062DB0", Length = "0x4C")]
		[Token(Token = "0x6000E29")]
		internal void SetFailure(ParseFailureKind failure, string failureParameter) { }

		[Address(RVA = "0x2063A00", Offset = "0x2062E00", Length = "0x68")]
		[Token(Token = "0x6000E2A")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	}

	[Token(Token = "0x200018A")]
	private enum ParseFailureKind : int
	{
		None = 0,
		Argument = 1,
		ArgumentNull = 2,
		ArgumentWithParameter = 3,
		UnhandledException = 4,
	}

	[Token(Token = "0x200018C")]
	private class ValuesAndNames
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005A9")]
		public UInt64[] Values; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005AA")]
		public String[] Names; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000E2C")]
		public ValuesAndNames(UInt64[] values, String[] names) { }

	}

	[Token(Token = "0x400059A")]
	private static readonly Char[] enumSeperatorCharArray; //Field offset: 0x0
	[Token(Token = "0x400059B")]
	private const string enumSeperator = ", "; //Field offset: 0x0

	[Address(RVA = "0x2068840", Offset = "0x2067C40", Length = "0x78")]
	[Token(Token = "0x6000E26")]
	private static Enum() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000E25")]
	protected Enum() { }

	[Address(RVA = "0x2063A70", Offset = "0x2062E70", Length = "0x1EB")]
	[Token(Token = "0x6000E05")]
	public override int CompareTo(object target) { }

	[Address(RVA = "0x2063C60", Offset = "0x2063060", Length = "0x8")]
	[Token(Token = "0x6000E01")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2063C70", Offset = "0x2063070", Length = "0x710")]
	[ComVisible(True)]
	[Token(Token = "0x6000DFC")]
	public static string Format(Type enumType, object value, string format) { }

	[Address(RVA = "0x2064520", Offset = "0x2063920", Length = "0x5")]
	[Token(Token = "0x6000E00")]
	private int get_hashcode() { }

	[Address(RVA = "0x2064B40", Offset = "0x2063F40", Length = "0x5")]
	[Token(Token = "0x6000DFD")]
	private object get_value() { }

	[Address(RVA = "0x2064390", Offset = "0x2063790", Length = "0x177")]
	[Token(Token = "0x6000DE6")]
	private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	[Address(RVA = "0x2064510", Offset = "0x2063910", Length = "0x5")]
	[Token(Token = "0x6000DED")]
	private static bool GetEnumValuesAndNames(RuntimeType enumType, out UInt64[] values, out String[] names) { }

	[Address(RVA = "0x2064520", Offset = "0x2063920", Length = "0x5")]
	[Token(Token = "0x6000E02")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2064530", Offset = "0x2063930", Length = "0xAD")]
	[ComVisible(True)]
	[Token(Token = "0x6000DF7")]
	public static string GetName(Type enumType, object value) { }

	[Address(RVA = "0x20645E0", Offset = "0x20639E0", Length = "0x9E")]
	[ComVisible(True)]
	[Token(Token = "0x6000DF8")]
	public static String[] GetNames(Type enumType) { }

	[Address(RVA = "0x2064680", Offset = "0x2063A80", Length = "0x418")]
	[Token(Token = "0x6000E09")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x2064AA0", Offset = "0x2063EA0", Length = "0x9E")]
	[ComVisible(True)]
	[Token(Token = "0x6000DF4")]
	public static Type GetUnderlyingType(Type enumType) { }

	[Address(RVA = "0x2064B40", Offset = "0x2063F40", Length = "0x5")]
	[Token(Token = "0x6000DFE")]
	internal object GetValue() { }

	[Address(RVA = "0x2064B50", Offset = "0x2063F50", Length = "0x9E")]
	[ComVisible(True)]
	[Token(Token = "0x6000DF5")]
	public static Array GetValues(Type enumType) { }

	[Address(RVA = "0x2064BF0", Offset = "0x2063FF0", Length = "0x198")]
	[Token(Token = "0x6000E08")]
	public bool HasFlag(Enum flag) { }

	[Address(RVA = "0x2064D90", Offset = "0x2064190", Length = "0x5")]
	[Token(Token = "0x6000DEE")]
	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	[Address(RVA = "0x2064DA0", Offset = "0x20641A0", Length = "0x5")]
	[Token(Token = "0x6000DEB")]
	private static int InternalCompareTo(object o1, object o2) { }

	[Address(RVA = "0x2064DB0", Offset = "0x20641B0", Length = "0x201")]
	[Token(Token = "0x6000DE9")]
	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	[Address(RVA = "0x2064FC0", Offset = "0x20643C0", Length = "0x17F")]
	[Token(Token = "0x6000DE8")]
	private static string InternalFormat(RuntimeType eT, object value) { }

	[Address(RVA = "0x2065140", Offset = "0x2064540", Length = "0x478")]
	[Token(Token = "0x6000DE7")]
	private static string InternalFormattedHexString(object value) { }

	[Address(RVA = "0x20655E0", Offset = "0x20649E0", Length = "0x3F")]
	[Token(Token = "0x6000DF9")]
	internal static String[] InternalGetNames(RuntimeType enumType) { }

	[Address(RVA = "0x2065620", Offset = "0x2064A20", Length = "0x5")]
	[Token(Token = "0x6000DEC")]
	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	[Address(RVA = "0x2065630", Offset = "0x2064A30", Length = "0x3F")]
	[Token(Token = "0x6000DF6")]
	internal static UInt64[] InternalGetValues(RuntimeType enumType) { }

	[Address(RVA = "0x2065670", Offset = "0x2064A70", Length = "0x5")]
	[Token(Token = "0x6000DFF")]
	private bool InternalHasFlag(Enum flags) { }

	[Address(RVA = "0x2065680", Offset = "0x2064A80", Length = "0xAD")]
	[ComVisible(True)]
	[Token(Token = "0x6000DFB")]
	public static bool IsDefined(Type enumType, object value) { }

	[Address(RVA = "0x2065800", Offset = "0x2064C00", Length = "0xD2")]
	[ComVisible(True)]
	[Token(Token = "0x6000DF1")]
	public static object Parse(Type enumType, string value) { }

	[Address(RVA = "0x2065730", Offset = "0x2064B30", Length = "0xC8")]
	[ComVisible(True)]
	[Token(Token = "0x6000DF2")]
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	[Address(RVA = "0x20658E0", Offset = "0x2064CE0", Length = "0x8C")]
	[Token(Token = "0x6000E0A")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x2065970", Offset = "0x2064D70", Length = "0x8C")]
	[Token(Token = "0x6000E0D")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2065A00", Offset = "0x2064E00", Length = "0x8C")]
	[Token(Token = "0x6000E0B")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2065A90", Offset = "0x2064E90", Length = "0xF2")]
	[Token(Token = "0x6000E17")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2065B90", Offset = "0x2064F90", Length = "0xA8")]
	[Token(Token = "0x6000E16")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2065C40", Offset = "0x2065040", Length = "0x8C")]
	[Token(Token = "0x6000E15")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x2065CD0", Offset = "0x20650D0", Length = "0x8C")]
	[Token(Token = "0x6000E0E")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2065D60", Offset = "0x2065160", Length = "0x8C")]
	[Token(Token = "0x6000E10")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2065DF0", Offset = "0x20651F0", Length = "0x8C")]
	[Token(Token = "0x6000E12")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2065E80", Offset = "0x2065280", Length = "0x8C")]
	[Token(Token = "0x6000E0C")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x2065F10", Offset = "0x2065310", Length = "0x8C")]
	[Token(Token = "0x6000E14")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2065FA0", Offset = "0x20653A0", Length = "0x69")]
	[Token(Token = "0x6000E18")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x2066010", Offset = "0x2065410", Length = "0x8C")]
	[Token(Token = "0x6000E0F")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20660A0", Offset = "0x20654A0", Length = "0x8C")]
	[Token(Token = "0x6000E11")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2066130", Offset = "0x2065530", Length = "0x8C")]
	[Token(Token = "0x6000E13")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x20661C0", Offset = "0x20655C0", Length = "0x21A")]
	[ComVisible(True)]
	[Token(Token = "0x6000E1A")]
	public static object ToObject(Type enumType, short value) { }

	[Address(RVA = "0x2067970", Offset = "0x2066D70", Length = "0x21A")]
	[CLSCompliant(False)]
	[ComVisible(True)]
	[Token(Token = "0x6000E19")]
	public static object ToObject(Type enumType, sbyte value) { }

	[Address(RVA = "0x20663E0", Offset = "0x20657E0", Length = "0x219")]
	[Token(Token = "0x6000E22")]
	private static object ToObject(Type enumType, bool value) { }

	[Address(RVA = "0x20672C0", Offset = "0x20666C0", Length = "0x6C")]
	[ComVisible(True)]
	[Token(Token = "0x6000DFA")]
	public static object ToObject(Type enumType, object value) { }

	[Address(RVA = "0x2066820", Offset = "0x2065C20", Length = "0x219")]
	[ComVisible(True)]
	[Token(Token = "0x6000E1F")]
	public static object ToObject(Type enumType, long value) { }

	[Address(RVA = "0x20670A0", Offset = "0x20664A0", Length = "0x218")]
	[CLSCompliant(False)]
	[ComVisible(True)]
	[Token(Token = "0x6000E1E")]
	public static object ToObject(Type enumType, uint value) { }

	[Address(RVA = "0x2066600", Offset = "0x2065A00", Length = "0x219")]
	[ComVisible(True)]
	[Token(Token = "0x6000E1B")]
	public static object ToObject(Type enumType, int value) { }

	[Address(RVA = "0x2066A40", Offset = "0x2065E40", Length = "0x219")]
	[Token(Token = "0x6000E21")]
	private static object ToObject(Type enumType, char value) { }

	[Address(RVA = "0x2067750", Offset = "0x2066B50", Length = "0x219")]
	[CLSCompliant(False)]
	[ComVisible(True)]
	[Token(Token = "0x6000E20")]
	public static object ToObject(Type enumType, ulong value) { }

	[Address(RVA = "0x2066E80", Offset = "0x2066280", Length = "0x219")]
	[CLSCompliant(False)]
	[ComVisible(True)]
	[Token(Token = "0x6000E1D")]
	public static object ToObject(Type enumType, ushort value) { }

	[Address(RVA = "0x2066C60", Offset = "0x2066060", Length = "0x219")]
	[ComVisible(True)]
	[Token(Token = "0x6000E1C")]
	public static object ToObject(Type enumType, byte value) { }

	[Address(RVA = "0x2067B90", Offset = "0x2066F90", Length = "0x8")]
	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	[Token(Token = "0x6000E04")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x1FCFE00", Offset = "0x1FCF200", Length = "0x14")]
	[Obsolete("The provider argument is not used. Please use ToString().")]
	[Token(Token = "0x6000E07")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2067BA0", Offset = "0x2066FA0", Length = "0xA9")]
	[Token(Token = "0x6000E03")]
	public virtual string ToString() { }

	[Address(RVA = "0x2067C50", Offset = "0x2067050", Length = "0x26D")]
	[Token(Token = "0x6000E06")]
	public string ToString(string format) { }

	[Address(RVA = "0x2067EC0", Offset = "0x20672C0", Length = "0x168")]
	[Token(Token = "0x6000DEA")]
	internal static ulong ToUInt64(object value) { }

	[Address(RVA = "0x7D4180", Offset = "0x7D3580", Length = "0x149")]
	[Token(Token = "0x6000DEF")]
	public static bool TryParse(string value, out TEnum result) { }

	[Address(RVA = "0x7D42D0", Offset = "0x7D36D0", Length = "0x128")]
	[Token(Token = "0x6000DF0")]
	public static bool TryParse(string value, bool ignoreCase, out TEnum result) { }

	[Address(RVA = "0x2068780", Offset = "0x2067B80", Length = "0xBB")]
	[Token(Token = "0x6000E23")]
	public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result) { }

	[Address(RVA = "0x20686B0", Offset = "0x2067AB0", Length = "0xCE")]
	[Token(Token = "0x6000E24")]
	public static bool TryParse(Type enumType, string value, out object result) { }

	[Address(RVA = "0x2068050", Offset = "0x2067450", Length = "0x651")]
	[Token(Token = "0x6000DF3")]
	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult) { }

}

