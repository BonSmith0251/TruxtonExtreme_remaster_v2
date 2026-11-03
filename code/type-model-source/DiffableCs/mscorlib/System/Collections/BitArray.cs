namespace System.Collections;

[DefaultMember("Item")]
[Token(Token = "0x20005C2")]
public sealed class BitArray : ICollection, IEnumerable, ICloneable
{
	[Token(Token = "0x20005C3")]
	private class BitArrayEnumeratorSimple : IEnumerator, ICloneable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017EB")]
		private BitArray bitarray; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017EC")]
		private int index; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40017ED")]
		private int version; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017EE")]
		private bool currentElement; //Field offset: 0x20

		[Token(Token = "0x1700066C")]
		public override object Current
		{
			[Address(RVA = "0x1FBD600", Offset = "0x1FBCA00", Length = "0x110")]
			[Token(Token = "0x6002A5A")]
			 get { } //Length: 272
		}

		[Address(RVA = "0x1FBD5B0", Offset = "0x1FBC9B0", Length = "0x49")]
		[Token(Token = "0x6002A57")]
		internal BitArrayEnumeratorSimple(BitArray bitarray) { }

		[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
		[Token(Token = "0x6002A58")]
		public override object Clone() { }

		[Address(RVA = "0x1FBD600", Offset = "0x1FBCA00", Length = "0x110")]
		[Token(Token = "0x6002A5A")]
		public override object get_Current() { }

		[Address(RVA = "0x1FBD420", Offset = "0x1FBC820", Length = "0x10A")]
		[Token(Token = "0x6002A59")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1FBD530", Offset = "0x1FBC930", Length = "0x79")]
		[Token(Token = "0x6002A5B")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017E7")]
	private Int32[] m_array; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017E8")]
	private int m_length; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40017E9")]
	private int _version; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017EA")]
	private object _syncRoot; //Field offset: 0x20

	[Token(Token = "0x17000669")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002A51")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700066B")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002A53")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000667")]
	public bool Item
	{
		[Address(RVA = "0x1FBEAC0", Offset = "0x1FBDEC0", Length = "0x8")]
		[Token(Token = "0x6002A47")]
		 get { } //Length: 8
		[Address(RVA = "0x1FBEB40", Offset = "0x1FBDF40", Length = "0x11F")]
		[Token(Token = "0x6002A48")]
		 set { } //Length: 287
	}

	[Token(Token = "0x17000668")]
	public int Length
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002A4E")]
		 get { } //Length: 4
		[Address(RVA = "0x1FBEC60", Offset = "0x1FBE060", Length = "0x196")]
		[Token(Token = "0x6002A4F")]
		 set { } //Length: 406
	}

	[Token(Token = "0x1700066A")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FBEAD0", Offset = "0x1FBDED0", Length = "0x68")]
		[Token(Token = "0x6002A52")]
		 get { } //Length: 104
	}

	[Address(RVA = "0x1FBE560", Offset = "0x1FBD960", Length = "0x16A")]
	[Token(Token = "0x6002A43")]
	public BitArray(int length) { }

	[Address(RVA = "0x1FBE3E0", Offset = "0x1FBD7E0", Length = "0x176")]
	[Token(Token = "0x6002A44")]
	public BitArray(int length, bool defaultValue) { }

	[Address(RVA = "0x1FBE6D0", Offset = "0x1FBDAD0", Length = "0x2ED")]
	[Token(Token = "0x6002A45")]
	public BitArray(Byte[] bytes) { }

	[Address(RVA = "0x1FBE9C0", Offset = "0x1FBDDC0", Length = "0xFA")]
	[Token(Token = "0x6002A46")]
	public BitArray(BitArray bits) { }

	[Address(RVA = "0x1FBD720", Offset = "0x1FBCB20", Length = "0x125")]
	[Token(Token = "0x6002A54")]
	public override object Clone() { }

	[Address(RVA = "0x1FBD850", Offset = "0x1FBCC50", Length = "0x5F2")]
	[Token(Token = "0x6002A50")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x1FBDEF0", Offset = "0x1FBD2F0", Length = "0xEB")]
	[Token(Token = "0x6002A49")]
	public bool Get(int index) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002A51")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002A53")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1FBEAC0", Offset = "0x1FBDEC0", Length = "0x8")]
	[Token(Token = "0x6002A47")]
	public bool get_Item(int index) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002A4E")]
	public int get_Length() { }

	[Address(RVA = "0x1FBEAD0", Offset = "0x1FBDED0", Length = "0x68")]
	[Token(Token = "0x6002A52")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FBDE50", Offset = "0x1FBD250", Length = "0x14")]
	[Token(Token = "0x6002A56")]
	private static int GetArrayLength(int n, int div) { }

	[Address(RVA = "0x1FBDE70", Offset = "0x1FBD270", Length = "0x77")]
	[Token(Token = "0x6002A55")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FBDFE0", Offset = "0x1FBD3E0", Length = "0x124")]
	[Token(Token = "0x6002A4C")]
	public BitArray Or(BitArray value) { }

	[Address(RVA = "0x1FBE190", Offset = "0x1FBD590", Length = "0x11F")]
	[Token(Token = "0x6002A4A")]
	public void Set(int index, bool value) { }

	[Address(RVA = "0x1FBEB40", Offset = "0x1FBDF40", Length = "0x11F")]
	[Token(Token = "0x6002A48")]
	public void set_Item(int index, bool value) { }

	[Address(RVA = "0x1FBEC60", Offset = "0x1FBE060", Length = "0x196")]
	[Token(Token = "0x6002A4F")]
	public void set_Length(int value) { }

	[Address(RVA = "0x1FBE110", Offset = "0x1FBD510", Length = "0x76")]
	[Token(Token = "0x6002A4B")]
	public void SetAll(bool value) { }

	[Address(RVA = "0x1FBE2B0", Offset = "0x1FBD6B0", Length = "0x124")]
	[Token(Token = "0x6002A4D")]
	public BitArray Xor(BitArray value) { }

}

