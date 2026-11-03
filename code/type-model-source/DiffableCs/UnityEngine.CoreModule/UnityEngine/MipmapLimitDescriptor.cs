namespace UnityEngine;

[Token(Token = "0x200013E")]
public struct MipmapLimitDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400040E")]
	private readonly bool <useMipmapLimit>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400040F")]
	private readonly string <groupName>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700026C")]
	public string groupName
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F94")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700026B")]
	public bool useMipmapLimit
	{
		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F93")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x12D6CA0", Offset = "0x12D60A0", Length = "0x12")]
	[Token(Token = "0x6000F95")]
	public MipmapLimitDescriptor(bool useMipmapLimit, string groupName) { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F94")]
	public string get_groupName() { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F93")]
	public bool get_useMipmapLimit() { }

}

