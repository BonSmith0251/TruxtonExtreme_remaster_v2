namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000067")]
public class SceneProvider : ISceneProvider2, ISceneProvider
{
	[Token(Token = "0x2000068")]
	private class SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000110")]
		private bool m_ActivateOnLoad; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000111")]
		private SceneInstance m_Inst; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000112")]
		private IResourceLocation m_Location; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000113")]
		private LoadSceneParameters m_LoadSceneParameters; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000114")]
		private SceneReleaseMode m_ReleaseMode; //Field offset: 0xC8
		[FieldOffset(Offset = "0xCC")]
		[Token(Token = "0x4000115")]
		private int m_Priority; //Field offset: 0xCC
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000116")]
		private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0xD0
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4000117")]
		private ResourceManager m_ResourceManager; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4000118")]
		private ISceneProvider2 m_provider; //Field offset: 0xF0

		[Token(Token = "0x1700005E")]
		protected virtual string DebugName
		{
			[Address(RVA = "0x2E4F040", Offset = "0x2E4E440", Length = "0xF7")]
			[Token(Token = "0x600024E")]
			 get { } //Length: 247
		}

		[Token(Token = "0x1700005F")]
		protected virtual float Progress
		{
			[Address(RVA = "0x2E4F140", Offset = "0x2E4E540", Length = "0xB8")]
			[Token(Token = "0x6000253")]
			 get { } //Length: 184
		}

		[Address(RVA = "0x2E4EFC0", Offset = "0x2E4E3C0", Length = "0x7E")]
		[Token(Token = "0x6000248")]
		public SceneOp(ResourceManager rm, ISceneProvider2 provider) { }

		[Address(RVA = "0x2E4DE40", Offset = "0x2E4D240", Length = "0x1FF")]
		[Token(Token = "0x6000252")]
		protected virtual void Destroy() { }

		[Address(RVA = "0x2E4E040", Offset = "0x2E4D440", Length = "0x5A8")]
		[Token(Token = "0x600024F")]
		protected virtual void Execute() { }

		[Address(RVA = "0x2E4F040", Offset = "0x2E4E440", Length = "0xF7")]
		[Token(Token = "0x600024E")]
		protected virtual string get_DebugName() { }

		[Address(RVA = "0x2E4F140", Offset = "0x2E4E540", Length = "0xB8")]
		[Token(Token = "0x6000253")]
		protected virtual float get_Progress() { }

		[Address(RVA = "0x2E4E5F0", Offset = "0x2E4D9F0", Length = "0x146")]
		[Token(Token = "0x600024D")]
		public virtual void GetDependencies(List<AsyncOperationHandle> deps) { }

		[Address(RVA = "0x2E4E740", Offset = "0x2E4DB40", Length = "0xE2")]
		[Token(Token = "0x6000249")]
		internal virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

		[Address(RVA = "0x2E4E940", Offset = "0x2E4DD40", Length = "0x13C")]
		[Token(Token = "0x600024A")]
		public void Init(IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

		[Address(RVA = "0x2E4E830", Offset = "0x2E4DC30", Length = "0x10D")]
		[Token(Token = "0x600024B")]
		public void Init(IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

		[Address(RVA = "0x2E4EC10", Offset = "0x2E4E010", Length = "0x59")]
		[Token(Token = "0x6000251")]
		private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneParameters loadSceneParameters) { }

		[Address(RVA = "0x2E4EA80", Offset = "0x2E4DE80", Length = "0x184")]
		[Token(Token = "0x6000250")]
		internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

		[Address(RVA = "0x2E4EC70", Offset = "0x2E4E070", Length = "0x26F")]
		[Token(Token = "0x600024C")]
		protected virtual bool InvokeWaitForCompletion() { }

		[Address(RVA = "0x2E4EEE0", Offset = "0x2E4E2E0", Length = "0xD0")]
		[Token(Token = "0x6000254")]
		private override void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

	}

	[Token(Token = "0x2000069")]
	private class UnloadSceneOp : AsyncOperationBase<SceneInstance>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000119")]
		private SceneInstance m_Instance; //Field offset: 0xA0
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400011A")]
		private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle; //Field offset: 0xB0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400011B")]
		private UnloadSceneOptions m_UnloadOptions; //Field offset: 0xC8

		[Token(Token = "0x17000060")]
		protected virtual float Progress
		{
			[Address(RVA = "0x2E518E0", Offset = "0x2E50CE0", Length = "0x3D")]
			[Token(Token = "0x6000259")]
			 get { } //Length: 61
		}

		[Address(RVA = "0x2E518A0", Offset = "0x2E50CA0", Length = "0x39")]
		[Token(Token = "0x600025A")]
		public UnloadSceneOp() { }

		[Address(RVA = "0x2E51540", Offset = "0x2E50940", Length = "0x11A")]
		[Token(Token = "0x6000256")]
		protected virtual void Execute() { }

		[Address(RVA = "0x2E518E0", Offset = "0x2E50CE0", Length = "0x3D")]
		[Token(Token = "0x6000259")]
		protected virtual float get_Progress() { }

		[Address(RVA = "0x2E51660", Offset = "0x2E50A60", Length = "0xC0")]
		[Token(Token = "0x6000255")]
		public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions options) { }

		[Address(RVA = "0x2E51720", Offset = "0x2E50B20", Length = "0xA4")]
		[Token(Token = "0x6000257")]
		protected virtual bool InvokeWaitForCompletion() { }

		[Address(RVA = "0x2E517D0", Offset = "0x2E50BD0", Length = "0xD0")]
		[Token(Token = "0x6000258")]
		private void UnloadSceneCompleted(AsyncOperation obj) { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000247")]
	public SceneProvider() { }

	[Address(RVA = "0x2E4F470", Offset = "0x2E4E870", Length = "0xAD")]
	[Token(Token = "0x6000242")]
	public override AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	[Address(RVA = "0x2E4F890", Offset = "0x2E4EC90", Length = "0x5B")]
	[Token(Token = "0x6000243")]
	public override AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	[Address(RVA = "0x2E4F520", Offset = "0x2E4E920", Length = "0x36E")]
	[Token(Token = "0x6000244")]
	public override AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority) { }

	[Address(RVA = "0x2E4F8F0", Offset = "0x2E4ECF0", Length = "0x111")]
	[Token(Token = "0x6000245")]
	public override AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	[Address(RVA = "0x2E4FA10", Offset = "0x2E4EE10", Length = "0x1F3")]
	[Token(Token = "0x6000246")]
	private override AsyncOperationHandle<SceneInstance> UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2.ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }

}

