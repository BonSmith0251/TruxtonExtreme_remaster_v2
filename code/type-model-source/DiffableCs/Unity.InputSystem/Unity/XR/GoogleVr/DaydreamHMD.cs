namespace Unity.XR.GoogleVr;

[InputControlLayout(displayName = "Daydream Headset", hideInUI = True)]
[Token(Token = "0x2000012")]
public class DaydreamHMD : XRHMD
{

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x60000D7")]
	public DaydreamHMD() { }

}

