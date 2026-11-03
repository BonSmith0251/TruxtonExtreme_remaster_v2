namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000031")]
public abstract class MessageBase
{
	[Token(Token = "0x4000090")]
	private static Byte[] header; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000091")]
	private int _type; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000092")]
	private NtlmFlags _flags; //Field offset: 0x14

	[Token(Token = "0x17000053")]
	public NtlmFlags Flags
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000120")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000121")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000054")]
	public int Type
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000122")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1E50F60", Offset = "0x1E50360", Length = "0x8C")]
	[Token(Token = "0x6000127")]
	private static MessageBase() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x600011F")]
	protected MessageBase(int messageType) { }

	[Address(RVA = "0x1E50AF0", Offset = "0x1E4FEF0", Length = "0x100")]
	[Token(Token = "0x6000125")]
	protected bool CheckHeader(Byte[] message) { }

	[Address(RVA = "0x1E50C00", Offset = "0x1E50000", Length = "0x26B")]
	[Token(Token = "0x6000124")]
	protected override void Decode(Byte[] message) { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000120")]
	public NtlmFlags get_Flags() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000122")]
	public int get_Type() { }

	[Token(Token = "0x6000126")]
	public abstract Byte[] GetBytes() { }

	[Address(RVA = "0x1E50E70", Offset = "0x1E50270", Length = "0xE3")]
	[Token(Token = "0x6000123")]
	protected Byte[] PrepareMessage(int messageSize) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000121")]
	public void set_Flags(NtlmFlags value) { }

}

