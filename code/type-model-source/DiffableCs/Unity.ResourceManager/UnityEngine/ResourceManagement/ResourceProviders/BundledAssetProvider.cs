namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName("Assets from Bundles Provider")]
[Token(Token = "0x2000055")]
public class BundledAssetProvider : ResourceProviderBase
{
	[Token(Token = "0x2000056")]
	public class InternalOp
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F0")]
		private AssetBundle m_AssetBundle; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F1")]
		private AssetBundleRequest m_PreloadRequest; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F2")]
		private AssetBundleRequest m_RequestOperation; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F3")]
		private object m_Result; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000F4")]
		private ProvideHandle m_ProvideHandle; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000F5")]
		private string subObjectName; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001FB")]
		public InternalOp() { }

		[Address(RVA = "0x2E449F0", Offset = "0x2E43DF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60001FC")]
		private void <Start>b__8_0(AsyncOperation operation) { }

		[Address(RVA = "0x2E41AE0", Offset = "0x2E40EE0", Length = "0x522")]
		[Token(Token = "0x60001F4")]
		private void ActionComplete(AsyncOperation obj) { }

		[Address(RVA = "0x2E42010", Offset = "0x2E41410", Length = "0x5EC")]
		[Token(Token = "0x60001F2")]
		private void BeginAssetLoad() { }

		[Address(RVA = "0x2E42600", Offset = "0x2E41A00", Length = "0x150")]
		[Token(Token = "0x60001F9")]
		private void CompleteOperation() { }

		[Address(RVA = "0x2E42980", Offset = "0x2E41D80", Length = "0x7D")]
		[Token(Token = "0x60001F5")]
		private void GetArrayResult(Object[] allAssets) { }

		[Address(RVA = "0x2E42A00", Offset = "0x2E41E00", Length = "0xF7")]
		[Token(Token = "0x60001F7")]
		private void GetAssetResult(object asset) { }

		[Address(RVA = "0x2E42B00", Offset = "0x2E41F00", Length = "0xE4")]
		[Token(Token = "0x60001F8")]
		private void GetAssetSubObjectResult(Object[] allAssets) { }

		[Address(RVA = "0x2E42BF0", Offset = "0x2E41FF0", Length = "0x1F6")]
		[Token(Token = "0x60001F6")]
		private void GetListResult(Object[] allAssets) { }

		[Address(RVA = "0x2E42DF0", Offset = "0x2E421F0", Length = "0x185")]
		[Token(Token = "0x60001F0")]
		internal static bool IsDownloadOnly(IList<Object> results) { }

		[Address(RVA = "0x9F1CD0", Offset = "0x9F10D0", Length = "0x213")]
		[Token(Token = "0x60001EF")]
		internal static T LoadBundleFromDependecies(IList<Object> results) { }

		[Address(RVA = "0x2E42F80", Offset = "0x2E42380", Length = "0x16")]
		[Token(Token = "0x60001FA")]
		public float ProgressCallback() { }

		[Address(RVA = "0x2E43F80", Offset = "0x2E43380", Length = "0x502")]
		[Token(Token = "0x60001F1")]
		public void Start(ProvideHandle provideHandle) { }

		[Address(RVA = "0x2E44A00", Offset = "0x2E43E00", Length = "0xE5")]
		[Token(Token = "0x60001F3")]
		private bool WaitForCompletionHandler() { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001EE")]
	public BundledAssetProvider() { }

	[Address(RVA = "0x2E3D5A0", Offset = "0x2E3C9A0", Length = "0x7A")]
	[Token(Token = "0x60001ED")]
	public virtual void Provide(ProvideHandle provideHandle) { }

}

