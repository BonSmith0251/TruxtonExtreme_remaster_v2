namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Cinemachine State Driven Camera")]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineStateDrivenCamera.html")]
[SaveDuringPlay]
[Token(Token = "0x200004A")]
public class CinemachineStateDrivenCamera : CinemachineCameraManagerBase
{
	[Token(Token = "0x200004D")]
	private struct HashPair
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000126")]
		public int parentHash; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000127")]
		public int hash; //Field offset: 0x4

	}

	[Token(Token = "0x200004B")]
	internal struct Instruction
	{
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("m_FullHash")]
		[Token(Token = "0x4000120")]
		[Tooltip("The full hash of the animation state")]
		public int FullHash; //Field offset: 0x0
		[ChildCameraProperty]
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("m_VirtualCamera")]
		[Token(Token = "0x4000121")]
		[Tooltip("The virtual camera to activate when the animation state becomes active")]
		public CinemachineVirtualCameraBase Camera; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("m_ActivateAfter")]
		[Token(Token = "0x4000122")]
		[Tooltip("How long to wait (in seconds) before activating the camera. This filters out very short state durations")]
		public float ActivateAfter; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("m_MinDuration")]
		[Token(Token = "0x4000123")]
		[Tooltip("The minimum length of time (in seconds) to keep a camera active")]
		public float MinDuration; //Field offset: 0x14

	}

	[Token(Token = "0x200004C")]
	public struct ParentHash
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000124")]
		public int Hash; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000125")]
		public int HashOfParent; //Field offset: 0x4

	}

	[FieldOffset(Offset = "0x208")]
	[FormerlySerializedAs("m_AnimatedTarget")]
	[NoSaveDuringPlay]
	[Space]
	[Token(Token = "0x4000112")]
	[Tooltip("The state machine whose state changes will drive this camera's choice of active child")]
	public Animator AnimatedTarget; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[FormerlySerializedAs("m_LayerIndex")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000113")]
	[Tooltip("Which layer in the target state machine to observe")]
	public int LayerIndex; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[FormerlySerializedAs("m_Instructions")]
	[Token(Token = "0x4000114")]
	[Tooltip("The set of instructions associating cameras with states.  These instructions are used to choose the live child at any given moment")]
	public Instruction[] Instructions; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000115")]
	private List<ParentHash> HashOfParent; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[FormerlySerializedAs("m_LookAt")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000116")]
	private Transform m_LegacyLookAt; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[FormerlySerializedAs("m_Follow")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000117")]
	private Transform m_LegacyFollow; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000118")]
	private float m_ActivationTime; //Field offset: 0x238
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000119")]
	private int m_ActiveInstructionIndex; //Field offset: 0x23C
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x400011A")]
	private float m_PendingActivationTime; //Field offset: 0x240
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x400011B")]
	private int m_PendingInstructionIndex; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x400011C")]
	private Dictionary<Int32, List`1<Int32>> m_InstructionDictionary; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x400011D")]
	private Dictionary<Int32, Int32> m_StateParentLookup; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400011E")]
	private readonly List<AnimatorClipInfo> m_ClipInfoList; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400011F")]
	private Dictionary<AnimationClip, List`1<HashPair>> m_HashCache; //Field offset: 0x260

	[Address(RVA = "0x282A2E0", Offset = "0x28296E0", Length = "0xC9")]
	[Token(Token = "0x600014A")]
	public CinemachineStateDrivenCamera() { }

	[Address(RVA = "0x2829020", Offset = "0x2828420", Length = "0x9C")]
	[Token(Token = "0x6000149")]
	public void CancelWait() { }

	[Address(RVA = "0x28290C0", Offset = "0x28284C0", Length = "0x6F5")]
	[Token(Token = "0x6000147")]
	protected virtual CinemachineVirtualCameraBase ChooseCurrentCamera(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x28297C0", Offset = "0x2828BC0", Length = "0x7A")]
	[Token(Token = "0x6000144")]
	internal static int CreateFakeHash(int parentHash, AnimationClip clip) { }

	[Address(RVA = "0x2829840", Offset = "0x2828C40", Length = "0x13E")]
	[Token(Token = "0x6000148")]
	private int GetClipHash(int hash, List<AnimatorClipInfo> clips) { }

	[Address(RVA = "0x2829980", Offset = "0x2828D80", Length = "0x2BF")]
	[Token(Token = "0x6000145")]
	private int LookupFakeHash(int parentHash, AnimationClip clip) { }

	[Address(RVA = "0x2829C40", Offset = "0x2829040", Length = "0x1D0")]
	[Token(Token = "0x6000143")]
	protected private virtual void PerformLegacyUpgrade(int streamedVersion) { }

	[Address(RVA = "0x2829E10", Offset = "0x2829210", Length = "0xB7")]
	[Token(Token = "0x6000142")]
	protected virtual void Reset() { }

	[Address(RVA = "0x2829ED0", Offset = "0x28292D0", Length = "0x7A")]
	[Token(Token = "0x6000141")]
	internal void SetParentHash(List<ParentHash> list) { }

	[Address(RVA = "0x2829F50", Offset = "0x2829350", Length = "0x38D")]
	[Token(Token = "0x6000146")]
	internal void ValidateInstructions() { }

}

