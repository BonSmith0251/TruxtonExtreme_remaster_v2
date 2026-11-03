namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[Token(Token = "0x200000B")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	internal string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_FeatureType")]
	[Token(Token = "0x400004D")]
	internal InputFeatureType m_InternalType; //Field offset: 0x8

	[Token(Token = "0x17000005")]
	internal InputFeatureType internalType
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6000006")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public string name
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x3491BD0", Offset = "0x3490FD0", Length = "0xBF")]
	[Token(Token = "0x6000007")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3491C90", Offset = "0x3491090", Length = "0x46")]
	[Token(Token = "0x6000008")]
	public override bool Equals(InputFeatureUsage other) { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6000006")]
	internal InputFeatureType get_internalType() { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6000005")]
	public string get_name() { }

	[Address(RVA = "0x3491CE0", Offset = "0x34910E0", Length = "0x5A")]
	[Token(Token = "0x6000009")]
	public virtual int GetHashCode() { }

}

