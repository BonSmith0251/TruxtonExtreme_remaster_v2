namespace System.Dynamic;

[Token(Token = "0x2000279")]
public abstract class SetMemberBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400047D")]
	private readonly string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400047E")]
	private readonly bool <IgnoreCase>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000285")]
	public bool IgnoreCase
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C58")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000286")]
	internal virtual bool IsStandardBinder
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000C5A")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000284")]
	public string Name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C57")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000283")]
	public virtual Type ReturnType
	{
		[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
		[Token(Token = "0x6000C56")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x22B42B0", Offset = "0x22B36B0", Length = "0xB5")]
	[Token(Token = "0x6000C55")]
	protected SetMemberBinder(string name, bool ignoreCase) { }

	[Address(RVA = "0x22B4120", Offset = "0x22B3520", Length = "0x189")]
	[Token(Token = "0x6000C59")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2291290", Offset = "0x2290690", Length = "0x25")]
	[Token(Token = "0x6000C5B")]
	public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) { }

	[Token(Token = "0x6000C5C")]
	public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C58")]
	public bool get_IgnoreCase() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000C5A")]
	internal virtual bool get_IsStandardBinder() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C57")]
	public string get_Name() { }

	[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
	[Token(Token = "0x6000C56")]
	public virtual Type get_ReturnType() { }

}

