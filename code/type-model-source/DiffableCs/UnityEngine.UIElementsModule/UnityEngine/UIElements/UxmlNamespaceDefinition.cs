namespace UnityEngine.UIElements;

[Token(Token = "0x2000516")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct UxmlNamespaceDefinition : IEquatable<UxmlNamespaceDefinition>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40010AF")]
	private static readonly UxmlNamespaceDefinition <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40010B0")]
	public string prefix; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40010B1")]
	public string resolvedNamespace; //Field offset: 0x8

	[Token(Token = "0x170009D6")]
	public static UxmlNamespaceDefinition Empty
	{
		[Address(RVA = "0x32C4FB0", Offset = "0x32C43B0", Length = "0x5A")]
		[CompilerGenerated]
		[Token(Token = "0x600259F")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x32C4F70", Offset = "0x32C4370", Length = "0x39")]
	[Token(Token = "0x60025A4")]
	private static UxmlNamespaceDefinition() { }

	[Address(RVA = "0x32C4DF0", Offset = "0x32C41F0", Length = "0x10C")]
	[Token(Token = "0x60025A1")]
	public override bool Equals(UxmlNamespaceDefinition other) { }

	[Address(RVA = "0x32C4D30", Offset = "0x32C4130", Length = "0xB0")]
	[Token(Token = "0x60025A2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32C4FB0", Offset = "0x32C43B0", Length = "0x5A")]
	[CompilerGenerated]
	[Token(Token = "0x600259F")]
	public static UxmlNamespaceDefinition get_Empty() { }

	[Address(RVA = "0x32C4F00", Offset = "0x32C4300", Length = "0x6D")]
	[Token(Token = "0x60025A3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32C5010", Offset = "0x32C4410", Length = "0xA8")]
	[Token(Token = "0x60025A0")]
	public static bool op_Equality(UxmlNamespaceDefinition lhs, UxmlNamespaceDefinition rhs) { }

}

