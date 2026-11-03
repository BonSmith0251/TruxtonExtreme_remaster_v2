namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005F5")]
internal class ManagedObjectStore
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015CB")]
	private readonly int m_ChunkSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015CC")]
	private int m_Length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015CD")]
	private readonly List<T[]> m_Chunks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015CE")]
	private readonly Queue<Int32> m_Free; //Field offset: 0x0

	[Address(RVA = "0xCF7C70", Offset = "0xCF7070", Length = "0x194")]
	[Token(Token = "0x6002AAA")]
	public ManagedObjectStore`1(int chunkSize = 2048) { }

	[Address(RVA = "0xCF7260", Offset = "0xCF6660", Length = "0x5A")]
	[Token(Token = "0x6002AAB")]
	public T GetValue(int index) { }

	[Address(RVA = "0xCF7AE0", Offset = "0xCF6EE0", Length = "0x18F")]
	[Token(Token = "0x6002AAC")]
	public void UpdateValue(ref int index, T value) { }

}

