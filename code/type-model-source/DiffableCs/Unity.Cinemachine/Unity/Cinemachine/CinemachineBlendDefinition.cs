namespace Unity.Cinemachine;

[Token(Token = "0x2000086")]
public struct CinemachineBlendDefinition
{
	[Token(Token = "0x2000087")]
	internal sealed class LookupBlendDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C153A0", Offset = "0x1C147A0", Length = "0x125")]
		[Token(Token = "0x60002AC")]
		public LookupBlendDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
		[Token(Token = "0x60002AE")]
		public override IAsyncResult BeginInvoke(ICinemachineCamera outgoing, ICinemachineCamera incoming, AsyncCallback callback, object object) { }

		[Address(RVA = "0x17C9A40", Offset = "0x17C8E40", Length = "0x34")]
		[Token(Token = "0x60002AF")]
		public override CinemachineBlendDefinition EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x1C14C20", Offset = "0x1C14020", Length = "0x31")]
		[Token(Token = "0x60002AD")]
		public override CinemachineBlendDefinition Invoke(ICinemachineCamera outgoing, ICinemachineCamera incoming) { }

	}

	[Token(Token = "0x2000088")]
	internal enum Styles : int
	{
		Cut = 0,
		EaseInOut = 1,
		EaseIn = 2,
		EaseOut = 3,
		HardIn = 4,
		HardOut = 5,
		Linear = 6,
		Custom = 7,
	}

	[Token(Token = "0x4000246")]
	private static AnimationCurve[] s_StandardCurves; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[FormerlySerializedAs("m_Style")]
	[Token(Token = "0x4000243")]
	[Tooltip("Shape of the blend curve")]
	public Styles Style; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[FormerlySerializedAs("m_Time")]
	[Token(Token = "0x4000244")]
	[Tooltip("Duration of the blend, in seconds")]
	public float Time; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[FormerlySerializedAs("m_CustomCurve")]
	[Token(Token = "0x4000245")]
	public AnimationCurve CustomCurve; //Field offset: 0x8

	[Token(Token = "0x1700008D")]
	public AnimationCurve BlendCurve
	{
		[Address(RVA = "0x283AEC0", Offset = "0x283A2C0", Length = "0xBC")]
		[Token(Token = "0x60002AB")]
		 get { } //Length: 188
	}

	[Token(Token = "0x1700008C")]
	public float BlendTime
	{
		[Address(RVA = "0x283AF80", Offset = "0x283A380", Length = "0xF")]
		[Token(Token = "0x60002A8")]
		 get { } //Length: 15
	}

	[Address(RVA = "0x283AEA0", Offset = "0x283A2A0", Length = "0x1A")]
	[Token(Token = "0x60002A9")]
	public CinemachineBlendDefinition(Styles style, float time) { }

	[Address(RVA = "0x283A810", Offset = "0x2839C10", Length = "0x688")]
	[Token(Token = "0x60002AA")]
	private void CreateStandardCurves() { }

	[Address(RVA = "0x283AEC0", Offset = "0x283A2C0", Length = "0xBC")]
	[Token(Token = "0x60002AB")]
	public AnimationCurve get_BlendCurve() { }

	[Address(RVA = "0x283AF80", Offset = "0x283A380", Length = "0xF")]
	[Token(Token = "0x60002A8")]
	public float get_BlendTime() { }

}

