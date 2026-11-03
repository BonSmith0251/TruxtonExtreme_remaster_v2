namespace TXEKernel;

[Token(Token = "0x2000037")]
public static class HelperButtonGuide
{
	[CompilerGenerated]
	[Token(Token = "0x200003A")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013F")]
		public SpriteKind bt0; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000140")]
		public ButtonLabel bl0; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000141")]
		public SpriteKind bt1; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000142")]
		public ButtonLabel bl1; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000143")]
		public SpriteKind bt2; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000144")]
		public ButtonLabel bl2; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000145")]
		public SpriteKind bt3; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000146")]
		public ButtonLabel bl3; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000147")]
		public SpriteKind bt4; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000148")]
		public ButtonLabel bl4; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000149")]
		public SpriteKind bt5; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400014A")]
		public ButtonLabel bl5; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400014B")]
		public SpriteKind bt6; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400014C")]
		public ButtonLabel bl6; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400014D")]
		public SpriteKind bt7; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x400014E")]
		public ButtonLabel bl7; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400014F")]
		public SpriteKind bt8; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000150")]
		public ButtonLabel bl8; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000151")]
		public SpriteKind bt9; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000152")]
		public ButtonLabel bl9; //Field offset: 0x5C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001A9")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x26E9D20", Offset = "0x26E9120", Length = "0x343")]
		[Token(Token = "0x60001AA")]
		internal void <SetGuide>g__SetGuideFunction|0() { }

	}

	[Token(Token = "0x2000039")]
	internal enum ButtonLabel : int
	{
		none = 0,
		ok = 1,
		cancel = 2,
		back = 3,
		close = 4,
		move = 5,
		change = 6,
		select = 7,
		select1P = 8,
		select2P = 9,
		end = 10,
		skip = 11,
		next = 12,
		pm10 = 13,
		pm100 = 14,
		changeRanking = 15,
		moveMyRank = 16,
		claerArenaLocalRank = 17,
		dispMyAccount = 18,
		zoomOut = 19,
		zoomIn = 20,
		roll = 21,
		reset = 22,
		color = 23,
		p1 = 24,
		p2 = 25,
		comic = 26,
		autoplay = 27,
		autoend = 28,
		scroll = 29,
		nextLevel = 30,
		previousLevel = 31,
		fire = 32,
		bomb = 33,
		speed = 34,
		boost = 35,
		slow = 36,
		pageMove = 37,
		pageNext = 38,
		pageBack = 39,
	}

	[Token(Token = "0x2000038")]
	internal enum SpriteKind : int
	{
		All = 0,
		LR = 1,
		UD = 2,
		none = 3,
		OK = 4,
		NG = 5,
		TRIANGLE = 6,
		SQUARE = 7,
		L1 = 8,
		R1 = 9,
		L2 = 10,
		R2 = 11,
		L3 = 12,
		R3 = 13,
		STICK_L = 14,
		STICK_R = 15,
		CIRCLE = 16,
		CROSS = 17,
		L = 18,
		R = 19,
		OPT = 20,
		ANY = 21,
	}

	[Token(Token = "0x40000FE")]
	private static Action _lastSetGuideFunction; //Field offset: 0x0

	[Address(RVA = "0x26D9910", Offset = "0x26D8D10", Length = "0x6D")]
	[Token(Token = "0x60001A7")]
	private static string _getGuideStrKey(ButtonLabel bl) { }

	[Address(RVA = "0x26D9980", Offset = "0x26D8D80", Length = "0x344")]
	[Token(Token = "0x60001A6")]
	private static string _getSpriteKey(SpriteKind bt) { }

	[Address(RVA = "0x26D8F70", Offset = "0x26D8370", Length = "0x60")]
	[CompilerGenerated]
	[Token(Token = "0x60001A8")]
	internal static Buttons <_getSpriteKey>g__AsButton|61_0(SpriteKind btn) { }

	[Address(RVA = "0x26D5C10", Offset = "0x26D5010", Length = "0x8D")]
	[Token(Token = "0x6000180")]
	public static void ANY(ButtonLabel buttonLabel) { }

	[Address(RVA = "0x26D5CA0", Offset = "0x26D50A0", Length = "0x127")]
	[Token(Token = "0x6000181")]
	public static void BACK() { }

	[Address(RVA = "0x26D63F0", Offset = "0x26D57F0", Length = "0xDE")]
	[Token(Token = "0x6000171")]
	public static void Clear() { }

	[Address(RVA = "0x26D5DD0", Offset = "0x26D51D0", Length = "0x133")]
	[Token(Token = "0x6000185")]
	public static void CUSTOMBUTTONS1() { }

	[Address(RVA = "0x26D5F10", Offset = "0x26D5310", Length = "0x133")]
	[Token(Token = "0x6000186")]
	public static void CUSTOMBUTTONS2() { }

	[Address(RVA = "0x26D6050", Offset = "0x26D5450", Length = "0x133")]
	[Token(Token = "0x6000187")]
	public static void CUSTOMBUTTONS3() { }

	[Address(RVA = "0x26D6190", Offset = "0x26D5590", Length = "0x12D")]
	[Token(Token = "0x6000188")]
	public static void CUSTOMBUTTONS4() { }

	[Address(RVA = "0x26D5DD0", Offset = "0x26D51D0", Length = "0x133")]
	[Token(Token = "0x6000189")]
	public static void CUSTOMKEY1() { }

	[Address(RVA = "0x26D62C0", Offset = "0x26D56C0", Length = "0x127")]
	[Token(Token = "0x600018A")]
	public static void CUSTOMKEY2() { }

	[Address(RVA = "0x26D5F10", Offset = "0x26D5310", Length = "0x133")]
	[Token(Token = "0x600018B")]
	public static void CUSTOMKEY3() { }

	[Address(RVA = "0x26D64D0", Offset = "0x26D58D0", Length = "0x10C")]
	[Token(Token = "0x60001A5")]
	public static string GetGuideStr(ButtonLabel bl) { }

	[Address(RVA = "0x26D6980", Offset = "0x26D5D80", Length = "0xA3")]
	[Token(Token = "0x60001A4")]
	public static Sprite GetSprite(SpriteKind bt) { }

	[Address(RVA = "0x26D65E0", Offset = "0x26D59E0", Length = "0x396")]
	[Token(Token = "0x60001A3")]
	public static List<SpriteKind> GetSpriteKind(Buttons tbtns) { }

	[Address(RVA = "0x26D6A30", Offset = "0x26D5E30", Length = "0x12D")]
	[Token(Token = "0x600018C")]
	public static void HOWTO() { }

	[Address(RVA = "0x26D6B60", Offset = "0x26D5F60", Length = "0xB7")]
	[Token(Token = "0x600016F")]
	public static bool IsDisplayGuide(bool isAlphaType) { }

	[Address(RVA = "0x26D6FE0", Offset = "0x26D63E0", Length = "0x12D")]
	[Token(Token = "0x6000177")]
	public static void LR_OK() { }

	[Address(RVA = "0x26D6C20", Offset = "0x26D6020", Length = "0x133")]
	[Token(Token = "0x6000178")]
	public static void LR_OKBACK() { }

	[Address(RVA = "0x26D6EA0", Offset = "0x26D62A0", Length = "0x133")]
	[Token(Token = "0x6000179")]
	public static void LR_OKCANCEL() { }

	[Address(RVA = "0x26D6D60", Offset = "0x26D6160", Length = "0x133")]
	[Token(Token = "0x600017A")]
	public static void LR_OKCANCELOPT() { }

	[Address(RVA = "0x26D7110", Offset = "0x26D6510", Length = "0x13F")]
	[Token(Token = "0x6000199")]
	public static void MODEL1() { }

	[Address(RVA = "0x26D7250", Offset = "0x26D6650", Length = "0x145")]
	[Token(Token = "0x600019A")]
	public static void MODEL2() { }

	[Address(RVA = "0x26D73A0", Offset = "0x26D67A0", Length = "0x8D")]
	[Token(Token = "0x600017F")]
	public static void NG(ButtonLabel buttonLabel) { }

	[Address(RVA = "0x26D7430", Offset = "0x26D6830", Length = "0x8D")]
	[Token(Token = "0x600017E")]
	public static void OK(ButtonLabel buttonLabel) { }

	[Address(RVA = "0x26D74C0", Offset = "0x26D68C0", Length = "0x133")]
	[Token(Token = "0x6000183")]
	public static void PAUSEMENU() { }

	[Address(RVA = "0x26D7AC0", Offset = "0x26D6EC0", Length = "0x133")]
	[Token(Token = "0x600019D")]
	public static void PIPIRU_VILLAGE() { }

	[Address(RVA = "0x26D7600", Offset = "0x26D6A00", Length = "0x12B")]
	[Token(Token = "0x60001A0")]
	public static void PIPIRU_VILLAGE_INIT() { }

	[Address(RVA = "0x26D7730", Offset = "0x26D6B30", Length = "0x12D")]
	[Token(Token = "0x600019E")]
	public static void PIPIRU_VILLAGE_MAX() { }

	[Address(RVA = "0x26D7860", Offset = "0x26D6C60", Length = "0x12D")]
	[Token(Token = "0x600019F")]
	public static void PIPIRU_VILLAGE_MIN() { }

	[Address(RVA = "0x26D7990", Offset = "0x26D6D90", Length = "0x127")]
	[Token(Token = "0x60001A1")]
	public static void PIPIRU_VILLAGE_WAIT() { }

	[Address(RVA = "0x26D7C00", Offset = "0x26D7000", Length = "0x139")]
	[Token(Token = "0x600018D")]
	public static void RANKING1() { }

	[Address(RVA = "0x26D7D40", Offset = "0x26D7140", Length = "0x133")]
	[Token(Token = "0x600018E")]
	public static void RANKING1n() { }

	[Address(RVA = "0x26D7E80", Offset = "0x26D7280", Length = "0x133")]
	[Token(Token = "0x600018F")]
	public static void RANKING2() { }

	[Address(RVA = "0x26D7FC0", Offset = "0x26D73C0", Length = "0x12D")]
	[Token(Token = "0x6000190")]
	public static void RANKING2n() { }

	[Address(RVA = "0x26D80F0", Offset = "0x26D74F0", Length = "0x133")]
	[Token(Token = "0x6000191")]
	public static void RANKING3() { }

	[Address(RVA = "0x26D8230", Offset = "0x26D7630", Length = "0x12D")]
	[Token(Token = "0x6000192")]
	public static void RANKING3n() { }

	[Address(RVA = "0x26D8360", Offset = "0x26D7760", Length = "0x12D")]
	[Token(Token = "0x6000193")]
	public static void RANKING4() { }

	[Address(RVA = "0x26D8490", Offset = "0x26D7890", Length = "0x127")]
	[Token(Token = "0x6000194")]
	public static void RANKING4n() { }

	[Address(RVA = "0x26D85C0", Offset = "0x26D79C0", Length = "0x12D")]
	[Token(Token = "0x6000196")]
	public static void SERVICEREDORD1() { }

	[Address(RVA = "0x26D5CA0", Offset = "0x26D50A0", Length = "0x127")]
	[Token(Token = "0x6000195")]
	public static void SERVICEREDORD1n() { }

	[Address(RVA = "0x26D86F0", Offset = "0x26D7AF0", Length = "0x133")]
	[Token(Token = "0x6000198")]
	public static void SERVICEREDORD2() { }

	[Address(RVA = "0x26D8230", Offset = "0x26D7630", Length = "0x12D")]
	[Token(Token = "0x6000197")]
	public static void SERVICEREDORD2n() { }

	[Address(RVA = "0x26D8970", Offset = "0x26D7D70", Length = "0x196")]
	[Token(Token = "0x600016C")]
	public static void SetGuide(SpriteKind bt0, ButtonLabel bl0, SpriteKind bt1 = 3, ButtonLabel bl1 = 0, SpriteKind bt2 = 3, ButtonLabel bl2 = 0, SpriteKind bt3 = 3, ButtonLabel bl3 = 0, SpriteKind bt4 = 3, ButtonLabel bl4 = 0, SpriteKind bt5 = 3, ButtonLabel bl5 = 0, SpriteKind bt6 = 3, ButtonLabel bl6 = 0, SpriteKind bt7 = 3, ButtonLabel bl7 = 0, SpriteKind bt8 = 3, ButtonLabel bl8 = 0, SpriteKind bt9 = 3, ButtonLabel bl9 = 0) { }

	[Address(RVA = "0x26D8B10", Offset = "0x26D7F10", Length = "0xA3")]
	[Token(Token = "0x6000172")]
	public static void SetWidthMode(bool isHMode) { }

	[Address(RVA = "0x26D8BC0", Offset = "0x26D7FC0", Length = "0x98")]
	[Token(Token = "0x6000170")]
	public static void StackClear() { }

	[Address(RVA = "0x26D8C60", Offset = "0x26D8060", Length = "0x8B")]
	[Token(Token = "0x600016E")]
	public static void StackGuide(bool isPush) { }

	[Address(RVA = "0x26D8830", Offset = "0x26D7C30", Length = "0x137")]
	[Token(Token = "0x6000184")]
	public static void STORYMODE() { }

	[Address(RVA = "0x26D8CF0", Offset = "0x26D80F0", Length = "0x133")]
	[Token(Token = "0x600019B")]
	public static void TEAM1() { }

	[Address(RVA = "0x26D8E30", Offset = "0x26D8230", Length = "0x133")]
	[Token(Token = "0x600019C")]
	public static void TEAM2() { }

	[Address(RVA = "0x26D8230", Offset = "0x26D7630", Length = "0x12D")]
	[Token(Token = "0x6000182")]
	public static void UD_BACK() { }

	[Address(RVA = "0x26D93E0", Offset = "0x26D87E0", Length = "0x90")]
	[Token(Token = "0x600017B")]
	public static void UD_LR(ButtonLabel lrlabel) { }

	[Address(RVA = "0x26D9340", Offset = "0x26D8740", Length = "0x98")]
	[Token(Token = "0x600017D")]
	public static void UD_LR_OKBACK(ButtonLabel lrlabel) { }

	[Address(RVA = "0x26D92A0", Offset = "0x26D86A0", Length = "0x94")]
	[Token(Token = "0x600017C")]
	public static void UD_LRBACK(ButtonLabel lrlabel) { }

	[Address(RVA = "0x26D95B0", Offset = "0x26D89B0", Length = "0x12D")]
	[Token(Token = "0x6000175")]
	public static void UD_OK() { }

	[Address(RVA = "0x26D9470", Offset = "0x26D8870", Length = "0x133")]
	[Token(Token = "0x6000176")]
	public static void UD_OKBACK() { }

	[Address(RVA = "0x26D9170", Offset = "0x26D8570", Length = "0x12B")]
	[Token(Token = "0x6000173")]
	public static void UDLR_OK() { }

	[Address(RVA = "0x26D9030", Offset = "0x26D8430", Length = "0x131")]
	[Token(Token = "0x6000174")]
	public static void UDLR_OKBACK() { }

	[Address(RVA = "0x26D96E0", Offset = "0x26D8AE0", Length = "0xE3")]
	[Token(Token = "0x600016D")]
	public static void UpdateGuideOnInputChanged() { }

	[Address(RVA = "0x26D97D0", Offset = "0x26D8BD0", Length = "0x13D")]
	[Token(Token = "0x60001A2")]
	public static void WaitAComicPage(bool isAutoplay = false, bool isEnd = false) { }

}

