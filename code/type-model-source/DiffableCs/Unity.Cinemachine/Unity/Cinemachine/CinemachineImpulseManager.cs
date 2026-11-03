namespace Unity.Cinemachine;

[Token(Token = "0x200015B")]
public class CinemachineImpulseManager
{
	[Token(Token = "0x200015C")]
	internal struct EnvelopeDefinition
	{
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("m_AttackShape")]
		[Token(Token = "0x40005D0")]
		[Tooltip("Normalized curve defining the shape of the start of the envelope.  If blank a default curve will be used")]
		public AnimationCurve AttackShape; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("m_DecayShape")]
		[Token(Token = "0x40005D1")]
		[Tooltip("Normalized curve defining the shape of the end of the envelope.  If blank a default curve will be used")]
		public AnimationCurve DecayShape; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("m_AttackTime")]
		[Token(Token = "0x40005D2")]
		[Tooltip("Duration in seconds of the attack.  Attack curve will be scaled to fit.  Must be >= 0.")]
		public float AttackTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("m_SustainTime")]
		[Token(Token = "0x40005D3")]
		[Tooltip("Duration in seconds of the central fully-scaled part of the envelope.  Must be >= 0.")]
		public float SustainTime; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_DecayTime")]
		[Token(Token = "0x40005D4")]
		[Tooltip("Duration in seconds of the decay.  Decay curve will be scaled to fit.  Must be >= 0.")]
		public float DecayTime; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("m_ScaleWithImpact")]
		[Token(Token = "0x40005D5")]
		[Tooltip("If checked, signal amplitude scaling will also be applied to the time envelope of the signal.  Stronger signals will last longer.")]
		public bool ScaleWithImpact; //Field offset: 0x1C
		[FieldOffset(Offset = "0x1D")]
		[FormerlySerializedAs("m_HoldForever")]
		[Token(Token = "0x40005D6")]
		[Tooltip("If true, then duration is infinite.")]
		public bool HoldForever; //Field offset: 0x1D

		[Token(Token = "0x17000145")]
		public static EnvelopeDefinition Default
		{
			[Address(RVA = "0x289B240", Offset = "0x289A640", Length = "0x20")]
			[Token(Token = "0x60006B1")]
			 get { } //Length: 32
		}

		[Token(Token = "0x17000146")]
		public float Duration
		{
			[Address(RVA = "0x289B260", Offset = "0x289A660", Length = "0x1F")]
			[IsReadOnly]
			[Token(Token = "0x60006B2")]
			 get { } //Length: 31
		}

		[Address(RVA = "0x289B050", Offset = "0x289A450", Length = "0x29")]
		[Token(Token = "0x60006B4")]
		public void ChangeStopTime(float offset, bool forceNoDecay) { }

		[Address(RVA = "0x289B080", Offset = "0x289A480", Length = "0x3D")]
		[Token(Token = "0x60006B5")]
		public void Clear() { }

		[Address(RVA = "0x289B240", Offset = "0x289A640", Length = "0x20")]
		[Token(Token = "0x60006B1")]
		public static EnvelopeDefinition get_Default() { }

		[Address(RVA = "0x289B260", Offset = "0x289A660", Length = "0x1F")]
		[IsReadOnly]
		[Token(Token = "0x60006B2")]
		public float get_Duration() { }

		[Address(RVA = "0x289B0C0", Offset = "0x289A4C0", Length = "0x14A")]
		[IsReadOnly]
		[Token(Token = "0x60006B3")]
		public float GetValueAt(float offset) { }

		[Address(RVA = "0x289B210", Offset = "0x289A610", Length = "0x2A")]
		[Token(Token = "0x60006B6")]
		public void Validate() { }

	}

	[Token(Token = "0x200015D")]
	internal class ImpulseEvent
	{
		[Token(Token = "0x200015E")]
		internal enum DirectionModes : int
		{
			Fixed = 0,
			RotateTowardSource = 1,
		}

		[Token(Token = "0x200015F")]
		internal enum DissipationModes : int
		{
			LinearDecay = 0,
			SoftDecay = 1,
			ExponentialDecay = 2,
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005D7")]
		public float StartTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005D8")]
		public EnvelopeDefinition Envelope; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40005D9")]
		public ISignalSource6D SignalSource; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40005DA")]
		public Vector3 Position; //Field offset: 0x40
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40005DB")]
		public float Radius; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40005DC")]
		public DirectionModes DirectionMode; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40005DD")]
		public int Channel; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40005DE")]
		public DissipationModes DissipationMode; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40005DF")]
		public float DissipationDistance; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40005E0")]
		public float CustomDissipation; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40005E1")]
		public float PropagationSpeed; //Field offset: 0x64

		[Token(Token = "0x17000147")]
		public bool Expired
		{
			[Address(RVA = "0x289BB90", Offset = "0x289AF90", Length = "0xE3")]
			[Token(Token = "0x60006B7")]
			 get { } //Length: 227
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006BC")]
		internal ImpulseEvent() { }

		[Address(RVA = "0x289B280", Offset = "0x289A680", Length = "0x32")]
		[Token(Token = "0x60006B8")]
		public void Cancel(float time, bool forceNoDecay) { }

		[Address(RVA = "0x289B2C0", Offset = "0x289A6C0", Length = "0xAF")]
		[Token(Token = "0x60006BB")]
		public void Clear() { }

		[Address(RVA = "0x289B370", Offset = "0x289A770", Length = "0x1B7")]
		[Token(Token = "0x60006B9")]
		public float DistanceDecay(float distance) { }

		[Address(RVA = "0x289BB90", Offset = "0x289AF90", Length = "0xE3")]
		[Token(Token = "0x60006B7")]
		public bool get_Expired() { }

		[Address(RVA = "0x289B530", Offset = "0x289A930", Length = "0x657")]
		[Token(Token = "0x60006BA")]
		public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot) { }

	}

	[Token(Token = "0x40005CB")]
	private static CinemachineImpulseManager s_Instance; //Field offset: 0x0
	[Token(Token = "0x40005CC")]
	private const float Epsilon = 0.0001; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005CD")]
	private List<ImpulseEvent> m_ExpiredEvents; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005CE")]
	private List<ImpulseEvent> m_ActiveEvents; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005CF")]
	public bool IgnoreTimeScale; //Field offset: 0x20

	[Token(Token = "0x17000144")]
	public float CurrentTime
	{
		[Address(RVA = "0x2882E30", Offset = "0x2882230", Length = "0x58")]
		[Token(Token = "0x60006AD")]
		 get { } //Length: 88
	}

	[Token(Token = "0x17000143")]
	public static CinemachineImpulseManager Instance
	{
		[Address(RVA = "0x2882E90", Offset = "0x2882290", Length = "0x8D")]
		[Token(Token = "0x60006A8")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60006A7")]
	private CinemachineImpulseManager() { }

	[Address(RVA = "0x2882240", Offset = "0x2881640", Length = "0xFC")]
	[Token(Token = "0x60006AF")]
	public void AddImpulseEvent(ImpulseEvent e) { }

	[Address(RVA = "0x2882340", Offset = "0x2881740", Length = "0xC1")]
	[Token(Token = "0x60006B0")]
	public void Clear() { }

	[Address(RVA = "0x2882410", Offset = "0x2881810", Length = "0xB6")]
	[Token(Token = "0x60006AA")]
	internal static float EvaluateDissipationScale(float spread, float normalizedDistance) { }

	[Address(RVA = "0x2882E30", Offset = "0x2882230", Length = "0x58")]
	[Token(Token = "0x60006AD")]
	public float get_CurrentTime() { }

	[Address(RVA = "0x2882E90", Offset = "0x2882290", Length = "0x8D")]
	[Token(Token = "0x60006A8")]
	public static CinemachineImpulseManager get_Instance() { }

	[Address(RVA = "0x28824D0", Offset = "0x28818D0", Length = "0x45A")]
	[Token(Token = "0x60006AB")]
	public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) { }

	[Address(RVA = "0x2882930", Offset = "0x2881D30", Length = "0x30B")]
	[Token(Token = "0x60006AC")]
	public bool GetStrongestImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) { }

	[Address(RVA = "0x2882C40", Offset = "0x2882040", Length = "0x104")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x60006A9")]
	private static void InitializeModule() { }

	[Address(RVA = "0x2882D50", Offset = "0x2882150", Length = "0xDA")]
	[Token(Token = "0x60006AE")]
	public ImpulseEvent NewImpulseEvent() { }

}

