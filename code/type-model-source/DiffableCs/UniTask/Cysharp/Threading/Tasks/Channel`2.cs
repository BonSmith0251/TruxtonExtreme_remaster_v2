namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200001D")]
public abstract class Channel
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000057")]
	private ChannelReader<TRead> <Reader>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000058")]
	private ChannelWriter<TWrite> <Writer>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000015")]
	public ChannelReader<TRead> Reader
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000A6")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000A7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000016")]
	public ChannelWriter<TWrite> Writer
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000A8")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000A9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000AC")]
	protected Channel`2() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000A6")]
	public ChannelReader<TRead> get_Reader() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000A8")]
	public ChannelWriter<TWrite> get_Writer() { }

	[Address(RVA = "0x16D11F0", Offset = "0x16D05F0", Length = "0x7A")]
	[Token(Token = "0x60000AA")]
	public static ChannelReader<TRead> op_Implicit(Channel<TWrite, TRead> channel) { }

	[Address(RVA = "0x16D1170", Offset = "0x16D0570", Length = "0x7A")]
	[Token(Token = "0x60000AB")]
	public static ChannelWriter<TWrite> op_Implicit(Channel<TWrite, TRead> channel) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000A7")]
	protected void set_Reader(ChannelReader<TRead> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000A9")]
	protected void set_Writer(ChannelWriter<TWrite> value) { }

}

