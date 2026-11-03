namespace UnityEngine.InputSystem.XR;

[InputControlLayout(commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, isGenericTypeOfDevice = True, displayName = "XR Controller")]
[Token(Token = "0x20000E5")]
public class XRController : TrackedDevice
{

	[Token(Token = "0x1700032A")]
	public static XRController leftHand
	{
		[Address(RVA = "0x29D1A80", Offset = "0x29D0E80", Length = "0xA0")]
		[Token(Token = "0x6000C2C")]
		 get { } //Length: 160
	}

	[Token(Token = "0x1700032B")]
	public static XRController rightHand
	{
		[Address(RVA = "0x29D1B20", Offset = "0x29D0F20", Length = "0xA0")]
		[Token(Token = "0x6000C2D")]
		 get { } //Length: 160
	}

	[Address(RVA = "0x28DA180", Offset = "0x28D9580", Length = "0x7")]
	[Token(Token = "0x6000C2F")]
	public XRController() { }

	[Address(RVA = "0x29D1940", Offset = "0x29D0D40", Length = "0x132")]
	[Token(Token = "0x6000C2E")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29D1A80", Offset = "0x29D0E80", Length = "0xA0")]
	[Token(Token = "0x6000C2C")]
	public static XRController get_leftHand() { }

	[Address(RVA = "0x29D1B20", Offset = "0x29D0F20", Length = "0xA0")]
	[Token(Token = "0x6000C2D")]
	public static XRController get_rightHand() { }

}

