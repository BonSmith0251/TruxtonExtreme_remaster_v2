namespace System.ComponentModel;

[Token(Token = "0x20001A4")]
public class PropertyChangedEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000671")]
	private readonly string _propertyName; //Field offset: 0x10

	[Address(RVA = "0x2666930", Offset = "0x2665D30", Length = "0x65")]
	[Token(Token = "0x6000A2B")]
	public PropertyChangedEventArgs(string propertyName) { }

}

