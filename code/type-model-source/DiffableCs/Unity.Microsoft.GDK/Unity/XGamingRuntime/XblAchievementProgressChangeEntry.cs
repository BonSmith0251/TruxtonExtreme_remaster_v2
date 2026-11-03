namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000143")]
public class XblAchievementProgressChangeEntry
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000213")]
	private readonly string <AchievementId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000214")]
	private readonly XblAchievementProgressState <ProgressState>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000215")]
	private readonly XblAchievementProgression <Progression>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000088")]
	public string AchievementId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000765")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008A")]
	public XblAchievementProgression Progression
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000767")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000089")]
	public XblAchievementProgressState ProgressState
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000766")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2B7D210", Offset = "0x2B7C610", Length = "0xD5")]
	[Token(Token = "0x6000764")]
	internal XblAchievementProgressChangeEntry(XblAchievementProgressChangeEntry interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000765")]
	public string get_AchievementId() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000767")]
	public XblAchievementProgression get_Progression() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000766")]
	public XblAchievementProgressState get_ProgressState() { }

}

