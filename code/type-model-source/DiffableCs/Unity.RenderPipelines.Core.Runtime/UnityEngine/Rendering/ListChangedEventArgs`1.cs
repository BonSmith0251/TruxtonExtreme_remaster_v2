namespace UnityEngine.Rendering;

[Token(Token = "0x200005E")]
public sealed class ListChangedEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014C")]
	public readonly int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014D")]
	public readonly T item; //Field offset: 0x0

	[Address(RVA = "0xB0AF10", Offset = "0xB0A310", Length = "0x74")]
	[Token(Token = "0x6000548")]
	public ListChangedEventArgs`1(int index, T item) { }

}

