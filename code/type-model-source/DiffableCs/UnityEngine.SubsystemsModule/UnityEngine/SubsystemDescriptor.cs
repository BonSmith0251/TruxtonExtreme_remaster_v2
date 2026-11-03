namespace UnityEngine;

[Obsolete("Use SubsystemDescriptorWithProvider instead.", False)]
[Token(Token = "0x200000B")]
public abstract class SubsystemDescriptor : ISubsystemDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	private string <id>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000005")]
	public override string id
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000011")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000012")]
	protected SubsystemDescriptor() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000011")]
	public override string get_id() { }

}

