namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x200005B")]
public struct ProvideHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FF")]
	private int m_Version; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000100")]
	private IGenericProviderOperation m_InternalOp; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000101")]
	private ResourceManager m_ResourceManager; //Field offset: 0x10

	[Token(Token = "0x17000055")]
	public int DependencyCount
	{
		[Address(RVA = "0x2E46620", Offset = "0x2E45A20", Length = "0x52")]
		[Token(Token = "0x6000210")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000051")]
	internal IGenericProviderOperation InternalOp
	{
		[Address(RVA = "0x2E46680", Offset = "0x2E45A80", Length = "0x9B")]
		[Token(Token = "0x600020C")]
		internal get { } //Length: 155
	}

	[Token(Token = "0x17000050")]
	internal bool IsValid
	{
		[Address(RVA = "0x2E46720", Offset = "0x2E45B20", Length = "0x54")]
		[Token(Token = "0x600020B")]
		internal get { } //Length: 84
	}

	[Token(Token = "0x17000054")]
	public IResourceLocation Location
	{
		[Address(RVA = "0x2E46780", Offset = "0x2E45B80", Length = "0x52")]
		[Token(Token = "0x600020F")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000052")]
	public ResourceManager ResourceManager
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600020D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000053")]
	public Type Type
	{
		[Address(RVA = "0x2E467E0", Offset = "0x2E45BE0", Length = "0x52")]
		[Token(Token = "0x600020E")]
		 get { } //Length: 82
	}

	[Address(RVA = "0x2E46590", Offset = "0x2E45990", Length = "0x84")]
	[Token(Token = "0x600020A")]
	internal ProvideHandle(ResourceManager rm, IGenericProviderOperation op) { }

	[Address(RVA = "0x8DF620", Offset = "0x8DEA20", Length = "0x104")]
	[Token(Token = "0x6000216")]
	public void Complete(T result, bool status, Exception exception) { }

	[Address(RVA = "0x2E46620", Offset = "0x2E45A20", Length = "0x52")]
	[Token(Token = "0x6000210")]
	public int get_DependencyCount() { }

	[Address(RVA = "0x2E46680", Offset = "0x2E45A80", Length = "0x9B")]
	[Token(Token = "0x600020C")]
	internal IGenericProviderOperation get_InternalOp() { }

	[Address(RVA = "0x2E46720", Offset = "0x2E45B20", Length = "0x54")]
	[Token(Token = "0x600020B")]
	internal bool get_IsValid() { }

	[Address(RVA = "0x2E46780", Offset = "0x2E45B80", Length = "0x52")]
	[Token(Token = "0x600020F")]
	public IResourceLocation get_Location() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600020D")]
	public ResourceManager get_ResourceManager() { }

	[Address(RVA = "0x2E467E0", Offset = "0x2E45BE0", Length = "0x52")]
	[Token(Token = "0x600020E")]
	public Type get_Type() { }

	[Address(RVA = "0x2E462B0", Offset = "0x2E456B0", Length = "0x61")]
	[Token(Token = "0x6000212")]
	public void GetDependencies(IList<Object> list) { }

	[Address(RVA = "0x8DF880", Offset = "0x8DEC80", Length = "0xDF")]
	[Token(Token = "0x6000211")]
	public TDepObject GetDependency(int index) { }

	[Address(RVA = "0x2E46320", Offset = "0x2E45720", Length = "0xC5")]
	[Token(Token = "0x6000214")]
	public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback) { }

	[Address(RVA = "0x2E463F0", Offset = "0x2E457F0", Length = "0xC5")]
	[Token(Token = "0x6000213")]
	public void SetProgressCallback(Func<Single> callback) { }

	[Address(RVA = "0x2E464C0", Offset = "0x2E458C0", Length = "0xC5")]
	[Token(Token = "0x6000215")]
	public void SetWaitForCompletionCallback(Func<Boolean> callback) { }

}

