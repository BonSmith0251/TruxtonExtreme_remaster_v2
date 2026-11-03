namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Key = {Key}, Value = {Value}")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x2000127")]
public struct KeyValue
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004F4")]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004F5")]
	internal int m_Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004F6")]
	internal int m_Next; //Field offset: 0x0

	[Token(Token = "0x17000170")]
	public TKey Key
	{
		[Address(RVA = "0xAF0020", Offset = "0xAEF420", Length = "0xAE")]
		[Token(Token = "0x6000C4F")]
		 get { } //Length: 174
	}

	[Token(Token = "0x1700016F")]
	public static KeyValue<TKey, TValue> Null
	{
		[Address(RVA = "0xAC9B50", Offset = "0xAC8F50", Length = "0x11")]
		[Token(Token = "0x6000C4E")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000171")]
	public TValue Value
	{
		[Address(RVA = "0xAF0260", Offset = "0xAEF660", Length = "0x68")]
		[Token(Token = "0x6000C50")]
		 get { } //Length: 104
	}

	[Address(RVA = "0xAF0020", Offset = "0xAEF420", Length = "0xAE")]
	[Token(Token = "0x6000C4F")]
	public TKey get_Key() { }

	[Address(RVA = "0xAC9B50", Offset = "0xAC8F50", Length = "0x11")]
	[Token(Token = "0x6000C4E")]
	public static KeyValue<TKey, TValue> get_Null() { }

	[Address(RVA = "0xAF0260", Offset = "0xAEF660", Length = "0x68")]
	[Token(Token = "0x6000C50")]
	public TValue get_Value() { }

	[Address(RVA = "0xAEFAA0", Offset = "0xAEEEA0", Length = "0xED")]
	[Token(Token = "0x6000C51")]
	public bool GetKeyValue(out TKey key, out TValue value) { }

}

