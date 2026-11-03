namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Noise/Cinemachine Basic Multi Channel Perlin")]
[CameraPipeline(Stage::Noise (2))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineBasicMultiChannelPerlin.html")]
[SaveDuringPlay]
[Token(Token = "0x2000059")]
public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase, IModifiableNoise
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_Definition")]
	[FormerlySerializedAs("m_NoiseProfile")]
	[Token(Token = "0x4000162")]
	[Tooltip("The asset containing the Noise Profile.  Define the frequencies and amplitudes there to make a characteristic noise profile.  Make your own or just use one of the many presets.")]
	public NoiseSettings NoiseProfile; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_PivotOffset")]
	[Token(Token = "0x4000163")]
	[Tooltip("When rotating the camera, offset the camera's pivot position by this much (camera space)")]
	public Vector3 PivotOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_AmplitudeGain")]
	[Token(Token = "0x4000164")]
	[Tooltip("Gain to apply to the amplitudes defined in the NoiseSettings asset.  1 is normal.  Setting this to 0 completely mutes the noise.")]
	public float AmplitudeGain; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_FrequencyGain")]
	[Token(Token = "0x4000165")]
	[Tooltip("Scale factor to apply to the frequencies defined in the NoiseSettings asset.  1 is normal.  Larger magnitudes will make the noise shake more rapidly.")]
	public float FrequencyGain; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000166")]
	private bool m_Initialized; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000167")]
	private float m_NoiseTime; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[FormerlySerializedAs("mNoiseOffsets")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000168")]
	private Vector3 m_NoiseOffsets; //Field offset: 0x4C

	[Token(Token = "0x17000039")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x281CBF0", Offset = "0x281BFF0", Length = "0x64")]
		[Token(Token = "0x6000189")]
		 get { } //Length: 100
	}

	[Token(Token = "0x1700003A")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600018A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000038")]
	private override ValueTuple<Single, Single> Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise.NoiseAmplitudeFrequency
	{
		[Address(RVA = "0x281CAD0", Offset = "0x281BED0", Length = "0x52")]
		[Token(Token = "0x6000187")]
		private get { } //Length: 82
		[Address(RVA = "0x281CB30", Offset = "0x281BF30", Length = "0x1C")]
		[Token(Token = "0x6000188")]
		private set { } //Length: 28
	}

	[Address(RVA = "0x281CB50", Offset = "0x281BF50", Length = "0x98")]
	[Token(Token = "0x600018E")]
	public CinemachineBasicMultiChannelPerlin() { }

	[Address(RVA = "0x281CBF0", Offset = "0x281BFF0", Length = "0x64")]
	[Token(Token = "0x6000189")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600018A")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x281BC30", Offset = "0x281B030", Length = "0x154")]
	[Token(Token = "0x600018D")]
	private void Initialize() { }

	[Address(RVA = "0x281BD90", Offset = "0x281B190", Length = "0xCAB")]
	[Token(Token = "0x600018B")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x281CA40", Offset = "0x281BE40", Length = "0x83")]
	[Token(Token = "0x600018C")]
	public void ReSeed() { }

	[Address(RVA = "0x281CAD0", Offset = "0x281BED0", Length = "0x52")]
	[Token(Token = "0x6000187")]
	private override ValueTuple<Single, Single> Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise.get_NoiseAmplitudeFrequency() { }

	[Address(RVA = "0x281CB30", Offset = "0x281BF30", Length = "0x1C")]
	[Token(Token = "0x6000188")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableNoise.set_NoiseAmplitudeFrequency(ValueTuple<Single, Single> value) { }

}

