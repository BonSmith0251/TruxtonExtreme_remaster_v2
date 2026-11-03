namespace UnityEngine;

[Token(Token = "0x2000099")]
public struct ApplicationMemoryUsageChange
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000162")]
	private ApplicationMemoryUsage <memoryUsage>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000066")]
	private ApplicationMemoryUsage memoryUsage
	{
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60002B0")]
		private set { } //Length: 3
	}

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60002B1")]
	public ApplicationMemoryUsageChange(ApplicationMemoryUsage usage) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60002B0")]
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

}

