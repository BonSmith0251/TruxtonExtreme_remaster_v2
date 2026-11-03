namespace UnityEngine.AddressableAssets;

[Token(Token = "0x2000038")]
internal class CheckCatalogsOperation : AsyncOperationBase<List`1<String>>
{
	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private sealed class <>c
	{
		[Token(Token = "0x40000B7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000B8")]
		public static Func<IResourceProvider, Boolean> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x27B5A20", Offset = "0x27B4E20", Length = "0x67")]
		[Token(Token = "0x600018C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600018D")]
		public <>c() { }

		[Address(RVA = "0x27B4A20", Offset = "0x27B3E20", Length = "0x7F")]
		[Token(Token = "0x600018E")]
		internal bool <Start>b__5_0(IResourceProvider rp) { }

	}

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000B3")]
	private AddressablesImpl m_Addressables; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000B4")]
	private List<String> m_LocalHashes; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000B5")]
	private List<ResourceLocatorInfo> m_LocatorInfos; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000B6")]
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0xB0

	[Address(RVA = "0x27A7840", Offset = "0x27A6C40", Length = "0x5B")]
	[Token(Token = "0x6000185")]
	public CheckCatalogsOperation(AddressablesImpl aa) { }

	[Address(RVA = "0x27A6A00", Offset = "0x27A5E00", Length = "0x3D")]
	[Token(Token = "0x6000188")]
	protected virtual void Destroy() { }

	[Address(RVA = "0x27A6A40", Offset = "0x27A5E40", Length = "0xA8")]
	[Token(Token = "0x600018B")]
	protected virtual void Execute() { }

	[Address(RVA = "0x27A6AF0", Offset = "0x27A5EF0", Length = "0x11F")]
	[Token(Token = "0x6000189")]
	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	[Address(RVA = "0x27A6C10", Offset = "0x27A6010", Length = "0x124")]
	[Token(Token = "0x6000187")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x27A6D40", Offset = "0x27A6140", Length = "0x505")]
	[Token(Token = "0x600018A")]
	internal static List<String> ProcessDependentOpResults(IList<AsyncOperationHandle> results, List<ResourceLocatorInfo> locatorInfos, List<String> localHashes, out string errorString, out bool success) { }

	[Address(RVA = "0x27A7250", Offset = "0x27A6650", Length = "0x5EE")]
	[Token(Token = "0x6000186")]
	public AsyncOperationHandle<List`1<String>> Start(List<ResourceLocatorInfo> locatorInfos) { }

}

