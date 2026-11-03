namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D0")]
public class BGMEntryBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000D1")]
	private struct <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EE")]
		public BGMEntryBehaviour <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005EF")]
		public SoundManager sm; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E3")]
	private BGM _bgmKind; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40005E4")]
	private PlayStage _stageKind; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E5")]
	private PlaySection _sectionKind; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40005E6")]
	private bool _isPlayStart; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x40005E7")]
	private bool _isLoop; //Field offset: 0x1D
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005E8")]
	private AudioClip _loopClip; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005E9")]
	private Record _record; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005EA")]
	private TimelineClip _timelineClip; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005EB")]
	private int _channel; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40005EC")]
	private float _volume; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005ED")]
	private float _cacheDbVolume; //Field offset: 0x40

	[Token(Token = "0x17000152")]
	private float FVolume
	{
		[Address(RVA = "0x1D314D0", Offset = "0x1D308D0", Length = "0xB")]
		[Token(Token = "0x600072A")]
		private get { } //Length: 11
	}

	[Address(RVA = "0x1D314B0", Offset = "0x1D308B0", Length = "0x1C")]
	[Token(Token = "0x600072B")]
	public BGMEntryBehaviour() { }

	[Address(RVA = "0x1D313B0", Offset = "0x1D307B0", Length = "0xB0")]
	[CompilerGenerated]
	[Token(Token = "0x600072C")]
	private bool <StopBGM>g__IsPlayingBGM|8_0(ref <>c__DisplayClass8_0 unnamed_param_0) { }

	[Address(RVA = "0x1D314D0", Offset = "0x1D308D0", Length = "0xB")]
	[Token(Token = "0x600072A")]
	private float get_FVolume() { }

	[Address(RVA = "0x1D30C90", Offset = "0x1D30090", Length = "0x7")]
	[Token(Token = "0x6000724")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D30CA0", Offset = "0x1D300A0", Length = "0x1CB")]
	[Token(Token = "0x6000723")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D30E70", Offset = "0x1D30270", Length = "0x54")]
	[Token(Token = "0x6000721")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x1D30ED0", Offset = "0x1D302D0", Length = "0x67")]
	[Token(Token = "0x6000722")]
	public virtual void OnGraphStop(Playable playable) { }

	[Address(RVA = "0x1D30F40", Offset = "0x1D30340", Length = "0xAD")]
	[Token(Token = "0x6000725")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[Address(RVA = "0x1D30FF0", Offset = "0x1D303F0", Length = "0x22D")]
	[Token(Token = "0x6000728")]
	private void ProgressBGM(float tvolume) { }

	[Address(RVA = "0x1D31220", Offset = "0x1D30620", Length = "0x17")]
	[Token(Token = "0x6000726")]
	public void SetSection(PlayStage tstage, PlaySection tsection, TimelineClip tclip) { }

	[Address(RVA = "0x1D31240", Offset = "0x1D30640", Length = "0x16E")]
	[Token(Token = "0x6000729")]
	private void StopBGM() { }

	[Address(RVA = "0x1D31470", Offset = "0x1D30870", Length = "0x39")]
	[Token(Token = "0x6000727")]
	private void UpdateClipVolumeDB() { }

}

