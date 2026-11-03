namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000593")]
public sealed class EventAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001789")]
	private int <EventId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400178A")]
	private EventLevel <Level>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400178B")]
	private EventKeywords <Keywords>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400178C")]
	private string <Message>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000604")]
	private int EventId
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002910")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000606")]
	public EventKeywords Keywords
	{
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002912")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000605")]
	public EventLevel Level
	{
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002911")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000607")]
	public string Message
	{
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002913")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600290F")]
	public EventAttribute(int eventId) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002910")]
	private void set_EventId(int value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002912")]
	public void set_Keywords(EventKeywords value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002911")]
	public void set_Level(EventLevel value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002913")]
	public void set_Message(string value) { }

}

