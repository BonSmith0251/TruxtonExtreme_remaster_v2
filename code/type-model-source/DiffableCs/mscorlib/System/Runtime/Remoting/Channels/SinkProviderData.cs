namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x2000390")]
public class SinkProviderData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E78")]
	private string sinkName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E79")]
	private ArrayList children; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E7A")]
	private Hashtable properties; //Field offset: 0x20

	[Token(Token = "0x1700030B")]
	public IList Children
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001C0B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700030C")]
	public IDictionary Properties
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001C0C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F14770", Offset = "0x1F13B70", Length = "0xAE")]
	[Token(Token = "0x6001C0A")]
	public SinkProviderData(string name) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001C0B")]
	public IList get_Children() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001C0C")]
	public IDictionary get_Properties() { }

}

