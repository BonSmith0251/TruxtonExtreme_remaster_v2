namespace System.Dynamic;

[Token(Token = "0x2000263")]
public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400043F")]
	private readonly string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000440")]
	private readonly bool <IgnoreCase>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700025D")]
	public bool IgnoreCase
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BAC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700025C")]
	public string Name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BAB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2295720", Offset = "0x2294B20", Length = "0xA8")]
	[Token(Token = "0x6000BAF")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x1E57D60", Offset = "0x1E57160", Length = "0x17")]
	[Token(Token = "0x6000BAD")]
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) { }

	[Token(Token = "0x6000BAE")]
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BAC")]
	public bool get_IgnoreCase() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BAB")]
	public string get_Name() { }

}

