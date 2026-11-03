namespace KANAI.DebugTools;

[Token(Token = "0x2000006")]
public class DebugInformation : MonoBehaviour
{

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600000D")]
	public DebugInformation() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000B")]
	public static void PrintS(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000C")]
	public static void SetFontColor(UITextFontColor fcolor) { }

}

