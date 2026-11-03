namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[Token(Token = "0x200054B")]
public class EventInterestAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001199")]
	internal Type[] eventTypes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400119A")]
	internal EventCategoryFlags categoryFlags; //Field offset: 0x18

	[Address(RVA = "0x32B9430", Offset = "0x32B8830", Length = "0x38")]
	[Token(Token = "0x60026C9")]
	public EventInterestAttribute(Type[] eventTypes) { }

	[Address(RVA = "0x32B9400", Offset = "0x32B8800", Length = "0x2B")]
	[Token(Token = "0x60026CA")]
	public EventInterestAttribute(EventInterestOptions interests) { }

	[Address(RVA = "0x32B9400", Offset = "0x32B8800", Length = "0x2B")]
	[Token(Token = "0x60026CB")]
	internal EventInterestAttribute(EventInterestOptionsInternal interests) { }

}

