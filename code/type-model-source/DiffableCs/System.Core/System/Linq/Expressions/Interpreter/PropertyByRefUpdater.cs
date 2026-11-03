namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000199")]
internal sealed class PropertyByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400035E")]
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400035F")]
	private readonly PropertyInfo _property; //Field offset: 0x30

	[Address(RVA = "0x2299E10", Offset = "0x2299210", Length = "0x6A")]
	[Token(Token = "0x60008C8")]
	public PropertyByRefUpdater(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	[Address(RVA = "0x22A7150", Offset = "0x22A6550", Length = "0x96")]
	[Token(Token = "0x60008CA")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x22A71F0", Offset = "0x22A65F0", Length = "0xDE")]
	[Token(Token = "0x60008C9")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

