namespace InGame.Kernel.UI;

[Token(Token = "0x20000BC")]
public class PlayerSettingPopupContent : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x20000C0")]
	private sealed class <>c
	{
		[Token(Token = "0x40005BC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40005BD")]
		public static Func<Int32, Boolean> <>9__21_0; //Field offset: 0x8

		[Address(RVA = "0x1D477D0", Offset = "0x1D46BD0", Length = "0x67")]
		[Token(Token = "0x60006E9")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006EA")]
		public <>c() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60006EB")]
		internal bool <_moreInformation>b__21_0(int id) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C1")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005BE")]
		public int i; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005BF")]
		public PlayerSettingPopupContent <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006EC")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x1D477A0", Offset = "0x1D46BA0", Length = "0x24")]
		[Token(Token = "0x60006ED")]
		internal void <Initialize>b__0() { }

	}

	[Token(Token = "0x20000BF")]
	private class aSettingMenu
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005BA")]
		public ButtonBase _button; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005BB")]
		public UISlideSelecter _selecter; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006E8")]
		public aSettingMenu() { }

	}

	[Token(Token = "0x20000BD")]
	private enum menuLabels : int
	{
		ArmLv = 0,
		ArmKind = 1,
		Players = 2,
		Bomb = 3,
		Speed = 4,
		DamageMag = 5,
		ScoreMag = 6,
		FullBoost = 7,
		NoHit = 8,
		More = 9,
		Area = 10,
		Exit = 11,
	}

	[Token(Token = "0x20000BE")]
	internal enum moreLabels : int
	{
		PlayLog = 0,
		Enemys = 1,
		DestroyRate = 2,
		Player = 3,
	}

	[Token(Token = "0x400059E")]
	private static readonly int moreLabelCount; //Field offset: 0x0
	[Token(Token = "0x40005A6")]
	private static readonly Single[] _damageMags; //Field offset: 0x8
	[Token(Token = "0x40005A7")]
	private static readonly Int32[] _scoreMags; //Field offset: 0x10
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400059F")]
	private int _indexNo; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40005A0")]
	private int _startAreaIndex; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005A1")]
	private int _resultAreaIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005A2")]
	private PlayerInformation _playerInformation; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005A3")]
	private String[] _logsString; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40005A4")]
	private aSettingMenu[] _menus; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40005A5")]
	private UITextMeshPro _underText; //Field offset: 0x88

	[Token(Token = "0x17000143")]
	public int ResultAreaIndex
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x60006E4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000144")]
	public UITextMeshPro UnderText
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60006E5")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1D3CF40", Offset = "0x1D3C340", Length = "0x3E")]
	[Token(Token = "0x60006E1")]
	private void _indexAdd() { }

	[Address(RVA = "0x1D3CF80", Offset = "0x1D3C380", Length = "0x38")]
	[Token(Token = "0x60006E0")]
	private void _indexSub() { }

	[Address(RVA = "0x1D3CFC0", Offset = "0x1D3C3C0", Length = "0x2AA")]
	[Token(Token = "0x60006E3")]
	private void _moreInformation() { }

	[Address(RVA = "0x1D3D270", Offset = "0x1D3C670", Length = "0x9F")]
	[Token(Token = "0x60006E2")]
	private void _pushButton(int tindex) { }

	[Address(RVA = "0x1D3D310", Offset = "0x1D3C710", Length = "0x143")]
	[Token(Token = "0x60006DE")]
	private void _setArmKindLabel(int tval) { }

	[Address(RVA = "0x1D3D460", Offset = "0x1D3C860", Length = "0x14E")]
	[Token(Token = "0x60006DC")]
	private void _setDamageMagLabel() { }

	[Address(RVA = "0x1D3D5B0", Offset = "0x1D3C9B0", Length = "0x32F")]
	[Token(Token = "0x60006DB")]
	private void _setMoreLabel() { }

	[Address(RVA = "0x1D3D8E0", Offset = "0x1D3CCE0", Length = "0x14A")]
	[Token(Token = "0x60006DD")]
	private void _setScoreMagLabel() { }

	[Address(RVA = "0x1D3CD40", Offset = "0x1D3C140", Length = "0x167")]
	[Token(Token = "0x60006E7")]
	private static PlayerSettingPopupContent() { }

	[Address(RVA = "0x1D3CEB0", Offset = "0x1D3C2B0", Length = "0x8B")]
	[Token(Token = "0x60006E6")]
	public PlayerSettingPopupContent() { }

	[Address(RVA = "0x1D3B890", Offset = "0x1D3AC90", Length = "0x3B")]
	[Token(Token = "0x60006D8")]
	public ArmsKind ArmKind() { }

	[Address(RVA = "0x1D3B8D0", Offset = "0x1D3ACD0", Length = "0x235")]
	[Token(Token = "0x60006D1")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x60006E4")]
	public int get_ResultAreaIndex() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60006E5")]
	public UITextMeshPro get_UnderText() { }

	[Address(RVA = "0x1D3BB10", Offset = "0x1D3AF10", Length = "0x4BD")]
	[Token(Token = "0x60006CE")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D3BFD0", Offset = "0x1D3B3D0", Length = "0x8")]
	[Token(Token = "0x60006D5")]
	public bool IsChangeArea() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60006D9")]
	public virtual bool IsFooter() { }

	[Address(RVA = "0x1D3BFE0", Offset = "0x1D3B3E0", Length = "0x3F")]
	[Token(Token = "0x60006D6")]
	public bool IsFullBoost() { }

	[Address(RVA = "0x1D3C020", Offset = "0x1D3B420", Length = "0x3F")]
	[Token(Token = "0x60006D7")]
	public bool IsNoDamageMode() { }

	[Address(RVA = "0x1D3C060", Offset = "0x1D3B460", Length = "0xA")]
	[Token(Token = "0x60006DA")]
	public virtual bool OnClickBackKey() { }

	[Address(RVA = "0x1D3C070", Offset = "0x1D3B470", Length = "0x3A")]
	[Token(Token = "0x60006D4")]
	public void SetLogString(string logs, int tno) { }

	[Address(RVA = "0x1D3C0B0", Offset = "0x1D3B4B0", Length = "0x1B2")]
	[Token(Token = "0x60006DF")]
	private void SetSelectNo(int n, ButtonState onState) { }

	[Address(RVA = "0x1D3C270", Offset = "0x1D3B670", Length = "0x1DB")]
	[Token(Token = "0x60006D3")]
	public void SetupArea(List<String> areas, int currentArea) { }

	[Address(RVA = "0x1D3C450", Offset = "0x1D3B850", Length = "0xF0")]
	[Token(Token = "0x60006D2")]
	public void SetupPlayer(PlayerInformation pinfo, bool isNohit, bool isFullBoost) { }

	[Address(RVA = "0x1D3CA80", Offset = "0x1D3BE80", Length = "0xA9")]
	[Token(Token = "0x60006CF")]
	public virtual void StartActive() { }

	[Address(RVA = "0x1D3CB30", Offset = "0x1D3BF30", Length = "0x1F0")]
	[Token(Token = "0x60006D0")]
	public void UpdateToPlayer() { }

}

