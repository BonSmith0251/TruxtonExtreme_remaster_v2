namespace Steamworks;

[AttributeUsage(AttributeTargets::Struct (8), AllowMultiple = False)]
[Token(Token = "0x200018A")]
internal class CallbackIdentityAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A5B")]
	private int <Identity>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000025")]
	public int Identity
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60008F0")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008F1")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x60008F2")]
	public CallbackIdentityAttribute(int callbackNum) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60008F0")]
	public int get_Identity() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008F1")]
	public void set_Identity(int value) { }

}

