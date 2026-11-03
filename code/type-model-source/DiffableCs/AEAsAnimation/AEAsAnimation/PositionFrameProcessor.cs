namespace AEAsAnimation;

[Token(Token = "0x2000052")]
public class PositionFrameProcessor : FrameProcessor<Single>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D8")]
	private List<Single> _defaultValues; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001D9")]
	private float _defaultValue; //Field offset: 0x30

	[Token(Token = "0x17000033")]
	public float x
	{
		[Address(RVA = "0x5C5480", Offset = "0x5C4880", Length = "0x122")]
		[Token(Token = "0x600014C")]
		 get { } //Length: 290
	}

	[Token(Token = "0x17000034")]
	public float y
	{
		[Address(RVA = "0x5C55B0", Offset = "0x5C49B0", Length = "0x128")]
		[Token(Token = "0x600014D")]
		 get { } //Length: 296
	}

	[Token(Token = "0x17000035")]
	public float z
	{
		[Address(RVA = "0x5C56E0", Offset = "0x5C4AE0", Length = "0x128")]
		[Token(Token = "0x600014E")]
		 get { } //Length: 296
	}

	[Address(RVA = "0x5C5400", Offset = "0x5C4800", Length = "0x73")]
	[Token(Token = "0x600014A")]
	public PositionFrameProcessor(LayerPropertyData<Single> data, float defaultValue = 0) { }

	[Address(RVA = "0x5C5380", Offset = "0x5C4780", Length = "0x7E")]
	[Token(Token = "0x600014B")]
	public PositionFrameProcessor(LayerPropertyData<Single> data, List<Single> defaultValues) { }

	[Address(RVA = "0x5C5480", Offset = "0x5C4880", Length = "0x122")]
	[Token(Token = "0x600014C")]
	public float get_x() { }

	[Address(RVA = "0x5C55B0", Offset = "0x5C49B0", Length = "0x128")]
	[Token(Token = "0x600014D")]
	public float get_y() { }

	[Address(RVA = "0x5C56E0", Offset = "0x5C4AE0", Length = "0x128")]
	[Token(Token = "0x600014E")]
	public float get_z() { }

	[Address(RVA = "0x5C5300", Offset = "0x5C4700", Length = "0x72")]
	[Token(Token = "0x600014F")]
	private float GetDefaultValue(int index) { }

}

