namespace Unity.Cinemachine;

[Token(Token = "0x2000151")]
public class CinemachineImpulseDefinition
{
	[Token(Token = "0x2000152")]
	internal enum ImpulseShapes : int
	{
		Custom = 0,
		Recoil = 1,
		Bump = 2,
		Explosion = 3,
		Rumble = 4,
	}

	[Token(Token = "0x2000153")]
	internal enum ImpulseTypes : int
	{
		Uniform = 0,
		Dissipating = 1,
		Propagating = 2,
		Legacy = 3,
	}

	[Token(Token = "0x2000156")]
	private class LegacySignalSource : ISignalSource6D
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005B5")]
		private CinemachineImpulseDefinition m_Def; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005B6")]
		private Vector3 m_Velocity; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40005B7")]
		private float m_StartTimeOffset; //Field offset: 0x24

		[Token(Token = "0x17000142")]
		public override float SignalDuration
		{
			[Address(RVA = "0x287F140", Offset = "0x287E540", Length = "0x33")]
			[Token(Token = "0x600069F")]
			 get { } //Length: 51
		}

		[Address(RVA = "0x287F090", Offset = "0x287E490", Length = "0xA3")]
		[Token(Token = "0x600069E")]
		public LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity) { }

		[Address(RVA = "0x287F140", Offset = "0x287E540", Length = "0x33")]
		[Token(Token = "0x600069F")]
		public override float get_SignalDuration() { }

		[Address(RVA = "0x287EE10", Offset = "0x287E210", Length = "0x275")]
		[Token(Token = "0x60006A0")]
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	}

	[Token(Token = "0x2000154")]
	internal enum RepeatModes : int
	{
		Stretch = 0,
		Loop = 1,
	}

	[Token(Token = "0x2000155")]
	private class SignalSource : ISignalSource6D
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005B3")]
		private CinemachineImpulseDefinition m_Def; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005B4")]
		private Vector3 m_Velocity; //Field offset: 0x18

		[Token(Token = "0x17000141")]
		public override float SignalDuration
		{
			[Address(RVA = "0x287FE50", Offset = "0x287F250", Length = "0x1C")]
			[Token(Token = "0x600069C")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x287FE00", Offset = "0x287F200", Length = "0x4E")]
		[Token(Token = "0x600069B")]
		public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity) { }

		[Address(RVA = "0x287FE50", Offset = "0x287F250", Length = "0x1C")]
		[Token(Token = "0x600069C")]
		public override float get_SignalDuration() { }

		[Address(RVA = "0x287FC60", Offset = "0x287F060", Length = "0x197")]
		[Token(Token = "0x600069D")]
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	}

	[Token(Token = "0x40005A4")]
	private static AnimationCurve[] s_StandardShapes; //Field offset: 0x0
	[CinemachineImpulseChannelProperty]
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_ImpulseChannel")]
	[Token(Token = "0x4000593")]
	[Tooltip("Impulse events generated here will appear on the channels included in the mask.")]
	public int ImpulseChannel; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[FormerlySerializedAs("m_ImpulseShape")]
	[Token(Token = "0x4000594")]
	[Tooltip("Shape of the impact signal")]
	public ImpulseShapes ImpulseShape; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_CustomImpulseShape")]
	[Token(Token = "0x4000595")]
	[Tooltip("Defines the custom shape of the impact signal that will be generated.")]
	public AnimationCurve CustomImpulseShape; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_ImpulseDuration")]
	[Token(Token = "0x4000596")]
	[Tooltip("The time during which the impact signal will occur.  The signal shape will be stretched to fill that time.")]
	public float ImpulseDuration; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("m_ImpulseType")]
	[Token(Token = "0x4000597")]
	[Tooltip("How the impulse travels through space and time.")]
	public ImpulseTypes ImpulseType; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_DissipationRate")]
	[Range(0, 1)]
	[Token(Token = "0x4000598")]
	[Tooltip("This defines how the widely signal will spread within the effect radius before dissipating with distance from the impact point")]
	public float DissipationRate; //Field offset: 0x28
	[CinemachineEmbeddedAssetProperty(True)]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_RawSignal")]
	[Header("Signal Shape")]
	[Token(Token = "0x4000599")]
	[Tooltip("Legacy mode only: Defines the signal that will be generated.")]
	public SignalSourceAsset RawSignal; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_AmplitudeGain")]
	[Token(Token = "0x400059A")]
	[Tooltip("Legacy mode only: Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
	public float AmplitudeGain; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_FrequencyGain")]
	[Token(Token = "0x400059B")]
	[Tooltip("Legacy mode only: Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
	public float FrequencyGain; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_RepeatMode")]
	[Token(Token = "0x400059C")]
	[Tooltip("Legacy mode only: How to fit the signal into the envelope time")]
	public RepeatModes RepeatMode; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("m_Randomize")]
	[Token(Token = "0x400059D")]
	[Tooltip("Legacy mode only: Randomize the signal start time")]
	public bool Randomize; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_TimeEnvelope")]
	[Token(Token = "0x400059E")]
	[Tooltip("Legacy mode only: This defines the time-envelope of the signal.  The raw signal will be time-scaled to fit in the envelope.")]
	public EnvelopeDefinition TimeEnvelope; //Field offset: 0x48
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("m_ImpactRadius")]
	[Header("Spatial Range")]
	[Token(Token = "0x400059F")]
	[Tooltip("Legacy mode only: The signal will have full amplitude in this radius surrounding the impact point.  Beyond that it will dissipate with distance.")]
	public float ImpactRadius; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[FormerlySerializedAs("m_DirectionMode")]
	[Token(Token = "0x40005A0")]
	[Tooltip("Legacy mode only: How the signal direction behaves as the listener moves away from the origin.")]
	public DirectionModes DirectionMode; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("m_DissipationMode")]
	[Token(Token = "0x40005A1")]
	[Tooltip("Legacy mode only: This defines how the signal will dissipate with distance beyond the impact radius.")]
	public DissipationModes DissipationMode; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[FormerlySerializedAs("m_DissipationDistance")]
	[Token(Token = "0x40005A2")]
	[Tooltip("The signal will have no effect outside this radius surrounding the impact point.")]
	public float DissipationDistance; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[FormerlySerializedAs("m_PropagationSpeed")]
	[Token(Token = "0x40005A3")]
	[Tooltip("The speed (m/s) at which the impulse propagates through space.  High speeds allow listeners to react instantaneously, while slower speeds allow listeners in the scene to react as if to a wave spreading from the source.")]
	public float PropagationSpeed; //Field offset: 0x78

	[Token(Token = "0x17000140")]
	internal AnimationCurve ImpulseCurve
	{
		[Address(RVA = "0x286E390", Offset = "0x286D790", Length = "0xBB")]
		[Token(Token = "0x6000696")]
		internal get { } //Length: 187
	}

	[Address(RVA = "0x286E2C0", Offset = "0x286D6C0", Length = "0xCF")]
	[Token(Token = "0x600069A")]
	public CinemachineImpulseDefinition() { }

	[Address(RVA = "0x286CE20", Offset = "0x286C220", Length = "0x22D")]
	[Token(Token = "0x6000698")]
	public ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	[Address(RVA = "0x286D050", Offset = "0x286C450", Length = "0x3F")]
	[Token(Token = "0x6000697")]
	public void CreateEvent(Vector3 position, Vector3 velocity) { }

	[Address(RVA = "0x286D090", Offset = "0x286C490", Length = "0xE77")]
	[Token(Token = "0x6000694")]
	private static void CreateStandardShapes() { }

	[Address(RVA = "0x286E390", Offset = "0x286D790", Length = "0xBB")]
	[Token(Token = "0x6000696")]
	internal AnimationCurve get_ImpulseCurve() { }

	[Address(RVA = "0x286DF10", Offset = "0x286D310", Length = "0x71")]
	[Token(Token = "0x6000695")]
	internal static AnimationCurve GetStandardCurve(ImpulseShapes shape) { }

	[Address(RVA = "0x286DF90", Offset = "0x286D390", Length = "0x24A")]
	[Token(Token = "0x6000699")]
	private ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	[Address(RVA = "0x286E1E0", Offset = "0x286D5E0", Length = "0xD9")]
	[Token(Token = "0x6000693")]
	public void OnValidate() { }

}

