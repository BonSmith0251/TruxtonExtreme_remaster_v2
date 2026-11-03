namespace AEAsAnimation;

[Token(Token = "0x2000053")]
public class SizeFrameProcessor : FrameProcessor<Single>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001DA")]
	private List<Single> _defaultValues; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001DB")]
	private float _defaultValue; //Field offset: 0x30

	[Token(Token = "0x17000036")]
	public float x
	{
		[Address(RVA = "0x5C5990", Offset = "0x5C4D90", Length = "0x122")]
		[Token(Token = "0x6000152")]
		 get { } //Length: 290
	}

	[Token(Token = "0x17000037")]
	public float y
	{
		[Address(RVA = "0x5C5AC0", Offset = "0x5C4EC0", Length = "0x128")]
		[Token(Token = "0x6000153")]
		 get { } //Length: 296
	}

	[Token(Token = "0x17000038")]
	public float z
	{
		[Address(RVA = "0x5C5BF0", Offset = "0x5C4FF0", Length = "0x165")]
		[Token(Token = "0x6000154")]
		 get { } //Length: 357
	}

	[Address(RVA = "0x5C5910", Offset = "0x5C4D10", Length = "0x73")]
	[Token(Token = "0x6000150")]
	public SizeFrameProcessor(LayerPropertyData<Single> data, float defaultValue = 0) { }

	[Address(RVA = "0x5C5890", Offset = "0x5C4C90", Length = "0x7E")]
	[Token(Token = "0x6000151")]
	public SizeFrameProcessor(LayerPropertyData<Single> data, List<Single> defaultValues) { }

	[Address(RVA = "0x5C5990", Offset = "0x5C4D90", Length = "0x122")]
	[Token(Token = "0x6000152")]
	public float get_x() { }

	[Address(RVA = "0x5C5AC0", Offset = "0x5C4EC0", Length = "0x128")]
	[Token(Token = "0x6000153")]
	public float get_y() { }

	[Address(RVA = "0x5C5BF0", Offset = "0x5C4FF0", Length = "0x165")]
	[Token(Token = "0x6000154")]
	public float get_z() { }

	[Address(RVA = "0x5C5810", Offset = "0x5C4C10", Length = "0x72")]
	[Token(Token = "0x6000155")]
	private float GetDefaultValue(int index) { }

}

