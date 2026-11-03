namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DefaultMember("Item")]
[Token(Token = "0x20002CA")]
internal class ResourcesData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D03")]
	public NativeList<ResourceUnversionedData>[] unversionedData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D04")]
	public NativeList<ResourceVersionedData>[] versionedData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D05")]
	public NativeList<ResourceReaderData>[] readerData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D06")]
	public Int32[] MaxVersions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D07")]
	public Int32[] MaxReaders; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D08")]
	public DynamicArray<Name>[] resourceNames; //Field offset: 0x38

	[Token(Token = "0x17000269")]
	public ResourceVersionedData Item
	{
		[Address(RVA = "0x2CBF3B0", Offset = "0x2CBE7B0", Length = "0x162")]
		[Token(Token = "0x60013BE")]
		 get { } //Length: 354
	}

	[Address(RVA = "0x2CBF1B0", Offset = "0x2CBE5B0", Length = "0x1FF")]
	[Token(Token = "0x60013B8")]
	public ResourcesData() { }

	[Address(RVA = "0x8EEF20", Offset = "0x8EE320", Length = "0xC3")]
	[Token(Token = "0x60013BA")]
	private void AllocateAndResizeNativeListIfNeeded(ref NativeList<T>& nativeList, int size, NativeArrayOptions options) { }

	[Address(RVA = "0x2CBE4F0", Offset = "0x2CBD8F0", Length = "0x161")]
	[Token(Token = "0x60013B9")]
	public void Clear() { }

	[Address(RVA = "0x2CBE660", Offset = "0x2CBDA60", Length = "0x127")]
	[Token(Token = "0x60013BF")]
	public void Dispose() { }

	[Address(RVA = "0x2CBF3B0", Offset = "0x2CBE7B0", Length = "0x162")]
	[Token(Token = "0x60013BE")]
	public ResourceVersionedData get_Item(ResourceHandle h) { }

	[Address(RVA = "0x2CBE8C0", Offset = "0x2CBDCC0", Length = "0xB1")]
	[Token(Token = "0x60013BC")]
	public int Index(in ResourceHandle h) { }

	[Address(RVA = "0x2CBE790", Offset = "0x2CBDB90", Length = "0x121")]
	[Token(Token = "0x60013BD")]
	public int IndexReader(in ResourceHandle h, int readerID) { }

	[Address(RVA = "0x2CBE980", Offset = "0x2CBDD80", Length = "0x82B")]
	[Token(Token = "0x60013BB")]
	public void Initialize(RenderGraphResourceRegistry resources) { }

}

