namespace UnityEngine.Rendering;

[Token(Token = "0x2000075")]
internal struct GPUInstanceIndex : IEquatable<GPUInstanceIndex>, IComparable<GPUInstanceIndex>
{
	[Token(Token = "0x400020F")]
	public static readonly GPUInstanceIndex Invalid; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020E")]
	private int <index>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000036")]
	public int index
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60001FC")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60001FD")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000037")]
	public bool valid
	{
		[Address(RVA = "0x2CE22F0", Offset = "0x2CE16F0", Length = "0x46")]
		[Token(Token = "0x60001FE")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x2CE22B0", Offset = "0x2CE16B0", Length = "0x39")]
	[Token(Token = "0x6000202")]
	private static GPUInstanceIndex() { }

	[Address(RVA = "0x2CE21A0", Offset = "0x2CE15A0", Length = "0x68")]
	[Token(Token = "0x6000200")]
	public override int CompareTo(GPUInstanceIndex other) { }

	[Address(RVA = "0x2CE2210", Offset = "0x2CE1610", Length = "0x50")]
	[Token(Token = "0x60001FF")]
	public override bool Equals(GPUInstanceIndex other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60001FC")]
	public int get_index() { }

	[Address(RVA = "0x2CE22F0", Offset = "0x2CE16F0", Length = "0x46")]
	[Token(Token = "0x60001FE")]
	public bool get_valid() { }

	[Address(RVA = "0x2CE2260", Offset = "0x2CE1660", Length = "0x42")]
	[Token(Token = "0x6000201")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60001FD")]
	public void set_index(int value) { }

}

