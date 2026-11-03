namespace TXEKernel;

[Token(Token = "0x20000CE")]
public static class TXECatalogLoader
{
	[CompilerGenerated]
	[Token(Token = "0x20000CF")]
	private struct <LoadOptionalAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000413")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000414")]
		public AsyncTaskMethodBuilder<AsyncOperationHandle`1<IResourceLocator>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000415")]
		public string platform; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000416")]
		public string catalogFileName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000417")]
		private AsyncOperationHandle<IResourceLocator> <catalogHandle>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000418")]
		private TaskAwaiter<IResourceLocator> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x271B550", Offset = "0x271A950", Length = "0x347")]
		[Token(Token = "0x600064F")]
		private override void MoveNext() { }

		[Address(RVA = "0x271B8A0", Offset = "0x271ACA0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000650")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x27111A0", Offset = "0x27105A0", Length = "0x4CB")]
	[Token(Token = "0x600064C")]
	private static IEnumerable<String> BuildCandidateDirectories(string streamingAssetsRoot, string platform) { }

	[Address(RVA = "0x2711670", Offset = "0x2710A70", Length = "0x76B")]
	[Token(Token = "0x600064B")]
	private static IEnumerable<String> GetLikelyBuildTargetFolders(string platform) { }

	[Address(RVA = "0x2711DE0", Offset = "0x27111E0", Length = "0x72")]
	[Token(Token = "0x600064A")]
	public static string GetPlatformFolderName() { }

	[Address(RVA = "0x2711E60", Offset = "0x2711260", Length = "0x11E")]
	[AsyncStateMachine(typeof(<LoadOptionalAsync>d__1))]
	[Token(Token = "0x6000649")]
	public static Task<AsyncOperationHandle`1<IResourceLocator>> LoadOptionalAsync(string platform, string catalogFileName) { }

	[Address(RVA = "0x2711F80", Offset = "0x2711380", Length = "0x1AF")]
	[Token(Token = "0x6000648")]
	public static string ResolveCatalogPath(string platform, string catalogFileName) { }

	[Address(RVA = "0x2712130", Offset = "0x2711530", Length = "0x1AD")]
	[Token(Token = "0x600064D")]
	private static string TryFindCatalogInDir(string dir, string catalogFileName) { }

	[Address(RVA = "0x27122E0", Offset = "0x27116E0", Length = "0xF4")]
	[Token(Token = "0x600064E")]
	private static string TryResolveAbsolute(string catalogFileName) { }

}

