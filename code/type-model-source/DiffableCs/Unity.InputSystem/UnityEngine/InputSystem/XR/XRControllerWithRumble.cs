namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000E6")]
public class XRControllerWithRumble : XRController
{

	[Address(RVA = "0x28DA180", Offset = "0x28D9580", Length = "0x7")]
	[Token(Token = "0x6000C31")]
	public XRControllerWithRumble() { }

	[Address(RVA = "0x29D1840", Offset = "0x29D0C40", Length = "0xFB")]
	[Token(Token = "0x6000C30")]
	public void SendImpulse(float amplitude, float duration) { }

}

