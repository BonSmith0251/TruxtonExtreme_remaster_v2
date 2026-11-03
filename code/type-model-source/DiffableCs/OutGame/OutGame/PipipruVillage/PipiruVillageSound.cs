namespace OutGame.PipipruVillage;

[Token(Token = "0x20000FB")]
public class PipiruVillageSound : SimpleSingleton<PipiruVillageSound>, IDisposable
{
	[Token(Token = "0x40003F4")]
	private static readonly List<BGM> _BgmList; //Field offset: 0x0
	[Token(Token = "0x40003F5")]
	private static readonly float _InitialBgmDelayTime; //Field offset: 0x8
	[Token(Token = "0x40003F6")]
	private static readonly float _StartBgmDelayTime; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003F7")]
	private int <SelectLevel>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003F8")]
	private BGM _requestBgm; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003F9")]
	private BGM _currentBgm; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40003FA")]
	private BGM _targetBgm; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003FB")]
	private int _playBgmChannel; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003FC")]
	private float _startBgmDelayTime; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003FD")]
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003FE")]
	private bool _isSwitchedStage; //Field offset: 0x30

	[Token(Token = "0x17000178")]
	public int PlayBgmChannel
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000640")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000177")]
	public int SelectLevel
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600063E")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600063F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x21F05D0", Offset = "0x21EF9D0", Length = "0x274")]
	[Token(Token = "0x6000642")]
	private static PipiruVillageSound() { }

	[Address(RVA = "0x21F0850", Offset = "0x21EFC50", Length = "0xBF")]
	[Token(Token = "0x6000641")]
	public PipiruVillageSound() { }

	[Address(RVA = "0x21F01A0", Offset = "0x21EF5A0", Length = "0xF6")]
	[CompilerGenerated]
	[Token(Token = "0x6000643")]
	private void <UpdateBgm>b__4_0() { }

	[Address(RVA = "0x21F00F0", Offset = "0x21EF4F0", Length = "0x36")]
	[Token(Token = "0x600063D")]
	public override void Dispose() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000640")]
	public int get_PlayBgmChannel() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600063E")]
	public int get_SelectLevel() { }

	[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
	[Token(Token = "0x600063A")]
	public void Initialize() { }

	[Address(RVA = "0x21F0130", Offset = "0x21EF530", Length = "0x67")]
	[Token(Token = "0x600063C")]
	public void PlaySE(ID seId, bool isForce = false) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600063F")]
	public void set_SelectLevel(int value) { }

	[Address(RVA = "0x21F02A0", Offset = "0x21EF6A0", Length = "0x325")]
	[Token(Token = "0x600063B")]
	public void UpdateBgm(int selectLevel) { }

}

