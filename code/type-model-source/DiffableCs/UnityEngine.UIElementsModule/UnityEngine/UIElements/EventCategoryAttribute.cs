namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200054C")]
internal class EventCategoryAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400119B")]
	internal EventCategory category; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x60026CC")]
	public EventCategoryAttribute(EventCategory category) { }

}

