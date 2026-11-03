namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Property (128))]
[Token(Token = "0x200000E")]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000012")]
	private TargetType <TargetType>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700000D")]
	public TargetType TargetType
	{
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600001F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000020")]
	public NativePropertyAttribute() { }

	[Address(RVA = "0x3166260", Offset = "0x3165660", Length = "0x8")]
	[Token(Token = "0x6000021")]
	public NativePropertyAttribute(string name) { }

	[Address(RVA = "0x3166270", Offset = "0x3165670", Length = "0x38")]
	[Token(Token = "0x6000022")]
	public NativePropertyAttribute(string name, bool isFree, TargetType targetType) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600001F")]
	public void set_TargetType(TargetType value) { }

}

