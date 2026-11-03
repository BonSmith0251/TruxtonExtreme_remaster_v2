namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "Vive Lighthouse", hideInUI = True)]
[Token(Token = "0x2000008")]
public class ViveLighthouse : TrackedDevice
{

	[Address(RVA = "0x28DA180", Offset = "0x28D9580", Length = "0x7")]
	[Token(Token = "0x6000044")]
	public ViveLighthouse() { }

}

