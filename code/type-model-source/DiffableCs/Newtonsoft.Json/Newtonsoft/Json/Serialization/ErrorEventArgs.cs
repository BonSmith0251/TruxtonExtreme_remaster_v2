namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200010B")]
public class ErrorEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Nullable(2)]
	[Token(Token = "0x400050D")]
	private readonly object <CurrentObject>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400050E")]
	private readonly ErrorContext <ErrorContext>k__BackingField; //Field offset: 0x18

	[Nullable(2)]
	[Token(Token = "0x170000F6")]
	public object CurrentObject
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x60007BC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F7")]
	public ErrorContext ErrorContext
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007BD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x213E0B0", Offset = "0x213D4B0", Length = "0x82")]
	[Token(Token = "0x60007BE")]
	public ErrorEventArgs(object currentObject, ErrorContext errorContext) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x60007BC")]
	public object get_CurrentObject() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007BD")]
	public ErrorContext get_ErrorContext() { }

}

