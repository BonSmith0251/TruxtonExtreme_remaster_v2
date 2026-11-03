namespace AEAsAnimation;

[Token(Token = "0x2000058")]
public class MaskShapeFrameProcessor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E7")]
	protected LayerShapePropertyData _data; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E8")]
	protected int _currentFrame; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001E9")]
	protected int _loopStartFrame; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EA")]
	protected int _loopEndFrame; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001EB")]
	protected int _periodFrame; //Field offset: 0x24

	[Token(Token = "0x17000041")]
	public int currentFrame
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000176")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000040")]
	public bool isInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000175")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000042")]
	public List<LayerShapeBezierData> shape
	{
		[Address(RVA = "0x5C4C20", Offset = "0x5C4020", Length = "0x5A")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x5C4BC0", Offset = "0x5C3FC0", Length = "0x40")]
	[Token(Token = "0x600016E")]
	public MaskShapeFrameProcessor(LayerShapePropertyData data) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000176")]
	public int get_currentFrame() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000175")]
	public bool get_isInvalid() { }

	[Address(RVA = "0x5C4C20", Offset = "0x5C4020", Length = "0x5A")]
	[Token(Token = "0x6000177")]
	public List<LayerShapeBezierData> get_shape() { }

	[Address(RVA = "0x5C4990", Offset = "0x5C3D90", Length = "0xEC")]
	[Token(Token = "0x6000170")]
	public void GoNextFrame() { }

	[Address(RVA = "0x5C4A80", Offset = "0x5C3E80", Length = "0xFC")]
	[Token(Token = "0x6000171")]
	public void GoToFrame(int frame, int periodFrame = -1) { }

	[Address(RVA = "0x5C4B80", Offset = "0x5C3F80", Length = "0x8")]
	[Token(Token = "0x6000174")]
	public void Restart() { }

	[Address(RVA = "0x5C4B90", Offset = "0x5C3F90", Length = "0x8")]
	[Token(Token = "0x6000172")]
	public void SetLoop() { }

	[Address(RVA = "0x5C4BA0", Offset = "0x5C3FA0", Length = "0x8")]
	[Token(Token = "0x6000173")]
	public void SetLoop(int from, int to) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x600016F")]
	public void SetPeriod(int periodFrame) { }

}

