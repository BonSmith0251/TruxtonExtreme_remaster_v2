namespace UnityEngine.AddressableAssets;

[Token(Token = "0x200003A")]
internal class CleanBundleCacheOperation : AsyncOperationBase<Boolean>, IUpdateReceiver
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000B9")]
	private AddressablesImpl m_Addressables; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000BA")]
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000BB")]
	private List<String> m_CacheDirsForRemoval; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000BC")]
	private Thread m_EnumerationThread; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000BD")]
	private string m_BaseCachePath; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000BE")]
	private bool m_UseMultiThreading; //Field offset: 0xD0

	[Address(RVA = "0x27A8880", Offset = "0x27A7C80", Length = "0xBD")]
	[Token(Token = "0x600018F")]
	public CleanBundleCacheOperation(AddressablesImpl aa, bool forceSingleThreading) { }

	[Address(RVA = "0x27A78A0", Offset = "0x27A6CA0", Length = "0x8F")]
	[Token(Token = "0x6000191")]
	public void CompleteInternal(bool result, bool success, string errorMsg) { }

	[Address(RVA = "0x27A7930", Offset = "0x27A6D30", Length = "0x66")]
	[Token(Token = "0x6000193")]
	protected virtual void Destroy() { }

	[Address(RVA = "0x27A7C40", Offset = "0x27A7040", Length = "0x7C")]
	[Token(Token = "0x6000198")]
	private void DetermineCacheDirsNotInUse(object data) { }

	[Address(RVA = "0x27A79A0", Offset = "0x27A6DA0", Length = "0x29A")]
	[Token(Token = "0x6000199")]
	private void DetermineCacheDirsNotInUse(HashSet<String> cacheDirsInUse) { }

	[Address(RVA = "0x27A7CC0", Offset = "0x27A70C0", Length = "0x1EE")]
	[Token(Token = "0x6000195")]
	protected virtual void Execute() { }

	[Address(RVA = "0x27A7EB0", Offset = "0x27A72B0", Length = "0x495")]
	[Token(Token = "0x600019A")]
	private HashSet<String> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps) { }

	[Address(RVA = "0x27A8350", Offset = "0x27A7750", Length = "0x11F")]
	[Token(Token = "0x6000194")]
	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	[Address(RVA = "0x27A8470", Offset = "0x27A7870", Length = "0xBE")]
	[Token(Token = "0x6000192")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x27A8530", Offset = "0x27A7930", Length = "0x1AF")]
	[Token(Token = "0x6000197")]
	private void RemoveCacheEntries() { }

	[Address(RVA = "0x27A86E0", Offset = "0x27A7AE0", Length = "0x135")]
	[Token(Token = "0x6000190")]
	public AsyncOperationHandle<Boolean> Start(AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

	[Address(RVA = "0x27A8820", Offset = "0x27A7C20", Length = "0x5C")]
	[Token(Token = "0x6000196")]
	private override void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

}

