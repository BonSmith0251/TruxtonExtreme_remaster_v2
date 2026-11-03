namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000063")]
public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000065")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010B")]
		public ResourceProviderBase <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010C")]
		public string id; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010D")]
		public string data; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600023A")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0x2E507D0", Offset = "0x2E4FBD0", Length = "0x35")]
		[Token(Token = "0x600023B")]
		internal bool <InitializeAsync>b__0() { }

	}

	[Token(Token = "0x2000064")]
	private class BaseInitAsyncOp : AsyncOperationBase<Boolean>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400010A")]
		private Func<Boolean> m_CallBack; //Field offset: 0x98

		[Address(RVA = "0x2E3C0C0", Offset = "0x2E3B4C0", Length = "0x39")]
		[Token(Token = "0x6000239")]
		public BaseInitAsyncOp() { }

		[Address(RVA = "0x2E3BFA0", Offset = "0x2E3B3A0", Length = "0xA9")]
		[Token(Token = "0x6000238")]
		protected virtual void Execute() { }

		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x6000236")]
		public void Init(Func<Boolean> callback) { }

		[Address(RVA = "0x2E3C050", Offset = "0x2E3B450", Length = "0x69")]
		[Token(Token = "0x6000237")]
		protected virtual bool InvokeWaitForCompletion() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000108")]
	protected string m_ProviderId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000109")]
	protected ProviderBehaviourFlags m_BehaviourFlags; //Field offset: 0x18

	[Token(Token = "0x1700005A")]
	public override string ProviderId
	{
		[Address(RVA = "0x2E4DCD0", Offset = "0x2E4D0D0", Length = "0x5D")]
		[Token(Token = "0x600022C")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700005B")]
	private override ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.BehaviourFlags
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000234")]
		private get { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000235")]
	protected ResourceProviderBase() { }

	[Address(RVA = "0x2E4DA90", Offset = "0x2E4CE90", Length = "0x4B")]
	[Token(Token = "0x600022E")]
	public override bool CanProvide(Type t, IResourceLocation location) { }

	[Address(RVA = "0x2E4DCD0", Offset = "0x2E4D0D0", Length = "0x5D")]
	[Token(Token = "0x600022C")]
	public override string get_ProviderId() { }

	[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
	[Token(Token = "0x6000231")]
	public override Type GetDefaultType(IResourceLocation location) { }

	[Address(RVA = "0x2E4DCA0", Offset = "0x2E4D0A0", Length = "0x29")]
	[Token(Token = "0x600022D")]
	public override bool Initialize(string id, string data) { }

	[Address(RVA = "0x2E4DAE0", Offset = "0x2E4CEE0", Length = "0x1BF")]
	[Token(Token = "0x6000233")]
	public override AsyncOperationHandle<Boolean> InitializeAsync(ResourceManager rm, string id, string data) { }

	[Token(Token = "0x6000232")]
	public abstract void Provide(ProvideHandle provideHandle) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000230")]
	public override void Release(IResourceLocation location, object obj) { }

	[Address(RVA = "0x22536E0", Offset = "0x2252AE0", Length = "0x14")]
	[Token(Token = "0x600022F")]
	public virtual string ToString() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000234")]
	private override ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags() { }

}

