namespace AEAsAnimation;

[Token(Token = "0x2000057")]
public class FrameProcessor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E2")]
	protected LayerPropertyData<T> _data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E3")]
	protected int _currentFrame; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E4")]
	protected int _loopStartFrame; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E5")]
	protected int _loopEndFrame; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E6")]
	protected int _periodFrame; //Field offset: 0x0

	[Token(Token = "0x1700003F")]
	public int currentFrame
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600016C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700003E")]
	public bool isInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x600016B")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1C0E440", Offset = "0x1C0D840", Length = "0x16")]
	[Token(Token = "0x600016D")]
	public FrameProcessor`1() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600016C")]
	public int get_currentFrame() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x600016B")]
	public bool get_isInvalid() { }

	[Address(RVA = "0x1C0DFF0", Offset = "0x1C0D3F0", Length = "0x149")]
	[Token(Token = "0x6000166")]
	public void GoNextFrame() { }

	[Address(RVA = "0x1C0E160", Offset = "0x1C0D560", Length = "0x149")]
	[Token(Token = "0x6000167")]
	public void GoToFrame(int frame, int periodFrame = -1) { }

	[Address(RVA = "0x5C4B80", Offset = "0x5C3F80", Length = "0x8")]
	[Token(Token = "0x600016A")]
	public void Restart() { }

	[Address(RVA = "0x5C4B90", Offset = "0x5C3F90", Length = "0x8")]
	[Token(Token = "0x6000168")]
	public void SetLoop() { }

	[Address(RVA = "0x5C4BA0", Offset = "0x5C3FA0", Length = "0x8")]
	[Token(Token = "0x6000169")]
	public void SetLoop(int from, int to) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x6000165")]
	public void SetPeriod(int periodFrame) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000164")]
	protected void SetUp(LayerPropertyData<T> data) { }

}

