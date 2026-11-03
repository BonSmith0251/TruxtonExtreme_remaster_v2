namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200014E")]
public class XblAchievementTimeWindow
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000233")]
	private DateTime <StartDate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000234")]
	private DateTime <EndDate>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700009A")]
	public private DateTime EndDate
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000795")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000796")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000099")]
	public private DateTime StartDate
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000793")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000794")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B7D8D0", Offset = "0x2B7CCD0", Length = "0x90")]
	[Token(Token = "0x6000792")]
	internal XblAchievementTimeWindow(XblAchievementTimeWindow interopTimeWindow) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000795")]
	public DateTime get_EndDate() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000793")]
	public DateTime get_StartDate() { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000796")]
	private void set_EndDate(DateTime value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000794")]
	private void set_StartDate(DateTime value) { }

}

