namespace AEAsAnimation;

[Token(Token = "0x2000032")]
public class AEMaskProcessor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000149")]
	public MaskShapeFrameProcessor _maskShape; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014A")]
	public AVLayerMaskMode _mode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400014B")]
	public bool _inverted; //Field offset: 0x1C

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000AC")]
	public AEMaskProcessor() { }

}

