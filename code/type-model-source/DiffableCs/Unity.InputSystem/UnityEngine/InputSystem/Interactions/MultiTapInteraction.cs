namespace UnityEngine.InputSystem.Interactions;

[Token(Token = "0x200022F")]
public class MultiTapInteraction : IInputInteraction<Single>, IInputInteraction
{
	[Token(Token = "0x2000230")]
	private enum TapPhase : int
	{
		None = 0,
		WaitingForNextRelease = 1,
		WaitingForNextPress = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C47")]
	[Tooltip("The maximum time (in seconds) allowed to elapse between pressing and releasing a control for it to register as a tap.")]
	public float tapTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C48")]
	[Tooltip("The maximum delay (in seconds) allowed between each tap. If this time is exceeded, the multi-tap is canceled.")]
	public float tapDelay; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C49")]
	[Tooltip("How many taps need to be performed in succession. Two means double-tap, three means triple-tap, and so on.")]
	public int tapCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C4A")]
	public float pressPoint; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C4B")]
	private TapPhase m_CurrentTapPhase; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000C4C")]
	private int m_CurrentTapCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C4D")]
	private double m_CurrentTapStartTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C4E")]
	private double m_LastTapReleaseTime; //Field offset: 0x30

	[Token(Token = "0x170005DD")]
	private float pressPointOrDefault
	{
		[Address(RVA = "0x291E5B0", Offset = "0x291D9B0", Length = "0x53")]
		[Token(Token = "0x600148E")]
		private get { } //Length: 83
	}

	[Token(Token = "0x170005DE")]
	private float releasePointOrDefault
	{
		[Address(RVA = "0x291E610", Offset = "0x291DA10", Length = "0x76")]
		[Token(Token = "0x600148F")]
		private get { } //Length: 118
	}

	[Token(Token = "0x170005DC")]
	internal float tapDelayOrDefault
	{
		[Address(RVA = "0x291E690", Offset = "0x291DA90", Length = "0x6C")]
		[Token(Token = "0x600148D")]
		internal get { } //Length: 108
	}

	[Token(Token = "0x170005DB")]
	private float tapTimeOrDefault
	{
		[Address(RVA = "0x291E700", Offset = "0x291DB00", Length = "0x6C")]
		[Token(Token = "0x600148C")]
		private get { } //Length: 108
	}

	[Address(RVA = "0x291E5A0", Offset = "0x291D9A0", Length = "0xE")]
	[Token(Token = "0x6001492")]
	public MultiTapInteraction() { }

	[Address(RVA = "0x291E5B0", Offset = "0x291D9B0", Length = "0x53")]
	[Token(Token = "0x600148E")]
	private float get_pressPointOrDefault() { }

	[Address(RVA = "0x291E610", Offset = "0x291DA10", Length = "0x76")]
	[Token(Token = "0x600148F")]
	private float get_releasePointOrDefault() { }

	[Address(RVA = "0x291E690", Offset = "0x291DA90", Length = "0x6C")]
	[Token(Token = "0x600148D")]
	internal float get_tapDelayOrDefault() { }

	[Address(RVA = "0x291E700", Offset = "0x291DB00", Length = "0x6C")]
	[Token(Token = "0x600148C")]
	private float get_tapTimeOrDefault() { }

	[Address(RVA = "0x291E300", Offset = "0x291D700", Length = "0x284")]
	[Token(Token = "0x6001490")]
	public override void Process(ref InputInteractionContext context) { }

	[Address(RVA = "0x291E590", Offset = "0x291D990", Length = "0xF")]
	[Token(Token = "0x6001491")]
	public override void Reset() { }

}

