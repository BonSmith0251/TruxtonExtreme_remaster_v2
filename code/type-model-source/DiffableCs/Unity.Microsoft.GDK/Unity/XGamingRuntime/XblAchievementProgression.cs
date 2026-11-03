namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000146")]
public class XblAchievementProgression
{
	[CompilerGenerated]
	[Token(Token = "0x2000147")]
	private sealed class <>c
	{
		[Token(Token = "0x400021C")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400021D")]
		public static Func<XblAchievementRequirement, XblAchievementRequirement> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B7B850", Offset = "0x2B7AC50", Length = "0x67")]
		[Token(Token = "0x6000775")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000776")]
		public <>c() { }

		[Address(RVA = "0x2B710B0", Offset = "0x2B704B0", Length = "0xFC")]
		[Token(Token = "0x6000777")]
		internal XblAchievementRequirement <.ctor>b__0_0(XblAchievementRequirement r) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021A")]
	private XblAchievementRequirement[] <Requirements>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400021B")]
	private DateTime <TimeUnlocked>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700008D")]
	public private XblAchievementRequirement[] Requirements
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000771")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000772")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700008E")]
	public private DateTime TimeUnlocked
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000773")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000774")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B7D440", Offset = "0x2B7C840", Length = "0x18E")]
	[Token(Token = "0x6000770")]
	internal XblAchievementProgression(XblAchievementProgression interopProgression) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000771")]
	public XblAchievementRequirement[] get_Requirements() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000773")]
	public DateTime get_TimeUnlocked() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000772")]
	private void set_Requirements(XblAchievementRequirement[] value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000774")]
	private void set_TimeUnlocked(DateTime value) { }

}

