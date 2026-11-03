namespace System.Dynamic;

[Token(Token = "0x2000277")]
public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400047B")]
	private readonly string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400047C")]
	private readonly bool <IgnoreCase>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000282")]
	public bool IgnoreCase
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C4D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000281")]
	public string Name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C4C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22AFDD0", Offset = "0x22AF1D0", Length = "0xE0")]
	[Token(Token = "0x6000C4E")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Token(Token = "0x6000C51")]
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0x2291290", Offset = "0x2290690", Length = "0x25")]
	[Token(Token = "0x6000C4F")]
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Token(Token = "0x6000C50")]
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C4D")]
	public bool get_IgnoreCase() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C4C")]
	public string get_Name() { }

}

