namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName("AssetBundle Provider")]
[Token(Token = "0x200004D")]
public class AssetBundleProvider : ResourceProviderBase
{
	[CompilerGenerated]
	[Token(Token = "0x200004E")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E1")]
		public IResourceLocation location; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001D0")]
		public <>c__DisplayClass12_0() { }

		[Address(RVA = "0x2E50810", Offset = "0x2E4FC10", Length = "0xA7")]
		[Token(Token = "0x60001D1")]
		internal void <Release>b__0(AsyncOperation op) { }

	}

	[Token(Token = "0x40000E0")]
	internal static Dictionary<String, AssetBundleUnloadOperation> m_UnloadingBundles; //Field offset: 0x0

	[Token(Token = "0x17000047")]
	internal static int AssetBundleCount
	{
		[Address(RVA = "0x2E37290", Offset = "0x2E36690", Length = "0x6C")]
		[Token(Token = "0x60001C7")]
		internal get { } //Length: 108
	}

	[Token(Token = "0x17000046")]
	internal static int UnloadingAssetBundleCount
	{
		[Address(RVA = "0x2E37300", Offset = "0x2E36700", Length = "0x6F")]
		[Token(Token = "0x60001C6")]
		internal get { } //Length: 111
	}

	[Token(Token = "0x17000045")]
	protected internal static Dictionary<String, AssetBundleUnloadOperation> UnloadingBundles
	{
		[Address(RVA = "0x2E37370", Offset = "0x2E36770", Length = "0x4E")]
		[Token(Token = "0x60001C4")]
		private get { } //Length: 78
		[Address(RVA = "0x2E373C0", Offset = "0x2E367C0", Length = "0x69")]
		[Token(Token = "0x60001C5")]
		internal set { } //Length: 105
	}

	[Address(RVA = "0x2E37200", Offset = "0x2E36600", Length = "0x84")]
	[Token(Token = "0x60001CF")]
	private static AssetBundleProvider() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001CE")]
	public AssetBundleProvider() { }

	[Address(RVA = "0x2E36870", Offset = "0x2E35C70", Length = "0xF4")]
	[Token(Token = "0x60001CD")]
	internal override IOperationCacheKey CreateCacheKeyForLocation(ResourceManager rm, IResourceLocation location, Type desiredType) { }

	[Address(RVA = "0x2E37290", Offset = "0x2E36690", Length = "0x6C")]
	[Token(Token = "0x60001C7")]
	internal static int get_AssetBundleCount() { }

	[Address(RVA = "0x2E37300", Offset = "0x2E36700", Length = "0x6F")]
	[Token(Token = "0x60001C6")]
	internal static int get_UnloadingAssetBundleCount() { }

	[Address(RVA = "0x2E37370", Offset = "0x2E36770", Length = "0x4E")]
	[Token(Token = "0x60001C4")]
	protected private static Dictionary<String, AssetBundleUnloadOperation> get_UnloadingBundles() { }

	[Address(RVA = "0x2E36970", Offset = "0x2E35D70", Length = "0x4D")]
	[Token(Token = "0x60001CA")]
	public virtual Type GetDefaultType(IResourceLocation location) { }

	[Address(RVA = "0x2E369C0", Offset = "0x2E35DC0", Length = "0x99")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	[Token(Token = "0x60001C3")]
	private static void Init() { }

	[Address(RVA = "0x2E36A60", Offset = "0x2E35E60", Length = "0x2C9")]
	[Token(Token = "0x60001C9")]
	public virtual void Provide(ProvideHandle providerInterface) { }

	[Address(RVA = "0x2E36D30", Offset = "0x2E36130", Length = "0x39F")]
	[Token(Token = "0x60001CB")]
	public virtual void Release(IResourceLocation location, object asset) { }

	[Address(RVA = "0x2E373C0", Offset = "0x2E367C0", Length = "0x69")]
	[Token(Token = "0x60001C5")]
	internal static void set_UnloadingBundles(Dictionary<String, AssetBundleUnloadOperation> value) { }

	[Address(RVA = "0x2E370D0", Offset = "0x2E364D0", Length = "0x1F")]
	[Token(Token = "0x60001CC")]
	public override bool ShouldRetryDownloadError(UnityWebRequestResult uwrResult) { }

	[Address(RVA = "0x2E370F0", Offset = "0x2E364F0", Length = "0x106")]
	[Token(Token = "0x60001C8")]
	internal static void WaitForAllUnloadingBundlesToComplete() { }

}

