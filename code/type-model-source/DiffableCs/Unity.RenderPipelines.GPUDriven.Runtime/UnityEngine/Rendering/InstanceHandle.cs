namespace UnityEngine.Rendering;

[Token(Token = "0x2000073")]
internal struct InstanceHandle : IEquatable<InstanceHandle>, IComparable<InstanceHandle>
{
	[Token(Token = "0x400020B")]
	public static readonly InstanceHandle Invalid; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020A")]
	private int <index>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000030")]
	public private int index
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60001EA")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60001EB")]
		private set { } //Length: 3
	}

	[Token(Token = "0x17000031")]
	public int instanceIndex
	{
		[Address(RVA = "0x2CEC8A0", Offset = "0x2CEBCA0", Length = "0x44")]
		[Token(Token = "0x60001EC")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000032")]
	public InstanceType type
	{
		[Address(RVA = "0x2CEC8F0", Offset = "0x2CEBCF0", Length = "0x45")]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000033")]
	public bool valid
	{
		[Address(RVA = "0x2CEC940", Offset = "0x2CEBD40", Length = "0x46")]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x2CEC860", Offset = "0x2CEBC60", Length = "0x39")]
	[Token(Token = "0x60001F4")]
	private static InstanceHandle() { }

	[Address(RVA = "0x2CEC6B0", Offset = "0x2CEBAB0", Length = "0x68")]
	[Token(Token = "0x60001F2")]
	public override int CompareTo(InstanceHandle other) { }

	[Address(RVA = "0x2CEC720", Offset = "0x2CEBB20", Length = "0x4F")]
	[Token(Token = "0x60001EF")]
	public static InstanceHandle Create(int instanceIndex, InstanceType instanceType) { }

	[Address(RVA = "0x2CEC770", Offset = "0x2CEBB70", Length = "0x50")]
	[Token(Token = "0x60001F1")]
	public override bool Equals(InstanceHandle other) { }

	[Address(RVA = "0x2CEC7C0", Offset = "0x2CEBBC0", Length = "0x41")]
	[Token(Token = "0x60001F0")]
	public static InstanceHandle FromInt(int value) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60001EA")]
	public int get_index() { }

	[Address(RVA = "0x2CEC8A0", Offset = "0x2CEBCA0", Length = "0x44")]
	[Token(Token = "0x60001EC")]
	public int get_instanceIndex() { }

	[Address(RVA = "0x2CEC8F0", Offset = "0x2CEBCF0", Length = "0x45")]
	[Token(Token = "0x60001ED")]
	public InstanceType get_type() { }

	[Address(RVA = "0x2CEC940", Offset = "0x2CEBD40", Length = "0x46")]
	[Token(Token = "0x60001EE")]
	public bool get_valid() { }

	[Address(RVA = "0x2CEC810", Offset = "0x2CEBC10", Length = "0x42")]
	[Token(Token = "0x60001F3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60001EB")]
	private void set_index(int value) { }

}

