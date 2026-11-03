namespace KANAI.Sound;

[Token(Token = "0x2000004")]
public class SoundChannel
{
	[Token(Token = "0x2000005")]
	internal enum SCType : int
	{
		BGM = 0,
		JINGLE = 1,
		SE = 2,
		SYSTEM = 3,
		VOICE = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private SCType _chType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000007")]
	private AudioSource _sources; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	private float _localVolume; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000009")]
	private bool _isReserved; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x400000A")]
	private bool _isPaused; //Field offset: 0x25
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x400000B")]
	private bool _isPlaying; //Field offset: 0x26
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000C")]
	private int _safePlayCounter; //Field offset: 0x28

	[Token(Token = "0x17000001")]
	public SCType ChType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000005")]
	public string ClipName
	{
		[Address(RVA = "0x1E0F950", Offset = "0x1E0ED50", Length = "0xD6")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 214
	}

	[Token(Token = "0x17000004")]
	public bool IsPlayingState
	{
		[Address(RVA = "0x1CC8820", Offset = "0x1CC7C20", Length = "0x5")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000003")]
	public bool IsReserved
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public float LocalVolume
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000019")]
	public SoundChannel() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000014")]
	public SCType get_ChType() { }

	[Address(RVA = "0x1E0F950", Offset = "0x1E0ED50", Length = "0xD6")]
	[Token(Token = "0x6000018")]
	public string get_ClipName() { }

	[Address(RVA = "0x1CC8820", Offset = "0x1CC7C20", Length = "0x5")]
	[Token(Token = "0x6000017")]
	public bool get_IsPlayingState() { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[Token(Token = "0x6000016")]
	public bool get_IsReserved() { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[Token(Token = "0x6000015")]
	public float get_LocalVolume() { }

	[Address(RVA = "0x1E0F2E0", Offset = "0x1E0E6E0", Length = "0x1D")]
	[Token(Token = "0x600000D")]
	public int GetPriority() { }

	[Address(RVA = "0x1E0F300", Offset = "0x1E0E700", Length = "0xDC")]
	[Token(Token = "0x6000003")]
	public void Initialize(SCType ct, AudioSource s) { }

	[Address(RVA = "0x1E0F3E0", Offset = "0x1E0E7E0", Length = "0x41")]
	[Token(Token = "0x6000011")]
	public bool IsEmpty(int currentFrameCounter) { }

	[Address(RVA = "0x1E0F430", Offset = "0x1E0E830", Length = "0x2A")]
	[Token(Token = "0x6000010")]
	public bool IsPlayOrPause() { }

	[Address(RVA = "0x1E0F460", Offset = "0x1E0E860", Length = "0x10F")]
	[Token(Token = "0x6000012")]
	public bool IsSame(string tclipName) { }

	[Address(RVA = "0x1E0F570", Offset = "0x1E0E970", Length = "0xC0")]
	[Token(Token = "0x6000007")]
	public void PlayLoop(AudioClip clip, bool withLoop, float ttime = 0) { }

	[Address(RVA = "0x1E0F640", Offset = "0x1E0EA40", Length = "0x77")]
	[Token(Token = "0x6000006")]
	public void PlayOneShot(AudioClip clip) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000008")]
	public void SetFrameCounter(int nframe) { }

	[Address(RVA = "0x1E0F6C0", Offset = "0x1E0EAC0", Length = "0x1E")]
	[Token(Token = "0x600000B")]
	public void SetLocalTime(float tsecond) { }

	[Address(RVA = "0x1E0F710", Offset = "0x1E0EB10", Length = "0x23")]
	[Token(Token = "0x6000009")]
	public void SetLocalVolume(float local) { }

	[Address(RVA = "0x1E0F6E0", Offset = "0x1E0EAE0", Length = "0x26")]
	[Token(Token = "0x600000A")]
	public void SetLocalVolumeByRate(float trate) { }

	[Address(RVA = "0x1E0F740", Offset = "0x1E0EB40", Length = "0x1E")]
	[Token(Token = "0x600000C")]
	public void SetPan(float pan) { }

	[Address(RVA = "0x1E0F760", Offset = "0x1E0EB60", Length = "0xC7")]
	[Token(Token = "0x6000013")]
	public void SetPause(bool v) { }

	[Address(RVA = "0x1E0F830", Offset = "0x1E0EC30", Length = "0x1E")]
	[Token(Token = "0x600000E")]
	public void SetPriority(int p) { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[Token(Token = "0x600000F")]
	public void SetReserve(bool v) { }

	[Address(RVA = "0x1E0F850", Offset = "0x1E0EC50", Length = "0x44")]
	[Token(Token = "0x6000005")]
	public void Stop() { }

	[Address(RVA = "0x1E0F8A0", Offset = "0x1E0ECA0", Length = "0xAC")]
	[Token(Token = "0x6000004")]
	public void Terminate() { }

}

