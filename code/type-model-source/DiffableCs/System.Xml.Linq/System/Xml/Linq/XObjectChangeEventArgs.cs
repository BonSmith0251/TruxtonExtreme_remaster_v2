namespace System.Xml.Linq;

[Token(Token = "0x2000021")]
public class XObjectChangeEventArgs : EventArgs
{
	[Token(Token = "0x4000055")]
	public static readonly XObjectChangeEventArgs Add; //Field offset: 0x0
	[Token(Token = "0x4000056")]
	public static readonly XObjectChangeEventArgs Remove; //Field offset: 0x8
	[Token(Token = "0x4000057")]
	public static readonly XObjectChangeEventArgs Name; //Field offset: 0x10
	[Token(Token = "0x4000058")]
	public static readonly XObjectChangeEventArgs Value; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000054")]
	private XObjectChange _objectChange; //Field offset: 0x10

	[Address(RVA = "0x240E3E0", Offset = "0x240D7E0", Length = "0x216")]
	[Token(Token = "0x60000D7")]
	private static XObjectChangeEventArgs() { }

	[Address(RVA = "0x240E600", Offset = "0x240DA00", Length = "0x58")]
	[Token(Token = "0x60000D6")]
	public XObjectChangeEventArgs(XObjectChange objectChange) { }

}

