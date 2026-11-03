namespace UnityEngine.AddressableAssets;

[Token(Token = "0x200003B")]
internal class UpdateCatalogsOperation : AsyncOperationBase<List`1<IResourceLocator>>
{
	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private sealed class <>c
	{
		[Token(Token = "0x40000C4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000C5")]
		public static Func<IResourceProvider, Boolean> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x27B5A90", Offset = "0x27B4E90", Length = "0x67")]
		[Token(Token = "0x60001A2")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001A3")]
		public <>c() { }

		[Address(RVA = "0x27B4AA0", Offset = "0x27B3EA0", Length = "0x7F")]
		[Token(Token = "0x60001A4")]
		internal bool <Start>b__6_0(IResourceProvider rp) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C6")]
		public UpdateCatalogsOperation <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000C7")]
		public List<IResourceLocator> catalogs; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001A5")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x27B4F20", Offset = "0x27B4320", Length = "0x15B")]
		[Token(Token = "0x60001A6")]
		internal void <OnCleanCacheCompleted>b__0(AsyncOperationHandle<Boolean> obj) { }

	}

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000BF")]
	private AddressablesImpl m_Addressables; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000C0")]
	private List<ResourceLocatorInfo> m_LocatorInfos; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000C1")]
	internal AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0xA8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000C2")]
	private AsyncOperationHandle<Boolean> m_CleanCacheOp; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000C3")]
	private bool m_AutoCleanBundleCache; //Field offset: 0xD8

	[Address(RVA = "0x27B6CE0", Offset = "0x27B60E0", Length = "0x5B")]
	[Token(Token = "0x600019B")]
	public UpdateCatalogsOperation(AddressablesImpl aa) { }

	[Address(RVA = "0x27B5BE0", Offset = "0x27B4FE0", Length = "0x3D")]
	[Token(Token = "0x600019E")]
	protected virtual void Destroy() { }

	[Address(RVA = "0x27B5C20", Offset = "0x27B5020", Length = "0x71A")]
	[Token(Token = "0x60001A0")]
	protected virtual void Execute() { }

	[Address(RVA = "0x27B6340", Offset = "0x27B5740", Length = "0x11F")]
	[Token(Token = "0x600019F")]
	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	[Address(RVA = "0x27B6460", Offset = "0x27B5860", Length = "0x19A")]
	[Token(Token = "0x600019D")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x27B6600", Offset = "0x27B5A00", Length = "0xEB")]
	[Token(Token = "0x60001A1")]
	private void OnCleanCacheCompleted(AsyncOperationHandle<Boolean> handle, List<IResourceLocator> catalogs) { }

	[Address(RVA = "0x27B66F0", Offset = "0x27B5AF0", Length = "0x5EC")]
	[Token(Token = "0x600019C")]
	public AsyncOperationHandle<List`1<IResourceLocator>> Start(IEnumerable<String> catalogIds, bool autoCleanBundleCache) { }

}

