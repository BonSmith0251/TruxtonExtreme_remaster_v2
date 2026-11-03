namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000561")]
public abstract class Calendar : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001645")]
	internal int m_currentEraValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4001646")]
	private bool m_isReadOnly; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001647")]
	internal int twoDigitYearMax; //Field offset: 0x18

	[Token(Token = "0x17000582")]
	internal override int BaseCalendarID
	{
		[Address(RVA = "0x1F71DF0", Offset = "0x1F711F0", Length = "0x14")]
		[Token(Token = "0x6002700")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x17000583")]
	internal override int CurrentEraValue
	{
		[Address(RVA = "0x1F71E10", Offset = "0x1F71210", Length = "0x208")]
		[Token(Token = "0x6002704")]
		internal get { } //Length: 520
	}

	[Token(Token = "0x17000584")]
	public abstract Int32[] Eras
	{
		[Token(Token = "0x600270A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000581")]
	internal override int ID
	{
		[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
		[Token(Token = "0x60026FF")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x17000580")]
	public override DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x1F72070", Offset = "0x1F71470", Length = "0x4F")]
		[Token(Token = "0x60026FD")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x1700057F")]
	public override DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x1F720C0", Offset = "0x1F714C0", Length = "0x4F")]
		[Token(Token = "0x60026FC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000585")]
	public override int TwoDigitYearMax
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002716")]
		 get { } //Length: 4
		[Address(RVA = "0x1F72110", Offset = "0x1F71510", Length = "0x24")]
		[Token(Token = "0x6002717")]
		 set { } //Length: 36
	}

	[Address(RVA = "0x1F71DD0", Offset = "0x1F711D0", Length = "0x15")]
	[Token(Token = "0x60026FE")]
	protected Calendar() { }

	[Address(RVA = "0x1F71690", Offset = "0x1F70A90", Length = "0x7B")]
	[ComVisible(False)]
	[Token(Token = "0x6002701")]
	public override object Clone() { }

	[Address(RVA = "0x1F71DF0", Offset = "0x1F711F0", Length = "0x14")]
	[Token(Token = "0x6002700")]
	internal override int get_BaseCalendarID() { }

	[Address(RVA = "0x1F71E10", Offset = "0x1F71210", Length = "0x208")]
	[Token(Token = "0x6002704")]
	internal override int get_CurrentEraValue() { }

	[Token(Token = "0x600270A")]
	public abstract Int32[] get_Eras() { }

	[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
	[Token(Token = "0x60026FF")]
	internal override int get_ID() { }

	[Address(RVA = "0x1F72070", Offset = "0x1F71470", Length = "0x4F")]
	[Token(Token = "0x60026FD")]
	public override DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x1F720C0", Offset = "0x1F714C0", Length = "0x4F")]
	[Token(Token = "0x60026FC")]
	public override DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002716")]
	public override int get_TwoDigitYearMax() { }

	[Token(Token = "0x6002705")]
	public abstract int GetDayOfMonth(DateTime time) { }

	[Token(Token = "0x6002706")]
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	[Token(Token = "0x6002707")]
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	[Token(Token = "0x6002708")]
	public abstract int GetDaysInYear(int year, int era) { }

	[Token(Token = "0x6002709")]
	public abstract int GetEra(DateTime time) { }

	[Token(Token = "0x600270B")]
	public abstract int GetMonth(DateTime time) { }

	[Token(Token = "0x600270C")]
	public abstract int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F71710", Offset = "0x1F70B10", Length = "0x41")]
	[Token(Token = "0x600271A")]
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }

	[Token(Token = "0x600270D")]
	public abstract int GetYear(DateTime time) { }

	[Address(RVA = "0x1F71760", Offset = "0x1F70B60", Length = "0x17")]
	[Token(Token = "0x600270E")]
	public override bool IsLeapYear(int year) { }

	[Token(Token = "0x600270F")]
	public abstract bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F71780", Offset = "0x1F70B80", Length = "0x8A")]
	[Token(Token = "0x6002715")]
	internal override bool IsValidDay(int year, int month, int day, int era) { }

	[Address(RVA = "0x1F71810", Offset = "0x1F70C10", Length = "0x77")]
	[Token(Token = "0x6002714")]
	internal override bool IsValidMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F71890", Offset = "0x1F70C90", Length = "0x8D")]
	[Token(Token = "0x6002713")]
	internal override bool IsValidYear(int year, int era) { }

	[Address(RVA = "0x1F72110", Offset = "0x1F71510", Length = "0x24")]
	[Token(Token = "0x6002717")]
	public override void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x6002703")]
	internal void SetReadOnlyState(bool readOnly) { }

	[Address(RVA = "0x1F71920", Offset = "0x1F70D20", Length = "0x1BE")]
	[Token(Token = "0x6002719")]
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	[Address(RVA = "0x1F71AE0", Offset = "0x1F70EE0", Length = "0x56")]
	[Token(Token = "0x6002710")]
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	[Token(Token = "0x6002711")]
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F71B40", Offset = "0x1F70F40", Length = "0x10E")]
	[Token(Token = "0x6002718")]
	public override int ToFourDigitYear(int year) { }

	[Address(RVA = "0x1F71C50", Offset = "0x1F71050", Length = "0xF7")]
	[Token(Token = "0x6002712")]
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	[Address(RVA = "0x1F71D50", Offset = "0x1F71150", Length = "0x78")]
	[Token(Token = "0x6002702")]
	internal void VerifyWritable() { }

}

