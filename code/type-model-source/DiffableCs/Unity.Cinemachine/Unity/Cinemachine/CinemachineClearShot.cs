namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Cinemachine ClearShot")]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineClearShot.html")]
[SaveDuringPlay]
[Token(Token = "0x200000F")]
public class CinemachineClearShot : CinemachineCameraManagerBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private sealed class <>c
	{
		[Token(Token = "0x400003B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400003C")]
		public static Comparison<Pair> <>9__16_0; //Field offset: 0x8

		[Address(RVA = "0x2818690", Offset = "0x2817A90", Length = "0x67")]
		[Token(Token = "0x600005A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600005B")]
		public <>c() { }

		[Address(RVA = "0x2818510", Offset = "0x2817910", Length = "0x19")]
		[Token(Token = "0x600005C")]
		internal int <Randomize>b__16_0(Pair p1, Pair p2) { }

	}

	[Token(Token = "0x2000010")]
	private struct Pair
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		public int a; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400003A")]
		public float b; //Field offset: 0x4

	}

	[FieldOffset(Offset = "0x208")]
	[FormerlySerializedAs("m_ActivateAfter")]
	[Token(Token = "0x400002F")]
	[Tooltip("Wait this many seconds before activating a new child camera")]
	public float ActivateAfter; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[FormerlySerializedAs("m_MinDuration")]
	[Token(Token = "0x4000030")]
	[Tooltip("An active camera must be active for at least this many seconds")]
	public float MinDuration; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[FormerlySerializedAs("m_RandomizeChoice")]
	[Token(Token = "0x4000031")]
	[Tooltip("If checked, camera choice will be randomized if multiple cameras are equally desirable.  Otherwise, child list order and child camera priority will be used.")]
	public bool RandomizeChoice; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[FormerlySerializedAs("m_LookAt")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000032")]
	private Transform m_LegacyLookAt; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[FormerlySerializedAs("m_Follow")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000033")]
	private Transform m_LegacyFollow; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000034")]
	private float m_ActivationTime; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000035")]
	private float m_PendingActivationTime; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000036")]
	private CinemachineVirtualCameraBase m_PendingCamera; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000037")]
	private bool m_RandomizeNow; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000038")]
	private List<CinemachineVirtualCameraBase> m_RandomizedChildren; //Field offset: 0x240

	[Address(RVA = "0x2804A80", Offset = "0x2803E80", Length = "0x7")]
	[Token(Token = "0x6000059")]
	public CinemachineClearShot() { }

	[Address(RVA = "0x2803B30", Offset = "0x2802F30", Length = "0x90A")]
	[Token(Token = "0x6000057")]
	protected virtual CinemachineVirtualCameraBase ChooseCurrentCamera(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2804440", Offset = "0x2803840", Length = "0x8F")]
	[Token(Token = "0x6000055")]
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x28044D0", Offset = "0x28038D0", Length = "0x1D0")]
	[Token(Token = "0x6000054")]
	protected private virtual void PerformLegacyUpgrade(int streamedVersion) { }

	[Address(RVA = "0x28046A0", Offset = "0x2803AA0", Length = "0x32B")]
	[Token(Token = "0x6000058")]
	private static List<CinemachineVirtualCameraBase> Randomize(List<CinemachineVirtualCameraBase> src) { }

	[Address(RVA = "0x2804A00", Offset = "0x2803E00", Length = "0x7D")]
	[Token(Token = "0x6000053")]
	protected virtual void Reset() { }

	[Address(RVA = "0x28049D0", Offset = "0x2803DD0", Length = "0x2F")]
	[Token(Token = "0x6000056")]
	public void ResetRandomization() { }

}

