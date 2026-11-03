namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000008")]
internal class InitalizationObjectsOperation : AsyncOperationBase<Boolean>
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400000B")]
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp; //Field offset: 0x98
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400000C")]
	private AddressablesImpl m_Addressables; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400000D")]
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0xB8

	[Token(Token = "0x17000002")]
	protected virtual string DebugName
	{
		[Address(RVA = "0x27AA9A0", Offset = "0x27A9DA0", Length = "0x2C")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x27AA960", Offset = "0x27A9D60", Length = "0x39")]
	[Token(Token = "0x6000013")]
	public InitalizationObjectsOperation() { }

	[Address(RVA = "0x27AA7F0", Offset = "0x27A9BF0", Length = "0x165")]
	[CompilerGenerated]
	[Token(Token = "0x6000014")]
	private void <Execute>b__8_0(AsyncOperationHandle<IList`1<AsyncOperationHandle>> obj) { }

	[Address(RVA = "0x27A9DF0", Offset = "0x27A91F0", Length = "0x5F5")]
	[Token(Token = "0x6000012")]
	protected virtual void Execute() { }

	[Address(RVA = "0x27AA9A0", Offset = "0x27A9DA0", Length = "0x2C")]
	[Token(Token = "0x600000F")]
	protected virtual string get_DebugName() { }

	[Address(RVA = "0x27AA3F0", Offset = "0x27A97F0", Length = "0x76")]
	[Token(Token = "0x600000E")]
	public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables) { }

	[Address(RVA = "0x27AA470", Offset = "0x27A9870", Length = "0x189")]
	[Token(Token = "0x6000011")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x27AA600", Offset = "0x27A9A00", Length = "0x1E7")]
	[Token(Token = "0x6000010")]
	internal bool LogRuntimeWarnings(string pathToBuildLogs) { }

}

