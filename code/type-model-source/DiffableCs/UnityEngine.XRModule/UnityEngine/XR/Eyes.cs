namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000E")]
public struct Eyes : IEquatable<Eyes>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	private ulong m_DeviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000053")]
	private uint m_FeatureIndex; //Field offset: 0x8

	[Token(Token = "0x17000009")]
	internal ulong deviceId
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x6000014")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700000A")]
	internal uint featureIndex
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6000015")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x3491710", Offset = "0x3490B10", Length = "0xAB")]
	[Token(Token = "0x6000016")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x34915F0", Offset = "0x34909F0", Length = "0x1C")]
	[Token(Token = "0x6000017")]
	public override bool Equals(Eyes other) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6000014")]
	internal ulong get_deviceId() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6000015")]
	internal uint get_featureIndex() { }

	[Address(RVA = "0x34916C0", Offset = "0x3490AC0", Length = "0x4D")]
	[Token(Token = "0x6000018")]
	public virtual int GetHashCode() { }

}

