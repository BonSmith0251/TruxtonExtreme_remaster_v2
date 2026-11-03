namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000198")]
public sealed class TypeConverterAttribute : Attribute
{
	[Token(Token = "0x400066A")]
	public static readonly TypeConverterAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400066B")]
	private readonly string <ConverterTypeName>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001ED")]
	public string ConverterTypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A00")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2678B00", Offset = "0x2677F00", Length = "0x85")]
	[Token(Token = "0x6000A03")]
	private static TypeConverterAttribute() { }

	[Address(RVA = "0x26482E0", Offset = "0x26476E0", Length = "0x33")]
	[Token(Token = "0x60009FD")]
	public TypeConverterAttribute() { }

	[Address(RVA = "0x2678B90", Offset = "0x2677F90", Length = "0x51")]
	[Token(Token = "0x60009FE")]
	public TypeConverterAttribute(Type type) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60009FF")]
	public TypeConverterAttribute(string typeName) { }

	[Address(RVA = "0x2678A90", Offset = "0x2677E90", Length = "0x6D")]
	[Token(Token = "0x6000A01")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A00")]
	public string get_ConverterTypeName() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x6000A02")]
	public virtual int GetHashCode() { }

}

