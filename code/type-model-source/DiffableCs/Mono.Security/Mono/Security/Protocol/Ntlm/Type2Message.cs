namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000036")]
public class Type2Message : MessageBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A6")]
	private Byte[] _nonce; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A7")]
	private string _targetName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A8")]
	private Byte[] _targetInfo; //Field offset: 0x28

	[Token(Token = "0x17000058")]
	public Byte[] Nonce
	{
		[Address(RVA = "0x1E58940", Offset = "0x1E57D40", Length = "0x77")]
		[Token(Token = "0x6000131")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700005A")]
	public Byte[] TargetInfo
	{
		[Address(RVA = "0x1E589C0", Offset = "0x1E57DC0", Length = "0x77")]
		[Token(Token = "0x6000133")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000059")]
	public string TargetName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000132")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E58890", Offset = "0x1E57C90", Length = "0xA3")]
	[Token(Token = "0x600012F")]
	public Type2Message(Byte[] message) { }

	[Address(RVA = "0x1E585C0", Offset = "0x1E579C0", Length = "0x189")]
	[Token(Token = "0x6000134")]
	protected virtual void Decode(Byte[] message) { }

	[Address(RVA = "0x1E58750", Offset = "0x1E57B50", Length = "0x6C")]
	[Token(Token = "0x6000130")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1E58940", Offset = "0x1E57D40", Length = "0x77")]
	[Token(Token = "0x6000131")]
	public Byte[] get_Nonce() { }

	[Address(RVA = "0x1E589C0", Offset = "0x1E57DC0", Length = "0x77")]
	[Token(Token = "0x6000133")]
	public Byte[] get_TargetInfo() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000132")]
	public string get_TargetName() { }

	[Address(RVA = "0x1E587C0", Offset = "0x1E57BC0", Length = "0xC7")]
	[Token(Token = "0x6000135")]
	public virtual Byte[] GetBytes() { }

}

