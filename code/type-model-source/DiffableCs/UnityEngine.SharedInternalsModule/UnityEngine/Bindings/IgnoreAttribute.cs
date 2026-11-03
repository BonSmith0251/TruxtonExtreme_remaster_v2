namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000018")]
[VisibleToOtherModules]
internal class IgnoreAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000022")]
	private bool <DoesNotContributeToSize>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000014")]
	public bool DoesNotContributeToSize
	{
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000036")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000037")]
	public IgnoreAttribute() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000036")]
	public void set_DoesNotContributeToSize(bool value) { }

}

