namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000BF")]
internal class NoThrowSetBinderMember : SetMemberBinder
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400043B")]
	private readonly SetMemberBinder _innerBinder; //Field offset: 0x28

	[Address(RVA = "0x212BC10", Offset = "0x212B010", Length = "0x45")]
	[Token(Token = "0x60005F5")]
	public NoThrowSetBinderMember(SetMemberBinder innerBinder) { }

	[Address(RVA = "0x212BAA0", Offset = "0x212AEA0", Length = "0x169")]
	[Token(Token = "0x60005F6")]
	public virtual DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

