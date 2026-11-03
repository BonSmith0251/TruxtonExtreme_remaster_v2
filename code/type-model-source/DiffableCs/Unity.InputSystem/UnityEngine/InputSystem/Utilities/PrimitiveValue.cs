namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000263")]
public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CCD")]
	private TypeCode m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CCE")]
	private bool m_BoolValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CCF")]
	private char m_CharValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD0")]
	private byte m_ByteValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD1")]
	private sbyte m_SByteValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD2")]
	private short m_ShortValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD3")]
	private ushort m_UShortValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD4")]
	private int m_IntValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD5")]
	private uint m_UIntValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD6")]
	private long m_LongValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD7")]
	private ulong m_ULongValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD8")]
	private float m_FloatValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD9")]
	private double m_DoubleValue; //Field offset: 0x4

	[Token(Token = "0x17000609")]
	public bool isEmpty
	{
		[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
		[Token(Token = "0x6001613")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000608")]
	public TypeCode type
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6001612")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000607")]
	internal Byte* valuePtr
	{
		[Address(RVA = "0x2927680", Offset = "0x2926A80", Length = "0x5")]
		[Token(Token = "0x6001611")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2927640", Offset = "0x2926A40", Length = "0x12")]
	[Token(Token = "0x600161A")]
	public PrimitiveValue(int value) { }

	[Address(RVA = "0x29275F0", Offset = "0x29269F0", Length = "0x13")]
	[Token(Token = "0x600161F")]
	public PrimitiveValue(double value) { }

	[Address(RVA = "0x2927560", Offset = "0x2926960", Length = "0x14")]
	[Token(Token = "0x600161E")]
	public PrimitiveValue(float value) { }

	[Address(RVA = "0x29275E0", Offset = "0x29269E0", Length = "0x10")]
	[Token(Token = "0x6001614")]
	public PrimitiveValue(bool value) { }

	[Address(RVA = "0x2927540", Offset = "0x2926940", Length = "0x11")]
	[Token(Token = "0x6001615")]
	public PrimitiveValue(char value) { }

	[Address(RVA = "0x2927610", Offset = "0x2926A10", Length = "0x10")]
	[Token(Token = "0x6001616")]
	public PrimitiveValue(byte value) { }

	[Address(RVA = "0x2927530", Offset = "0x2926930", Length = "0x10")]
	[Token(Token = "0x6001617")]
	public PrimitiveValue(sbyte value) { }

	[Address(RVA = "0x29275C0", Offset = "0x29269C0", Length = "0x11")]
	[Token(Token = "0x6001618")]
	public PrimitiveValue(short value) { }

	[Address(RVA = "0x2927660", Offset = "0x2926A60", Length = "0x11")]
	[Token(Token = "0x6001619")]
	public PrimitiveValue(ushort value) { }

	[Address(RVA = "0x2927580", Offset = "0x2926980", Length = "0x12")]
	[Token(Token = "0x600161D")]
	public PrimitiveValue(ulong value) { }

	[Address(RVA = "0x2927620", Offset = "0x2926A20", Length = "0x12")]
	[Token(Token = "0x600161B")]
	public PrimitiveValue(uint value) { }

	[Address(RVA = "0x29275A0", Offset = "0x29269A0", Length = "0x12")]
	[Token(Token = "0x600161C")]
	public PrimitiveValue(long value) { }

	[Address(RVA = "0x2925860", Offset = "0x2924C60", Length = "0x264")]
	[Token(Token = "0x6001620")]
	public PrimitiveValue ConvertTo(TypeCode type) { }

	[Address(RVA = "0x2925B00", Offset = "0x2924F00", Length = "0x31")]
	[Token(Token = "0x6001621")]
	public override bool Equals(PrimitiveValue other) { }

	[Address(RVA = "0x2925B40", Offset = "0x2924F40", Length = "0x1CF")]
	[Token(Token = "0x6001622")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x8B3BF0", Offset = "0x8B2FF0", Length = "0xDC")]
	[Token(Token = "0x600163A")]
	public static PrimitiveValue From(TValue value) { }

	[Address(RVA = "0x2925D10", Offset = "0x2925110", Length = "0x13")]
	[Token(Token = "0x6001648")]
	public static PrimitiveValue FromBoolean(bool value) { }

	[Address(RVA = "0x2925D30", Offset = "0x2925130", Length = "0x13")]
	[Token(Token = "0x600164A")]
	public static PrimitiveValue FromByte(byte value) { }

	[Address(RVA = "0x2925D50", Offset = "0x2925150", Length = "0x14")]
	[Token(Token = "0x6001649")]
	public static PrimitiveValue FromChar(char value) { }

	[Address(RVA = "0x2925D70", Offset = "0x2925170", Length = "0x16")]
	[Token(Token = "0x6001653")]
	public static PrimitiveValue FromDouble(double value) { }

	[Address(RVA = "0x2925D90", Offset = "0x2925190", Length = "0x14")]
	[Token(Token = "0x600164C")]
	public static PrimitiveValue FromInt16(short value) { }

	[Address(RVA = "0x2925DB0", Offset = "0x29251B0", Length = "0x15")]
	[Token(Token = "0x600164E")]
	public static PrimitiveValue FromInt32(int value) { }

	[Address(RVA = "0x2925DD0", Offset = "0x29251D0", Length = "0x15")]
	[Token(Token = "0x6001650")]
	public static PrimitiveValue FromInt64(long value) { }

	[Address(RVA = "0x2925DF0", Offset = "0x29251F0", Length = "0x21C")]
	[Token(Token = "0x600163B")]
	public static PrimitiveValue FromObject(object value) { }

	[Address(RVA = "0x29264B0", Offset = "0x29258B0", Length = "0x13")]
	[Token(Token = "0x600164B")]
	public static PrimitiveValue FromSByte(sbyte value) { }

	[Address(RVA = "0x29264D0", Offset = "0x29258D0", Length = "0x17")]
	[Token(Token = "0x6001652")]
	public static PrimitiveValue FromSingle(float value) { }

	[Address(RVA = "0x29264F0", Offset = "0x29258F0", Length = "0x335")]
	[Token(Token = "0x6001627")]
	public static PrimitiveValue FromString(string value) { }

	[Address(RVA = "0x2926830", Offset = "0x2925C30", Length = "0x14")]
	[Token(Token = "0x600164D")]
	public static PrimitiveValue FromUInt16(ushort value) { }

	[Address(RVA = "0x2926850", Offset = "0x2925C50", Length = "0x15")]
	[Token(Token = "0x600164F")]
	public static PrimitiveValue FromUInt32(uint value) { }

	[Address(RVA = "0x2926870", Offset = "0x2925C70", Length = "0x15")]
	[Token(Token = "0x6001651")]
	public static PrimitiveValue FromUInt64(ulong value) { }

	[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
	[Token(Token = "0x6001613")]
	public bool get_isEmpty() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6001612")]
	public TypeCode get_type() { }

	[Address(RVA = "0x2927680", Offset = "0x2926A80", Length = "0x5")]
	[Token(Token = "0x6001611")]
	internal Byte* get_valuePtr() { }

	[Address(RVA = "0x2926890", Offset = "0x2925C90", Length = "0x52")]
	[Token(Token = "0x6001625")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6001628")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x2927690", Offset = "0x2926A90", Length = "0x3A")]
	[Token(Token = "0x6001623")]
	public static bool op_Equality(PrimitiveValue left, PrimitiveValue right) { }

	[Address(RVA = "0x2925DB0", Offset = "0x29251B0", Length = "0x15")]
	[Token(Token = "0x6001642")]
	public static PrimitiveValue op_Implicit(int value) { }

	[Address(RVA = "0x29264D0", Offset = "0x29258D0", Length = "0x17")]
	[Token(Token = "0x6001646")]
	public static PrimitiveValue op_Implicit(float value) { }

	[Address(RVA = "0x2926870", Offset = "0x2925C70", Length = "0x15")]
	[Token(Token = "0x6001645")]
	public static PrimitiveValue op_Implicit(ulong value) { }

	[Address(RVA = "0x2925DD0", Offset = "0x29251D0", Length = "0x15")]
	[Token(Token = "0x6001644")]
	public static PrimitiveValue op_Implicit(long value) { }

	[Address(RVA = "0x2926850", Offset = "0x2925C50", Length = "0x15")]
	[Token(Token = "0x6001643")]
	public static PrimitiveValue op_Implicit(uint value) { }

	[Address(RVA = "0x2926830", Offset = "0x2925C30", Length = "0x14")]
	[Token(Token = "0x6001641")]
	public static PrimitiveValue op_Implicit(ushort value) { }

	[Address(RVA = "0x2925D90", Offset = "0x2925190", Length = "0x14")]
	[Token(Token = "0x6001640")]
	public static PrimitiveValue op_Implicit(short value) { }

	[Address(RVA = "0x29264B0", Offset = "0x29258B0", Length = "0x13")]
	[Token(Token = "0x600163F")]
	public static PrimitiveValue op_Implicit(sbyte value) { }

	[Address(RVA = "0x2925D30", Offset = "0x2925130", Length = "0x13")]
	[Token(Token = "0x600163E")]
	public static PrimitiveValue op_Implicit(byte value) { }

	[Address(RVA = "0x2925D50", Offset = "0x2925150", Length = "0x14")]
	[Token(Token = "0x600163D")]
	public static PrimitiveValue op_Implicit(char value) { }

	[Address(RVA = "0x2925D10", Offset = "0x2925110", Length = "0x13")]
	[Token(Token = "0x600163C")]
	public static PrimitiveValue op_Implicit(bool value) { }

	[Address(RVA = "0x2925D70", Offset = "0x2925170", Length = "0x16")]
	[Token(Token = "0x6001647")]
	public static PrimitiveValue op_Implicit(double value) { }

	[Address(RVA = "0x29276D0", Offset = "0x2926AD0", Length = "0x3A")]
	[Token(Token = "0x6001624")]
	public static bool op_Inequality(PrimitiveValue left, PrimitiveValue right) { }

	[Address(RVA = "0x29268F0", Offset = "0x2925CF0", Length = "0x24")]
	[Token(Token = "0x6001629")]
	public override bool ToBoolean(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926AC0", Offset = "0x2925EC0", Length = "0x8")]
	[Token(Token = "0x600162A")]
	public override byte ToByte(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926AD0", Offset = "0x2925ED0", Length = "0x78")]
	[Token(Token = "0x600162B")]
	public override char ToChar(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926B80", Offset = "0x2925F80", Length = "0x4E")]
	[Token(Token = "0x600162C")]
	public override DateTime ToDateTime(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926BD0", Offset = "0x2925FD0", Length = "0x3A")]
	[Token(Token = "0x600162D")]
	public override decimal ToDecimal(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926C10", Offset = "0x2926010", Length = "0xC8")]
	[Token(Token = "0x600162E")]
	public override double ToDouble(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926AC0", Offset = "0x2925EC0", Length = "0x8")]
	[Token(Token = "0x600162F")]
	public override short ToInt16(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926AC0", Offset = "0x2925EC0", Length = "0x8")]
	[Token(Token = "0x6001630")]
	public override int ToInt32(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926D10", Offset = "0x2926110", Length = "0x60")]
	[Token(Token = "0x6001631")]
	public override long ToInt64(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926DA0", Offset = "0x29261A0", Length = "0x24")]
	[Token(Token = "0x6001639")]
	public object ToObject() { }

	[Address(RVA = "0x2926AC0", Offset = "0x2925EC0", Length = "0x8")]
	[Token(Token = "0x6001632")]
	public override sbyte ToSByte(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926F70", Offset = "0x2926370", Length = "0x15")]
	[Token(Token = "0x6001633")]
	public override float ToSingle(IFormatProvider provider = null) { }

	[Address(RVA = "0x2926F90", Offset = "0x2926390", Length = "0x3F8")]
	[Token(Token = "0x6001626")]
	public virtual string ToString() { }

	[Address(RVA = "0x29273C0", Offset = "0x29267C0", Length = "0x7")]
	[Token(Token = "0x6001634")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x29273D0", Offset = "0x29267D0", Length = "0x3E")]
	[Token(Token = "0x6001635")]
	public override object ToType(Type conversionType, IFormatProvider provider) { }

	[Address(RVA = "0x2927410", Offset = "0x2926810", Length = "0xA")]
	[Token(Token = "0x6001636")]
	public override ushort ToUInt16(IFormatProvider provider = null) { }

	[Address(RVA = "0x2927410", Offset = "0x2926810", Length = "0xA")]
	[Token(Token = "0x6001637")]
	public override uint ToUInt32(IFormatProvider provider = null) { }

	[Address(RVA = "0x2927420", Offset = "0x2926820", Length = "0xDC")]
	[Token(Token = "0x6001638")]
	public override ulong ToUInt64(IFormatProvider provider = null) { }

}

