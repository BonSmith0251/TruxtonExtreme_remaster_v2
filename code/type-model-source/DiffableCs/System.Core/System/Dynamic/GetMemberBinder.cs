namespace System.Dynamic;

[Token(Token = "0x2000274")]
public abstract class GetMemberBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000479")]
	private readonly string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400047A")]
	private readonly bool <IgnoreCase>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700027F")]
	public bool IgnoreCase
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C43")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000280")]
	internal virtual bool IsStandardBinder
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000C47")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700027E")]
	public string Name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C42")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700027D")]
	public virtual Type ReturnType
	{
		[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
		[Token(Token = "0x6000C41")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x22AFC20", Offset = "0x22AF020", Length = "0xB5")]
	[Token(Token = "0x6000C40")]
	protected GetMemberBinder(string name, bool ignoreCase) { }

	[Address(RVA = "0x22AFB30", Offset = "0x22AEF30", Length = "0xEF")]
	[Token(Token = "0x6000C46")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x1E57D60", Offset = "0x1E57160", Length = "0x17")]
	[Token(Token = "0x6000C44")]
	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) { }

	[Token(Token = "0x6000C45")]
	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C43")]
	public bool get_IgnoreCase() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000C47")]
	internal virtual bool get_IsStandardBinder() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C42")]
	public string get_Name() { }

	[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
	[Token(Token = "0x6000C41")]
	public virtual Type get_ReturnType() { }

}

