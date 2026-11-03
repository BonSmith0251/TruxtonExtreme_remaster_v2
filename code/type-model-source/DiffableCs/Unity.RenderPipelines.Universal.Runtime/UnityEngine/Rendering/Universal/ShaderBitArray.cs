namespace UnityEngine.Rendering.Universal;

[DefaultMember("Item")]
[Token(Token = "0x20001A3")]
internal struct ShaderBitArray
{
	[Token(Token = "0x4000922")]
	private const int k_BitsPerElement = 32; //Field offset: 0x0
	[Token(Token = "0x4000923")]
	private const int k_ElementShift = 5; //Field offset: 0x0
	[Token(Token = "0x4000924")]
	private const int k_ElementMask = 31; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000925")]
	private Single[] m_Data; //Field offset: 0x0

	[Token(Token = "0x17000225")]
	public int bitCapacity
	{
		[Address(RVA = "0x2DEB500", Offset = "0x2DEA900", Length = "0x16")]
		[Token(Token = "0x6000903")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000226")]
	public Single[] data
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000904")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000224")]
	public int elemLength
	{
		[Address(RVA = "0x2DEB520", Offset = "0x2DEA920", Length = "0x10")]
		[Token(Token = "0x6000902")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000227")]
	public bool Item
	{
		[Address(RVA = "0x2DEB4B0", Offset = "0x2DEA8B0", Length = "0x4A")]
		[Token(Token = "0x6000908")]
		 get { } //Length: 74
		[Address(RVA = "0x2DEB530", Offset = "0x2DEA930", Length = "0x54")]
		[Token(Token = "0x6000909")]
		 set { } //Length: 84
	}

	[Address(RVA = "0x2DEB1D0", Offset = "0x2DEA5D0", Length = "0x4A")]
	[Token(Token = "0x6000906")]
	public void Clear() { }

	[Address(RVA = "0x2DEB500", Offset = "0x2DEA900", Length = "0x16")]
	[Token(Token = "0x6000903")]
	public int get_bitCapacity() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000904")]
	public Single[] get_data() { }

	[Address(RVA = "0x2DEB520", Offset = "0x2DEA920", Length = "0x10")]
	[Token(Token = "0x6000902")]
	public int get_elemLength() { }

	[Address(RVA = "0x2DEB4B0", Offset = "0x2DEA8B0", Length = "0x4A")]
	[Token(Token = "0x6000908")]
	public bool get_Item(int index) { }

	[Address(RVA = "0x2DEB220", Offset = "0x2DEA620", Length = "0xF")]
	[Token(Token = "0x6000907")]
	private void GetElementIndexAndBitOffset(int index, out int elemIndex, out int bitOffset) { }

	[Address(RVA = "0x2DEB230", Offset = "0x2DEA630", Length = "0x123")]
	[Token(Token = "0x6000905")]
	public void Resize(int bitCount) { }

	[Address(RVA = "0x2DEB530", Offset = "0x2DEA930", Length = "0x54")]
	[Token(Token = "0x6000909")]
	public void set_Item(int index, bool value) { }

	[Address(RVA = "0x2DEB360", Offset = "0x2DEA760", Length = "0x144")]
	[Token(Token = "0x600090A")]
	public virtual string ToString() { }

}

