namespace UnityEngine.VFX;

[Token(Token = "0x2000013")]
public struct VFXOutputEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002B")]
	private readonly int <nameId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002C")]
	private readonly VFXEventAttribute <eventAttribute>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700000D")]
	public VFXEventAttribute eventAttribute
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000085")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000C")]
	public int nameId
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000084")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
	[Token(Token = "0x6000086")]
	public VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute) { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000085")]
	public VFXEventAttribute get_eventAttribute() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000084")]
	public int get_nameId() { }

}

