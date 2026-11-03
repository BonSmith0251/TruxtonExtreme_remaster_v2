namespace System.Xml.Schema;

[Token(Token = "0x200015D")]
internal class UpaException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000751")]
	private object particle1; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000752")]
	private object particle2; //Field offset: 0x98

	[Token(Token = "0x170003E2")]
	public object Particle1
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000EF2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003E3")]
	public object Particle2
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6000EF3")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x258B8A0", Offset = "0x258ACA0", Length = "0x8E")]
	[Token(Token = "0x6000EF1")]
	public UpaException(object particle1, object particle2) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000EF2")]
	public object get_Particle1() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6000EF3")]
	public object get_Particle2() { }

}

