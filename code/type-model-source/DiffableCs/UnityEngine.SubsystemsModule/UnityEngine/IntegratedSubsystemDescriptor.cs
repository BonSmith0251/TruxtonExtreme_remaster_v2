namespace UnityEngine;

[Token(Token = "0x2000005")]
[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000003")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000003")]
	public override string id
	{
		[Address(RVA = "0x3166550", Offset = "0x3165950", Length = "0xB")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600000B")]
	protected IntegratedSubsystemDescriptor() { }

	[Address(RVA = "0x3166550", Offset = "0x3165950", Length = "0xB")]
	[Token(Token = "0x600000A")]
	public override string get_id() { }

}

