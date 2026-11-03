namespace System.Reflection;

[Token(Token = "0x2000509")]
public struct CustomAttributeTypedArgument
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013D4")]
	private readonly Type <ArgumentType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40013D5")]
	private readonly object <Value>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170004AB")]
	public Type ArgumentType
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023BD")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170004AC")]
	public object Value
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023BE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F55730", Offset = "0x1F54B30", Length = "0x112")]
	[Token(Token = "0x60023BB")]
	public CustomAttributeTypedArgument(object value) { }

	[Address(RVA = "0x1F553F0", Offset = "0x1F547F0", Length = "0x335")]
	[Token(Token = "0x60023BC")]
	public CustomAttributeTypedArgument(Type argumentType, object value) { }

	[Address(RVA = "0x1F54BF0", Offset = "0x1F53FF0", Length = "0x86")]
	[Token(Token = "0x60023C5")]
	private static object CanonicalizeValue(object value) { }

	[Address(RVA = "0x1F54C80", Offset = "0x1F54080", Length = "0x56")]
	[Token(Token = "0x60023BF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023BD")]
	public Type get_ArgumentType() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023BE")]
	public object get_Value() { }

	[Address(RVA = "0x1F54CE0", Offset = "0x1F540E0", Length = "0x4E")]
	[Token(Token = "0x60023C0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F55850", Offset = "0x1F54C50", Length = "0x8E")]
	[Token(Token = "0x60023C1")]
	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	[Address(RVA = "0x1F558E0", Offset = "0x1F54CE0", Length = "0x8E")]
	[Token(Token = "0x60023C2")]
	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	[Address(RVA = "0x1F553E0", Offset = "0x1F547E0", Length = "0xA")]
	[Token(Token = "0x60023C3")]
	public virtual string ToString() { }

	[Address(RVA = "0x1F54D30", Offset = "0x1F54130", Length = "0x6AA")]
	[Token(Token = "0x60023C4")]
	internal string ToString(bool typed) { }

}

