namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000FB")]
public class TLEntryBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DD")]
	private bool _isPlayStart; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40006DE")]
	private bool _isPlayCheck; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006DF")]
	private double _startTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006E0")]
	private double _durationTime; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006E1")]
	private double _localPassedTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006E2")]
	private TLEntryObject _timeline; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006E3")]
	private InGameAreaManager _areaManager; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006E4")]
	private TLEntryClip _clipData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006E5")]
	private TLClipFlag _clipFlag; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40006E6")]
	private TLGameModeFlag _gameModeFlag; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006E7")]
	private TLWeaponFlag _weaponFlag; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006E8")]
	private List<Int32> _areaIndexs; //Field offset: 0x58

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60007ED")]
	public TLEntryBehaviour() { }

	[Address(RVA = "0x1D51BB0", Offset = "0x1D50FB0", Length = "0x39E")]
	[Token(Token = "0x60007EC")]
	private bool IsCheckStartTL() { }

	[Address(RVA = "0x1D51F50", Offset = "0x1D51350", Length = "0x36C")]
	[Token(Token = "0x60007EA")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D522C0", Offset = "0x1D516C0", Length = "0x183")]
	[Token(Token = "0x60007E7")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D52450", Offset = "0x1D51850", Length = "0x107")]
	[Token(Token = "0x60007E3")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x1D52560", Offset = "0x1D51960", Length = "0x13")]
	[Token(Token = "0x60007E4")]
	public virtual void OnGraphStop(Playable playable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007E5")]
	public virtual void OnPlayableCreate(Playable playable) { }

	[Address(RVA = "0x1D52580", Offset = "0x1D51980", Length = "0x1B2")]
	[Token(Token = "0x60007E6")]
	public virtual void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x1D52740", Offset = "0x1D51B40", Length = "0xDB")]
	[Token(Token = "0x60007E8")]
	private void PlayStartProcess(double passedTime) { }

	[Address(RVA = "0x1D52820", Offset = "0x1D51C20", Length = "0xDB")]
	[Token(Token = "0x60007E9")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[Address(RVA = "0x1D52900", Offset = "0x1D51D00", Length = "0x77")]
	[Token(Token = "0x60007EB")]
	public void Set(TLEntryObject tl, TLEntryClip tclip) { }

}

