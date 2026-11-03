namespace Unity.Cinemachine;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineNoiseProfiles.html")]
[Token(Token = "0x20000D6")]
public sealed class NoiseSettings : SignalSourceAsset
{
	[Token(Token = "0x20000D7")]
	internal struct NoiseParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000333")]
		[Tooltip("The frequency of noise for this channel.  Higher magnitudes vibrate faster.")]
		public float Frequency; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000334")]
		[Tooltip("The amplitude of the noise for this channel.  Larger numbers vibrate higher.")]
		public float Amplitude; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000335")]
		[Tooltip("If checked, then the amplitude and frequency will not be randomized.")]
		public bool Constant; //Field offset: 0x8

		[Address(RVA = "0x2847300", Offset = "0x2846700", Length = "0x5C")]
		[Token(Token = "0x60003FA")]
		public float GetValueAt(float time, float timeOffset) { }

	}

	[Token(Token = "0x20000D8")]
	internal struct TransformNoiseParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000336")]
		[Tooltip("Noise definition for X-axis")]
		public NoiseParams X; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000337")]
		[Tooltip("Noise definition for Y-axis")]
		public NoiseParams Y; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000338")]
		[Tooltip("Noise definition for Z-axis")]
		public NoiseParams Z; //Field offset: 0x18

		[Address(RVA = "0x284D970", Offset = "0x284CD70", Length = "0x15C")]
		[Token(Token = "0x60003FB")]
		public Vector3 GetValueAt(float time, Vector3 timeOffsets) { }

	}

	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_Position")]
	[Token(Token = "0x4000331")]
	[Tooltip("These are the noise channels for the virtual camera's position. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
	public TransformNoiseParams[] PositionNoise; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_Orientation")]
	[Token(Token = "0x4000332")]
	[Tooltip("These are the noise channels for the virtual camera's orientation. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
	public TransformNoiseParams[] OrientationNoise; //Field offset: 0x20

	[Token(Token = "0x170000DB")]
	public virtual float SignalDuration
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60003F7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2847610", Offset = "0x2846A10", Length = "0x70")]
	[Token(Token = "0x60003F9")]
	public NoiseSettings() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60003F7")]
	public virtual float get_SignalDuration() { }

	[Address(RVA = "0x2847360", Offset = "0x2846760", Length = "0x140")]
	[Token(Token = "0x60003F6")]
	public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets) { }

	[Address(RVA = "0x28474B0", Offset = "0x28468B0", Length = "0x15F")]
	[Token(Token = "0x60003F8")]
	public virtual void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}

