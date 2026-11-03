namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Impulse Listener")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineImpulseListener.html")]
[SaveDuringPlay]
[Token(Token = "0x2000157")]
public class CinemachineImpulseListener : CinemachineExtension
{
	[Token(Token = "0x2000159")]
	internal struct ImpulseReaction
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C2")]
		[Tooltip("Secondary shake that will be triggered by the primary impulse.")]
		public NoiseSettings m_SecondaryNoise; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("m_AmplitudeGain")]
		[Token(Token = "0x40005C3")]
		[Tooltip("Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
		public float AmplitudeGain; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[FormerlySerializedAs("m_FrequencyGain")]
		[Token(Token = "0x40005C4")]
		[Tooltip("Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
		public float FrequencyGain; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("m_Duration")]
		[Token(Token = "0x40005C5")]
		[Tooltip("How long the secondary reaction lasts.")]
		public float Duration; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40005C6")]
		private float m_CurrentAmount; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005C7")]
		private float m_CurrentTime; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40005C8")]
		private float m_CurrentDamping; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005C9")]
		private bool m_Initialized; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		[Token(Token = "0x40005CA")]
		private Vector3 m_NoiseOffsets; //Field offset: 0x24

		[Address(RVA = "0x287E530", Offset = "0x287D930", Length = "0x456")]
		[Token(Token = "0x60006A5")]
		public bool GetReaction(float deltaTime, Vector3 impulsePos, out Vector3 pos, out Quaternion rot) { }

		[Address(RVA = "0x287E990", Offset = "0x287DD90", Length = "0x83")]
		[Token(Token = "0x60006A4")]
		public void ReSeed() { }

	}

	[Token(Token = "0x2000158")]
	internal enum SignalCombinationModes : int
	{
		Additive = 0,
		UseLargest = 1,
	}

	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_ApplyAfter")]
	[Token(Token = "0x40005B8")]
	[Tooltip("When to apply the impulse reaction.  Default is after the Noise stage.  Modify this if necessary to influence the ordering of extension effects")]
	public Stage ApplyAfter; //Field offset: 0x30
	[CinemachineImpulseChannelProperty]
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_ChannelMask")]
	[Token(Token = "0x40005B9")]
	[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
	public int ChannelMask; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_Gain")]
	[Token(Token = "0x40005BA")]
	[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
	public float Gain; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_Use2DDistance")]
	[Token(Token = "0x40005BB")]
	[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
	public bool Use2DDistance; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[FormerlySerializedAs("m_UseCameraSpace")]
	[Token(Token = "0x40005BC")]
	[Tooltip("Enable this to process all impulse signals in camera space")]
	public bool UseCameraSpace; //Field offset: 0x3D
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005BD")]
	[Tooltip("Controls how the Impulse Listener combines multiple impulses active at the current point in space.\n\n<b>Additive</b>: Combines all the active signals together, like sound waves.  This is the default.\n\n<b>Use Largest</b>: Considers only the signal with the largest amplitude; ignores any others.")]
	public SignalCombinationModes SignalCombinationMode; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_ReactionSettings")]
	[Token(Token = "0x40005BE")]
	[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
	public ImpulseReaction ReactionSettings; //Field offset: 0x48

	[Address(RVA = "0x286EBF0", Offset = "0x286DFF0", Length = "0xE")]
	[Token(Token = "0x60006A3")]
	public CinemachineImpulseListener() { }

	[Address(RVA = "0x286E450", Offset = "0x286D850", Length = "0x719")]
	[Token(Token = "0x60006A2")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x286EB70", Offset = "0x286DF70", Length = "0x7D")]
	[Token(Token = "0x60006A1")]
	private void Reset() { }

}

