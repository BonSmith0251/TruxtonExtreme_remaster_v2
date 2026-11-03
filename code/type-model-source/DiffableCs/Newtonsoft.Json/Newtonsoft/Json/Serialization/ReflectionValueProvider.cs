namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000138")]
public class ReflectionValueProvider : IValueProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BD")]
	private readonly MemberInfo _memberInfo; //Field offset: 0x10

	[Address(RVA = "0x216D4B0", Offset = "0x216C8B0", Length = "0x62")]
	[Token(Token = "0x6000991")]
	public ReflectionValueProvider(MemberInfo memberInfo) { }

	[Address(RVA = "0x216D120", Offset = "0x216C520", Length = "0x235")]
	[Token(Token = "0x6000993")]
	public override object GetValue(object target) { }

	[Address(RVA = "0x216D360", Offset = "0x216C760", Length = "0x14D")]
	[Token(Token = "0x6000992")]
	public override void SetValue(object target, object value) { }

}

