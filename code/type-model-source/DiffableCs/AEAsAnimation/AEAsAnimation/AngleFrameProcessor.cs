namespace AEAsAnimation;

[Token(Token = "0x2000054")]
public class AngleFrameProcessor : FrameProcessor<Single>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001DC")]
	private List<Single> _defaultValues; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001DD")]
	private float _defaultValue; //Field offset: 0x30

	[Token(Token = "0x17000039")]
	public float angle
	{
		[Address(RVA = "0x5C4200", Offset = "0x5C3600", Length = "0x122")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 290
	}

	[Address(RVA = "0x5C4180", Offset = "0x5C3580", Length = "0x73")]
	[Token(Token = "0x6000156")]
	public AngleFrameProcessor(LayerPropertyData<Single> data, float defaultValue = 0) { }

	[Address(RVA = "0x5C4100", Offset = "0x5C3500", Length = "0x7E")]
	[Token(Token = "0x6000157")]
	public AngleFrameProcessor(LayerPropertyData<Single> data, List<Single> defaultValues) { }

	[Address(RVA = "0x5C4200", Offset = "0x5C3600", Length = "0x122")]
	[Token(Token = "0x6000158")]
	public float get_angle() { }

	[Address(RVA = "0x5C4080", Offset = "0x5C3480", Length = "0x72")]
	[Token(Token = "0x6000159")]
	private float GetDefaultValue(int index) { }

}

