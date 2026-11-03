namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D5")]
public class BGSlideRangeBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40005F3")]
	private float _slideRange; //Field offset: 0x10

	[Token(Token = "0x17000154")]
	public float SlideRange
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000735")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000737")]
	public BGSlideRangeBehaviour() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000735")]
	public float get_SlideRange() { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6000736")]
	public void Set(float range) { }

}

