namespace Unity.Collections;

[DebuggerDisplay("Key = {Key}, Value = {Value}")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x200008F")]
public struct KVPair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B5")]
	internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B6")]
	internal int m_Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B7")]
	internal int m_Next; //Field offset: 0x0

	[Token(Token = "0x170000B2")]
	public TKey Key
	{
		[Address(RVA = "0xAC9A20", Offset = "0xAC8E20", Length = "0x2E")]
		[Token(Token = "0x6000721")]
		 get { } //Length: 46
	}

	[Token(Token = "0x170000B1")]
	public static KVPair<TKey, TValue> Null
	{
		[Address(RVA = "0xAC9B50", Offset = "0xAC8F50", Length = "0x11")]
		[Token(Token = "0x6000720")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000B3")]
	public TValue Value
	{
		[Address(RVA = "0xAC9B70", Offset = "0xAC8F70", Length = "0x4E")]
		[Token(Token = "0x6000722")]
		 get { } //Length: 78
	}

	[Address(RVA = "0xAC9A20", Offset = "0xAC8E20", Length = "0x2E")]
	[Token(Token = "0x6000721")]
	public TKey get_Key() { }

	[Address(RVA = "0xAC9B50", Offset = "0xAC8F50", Length = "0x11")]
	[Token(Token = "0x6000720")]
	public static KVPair<TKey, TValue> get_Null() { }

	[Address(RVA = "0xAC9B70", Offset = "0xAC8F70", Length = "0x4E")]
	[Token(Token = "0x6000722")]
	public TValue get_Value() { }

	[Address(RVA = "0xAC99A0", Offset = "0xAC8DA0", Length = "0x7B")]
	[Token(Token = "0x6000723")]
	public bool GetKeyValue(out TKey key, out TValue value) { }

}

