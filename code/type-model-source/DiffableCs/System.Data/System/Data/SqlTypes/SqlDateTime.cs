namespace System.Data.SqlTypes;

[Token(Token = "0x20000AE")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x400036C")]
	private static readonly double s_SQLTicksPerMillisecond; //Field offset: 0x0
	[Token(Token = "0x400036D")]
	public static readonly int SQLTicksPerSecond; //Field offset: 0x8
	[Token(Token = "0x400036E")]
	public static readonly int SQLTicksPerMinute; //Field offset: 0xC
	[Token(Token = "0x400036F")]
	public static readonly int SQLTicksPerHour; //Field offset: 0x10
	[Token(Token = "0x4000370")]
	private static readonly int s_SQLTicksPerDay; //Field offset: 0x14
	[Token(Token = "0x4000371")]
	private static readonly long s_ticksPerSecond; //Field offset: 0x18
	[Token(Token = "0x4000372")]
	private static readonly DateTime s_SQLBaseDate; //Field offset: 0x20
	[Token(Token = "0x4000373")]
	private static readonly long s_SQLBaseDateTicks; //Field offset: 0x28
	[Token(Token = "0x4000374")]
	private static readonly int s_minYear; //Field offset: 0x30
	[Token(Token = "0x4000375")]
	private static readonly int s_maxYear; //Field offset: 0x34
	[Token(Token = "0x4000376")]
	private static readonly int s_minDay; //Field offset: 0x38
	[Token(Token = "0x4000377")]
	private static readonly int s_maxDay; //Field offset: 0x3C
	[Token(Token = "0x4000378")]
	private static readonly int s_minTime; //Field offset: 0x40
	[Token(Token = "0x4000379")]
	private static readonly int s_maxTime; //Field offset: 0x44
	[Token(Token = "0x400037A")]
	private static readonly int s_dayBase; //Field offset: 0x48
	[Token(Token = "0x400037B")]
	private static readonly Int32[] s_daysToMonth365; //Field offset: 0x50
	[Token(Token = "0x400037C")]
	private static readonly Int32[] s_daysToMonth366; //Field offset: 0x58
	[Token(Token = "0x400037D")]
	private static readonly DateTime s_minDateTime; //Field offset: 0x60
	[Token(Token = "0x400037E")]
	private static readonly DateTime s_maxDateTime; //Field offset: 0x68
	[Token(Token = "0x400037F")]
	private static readonly TimeSpan s_minTimeSpan; //Field offset: 0x70
	[Token(Token = "0x4000380")]
	private static readonly TimeSpan s_maxTimeSpan; //Field offset: 0x78
	[Token(Token = "0x4000381")]
	private static readonly string s_ISO8601_DateTimeFormat; //Field offset: 0x80
	[Token(Token = "0x4000382")]
	private static readonly String[] s_dateTimeFormats; //Field offset: 0x88
	[Token(Token = "0x4000383")]
	public static readonly SqlDateTime MinValue; //Field offset: 0x90
	[Token(Token = "0x4000384")]
	public static readonly SqlDateTime MaxValue; //Field offset: 0x9C
	[Token(Token = "0x4000385")]
	public static readonly SqlDateTime Null; //Field offset: 0xA8
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000369")]
	private bool m_fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400036A")]
	private int m_day; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400036B")]
	private int m_time; //Field offset: 0x8

	[Token(Token = "0x17000166")]
	public int DayTicks
	{
		[Address(RVA = "0x238D8C0", Offset = "0x238CCC0", Length = "0x53")]
		[Token(Token = "0x6000912")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000164")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x600090C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000167")]
	public int TimeTicks
	{
		[Address(RVA = "0x238D920", Offset = "0x238CD20", Length = "0x53")]
		[Token(Token = "0x6000913")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000165")]
	public DateTime Value
	{
		[Address(RVA = "0x238D980", Offset = "0x238CD80", Length = "0xA6")]
		[Token(Token = "0x6000911")]
		 get { } //Length: 166
	}

	[Address(RVA = "0x238D0E0", Offset = "0x238C4E0", Length = "0x624")]
	[Token(Token = "0x6000923")]
	private static SqlDateTime() { }

	[Address(RVA = "0x238D790", Offset = "0x238CB90", Length = "0x120")]
	[Token(Token = "0x600090B")]
	public SqlDateTime(int dayTicks, int timeTicks) { }

	[Address(RVA = "0x238D780", Offset = "0x238CB80", Length = "0xA")]
	[Token(Token = "0x6000909")]
	private SqlDateTime(bool fNull) { }

	[Address(RVA = "0x238D710", Offset = "0x238CB10", Length = "0x6A")]
	[Token(Token = "0x600090A")]
	public SqlDateTime(DateTime value) { }

	[Address(RVA = "0x238BF70", Offset = "0x238B370", Length = "0x1CF")]
	[Token(Token = "0x600091C")]
	public int CompareTo(SqlDateTime value) { }

	[Address(RVA = "0x238BE40", Offset = "0x238B240", Length = "0x12B")]
	[Token(Token = "0x600091B")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x238C140", Offset = "0x238B540", Length = "0x23B")]
	[Token(Token = "0x600091D")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x238C380", Offset = "0x238B780", Length = "0x12C")]
	[Token(Token = "0x6000910")]
	private static SqlDateTime FromDateTime(DateTime value) { }

	[Address(RVA = "0x238C4B0", Offset = "0x238B8B0", Length = "0x204")]
	[Token(Token = "0x600090F")]
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	[Address(RVA = "0x238D8C0", Offset = "0x238CCC0", Length = "0x53")]
	[Token(Token = "0x6000912")]
	public int get_DayTicks() { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x600090C")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x238D920", Offset = "0x238CD20", Length = "0x53")]
	[Token(Token = "0x6000913")]
	public int get_TimeTicks() { }

	[Address(RVA = "0x238D980", Offset = "0x238CD80", Length = "0xA6")]
	[Token(Token = "0x6000911")]
	public DateTime get_Value() { }

	[Address(RVA = "0x238C6C0", Offset = "0x238BAC0", Length = "0xA7")]
	[Token(Token = "0x600091E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x238C770", Offset = "0x238BB70", Length = "0x6B")]
	[Token(Token = "0x6000922")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x238C7E0", Offset = "0x238BBE0", Length = "0x17C")]
	[Token(Token = "0x600091A")]
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	[Address(RVA = "0x238C960", Offset = "0x238BD60", Length = "0x17C")]
	[Token(Token = "0x6000919")]
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	[Address(RVA = "0x238DA30", Offset = "0x238CE30", Length = "0xD8")]
	[Token(Token = "0x6000916")]
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	[Address(RVA = "0x238DB10", Offset = "0x238CF10", Length = "0xE1")]
	[Token(Token = "0x6000918")]
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	[Address(RVA = "0x238DC00", Offset = "0x238D000", Length = "0x74")]
	[Token(Token = "0x6000914")]
	public static SqlDateTime op_Implicit(DateTime value) { }

	[Address(RVA = "0x238DC80", Offset = "0x238D080", Length = "0xE1")]
	[Token(Token = "0x6000917")]
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600091F")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x238CAE0", Offset = "0x238BEE0", Length = "0x236")]
	[Token(Token = "0x6000920")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x238CD20", Offset = "0x238C120", Length = "0x15A")]
	[Token(Token = "0x6000921")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x238CE80", Offset = "0x238C280", Length = "0x106")]
	[Token(Token = "0x600090E")]
	private static DateTime ToDateTime(SqlDateTime value) { }

	[Address(RVA = "0x238CF90", Offset = "0x238C390", Length = "0xCE")]
	[Token(Token = "0x6000915")]
	public virtual string ToString() { }

	[Address(RVA = "0x238D060", Offset = "0x238C460", Length = "0x80")]
	[Token(Token = "0x600090D")]
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

}

