namespace Unity.Cinemachine;

[Token(Token = "0x200018E")]
internal sealed class CinemachinePlayableMixer : PlayableBehaviour
{
	[Token(Token = "0x200018F")]
	internal sealed class MasterDirectorDelegate : MulticastDelegate
	{

		[Address(RVA = "0x17C9ED0", Offset = "0x17C92D0", Length = "0xA5")]
		[Token(Token = "0x6000857")]
		public MasterDirectorDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x6000859")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600085A")]
		public override PlayableDirector EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000858")]
		public override PlayableDirector Invoke() { }

	}

	[Token(Token = "0x40006A4")]
	public static MasterDirectorDelegate GetMasterPlayableDirector; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A3")]
	public int Priority; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006A5")]
	private ICameraOverrideStack m_BrainOverrideStack; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006A6")]
	private int m_BrainOverrideId; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40006A7")]
	private bool m_PreviewPlay; //Field offset: 0x24

	[Address(RVA = "0x254F970", Offset = "0x254ED70", Length = "0xE")]
	[Token(Token = "0x6000856")]
	public CinemachinePlayableMixer() { }

	[Address(RVA = "0x289DF20", Offset = "0x289D320", Length = "0xBC")]
	[Token(Token = "0x6000855")]
	private float GetDeltaTime(float deltaTime) { }

	[Address(RVA = "0x289DFE0", Offset = "0x289D3E0", Length = "0xC9")]
	[Token(Token = "0x6000852")]
	public virtual void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x289E0B0", Offset = "0x289D4B0", Length = "0x5")]
	[Token(Token = "0x6000853")]
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	[Address(RVA = "0x289E0C0", Offset = "0x289D4C0", Length = "0x744")]
	[Token(Token = "0x6000854")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

