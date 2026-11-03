namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
[Token(Token = "0x200001A")]
[UsedByNativeCode]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
{

	[Address(RVA = "0x3493C90", Offset = "0x3493090", Length = "0x39")]
	[Token(Token = "0x6000057")]
	public XRInputSubsystemDescriptor() { }

}

