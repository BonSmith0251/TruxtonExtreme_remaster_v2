namespace UnityEngine.EventSystems;

[Token(Token = "0x200009B")]
public abstract class AbstractEventData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D0")]
	protected bool m_Used; //Field offset: 0x10

	[Token(Token = "0x1700019E")]
	public override bool used
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000633")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000634")]
	protected AbstractEventData() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000633")]
	public override bool get_used() { }

	[Address(RVA = "0x2170560", Offset = "0x216F960", Length = "0x5")]
	[Token(Token = "0x6000631")]
	public override void Reset() { }

	[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
	[Token(Token = "0x6000632")]
	public override void Use() { }

}

