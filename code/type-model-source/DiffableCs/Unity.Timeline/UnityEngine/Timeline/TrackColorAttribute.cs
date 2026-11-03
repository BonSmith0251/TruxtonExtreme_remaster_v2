namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200002B")]
public class TrackColorAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D4")]
	private Color m_Color; //Field offset: 0x10

	[Token(Token = "0x1700008A")]
	public Color color
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x60001C2")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2F3EB40", Offset = "0x2F3DF40", Length = "0x6A")]
	[Token(Token = "0x60001C3")]
	public TrackColorAttribute(float r, float g, float b) { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x60001C2")]
	public Color get_color() { }

}

