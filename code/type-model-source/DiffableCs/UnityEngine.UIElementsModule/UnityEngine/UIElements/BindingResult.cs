namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000024")]
public struct BindingResult
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000054")]
	private readonly BindingStatus <status>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000055")]
	private readonly string <message>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000029")]
	public string message
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000A6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000028")]
	public BindingStatus status
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60000A5")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
	[Token(Token = "0x60000A7")]
	public BindingResult(BindingStatus status, string message = null) { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000A6")]
	public string get_message() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60000A5")]
	public BindingStatus get_status() { }

}

