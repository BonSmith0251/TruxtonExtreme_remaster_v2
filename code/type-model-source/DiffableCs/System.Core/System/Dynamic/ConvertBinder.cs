namespace System.Dynamic;

[Token(Token = "0x2000260")]
public abstract class ConvertBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400043E")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700025B")]
	public Type Type
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BA1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2293E10", Offset = "0x2293210", Length = "0xA8")]
	[Token(Token = "0x6000BA4")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x1E57D60", Offset = "0x1E57160", Length = "0x17")]
	[Token(Token = "0x6000BA2")]
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	[Token(Token = "0x6000BA3")]
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BA1")]
	public Type get_Type() { }

}

