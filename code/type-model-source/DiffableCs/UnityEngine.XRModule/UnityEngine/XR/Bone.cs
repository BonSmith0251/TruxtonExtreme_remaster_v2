namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000F")]
public struct Bone : IEquatable<Bone>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000054")]
	private ulong m_DeviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000055")]
	private uint m_FeatureIndex; //Field offset: 0x8

	[Token(Token = "0x1700000B")]
	internal ulong deviceId
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x6000019")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700000C")]
	internal uint featureIndex
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x600001A")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x3491610", Offset = "0x3490A10", Length = "0xAB")]
	[Token(Token = "0x600001B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x34915F0", Offset = "0x34909F0", Length = "0x1C")]
	[Token(Token = "0x600001C")]
	public override bool Equals(Bone other) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6000019")]
	internal ulong get_deviceId() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x600001A")]
	internal uint get_featureIndex() { }

	[Address(RVA = "0x34916C0", Offset = "0x3490AC0", Length = "0x4D")]
	[Token(Token = "0x600001D")]
	public virtual int GetHashCode() { }

}

