namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000037")]
public class Type3Message : MessageBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A9")]
	private NtlmAuthLevel _level; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AA")]
	private Byte[] _challenge; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AB")]
	private string _host; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000AC")]
	private string _domain; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000AD")]
	private string _username; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000AE")]
	private string _password; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000AF")]
	private Type2Message _type2; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000B0")]
	private Byte[] _lm; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000B1")]
	private Byte[] _nt; //Field offset: 0x58

	[Token(Token = "0x1700005B")]
	public string Domain
	{
		[Address(RVA = "0x1E59920", Offset = "0x1E58D20", Length = "0x79")]
		[Token(Token = "0x6000138")]
		 set { } //Length: 121
	}

	[Token(Token = "0x1700005C")]
	public string Password
	{
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000139")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700005D")]
	public string Username
	{
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600013A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1E59690", Offset = "0x1E58A90", Length = "0x289")]
	[Token(Token = "0x6000136")]
	public Type3Message(Type2Message type2) { }

	[Address(RVA = "0x1E58AB0", Offset = "0x1E57EB0", Length = "0x2C1")]
	[Token(Token = "0x600013B")]
	protected virtual void Decode(Byte[] message) { }

	[Address(RVA = "0x1E58A40", Offset = "0x1E57E40", Length = "0x6C")]
	[Token(Token = "0x600013C")]
	private string DecodeString(Byte[] buffer, int offset, int len) { }

	[Address(RVA = "0x1E58D80", Offset = "0x1E58180", Length = "0x8B")]
	[Token(Token = "0x600013D")]
	private Byte[] EncodeString(string text) { }

	[Address(RVA = "0x1E58E10", Offset = "0x1E58210", Length = "0xB0")]
	[Token(Token = "0x6000137")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1E58ED0", Offset = "0x1E582D0", Length = "0x7B5")]
	[Token(Token = "0x600013E")]
	public virtual Byte[] GetBytes() { }

	[Address(RVA = "0x1E59920", Offset = "0x1E58D20", Length = "0x79")]
	[Token(Token = "0x6000138")]
	public void set_Domain(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000139")]
	public void set_Password(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600013A")]
	public void set_Username(string value) { }

}

