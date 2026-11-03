namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
[Token(Token = "0x200061B")]
internal struct LayoutList : IDisposable
{
	[Token(Token = "0x200061C")]
	private struct Data
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001670")]
		public int Capacity; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001671")]
		public int Count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001672")]
		public T* Values; //Field offset: 0x0

	}

	[Token(Token = "0x400166E")]
	private static readonly MemoryLabel s_Label; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400166F")]
	private Data<T>* m_Data; //Field offset: 0x0

	[Token(Token = "0x17000AEF")]
	public int Count
	{
		[Address(RVA = "0xAFB9E0", Offset = "0xAFADE0", Length = "0x19")]
		[Token(Token = "0x6002B70")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000AF0")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x6002B71")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000AF1")]
	public T Item
	{
		[Address(RVA = "0xAFBAB0", Offset = "0xAFAEB0", Length = "0xF8")]
		[Token(Token = "0x6002B72")]
		 get { } //Length: 248
	}

	[Address(RVA = "0xAFB500", Offset = "0xAFA900", Length = "0xB0")]
	[Token(Token = "0x6002B7C")]
	private static LayoutList`1() { }

	[Address(RVA = "0x604930", Offset = "0x603D30", Length = "0x8")]
	[Token(Token = "0x6002B73")]
	public LayoutList`1() { }

	[Address(RVA = "0xAFB870", Offset = "0xAFAC70", Length = "0x16B")]
	[Token(Token = "0x6002B74")]
	public LayoutList`1(int initialCapacity) { }

	[Address(RVA = "0xAFA370", Offset = "0xAF9770", Length = "0x16F")]
	[Token(Token = "0x6002B75")]
	public override void Dispose() { }

	[Address(RVA = "0xAFA4E0", Offset = "0xAF98E0", Length = "0xA8")]
	[Token(Token = "0x6002B79")]
	private void EnsureCapacity(int capacity) { }

	[Address(RVA = "0xAFB9E0", Offset = "0xAFADE0", Length = "0x19")]
	[Token(Token = "0x6002B70")]
	public int get_Count() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[Token(Token = "0x6002B71")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xAFBAB0", Offset = "0xAFAEB0", Length = "0xF8")]
	[Token(Token = "0x6002B72")]
	public T get_Item(int index) { }

	[Address(RVA = "0xAFA670", Offset = "0xAF9A70", Length = "0xA4")]
	[Token(Token = "0x6002B78")]
	private void IncreaseCapacity() { }

	[Address(RVA = "0xAFA800", Offset = "0xAF9C00", Length = "0x165")]
	[Token(Token = "0x6002B76")]
	public void Insert(int index, T value) { }

	[Address(RVA = "0xAFAD60", Offset = "0xAFA160", Length = "0xEF")]
	[Token(Token = "0x6002B77")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xAFAE50", Offset = "0xAFA250", Length = "0x1E4")]
	[Token(Token = "0x6002B7B")]
	private static Void* ResizeArray(Void* fromPtr, long fromCount, long toCount, long size, int align) { }

	[Address(RVA = "0xAFB3D0", Offset = "0xAFA7D0", Length = "0x12F")]
	[Token(Token = "0x6002B7A")]
	private void ResizeCapacity(int capacity) { }

}

