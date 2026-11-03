namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002B2")]
internal class CompilerContextData : IDisposable, ICompiledGraph
{
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x20002B4")]
	internal struct NativePassIterator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C3D")]
		private readonly CompilerContextData m_Ctx; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C3E")]
		private int m_Index; //Field offset: 0x8

		[IsReadOnly]
		[Token(Token = "0x17000264")]
		public NativePassData Current
		{
			[Address(RVA = "0x2C9BF70", Offset = "0x2C9B370", Length = "0x4A")]
			[Token(Token = "0x6001346")]
			 get { } //Length: 74
		}

		[Address(RVA = "0x2C9BF60", Offset = "0x2C9B360", Length = "0xB")]
		[Token(Token = "0x6001345")]
		public NativePassIterator(CompilerContextData ctx) { }

		[Address(RVA = "0x2C9BF70", Offset = "0x2C9B370", Length = "0x4A")]
		[Token(Token = "0x6001346")]
		public NativePassData get_Current() { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x6001348")]
		public NativePassIterator GetEnumerator() { }

		[Address(RVA = "0x2C9BEA0", Offset = "0x2C9B2A0", Length = "0xB1")]
		[Token(Token = "0x6001347")]
		public bool MoveNext() { }

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x20002B3")]
	internal struct PassIterator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C3B")]
		private readonly CompilerContextData m_Ctx; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C3C")]
		private int m_Index; //Field offset: 0x8

		[IsReadOnly]
		[Token(Token = "0x17000263")]
		public PassData Current
		{
			[Address(RVA = "0x2C9C030", Offset = "0x2C9B430", Length = "0x4A")]
			[Token(Token = "0x6001342")]
			 get { } //Length: 74
		}

		[Address(RVA = "0x2C9BF60", Offset = "0x2C9B360", Length = "0xB")]
		[Token(Token = "0x6001341")]
		public PassIterator(CompilerContextData ctx) { }

		[Address(RVA = "0x2C9C030", Offset = "0x2C9B430", Length = "0x4A")]
		[Token(Token = "0x6001342")]
		public PassData get_Current() { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x6001344")]
		public PassIterator GetEnumerator() { }

		[Address(RVA = "0x2C9BFC0", Offset = "0x2C9B3C0", Length = "0x6C")]
		[Token(Token = "0x6001343")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C2D")]
	public ResourcesData resources; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C2E")]
	public NativeList<PassData> passData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C2F")]
	public Dictionary<Int32, GraphicsFence> fences; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C30")]
	public DynamicArray<Name> passNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C31")]
	public NativeList<PassInputData> inputData; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C32")]
	public NativeList<PassOutputData> outputData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C33")]
	public NativeList<PassFragmentData> fragmentData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C34")]
	public NativeList<ResourceHandle> sampledData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C35")]
	public NativeList<ResourceHandle> createData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C36")]
	public NativeList<ResourceHandle> destroyData; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C37")]
	public NativeList<PassRandomWriteData> randomAccessResourceData; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C38")]
	public NativeList<NativePassData> nativePassData; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C39")]
	public NativeList<SubPassDescriptor> nativeSubPassData; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C3A")]
	private bool m_AreNativeListsAllocated; //Field offset: 0x78

	[Token(Token = "0x17000262")]
	public NativePassIterator NativePasses
	{
		[Address(RVA = "0x2C8F3C0", Offset = "0x2C8E7C0", Length = "0x15")]
		[Token(Token = "0x600133C")]
		 get { } //Length: 21
	}

	[Token(Token = "0x17000261")]
	public PassIterator Passes
	{
		[Address(RVA = "0x2C8F3C0", Offset = "0x2C8E7C0", Length = "0x15")]
		[Token(Token = "0x600133A")]
		 get { } //Length: 21
	}

	[Address(RVA = "0x2C8F2C0", Offset = "0x2C8E6C0", Length = "0xF7")]
	[Token(Token = "0x6001329")]
	public CompilerContextData() { }

	[Address(RVA = "0x2C8DA70", Offset = "0x2C8CE70", Length = "0x2BA")]
	[Token(Token = "0x600132A")]
	private void AllocateNativeDataStructuresIfNeeded(int estimatedNumPasses) { }

	[Address(RVA = "0x2C8DD30", Offset = "0x2C8D130", Length = "0x146")]
	[Token(Token = "0x6001340")]
	private void Cleanup() { }

	[Address(RVA = "0x2C8DE80", Offset = "0x2C8D280", Length = "0x191")]
	[Token(Token = "0x600132C")]
	public override void Clear() { }

	[Address(RVA = "0x2C8E020", Offset = "0x2C8D420", Length = "0xA4")]
	[Token(Token = "0x6001338")]
	public void CullAllPasses(bool isCulled) { }

	[Address(RVA = "0x2C8E0D0", Offset = "0x2C8D4D0", Length = "0x53")]
	[Token(Token = "0x600133F")]
	public override void Dispose() { }

	[Address(RVA = "0x2C8E130", Offset = "0x2C8D530", Length = "0x57")]
	[Token(Token = "0x600133E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2C8F3C0", Offset = "0x2C8E7C0", Length = "0x15")]
	[Token(Token = "0x600133C")]
	public NativePassIterator get_NativePasses() { }

	[Address(RVA = "0x2C8F3C0", Offset = "0x2C8E7C0", Length = "0x15")]
	[Token(Token = "0x600133A")]
	public PassIterator get_Passes() { }

	[Address(RVA = "0x2C8E190", Offset = "0x2C8D590", Length = "0x69")]
	[Token(Token = "0x6001332")]
	public Name GetFullPassName(int passId) { }

	[Address(RVA = "0x2C8E200", Offset = "0x2C8D600", Length = "0x38B")]
	[Token(Token = "0x600133D")]
	internal List<NativePassData> GetNativePasses() { }

	[Address(RVA = "0x2C8E5F0", Offset = "0x2C8D9F0", Length = "0x26D")]
	[Token(Token = "0x600133B")]
	internal List<PassData> GetPasses() { }

	[Address(RVA = "0x2C8E590", Offset = "0x2C8D990", Length = "0x55")]
	[Token(Token = "0x6001333")]
	public string GetPassName(int passId) { }

	[Address(RVA = "0x2C8E860", Offset = "0x2C8DC60", Length = "0xCB")]
	[Token(Token = "0x6001334")]
	public string GetResourceName(in ResourceHandle h) { }

	[Address(RVA = "0x2C8E930", Offset = "0x2C8DD30", Length = "0x99")]
	[Token(Token = "0x6001335")]
	public string GetResourceVersionedName(in ResourceHandle h) { }

	[Address(RVA = "0x2C8E9D0", Offset = "0x2C8DDD0", Length = "0x80")]
	[Token(Token = "0x6001339")]
	public TextureUVOrigin GetTextureUVOrigin(in TextureHandle targetHandle) { }

	[Address(RVA = "0x2C8EA50", Offset = "0x2C8DE50", Length = "0x83")]
	[Token(Token = "0x600132B")]
	public void Initialize(RenderGraphResourceRegistry resourceRegistry, int estimatedNumPasses) { }

	[Address(RVA = "0x2C8EAE0", Offset = "0x2C8DEE0", Length = "0x172")]
	[Token(Token = "0x600132F")]
	public ReadOnlySpan<ResourceReaderData> Readers(in ResourceHandle h) { }

	[Address(RVA = "0x2C8EC60", Offset = "0x2C8E060", Length = "0x12F")]
	[Token(Token = "0x6001330")]
	public ResourceReaderData ResourceReader(in ResourceHandle h, int i) { }

	[Address(RVA = "0x2C8ED90", Offset = "0x2C8E190", Length = "0xA0")]
	[Token(Token = "0x6001337")]
	public void TagAllPasses(int value) { }

	[Address(RVA = "0x2C8EE30", Offset = "0x2C8E230", Length = "0x143")]
	[Token(Token = "0x6001331")]
	public bool TryAddToFragmentList(in TextureAccess access, int listFirstIndex, int numItems, out string errorMessage) { }

	[Address(RVA = "0x2C8EF80", Offset = "0x2C8E380", Length = "0x267")]
	[Token(Token = "0x6001336")]
	public bool TryAddToRandomAccessResourceList(in ResourceHandle h, int randomWriteSlotIndex, bool preserveCounterValue, int listFirstIndex, int numItems, out string errorMessage) { }

	[Address(RVA = "0x2C8F1F0", Offset = "0x2C8E5F0", Length = "0xC5")]
	[Token(Token = "0x600132D")]
	public ResourceUnversionedData UnversionedResourceData(in ResourceHandle h) { }

	[Address(RVA = "0x2C8B080", Offset = "0x2C8A480", Length = "0x1781")]
	[Token(Token = "0x600132E")]
	public ResourceVersionedData VersionedResourceData(in ResourceHandle h) { }

}

