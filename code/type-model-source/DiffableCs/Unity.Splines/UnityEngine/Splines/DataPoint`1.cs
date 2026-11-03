namespace UnityEngine.Splines;

[Token(Token = "0x200000C")]
public struct DataPoint : IComparable<DataPoint`1<TDataType>>, IComparable<Single>, IDataPoint
{
	[FieldOffset(Offset = "0x0")]
	[FormerlySerializedAs("m_Time")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	private float m_Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400001F")]
	private TDataType m_Value; //Field offset: 0x0

	[Token(Token = "0x17000004")]
	public override float Index
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x600003A")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x600003B")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public TDataType Value
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x600003C")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x600003D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x12F1440", Offset = "0x12F0840", Length = "0x9")]
	[Token(Token = "0x600003E")]
	public DataPoint`1(float index, TDataType value) { }

	[Address(RVA = "0x17CABA0", Offset = "0x17C9FA0", Length = "0x69")]
	[Token(Token = "0x600003F")]
	public override int CompareTo(DataPoint<TDataType> other) { }

	[Address(RVA = "0x17CA960", Offset = "0x17C9D60", Length = "0x50")]
	[Token(Token = "0x6000040")]
	public override int CompareTo(float other) { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x600003A")]
	public override float get_Index() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x600003C")]
	public TDataType get_Value() { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x600003B")]
	public override void set_Index(float value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x600003D")]
	public void set_Value(TDataType value) { }

	[Address(RVA = "0x17CAC10", Offset = "0x17CA010", Length = "0xC9")]
	[Token(Token = "0x6000041")]
	public virtual string ToString() { }

}

