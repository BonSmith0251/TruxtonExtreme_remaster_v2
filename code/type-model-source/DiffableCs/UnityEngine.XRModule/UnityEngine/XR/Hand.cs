namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000D")]
public struct Hand : IEquatable<Hand>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000050")]
	private ulong m_DeviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000051")]
	private uint m_FeatureIndex; //Field offset: 0x8

	[Token(Token = "0x17000007")]
	internal ulong deviceId
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x600000F")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000008")]
	internal uint featureIndex
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6000010")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x34917C0", Offset = "0x3490BC0", Length = "0xAB")]
	[Token(Token = "0x6000011")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x34915F0", Offset = "0x34909F0", Length = "0x1C")]
	[Token(Token = "0x6000012")]
	public override bool Equals(Hand other) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x600000F")]
	internal ulong get_deviceId() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6000010")]
	internal uint get_featureIndex() { }

	[Address(RVA = "0x34916C0", Offset = "0x3490AC0", Length = "0x4D")]
	[Token(Token = "0x6000013")]
	public virtual int GetHashCode() { }

}

