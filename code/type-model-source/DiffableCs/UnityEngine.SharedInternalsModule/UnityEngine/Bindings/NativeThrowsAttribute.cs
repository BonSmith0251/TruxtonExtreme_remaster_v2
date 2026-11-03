namespace UnityEngine.Bindings;

[AttributeUsage(192)]
[Token(Token = "0x2000017")]
[VisibleToOtherModules]
internal class NativeThrowsAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000021")]
	private bool <ThrowsException>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000013")]
	public override bool ThrowsException
	{
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000034")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x31662B0", Offset = "0x31656B0", Length = "0x1A")]
	[Token(Token = "0x6000035")]
	public NativeThrowsAttribute() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000034")]
	public override void set_ThrowsException(bool value) { }

}

