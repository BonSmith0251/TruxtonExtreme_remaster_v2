namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000165")]
internal class LaserSoundRequestData
{
	[Token(Token = "0x2000166")]
	internal enum PlayState : int
	{
		None = 0,
		Playing = 1,
		Done = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000A4F")]
	private LaserSE SoundId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A50")]
	private ID lappedSoundId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A51")]
	private int _seCh; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A52")]
	private float MaserVolume; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A53")]
	private float TargetVolume; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000A54")]
	private bool _isLaped; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A55")]
	private PlayState _lstate; //Field offset: 0x28

	[Address(RVA = "0x1D71AC0", Offset = "0x1D70EC0", Length = "0x24")]
	[Token(Token = "0x6000B1D")]
	public LaserSoundRequestData() { }

	[Address(RVA = "0x1D71770", Offset = "0x1D70B70", Length = "0x8")]
	[Token(Token = "0x6000B1C")]
	public bool IsPlay() { }

	[Address(RVA = "0x1D71780", Offset = "0x1D70B80", Length = "0x8")]
	[Token(Token = "0x6000B1B")]
	public bool IsYet() { }

	[Address(RVA = "0x1D71790", Offset = "0x1D70B90", Length = "0xD6")]
	[Token(Token = "0x6000B16")]
	public void Play(bool isInArea) { }

	[Address(RVA = "0x1D71870", Offset = "0x1D70C70", Length = "0xC1")]
	[Token(Token = "0x6000B19")]
	public void ProgressVolume(float tdt) { }

	[Address(RVA = "0x1D71940", Offset = "0x1D70D40", Length = "0x6E")]
	[Token(Token = "0x6000B14")]
	public void Reset() { }

	[Address(RVA = "0x1D719B0", Offset = "0x1D70DB0", Length = "0x8")]
	[Token(Token = "0x6000B15")]
	public void SetSoundID(ID tid) { }

	[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
	[Token(Token = "0x6000B18")]
	public void SetTargetVolume(float tvol) { }

	[Address(RVA = "0x1D719D0", Offset = "0x1D70DD0", Length = "0x80")]
	[Token(Token = "0x6000B17")]
	public void SetVolume(float tvol) { }

	[Address(RVA = "0x1D71A50", Offset = "0x1D70E50", Length = "0x6E")]
	[Token(Token = "0x6000B1A")]
	public void Stop() { }

}

