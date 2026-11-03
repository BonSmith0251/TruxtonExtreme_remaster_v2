namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Spline Roll")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineSplineRoll.html")]
[SaveDuringPlay]
[Token(Token = "0x2000045")]
public class CinemachineSplineRoll : MonoBehaviour, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000047")]
	internal struct LerpRollData : IInterpolator<RollData>
	{

		[Address(RVA = "0x2832A90", Offset = "0x2831E90", Length = "0x46")]
		[Token(Token = "0x600013D")]
		public override RollData Interpolate(RollData a, RollData b, float t) { }

	}

	[Token(Token = "0x2000048")]
	internal struct LerpRollDataWithEasing : IInterpolator<RollData>
	{

		[Address(RVA = "0x2832A20", Offset = "0x2831E20", Length = "0x68")]
		[Token(Token = "0x600013E")]
		public override RollData Interpolate(RollData a, RollData b, float t) { }

	}

	[Token(Token = "0x2000049")]
	public struct RollCache
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000111")]
		private CinemachineSplineRoll m_RollCache; //Field offset: 0x0

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000140")]
		public CinemachineSplineRoll GetSplineRoll(MonoBehaviour owner) { }

		[Address(RVA = "0x2833430", Offset = "0x2832830", Length = "0x14F")]
		[Token(Token = "0x600013F")]
		public void Refresh(MonoBehaviour owner) { }

	}

	[Token(Token = "0x2000046")]
	internal struct RollData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000110")]
		[Tooltip("Roll (in degrees) around the forward direction for specific location on the track.\n- When placed on a SplineContainer, this is going to be a global override that affects all vcams using the Spline.\n- When placed on a CinemachineCamera, this is going to be a local override that only affects that CinemachineCamera.")]
		public float Value; //Field offset: 0x0

		[Address(RVA = "0x1F8D390", Offset = "0x1F8C790", Length = "0x5")]
		[Token(Token = "0x600013B")]
		public static float op_Implicit(RollData roll) { }

		[Address(RVA = "0x1F8D3A0", Offset = "0x1F8C7A0", Length = "0x5")]
		[Token(Token = "0x600013C")]
		public static RollData op_Implicit(float roll) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400010D")]
	[Tooltip("When enabled, roll eases into and out of the data point values.  Otherwise, interpolation is linear.")]
	public bool Easing; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[HideFoldout]
	[Token(Token = "0x400010E")]
	public SplineData<RollData> Roll; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x400010F")]
	private int m_StreamingVersion; //Field offset: 0x30

	[Address(RVA = "0x5D5A40", Offset = "0x5D4E40", Length = "0xB")]
	[Token(Token = "0x600013A")]
	public CinemachineSplineRoll() { }

	[Address(RVA = "0x2828D20", Offset = "0x2828120", Length = "0x5A")]
	[Token(Token = "0x6000134")]
	public IInterpolator<RollData> GetInterpolator() { }

	[Address(RVA = "0x2828D80", Offset = "0x2828180", Length = "0x12D")]
	[Token(Token = "0x6000139")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000138")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000137")]
	private void OnEnable() { }

	[Address(RVA = "0x2828EB0", Offset = "0x28282B0", Length = "0x116")]
	[Token(Token = "0x6000135")]
	private void PerformLegacyUpgrade(int streamedVersion) { }

	[Address(RVA = "0x2828FD0", Offset = "0x28283D0", Length = "0x44")]
	[Token(Token = "0x6000136")]
	private void Reset() { }

}

