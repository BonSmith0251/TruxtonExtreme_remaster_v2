namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000BE")]
internal class NoThrowGetBinderMember : GetMemberBinder
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400043A")]
	private readonly GetMemberBinder _innerBinder; //Field offset: 0x28

	[Address(RVA = "0x212BA50", Offset = "0x212AE50", Length = "0x45")]
	[Token(Token = "0x60005F3")]
	public NoThrowGetBinderMember(GetMemberBinder innerBinder) { }

	[Address(RVA = "0x212B8F0", Offset = "0x212ACF0", Length = "0x152")]
	[Token(Token = "0x60005F4")]
	public virtual DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

