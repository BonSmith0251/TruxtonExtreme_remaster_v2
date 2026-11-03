namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000168")]
[UsedByNativeCode]
public abstract class PropertyAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005FD")]
	private readonly bool <applyToCollection>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x305E1E0", Offset = "0x305D5E0", Length = "0x1A")]
	[Token(Token = "0x60011FD")]
	protected PropertyAttribute() { }

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x60011FE")]
	protected PropertyAttribute(bool applyToCollection) { }

}

