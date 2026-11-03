namespace UnityEngine.Rendering;

[Token(Token = "0x2000030")]
public class ContextContainer : IDisposable
{
	[Token(Token = "0x2000032")]
	private struct Item
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C1")]
		public ContextItem storage; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000C2")]
		public bool isSet; //Field offset: 0x8

	}

	[Token(Token = "0x2000031")]
	private static class TypeId
	{
		[Token(Token = "0x40000C0")]
		public static uint value; //Field offset: 0x0

		[Address(RVA = "0x10DF6B0", Offset = "0x10DEAB0", Length = "0x94")]
		[Token(Token = "0x6000483")]
		private static TypeId`1() { }

	}

	[Token(Token = "0x40000BF")]
	private static uint s_TypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BD")]
	private Item[] m_Items; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BE")]
	private List<UInt32> m_ActiveItemIndices; //Field offset: 0x18

	[Address(RVA = "0x2BBDF50", Offset = "0x2BBD350", Length = "0xA4")]
	[Token(Token = "0x6000482")]
	public ContextContainer() { }

	[Address(RVA = "0x7AA660", Offset = "0x7A9A60", Length = "0xB0")]
	[Token(Token = "0x600047E")]
	public bool Contains() { }

	[Address(RVA = "0x2BBDD60", Offset = "0x2BBD160", Length = "0x42")]
	[Token(Token = "0x600047F")]
	private bool Contains(uint typeId) { }

	[Address(RVA = "0x7AA9A0", Offset = "0x7A9DA0", Length = "0x166")]
	[Token(Token = "0x600047C")]
	public T Create() { }

	[Address(RVA = "0x7AA720", Offset = "0x7A9B20", Length = "0x274")]
	[Token(Token = "0x6000480")]
	private T CreateAndGetData(uint typeId) { }

	[Address(RVA = "0x2BBDDB0", Offset = "0x2BBD1B0", Length = "0x19A")]
	[Token(Token = "0x6000481")]
	public override void Dispose() { }

	[Address(RVA = "0x5D2AF0", Offset = "0x5D1EF0", Length = "0x3E1")]
	[Token(Token = "0x600047B")]
	public T Get() { }

	[Address(RVA = "0x7AAB10", Offset = "0x7A9F10", Length = "0x11F")]
	[Token(Token = "0x600047D")]
	public T GetOrCreate() { }

}

