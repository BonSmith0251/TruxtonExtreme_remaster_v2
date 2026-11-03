namespace TMPro;

[Token(Token = "0x2000070")]
public abstract class TMP_InputValidator : ScriptableObject
{

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000407")]
	protected TMP_InputValidator() { }

	[Token(Token = "0x6000406")]
	public abstract char Validate(ref string text, ref int pos, char ch) { }

}

