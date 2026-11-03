namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x2000596")]
public sealed class EventSourceAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001791")]
	private string <Guid>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001792")]
	private string <Name>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700060C")]
	public string Guid
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002929")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700060D")]
	public string Name
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600292A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600292B")]
	public EventSourceAttribute() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002929")]
	public void set_Guid(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600292A")]
	public void set_Name(string value) { }

}

