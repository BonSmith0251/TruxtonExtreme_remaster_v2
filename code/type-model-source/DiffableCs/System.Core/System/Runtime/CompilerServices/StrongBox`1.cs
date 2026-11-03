namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000255")]
public class StrongBox : IStrongBox
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000430")]
	public T Value; //Field offset: 0x0

	[Token(Token = "0x17000258")]
	private override object System.Runtime.CompilerServices.IStrongBox.Value
	{
		[Address(RVA = "0xFCF5A0", Offset = "0xFCE9A0", Length = "0x28")]
		[Token(Token = "0x6000B7F")]
		private get { } //Length: 40
		[Address(RVA = "0xFCF750", Offset = "0xFCEB50", Length = "0x67")]
		[Token(Token = "0x6000B80")]
		private set { } //Length: 103
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B7D")]
	public StrongBox`1() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6000B7E")]
	public StrongBox`1(T value) { }

	[Address(RVA = "0xFCF5A0", Offset = "0xFCE9A0", Length = "0x28")]
	[Token(Token = "0x6000B7F")]
	private override object System.Runtime.CompilerServices.IStrongBox.get_Value() { }

	[Address(RVA = "0xFCF750", Offset = "0xFCEB50", Length = "0x67")]
	[Token(Token = "0x6000B80")]
	private override void System.Runtime.CompilerServices.IStrongBox.set_Value(object value) { }

}

