namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200002D")]
public struct ClusterInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B8")]
	private int <BigCore>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000B9")]
	private int <MediumCore>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BA")]
	private int <LittleCore>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700006E")]
	public int BigCore
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600014C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000070")]
	public int LittleCore
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600014E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700006F")]
	public int MediumCore
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600014D")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600014C")]
	public int get_BigCore() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600014E")]
	public int get_LittleCore() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600014D")]
	public int get_MediumCore() { }

}

