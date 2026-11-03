namespace KANAI.Sound;

[Token(Token = "0x200000C")]
public class SoundManager : MonoBehaviourSingleton<SoundManager>
{
	[Token(Token = "0x200000D")]
	private class ClipData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004D")]
		private AudioClip _clip; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004E")]
		private string _filename; //Field offset: 0x18

		[Token(Token = "0x17000008")]
		public AudioClip Clip
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000055")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000009")]
		public string Filename
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000056")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1DFA290", Offset = "0x1DF9690", Length = "0x6F")]
		[Token(Token = "0x6000057")]
		public ClipData(AudioClip c, string kstr) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000055")]
		public AudioClip get_Clip() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000056")]
		public string get_Filename() { }

		[Address(RVA = "0x1E0F230", Offset = "0x1E0E630", Length = "0xA3")]
		[Token(Token = "0x6000058")]
		public void Release() { }

	}

	[Token(Token = "0x4000045")]
	public static readonly int BGMChannels; //Field offset: 0x0
	[Token(Token = "0x4000046")]
	public static readonly int JingleChannels; //Field offset: 0x4
	[Token(Token = "0x4000047")]
	public static readonly int VoiceChancels; //Field offset: 0x8
	[Token(Token = "0x4000048")]
	public static readonly int SystemChannels; //Field offset: 0xC
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000042")]
	private SoundSystem _soundSystem; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000043")]
	private Action _callback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000044")]
	private Action _stopAllCB; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000049")]
	private List<ClipData> _clips; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400004A")]
	private bool _isEnable; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400004B")]
	private bool _isPause; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x400004C")]
	private bool _isFade; //Field offset: 0x42

	[Token(Token = "0x17000006")]
	public bool IsEnable
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000007")]
	public bool IsFade
	{
		[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
		[Token(Token = "0x6000052")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E116F0", Offset = "0x1E10AF0", Length = "0x78")]
	[Token(Token = "0x6000054")]
	private static SoundManager() { }

	[Address(RVA = "0x1E11770", Offset = "0x1E10B70", Length = "0x3D")]
	[Token(Token = "0x6000053")]
	public SoundManager() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000050")]
	public string DebugString() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000051")]
	public bool get_IsEnable() { }

	[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
	[Token(Token = "0x6000052")]
	public bool get_IsFade() { }

	[Address(RVA = "0x1E0FF30", Offset = "0x1E0F330", Length = "0x6C")]
	[Token(Token = "0x600002C")]
	public AudioClip GetClip(int tindex) { }

	[Address(RVA = "0x1E0FEF0", Offset = "0x1E0F2F0", Length = "0x3A")]
	[Token(Token = "0x600002A")]
	public int GetClipCount() { }

	[Address(RVA = "0x1E0FFA0", Offset = "0x1E0F3A0", Length = "0x21")]
	[Token(Token = "0x600004A")]
	public int GetEmptyChannel(SCType stype) { }

	[Address(RVA = "0x1E0FFD0", Offset = "0x1E0F3D0", Length = "0xC2")]
	[Token(Token = "0x600002B")]
	public int GetIndex(string path) { }

	[Address(RVA = "0x1E100A0", Offset = "0x1E0F4A0", Length = "0x19")]
	[Token(Token = "0x600004C")]
	public int GetPlayingChannel(SCType sctype, string tclip) { }

	[Address(RVA = "0x1E100C0", Offset = "0x1E0F4C0", Length = "0x16")]
	[Token(Token = "0x600004B")]
	public int GetPlayingCount(SCType sctype, string tclip) { }

	[Address(RVA = "0x1E100E0", Offset = "0x1E0F4E0", Length = "0x180")]
	[Token(Token = "0x600004D")]
	public int GetPlayingForOverwrite(SCType sctype, string tclip) { }

	[Address(RVA = "0x1E10270", Offset = "0x1E0F670", Length = "0x251")]
	[Token(Token = "0x6000029")]
	public void Initialize(int sourceMax) { }

	[Address(RVA = "0x1E104D0", Offset = "0x1E0F8D0", Length = "0x152")]
	[Token(Token = "0x6000044")]
	public bool IsPlaying(SCType sctype) { }

	[Address(RVA = "0x1E10630", Offset = "0x1E0FA30", Length = "0x5F")]
	[Token(Token = "0x6000043")]
	public bool IsPlaying(int channel) { }

	[Address(RVA = "0x1E10690", Offset = "0x1E0FA90", Length = "0x66")]
	[Token(Token = "0x600004E")]
	private void LateUpdate() { }

	[Address(RVA = "0x1E10720", Offset = "0x1E0FB20", Length = "0x1E")]
	[Token(Token = "0x600003D")]
	public void MasterVolume(float vol) { }

	[Address(RVA = "0x1E10700", Offset = "0x1E0FB00", Length = "0x1E")]
	[Token(Token = "0x600003E")]
	public float MasterVolumeBGM(float vol) { }

	[Address(RVA = "0x1E10740", Offset = "0x1E0FB40", Length = "0x30")]
	[Token(Token = "0x600003F")]
	public void MuteSE(bool isMute) { }

	[Address(RVA = "0x1E10780", Offset = "0x1E0FB80", Length = "0x43")]
	[Token(Token = "0x600004F")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1E10870", Offset = "0x1E0FC70", Length = "0x1E")]
	[Token(Token = "0x600003B")]
	public void Pause(int channel, bool isPause) { }

	[Address(RVA = "0x1E107D0", Offset = "0x1E0FBD0", Length = "0x99")]
	[Token(Token = "0x600003C")]
	public void PauseAll(bool isPause) { }

	[Address(RVA = "0x1E10890", Offset = "0x1E0FC90", Length = "0x108")]
	[Token(Token = "0x6000035")]
	public void PlayBGM(int channel, AudioClip clip, float vol, float time, bool withLoop) { }

	[Address(RVA = "0x1E109F0", Offset = "0x1E0FDF0", Length = "0xC8")]
	[Token(Token = "0x6000033")]
	public int PlayLoop(int seID, float vol, float pan = 0, SCType stype = 2) { }

	[Address(RVA = "0x1E109A0", Offset = "0x1E0FDA0", Length = "0x42")]
	[Token(Token = "0x6000034")]
	public void PlayLoopCh(int tch, AudioClip c, float vol, float pan = 0, bool isLoop = true) { }

	[Address(RVA = "0x1E10AC0", Offset = "0x1E0FEC0", Length = "0x24")]
	[Token(Token = "0x6000032")]
	public void PlayNormalCh(int tch, AudioClip c, float vol, float pan = 0) { }

	[Address(RVA = "0x1E10B20", Offset = "0x1E0FF20", Length = "0xCB")]
	[Token(Token = "0x6000030")]
	public int PlayOneShot(int seID, float vol, float pan = 0, SCType stype = 2) { }

	[Address(RVA = "0x1E10AF0", Offset = "0x1E0FEF0", Length = "0x24")]
	[Token(Token = "0x6000031")]
	public void PlayOneShotCh(int tch, AudioClip tclip, float vol, float pan = 0) { }

	[Address(RVA = "0x1E10BF0", Offset = "0x1E0FFF0", Length = "0x1BC")]
	[Token(Token = "0x600002E")]
	public void RemoveClip(string nKey) { }

	[Address(RVA = "0x1E10DB0", Offset = "0x1E101B0", Length = "0x4B")]
	[Token(Token = "0x6000037")]
	public void Seek(int channel, float tsecond) { }

	[Address(RVA = "0x1E10E00", Offset = "0x1E10200", Length = "0x37")]
	[Token(Token = "0x6000047")]
	public void SetCallback(Action tcallback, Action stopAll) { }

	[Address(RVA = "0x1E10E40", Offset = "0x1E10240", Length = "0x15B")]
	[Token(Token = "0x600002D")]
	public int SetClip(AudioClip clip, string nKey) { }

	[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
	[Token(Token = "0x6000045")]
	public void SetEnable(bool value) { }

	[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
	[Token(Token = "0x6000046")]
	public void SetFade(bool value) { }

	[Address(RVA = "0x1E10FA0", Offset = "0x1E103A0", Length = "0x1B8")]
	[Token(Token = "0x6000049")]
	public void SetMasterVolume(float bgmv, float voicev, float sev) { }

	[Address(RVA = "0x1E11160", Offset = "0x1E10560", Length = "0x41")]
	[Token(Token = "0x600002F")]
	public void SetReserve(int tch) { }

	[Address(RVA = "0x1E111B0", Offset = "0x1E105B0", Length = "0x50")]
	[Token(Token = "0x6000041")]
	public void SetVolumeRate(int channel, float vol) { }

	[Address(RVA = "0x1E11380", Offset = "0x1E10780", Length = "0x1E")]
	[Token(Token = "0x6000036")]
	public void Stop(int channel) { }

	[Address(RVA = "0x1E11210", Offset = "0x1E10610", Length = "0x1E")]
	[Token(Token = "0x600003A")]
	public void StopAll(SCType sctype) { }

	[Address(RVA = "0x1E11230", Offset = "0x1E10630", Length = "0xEE")]
	[Token(Token = "0x6000038")]
	public void StopAll() { }

	[Address(RVA = "0x1E11320", Offset = "0x1E10720", Length = "0x58")]
	[Token(Token = "0x6000039")]
	public void StopWithoutSystem() { }

	[Address(RVA = "0x1E113A0", Offset = "0x1E107A0", Length = "0x2AE")]
	[Token(Token = "0x6000048")]
	public void Terminate() { }

	[Address(RVA = "0x1E116B0", Offset = "0x1E10AB0", Length = "0x3D")]
	[Token(Token = "0x6000042")]
	public float Volume(int channel) { }

	[Address(RVA = "0x1E11650", Offset = "0x1E10A50", Length = "0x50")]
	[Token(Token = "0x6000040")]
	public void Volume(int channel, float vol) { }

}

