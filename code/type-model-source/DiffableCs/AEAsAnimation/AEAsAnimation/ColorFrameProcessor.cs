namespace AEAsAnimation;

[Token(Token = "0x2000056")]
public class ColorFrameProcessor : FrameProcessor<Single>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E0")]
	private List<Single> _defaultValues; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E1")]
	private float _defaultValue; //Field offset: 0x30

	[Token(Token = "0x1700003D")]
	public float b
	{
		[Address(RVA = "0x5C45E0", Offset = "0x5C39E0", Length = "0x128")]
		[Token(Token = "0x6000162")]
		 get { } //Length: 296
	}

	[Token(Token = "0x1700003C")]
	public float g
	{
		[Address(RVA = "0x5C4710", Offset = "0x5C3B10", Length = "0x128")]
		[Token(Token = "0x6000161")]
		 get { } //Length: 296
	}

	[Token(Token = "0x1700003B")]
	public float r
	{
		[Address(RVA = "0x5C4840", Offset = "0x5C3C40", Length = "0x122")]
		[Token(Token = "0x6000160")]
		 get { } //Length: 290
	}

	[Address(RVA = "0x5C4560", Offset = "0x5C3960", Length = "0x73")]
	[Token(Token = "0x600015E")]
	public ColorFrameProcessor(LayerPropertyData<Single> data, float defaultValue = 0) { }

	[Address(RVA = "0x5C44E0", Offset = "0x5C38E0", Length = "0x7E")]
	[Token(Token = "0x600015F")]
	public ColorFrameProcessor(LayerPropertyData<Single> data, List<Single> defaultValues) { }

	[Address(RVA = "0x5C45E0", Offset = "0x5C39E0", Length = "0x128")]
	[Token(Token = "0x6000162")]
	public float get_b() { }

	[Address(RVA = "0x5C4710", Offset = "0x5C3B10", Length = "0x128")]
	[Token(Token = "0x6000161")]
	public float get_g() { }

	[Address(RVA = "0x5C4840", Offset = "0x5C3C40", Length = "0x122")]
	[Token(Token = "0x6000160")]
	public float get_r() { }

	[Address(RVA = "0x5C4460", Offset = "0x5C3860", Length = "0x72")]
	[Token(Token = "0x6000163")]
	private float GetDefaultValue(int index) { }

}

