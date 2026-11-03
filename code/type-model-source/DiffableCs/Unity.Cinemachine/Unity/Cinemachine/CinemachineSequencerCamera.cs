namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Cinemachine Sequencer Camera")]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineSequencerCamera.html")]
[SaveDuringPlay]
[Token(Token = "0x200003F")]
public class CinemachineSequencerCamera : CinemachineCameraManagerBase
{
	[Token(Token = "0x2000040")]
	internal struct Instruction
	{
		[ChildCameraProperty]
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("m_VirtualCamera")]
		[Token(Token = "0x40000F4")]
		[Tooltip("The camera to activate when this instruction becomes active")]
		public CinemachineVirtualCameraBase Camera; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("m_Blend")]
		[Token(Token = "0x40000F5")]
		[Tooltip("How to blend to the next camera in the list (if any)")]
		public CinemachineBlendDefinition Blend; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_Hold")]
		[Token(Token = "0x40000F6")]
		[Tooltip("How long to wait (in seconds) before activating the next camera in the list (if any)")]
		public float Hold; //Field offset: 0x18

		[Address(RVA = "0x2816420", Offset = "0x2815820", Length = "0x14")]
		[Token(Token = "0x600011B")]
		public void Validate() { }

	}

	[FieldOffset(Offset = "0x208")]
	[FormerlySerializedAs("m_Loop")]
	[Token(Token = "0x40000EE")]
	[Tooltip("When enabled, the child vcams will cycle indefinitely instead of just stopping at the last one")]
	public bool Loop; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[FormerlySerializedAs("m_Instructions")]
	[Token(Token = "0x40000EF")]
	[Tooltip("The set of instructions for enabling child cameras.")]
	public List<Instruction> Instructions; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[FormerlySerializedAs("m_LookAt")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x40000F0")]
	private Transform m_LegacyLookAt; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[FormerlySerializedAs("m_Follow")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x40000F1")]
	private Transform m_LegacyFollow; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40000F2")]
	private float m_ActivationTime; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x40000F3")]
	private int m_CurrentInstruction; //Field offset: 0x22C

	[Address(RVA = "0x2814D60", Offset = "0x2814160", Length = "0x87")]
	[Token(Token = "0x600011A")]
	public CinemachineSequencerCamera() { }

	[Address(RVA = "0x2814550", Offset = "0x2813950", Length = "0x279")]
	[Token(Token = "0x6000119")]
	private void AdvanceCurrentInstruction(float deltaTime) { }

	[Address(RVA = "0x28147D0", Offset = "0x2813BD0", Length = "0xCC")]
	[Token(Token = "0x6000116")]
	protected virtual CinemachineVirtualCameraBase ChooseCurrentCamera(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x28148A0", Offset = "0x2813CA0", Length = "0x6B")]
	[Token(Token = "0x6000117")]
	protected virtual CinemachineBlendDefinition LookupBlend(ICinemachineCamera outgoing, ICinemachineCamera incoming) { }

	[Address(RVA = "0x2814910", Offset = "0x2813D10", Length = "0x59")]
	[Token(Token = "0x6000115")]
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2814970", Offset = "0x2813D70", Length = "0x147")]
	[Token(Token = "0x6000113")]
	private void OnValidate() { }

	[Address(RVA = "0x2814AC0", Offset = "0x2813EC0", Length = "0x1D0")]
	[Token(Token = "0x6000114")]
	protected private virtual void PerformLegacyUpgrade(int streamedVersion) { }

	[Address(RVA = "0x2814C90", Offset = "0x2814090", Length = "0x35")]
	[Token(Token = "0x6000112")]
	protected virtual void Reset() { }

	[Address(RVA = "0x2814CD0", Offset = "0x28140D0", Length = "0x88")]
	[Token(Token = "0x6000118")]
	protected virtual bool UpdateCameraCache() { }

}

