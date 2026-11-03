namespace UnityEngine.InputSystem.XInput;

[InputControlLayout(stateType = typeof(XInputControllerWindowsState), hideInUI = True)]
[Token(Token = "0x2000105")]
public class XInputControllerWindows : XInputController
{

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000CCD")]
	public XInputControllerWindows() { }

}

