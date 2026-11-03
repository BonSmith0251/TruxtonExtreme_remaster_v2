namespace JetBrains.Annotations;

[AttributeUsage(224)]
[Token(Token = "0x2000082")]
public sealed class CollectionAccessAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000119")]
	private readonly CollectionAccessType <CollectionAccessType>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000199")]
	public CollectionAccessAttribute(CollectionAccessType collectionAccessType) { }

}

