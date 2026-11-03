namespace KANAI.Sound;

[Token(Token = "0x200000E")]
public class SoundSystem
{
	[Token(Token = "0x400004F")]
	private static readonly float MasterVolumeRate; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000050")]
	private AudioMixer _mixer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000051")]
	private Dictionary<SCType, AudioMixerGroup> _mixerGroups; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000052")]
	private Dictionary<SCType, Int32> _channelNums; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000053")]
	private SoundChannel[] _channelSources; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000054")]
	private int _sourceMax; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000055")]
	private int _frameCounter; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000056")]
	private float _bgmVolume; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000057")]
	private float _seVolume; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000058")]
	private bool _isMuteSE; //Field offset: 0x40

	[Token(Token = "0x1700000A")]
	private int FrameCounterWithDelay
	{
		[Address(RVA = "0x1E13A20", Offset = "0x1E12E20", Length = "0x7")]
		[Token(Token = "0x600007C")]
		private get { } //Length: 7
	}

	[Address(RVA = "0x1E13990", Offset = "0x1E12D90", Length = "0x2B")]
	[Token(Token = "0x600007A")]
	private SoundChannel _getSource(int channel) { }

	[Address(RVA = "0x1E139C0", Offset = "0x1E12DC0", Length = "0x53")]
	[Token(Token = "0x6000079")]
	private static ValueTuple<Int32, Int32> _getStartAndEnd(int tnums) { }

	[Address(RVA = "0x1E13880", Offset = "0x1E12C80", Length = "0x39")]
	[Token(Token = "0x600007E")]
	private static SoundSystem() { }

	[Address(RVA = "0x1E138C0", Offset = "0x1E12CC0", Length = "0xCB")]
	[Token(Token = "0x600007D")]
	public SoundSystem() { }

	[Address(RVA = "0x1E117B0", Offset = "0x1E10BB0", Length = "0x17")]
	[Token(Token = "0x6000069")]
	public void CounterUpdate() { }

	[Address(RVA = "0x1E13A20", Offset = "0x1E12E20", Length = "0x7")]
	[Token(Token = "0x600007C")]
	private int get_FrameCounterWithDelay() { }

	[Address(RVA = "0x1E117D0", Offset = "0x1E10BD0", Length = "0x1D9")]
	[Token(Token = "0x6000074")]
	public int GetEmptyChannelR(SCType ctype, bool isReverse = false) { }

	[Address(RVA = "0x1E119B0", Offset = "0x1E10DB0", Length = "0x171")]
	[Token(Token = "0x6000075")]
	public int GetPlayingChannel(SCType ctype, string tclipname) { }

	[Address(RVA = "0x1E11CA0", Offset = "0x1E110A0", Length = "0x143")]
	[Token(Token = "0x6000078")]
	public int GetPlayingCount(SCType ctype) { }

	[Address(RVA = "0x1E11B30", Offset = "0x1E10F30", Length = "0x165")]
	[Token(Token = "0x6000077")]
	public int GetPlayingCount(SCType ctype, string clipname) { }

	[Address(RVA = "0x1E11DF0", Offset = "0x1E111F0", Length = "0x169")]
	[Token(Token = "0x6000076")]
	public int GetPlayingForOverwrite(SCType ctype, string tclipname) { }

	[Address(RVA = "0x1E11F60", Offset = "0x1E11360", Length = "0x39")]
	[Token(Token = "0x600007B")]
	private float GetVolume(float v) { }

	[Address(RVA = "0x1E11FA0", Offset = "0x1E113A0", Length = "0x79C")]
	[Token(Token = "0x6000059")]
	public void Initialize(Transform _root, int sourceMax, int BGMChannels, int JingleChannels, int VoiceChannels, int SystemChannels) { }

	[Address(RVA = "0x1E12740", Offset = "0x1E11B40", Length = "0x56")]
	[Token(Token = "0x6000073")]
	public bool IsPlaying(int channel) { }

	[Address(RVA = "0x1E127A0", Offset = "0x1E11BA0", Length = "0x16")]
	[Token(Token = "0x600006F")]
	public void MuteSE(bool isMute) { }

	[Address(RVA = "0x1E12850", Offset = "0x1E11C50", Length = "0xFA")]
	[Token(Token = "0x6000067")]
	public void Pause(int channel, bool isPause) { }

	[Address(RVA = "0x1E127C0", Offset = "0x1E11BC0", Length = "0x89")]
	[Token(Token = "0x6000068")]
	public void PauseAll(bool isPause) { }

	[Address(RVA = "0x1E12950", Offset = "0x1E11D50", Length = "0xE2")]
	[Token(Token = "0x6000062")]
	public void PlayBGM(AudioClip clip, int channel, float vol, float startTime, bool withLoop) { }

	[Address(RVA = "0x1E12AF0", Offset = "0x1E11EF0", Length = "0x74")]
	[Token(Token = "0x6000060")]
	public int PlayLoop(AudioClip clip, float vol, float pan = 0, SCType stype = 2) { }

	[Address(RVA = "0x1E12A40", Offset = "0x1E11E40", Length = "0xA7")]
	[Token(Token = "0x6000061")]
	public void PlayLoopCh(int tch, AudioClip clip, float vol, float pan = 0) { }

	[Address(RVA = "0x1E12C20", Offset = "0x1E12020", Length = "0x74")]
	[Token(Token = "0x600005D")]
	public int PlayNormal(AudioClip clip, float vol, float pan = 0, SCType stype = 2) { }

	[Address(RVA = "0x1E12B70", Offset = "0x1E11F70", Length = "0xA7")]
	[Token(Token = "0x600005F")]
	public void PlayNormalCh(int tch, AudioClip clip, float vol, float pan = 0) { }

	[Address(RVA = "0x1E12DA0", Offset = "0x1E121A0", Length = "0x74")]
	[Token(Token = "0x600005C")]
	public int PlayOneShot(AudioClip clip, float vol, float pan = 0, SCType stype = 2) { }

	[Address(RVA = "0x1E12CA0", Offset = "0x1E120A0", Length = "0xF5")]
	[Token(Token = "0x600005E")]
	public void PlayOneShotCh(int tch, AudioClip clip, float vol, float pan = 0) { }

	[Address(RVA = "0x1E12E20", Offset = "0x1E12220", Length = "0x7F")]
	[Token(Token = "0x600006A")]
	public void Refresh() { }

	[Address(RVA = "0x1E12EA0", Offset = "0x1E122A0", Length = "0x43")]
	[Token(Token = "0x6000063")]
	public void SeekTime(int channel, float ttime) { }

	[Address(RVA = "0x1E13270", Offset = "0x1E12670", Length = "0xFD")]
	[Token(Token = "0x600006C")]
	public void SetMasterVolume(float v) { }

	[Address(RVA = "0x1E130C0", Offset = "0x1E124C0", Length = "0x1AF")]
	[Token(Token = "0x600006B")]
	public void SetMasterVolume(float bgmv, float voicev, float sev) { }

	[Address(RVA = "0x1E12EF0", Offset = "0x1E122F0", Length = "0xDE")]
	[Token(Token = "0x600006D")]
	public float SetMasterVolumeBGM(float v) { }

	[Address(RVA = "0x1E12FD0", Offset = "0x1E123D0", Length = "0xE0")]
	[Token(Token = "0x600006E")]
	public void SetMasterVolumeSE(float v) { }

	[Address(RVA = "0x1E13370", Offset = "0x1E12770", Length = "0x38")]
	[Token(Token = "0x600005B")]
	public void SetReserve(int ch) { }

	[Address(RVA = "0x1E133B0", Offset = "0x1E127B0", Length = "0x47")]
	[Token(Token = "0x6000071")]
	public void SetVolumeRate(int channel, float vol) { }

	[Address(RVA = "0x1E13630", Offset = "0x1E12A30", Length = "0x71")]
	[Token(Token = "0x6000064")]
	public void Stop(int channel) { }

	[Address(RVA = "0x1E13400", Offset = "0x1E12800", Length = "0x165")]
	[Token(Token = "0x6000066")]
	public void StopAll(SCType ctype) { }

	[Address(RVA = "0x1E13570", Offset = "0x1E12970", Length = "0xB2")]
	[Token(Token = "0x6000065")]
	public void StopAll() { }

	[Address(RVA = "0x1E136B0", Offset = "0x1E12AB0", Length = "0x130")]
	[Token(Token = "0x600005A")]
	public void Terminate() { }

	[Address(RVA = "0x1E137F0", Offset = "0x1E12BF0", Length = "0x47")]
	[Token(Token = "0x6000070")]
	public void Volume(int channel, float vol) { }

	[Address(RVA = "0x1E13840", Offset = "0x1E12C40", Length = "0x35")]
	[Token(Token = "0x6000072")]
	public float Volume(int channel) { }

}

