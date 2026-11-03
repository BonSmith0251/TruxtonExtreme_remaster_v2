namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000151")]
public class XblAchievementsManagerEvent
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400023C")]
	private readonly XblAchievementProgressChangeEntry <progressInfo>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400023D")]
	private readonly ulong <xboxUserId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023E")]
	private readonly XblAchievementsManagerEventType <eventType>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700009F")]
	public XblAchievementsManagerEventType eventType
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600079F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700009D")]
	public XblAchievementProgressChangeEntry progressInfo
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600079D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009E")]
	public ulong xboxUserId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600079E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B7E690", Offset = "0x2B7DA90", Length = "0xC3")]
	[Token(Token = "0x600079C")]
	internal XblAchievementsManagerEvent(XblAchievementsManagerEvent interopStruct) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600079F")]
	public XblAchievementsManagerEventType get_eventType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600079D")]
	public XblAchievementProgressChangeEntry get_progressInfo() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600079E")]
	public ulong get_xboxUserId() { }

}

