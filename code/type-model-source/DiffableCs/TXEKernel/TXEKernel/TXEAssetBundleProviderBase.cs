namespace TXEKernel;

[Token(Token = "0x20000C2")]
public abstract class TXEAssetBundleProviderBase : ResourceProviderBase
{
	[CompilerGenerated]
	[Token(Token = "0x20000C4")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E6")]
		public float progress; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600061E")]
		public <>c__DisplayClass1_0() { }

		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x600061F")]
		internal float <Provide>b__0() { }

		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6000620")]
		internal void <Provide>b__1(float p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C5")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E7")]
		public ProvideHandle provideHandle; //Field offset: 0x10
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003E8")]
		public string internalId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003E9")]
		public Action<Single> reportProgress; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003EA")]
		public AssetBundleCreateRequest request; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40003EB")]
		public string path; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000621")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x271F960", Offset = "0x271ED60", Length = "0x2E2")]
		[Token(Token = "0x6000622")]
		internal void <ProvideAsync>b__0(AsyncOperation _) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C6")]
	private struct <ProvideAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003EC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003ED")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003EE")]
		public ProvideHandle provideHandle; //Field offset: 0x10
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003EF")]
		public Action<Single> reportProgress; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003F0")]
		private <>c__DisplayClass3_0 <>8__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003F1")]
		public TXEAssetBundleProviderBase <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40003F2")]
		private object <>7__wrap1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40003F3")]
		private int <>7__wrap2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40003F4")]
		private Byte[] <data>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40003F5")]
		private Awaiter <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40003F6")]
		private Awaiter <>u__2; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40003F7")]
		private Exception <e>5__5; //Field offset: 0x70

		[Address(RVA = "0x271DE60", Offset = "0x271D260", Length = "0xEAA")]
		[Token(Token = "0x6000623")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000624")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20000C3")]
	internal sealed class TXEMemoryAssetBundleResource : IAssetBundleResource
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E4")]
		private AssetBundle _bundle; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003E5")]
		private readonly bool _owns; //Field offset: 0x18

		[Address(RVA = "0x1BC27C0", Offset = "0x1BC1BC0", Length = "0x44")]
		[Token(Token = "0x600061A")]
		public TXEMemoryAssetBundleResource(AssetBundle ab, bool owns) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600061B")]
		public override AssetBundle GetAssetBundle() { }

		[Address(RVA = "0x2715800", Offset = "0x2714C00", Length = "0x5E")]
		[Token(Token = "0x600061C")]
		public Task<AssetBundle> GetAssetBundleAsync() { }

		[Address(RVA = "0x2715860", Offset = "0x2714C60", Length = "0x46")]
		[Token(Token = "0x600061D")]
		public void Unload() { }

	}

	[Token(Token = "0x40003E3")]
	protected const int UnityMagicCheckBytes = 16; //Field offset: 0x0

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000619")]
	protected TXEAssetBundleProviderBase() { }

	[Address(RVA = "0x270FDA0", Offset = "0x270F1A0", Length = "0xD2")]
	[Token(Token = "0x6000615")]
	protected static bool HeadContainsUnity(Byte[] data) { }

	[Address(RVA = "0x270FF70", Offset = "0x270F370", Length = "0x208")]
	[Token(Token = "0x6000611")]
	public virtual void Provide(ProvideHandle provideHandle) { }

	[Address(RVA = "0x270FE80", Offset = "0x270F280", Length = "0xEE")]
	[AsyncStateMachine(typeof(<ProvideAsync>d__3))]
	[Token(Token = "0x6000613")]
	private UniTaskVoid ProvideAsync(ProvideHandle provideHandle, Action<Single> reportProgress) { }

	[Address(RVA = "0x2710180", Offset = "0x270F580", Length = "0x10D")]
	[Token(Token = "0x6000614")]
	public virtual void Release(IResourceLocation location, object asset) { }

	[Address(RVA = "0x2710290", Offset = "0x270F690", Length = "0x29F")]
	[Token(Token = "0x6000618")]
	protected static string ToLocalFilePathSafe(string internalId) { }

	[Token(Token = "0x6000612")]
	protected abstract Byte[] TransformBytes(Byte[] src, string internalId, string localPath) { }

	[Address(RVA = "0x2710540", Offset = "0x270F940", Length = "0xEF")]
	[Token(Token = "0x6000616")]
	protected static bool TryCompleteWithExistingMonoScripts(ProvideHandle provideHandle, bool isMonoScripts) { }

	[Address(RVA = "0x2710630", Offset = "0x270FA30", Length = "0x23D")]
	[Token(Token = "0x6000617")]
	protected static AssetBundle TryFindLoadedMonoScriptsBundle() { }

}

