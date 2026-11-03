namespace OutGame.DebugMenu;

[Token(Token = "0x2000167")]
public class DebugFPSDisplay : MonoBehaviour
{

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000906")]
	public DebugFPSDisplay() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000905")]
	public void Setup() { }

}

