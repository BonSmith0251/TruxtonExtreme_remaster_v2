namespace System.Reflection;

[Token(Token = "0x2000508")]
public struct CustomAttributeNamedArgument
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013CF")]
	private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013D0")]
	private readonly bool <IsField>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013D1")]
	private readonly string <MemberName>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013D2")]
	private readonly Type _attributeType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013D3")]
	private MemberInfo _lazyMemberInfo; //Field offset: 0x28

	[Token(Token = "0x170004A8")]
	public bool IsField
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023B3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004AA")]
	public MemberInfo MemberInfo
	{
		[Address(RVA = "0x1F548F0", Offset = "0x1F53CF0", Length = "0x174")]
		[Token(Token = "0x60023B5")]
		 get { } //Length: 372
	}

	[Token(Token = "0x170004A9")]
	public string MemberName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023B4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004A7")]
	public CustomAttributeTypedArgument TypedValue
	{
		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023B2")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x1F54400", Offset = "0x1F53800", Length = "0x6B")]
	[Token(Token = "0x60023AF")]
	internal CustomAttributeNamedArgument(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue) { }

	[Address(RVA = "0x1F54470", Offset = "0x1F53870", Length = "0x2ED")]
	[Token(Token = "0x60023B0")]
	public CustomAttributeNamedArgument(MemberInfo memberInfo, object value) { }

	[Address(RVA = "0x1F54760", Offset = "0x1F53B60", Length = "0x189")]
	[Token(Token = "0x60023B1")]
	public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument) { }

	[Address(RVA = "0x1F54050", Offset = "0x1F53450", Length = "0x68")]
	[Token(Token = "0x60023B6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023B3")]
	public bool get_IsField() { }

	[Address(RVA = "0x1F548F0", Offset = "0x1F53CF0", Length = "0x174")]
	[Token(Token = "0x60023B5")]
	public MemberInfo get_MemberInfo() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023B4")]
	public string get_MemberName() { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023B2")]
	public CustomAttributeTypedArgument get_TypedValue() { }

	[Address(RVA = "0x1F540C0", Offset = "0x1F534C0", Length = "0x60")]
	[Token(Token = "0x60023B7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F54A70", Offset = "0x1F53E70", Length = "0xBB")]
	[Token(Token = "0x60023B8")]
	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	[Address(RVA = "0x1F54B30", Offset = "0x1F53F30", Length = "0xBB")]
	[Token(Token = "0x60023B9")]
	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	[Address(RVA = "0x1F54120", Offset = "0x1F53520", Length = "0x2DD")]
	[Token(Token = "0x60023BA")]
	public virtual string ToString() { }

}

