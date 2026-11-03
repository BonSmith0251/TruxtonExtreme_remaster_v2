namespace AEAsAnimation;

[Token(Token = "0x2000055")]
public class OpacityFrameProcessor : FrameProcessor<Single>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001DE")]
	private List<Single> _defaultValues; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001DF")]
	private float _defaultValue; //Field offset: 0x30

	[Token(Token = "0x1700003A")]
	public float opacity
	{
		[Address(RVA = "0x5C4F20", Offset = "0x5C4320", Length = "0x122")]
		[Token(Token = "0x600015C")]
		 get { } //Length: 290
	}

	[Address(RVA = "0x5C4E20", Offset = "0x5C4220", Length = "0x73")]
	[Token(Token = "0x600015A")]
	public OpacityFrameProcessor(LayerPropertyData<Single> data, float defaultValue = 0) { }

	[Address(RVA = "0x5C4EA0", Offset = "0x5C42A0", Length = "0x7E")]
	[Token(Token = "0x600015B")]
	public OpacityFrameProcessor(LayerPropertyData<Single> data, List<Single> defaultValues) { }

	[Address(RVA = "0x5C4F20", Offset = "0x5C4320", Length = "0x122")]
	[Token(Token = "0x600015C")]
	public float get_opacity() { }

	[Address(RVA = "0x5C4DA0", Offset = "0x5C41A0", Length = "0x72")]
	[Token(Token = "0x600015D")]
	private float GetDefaultValue(int index) { }

}

