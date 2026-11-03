namespace Unity.Cinemachine;

[Extension]
[Obsolete("IInputAxisProvider is deprecated.  Use InputAxis and InputAxisController instead")]
[Token(Token = "0x200011F")]
public static class CinemachineInputProviderExtensions
{

	[Address(RVA = "0x286F190", Offset = "0x286E590", Length = "0xA5")]
	[Extension]
	[Token(Token = "0x6000582")]
	public static IInputAxisProvider GetInputAxisProvider(CinemachineVirtualCameraBase vcam) { }

}

