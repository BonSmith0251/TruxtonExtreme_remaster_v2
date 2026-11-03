namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000239")]
internal class ImmutableList
{
	[Token(Token = "0x4000612")]
	public static readonly ImmutableList<T> Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000613")]
	private T[] data; //Field offset: 0x0

	[Token(Token = "0x17000078")]
	public T[] Data
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000CB0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1C74A60", Offset = "0x1C73E60", Length = "0x13B")]
	[Token(Token = "0x6000CB6")]
	private static ImmutableList`1() { }

	[Address(RVA = "0x1C74BA0", Offset = "0x1C73FA0", Length = "0x5B")]
	[Token(Token = "0x6000CB1")]
	private ImmutableList`1() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000CB2")]
	public ImmutableList`1(T[] data) { }

	[Address(RVA = "0x1C74020", Offset = "0x1C73420", Length = "0x10E")]
	[Token(Token = "0x6000CB3")]
	public ImmutableList<T> Add(T value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000CB0")]
	public T[] get_Data() { }

	[Address(RVA = "0x1C74310", Offset = "0x1C73710", Length = "0x94")]
	[Token(Token = "0x6000CB5")]
	public int IndexOf(T value) { }

	[Address(RVA = "0x1C74760", Offset = "0x1C73B60", Length = "0x1DD")]
	[Token(Token = "0x6000CB4")]
	public ImmutableList<T> Remove(T value) { }

}

