namespace System.ComponentModel;

[Token(Token = "0x20001A6")]
public class PropertyChangingEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000672")]
	private readonly string _propertyName; //Field offset: 0x10

	[Address(RVA = "0x26669A0", Offset = "0x2665DA0", Length = "0x65")]
	[Token(Token = "0x6000A2E")]
	public PropertyChangingEventArgs(string propertyName) { }

}

