namespace System.Net;

[Token(Token = "0x200022B")]
internal class ResponseDescription
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000843")]
	internal bool Multiline; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000844")]
	internal int Status; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000845")]
	internal string StatusDescription; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000846")]
	internal StringBuilder StatusBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000847")]
	internal string StatusCodeString; //Field offset: 0x28

	[Token(Token = "0x170002E9")]
	internal bool InvalidStatusCode
	{
		[Address(RVA = "0x26ABF00", Offset = "0x26AB300", Length = "0x14")]
		[Token(Token = "0x6000EAC")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x170002E8")]
	internal bool PermanentFailure
	{
		[Address(RVA = "0x26ABF20", Offset = "0x26AB320", Length = "0x17")]
		[Token(Token = "0x6000EAB")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x170002E6")]
	internal bool PositiveCompletion
	{
		[Address(RVA = "0x26ABF40", Offset = "0x26AB340", Length = "0x17")]
		[Token(Token = "0x6000EA9")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x170002E5")]
	internal bool PositiveIntermediate
	{
		[Address(RVA = "0x26ABF60", Offset = "0x26AB360", Length = "0x14")]
		[Token(Token = "0x6000EA8")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x170002E7")]
	internal bool TransientFailure
	{
		[Address(RVA = "0x26ABF80", Offset = "0x26AB380", Length = "0x17")]
		[Token(Token = "0x6000EAA")]
		internal get { } //Length: 23
	}

	[Address(RVA = "0x26ABE90", Offset = "0x26AB290", Length = "0x6D")]
	[Token(Token = "0x6000EAD")]
	public ResponseDescription() { }

	[Address(RVA = "0x26ABF00", Offset = "0x26AB300", Length = "0x14")]
	[Token(Token = "0x6000EAC")]
	internal bool get_InvalidStatusCode() { }

	[Address(RVA = "0x26ABF20", Offset = "0x26AB320", Length = "0x17")]
	[Token(Token = "0x6000EAB")]
	internal bool get_PermanentFailure() { }

	[Address(RVA = "0x26ABF40", Offset = "0x26AB340", Length = "0x17")]
	[Token(Token = "0x6000EA9")]
	internal bool get_PositiveCompletion() { }

	[Address(RVA = "0x26ABF60", Offset = "0x26AB360", Length = "0x14")]
	[Token(Token = "0x6000EA8")]
	internal bool get_PositiveIntermediate() { }

	[Address(RVA = "0x26ABF80", Offset = "0x26AB380", Length = "0x17")]
	[Token(Token = "0x6000EAA")]
	internal bool get_TransientFailure() { }

}

