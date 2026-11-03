namespace System.Threading;

[Token(Token = "0x2000205")]
public struct SpinWait
{
	[Token(Token = "0x40009A3")]
	internal static readonly int SpinCountforSpinBeforeWait; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A4")]
	private int _count; //Field offset: 0x0

	[Token(Token = "0x17000193")]
	public int Count
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60011C6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000194")]
	public bool NextSpinWillYield
	{
		[Address(RVA = "0x20A58A0", Offset = "0x20A4CA0", Length = "0x62")]
		[Token(Token = "0x60011C7")]
		 get { } //Length: 98
	}

	[Address(RVA = "0x20A5820", Offset = "0x20A4C20", Length = "0x78")]
	[Token(Token = "0x60011CB")]
	private static SpinWait() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60011C6")]
	public int get_Count() { }

	[Address(RVA = "0x20A58A0", Offset = "0x20A4CA0", Length = "0x62")]
	[Token(Token = "0x60011C7")]
	public bool get_NextSpinWillYield() { }

	[Address(RVA = "0x20A56E0", Offset = "0x20A4AE0", Length = "0x4F")]
	[Token(Token = "0x60011C8")]
	public void SpinOnce() { }

	[Address(RVA = "0x20A5730", Offset = "0x20A4B30", Length = "0xEC")]
	[Token(Token = "0x60011C9")]
	public void SpinOnce(int sleep1Threshold) { }

	[Address(RVA = "0x20A5550", Offset = "0x20A4950", Length = "0x187")]
	[Token(Token = "0x60011CA")]
	private void SpinOnceCore(int sleep1Threshold) { }

}

