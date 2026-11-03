namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000038")]
public class SpriteCharacter : TextElement
{
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000189")]
	private string m_Name; //Field offset: 0x30

	[Token(Token = "0x1700003A")]
	public string name
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x6000172")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2F12CF0", Offset = "0x2F120F0", Length = "0x1A")]
	[Token(Token = "0x6000173")]
	public SpriteCharacter() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x6000172")]
	public string get_name() { }

}

