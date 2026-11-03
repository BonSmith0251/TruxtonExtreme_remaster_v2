namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Group Weight Manipulator")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/GroupWeightManipulator.html")]
[RequireComponent(typeof(CinemachineTargetGroup))]
[Token(Token = "0x200014E")]
public class GroupWeightManipulator : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_Weight0")]
	[Token(Token = "0x4000580")]
	[Tooltip("The weight of the group member at index 0")]
	public float Weight0; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("m_Weight1")]
	[Token(Token = "0x4000581")]
	[Tooltip("The weight of the group member at index 1")]
	public float Weight1; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_Weight2")]
	[Token(Token = "0x4000582")]
	[Tooltip("The weight of the group member at index 2")]
	public float Weight2; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("m_Weight3")]
	[Token(Token = "0x4000583")]
	[Tooltip("The weight of the group member at index 3")]
	public float Weight3; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Weight4")]
	[Token(Token = "0x4000584")]
	[Tooltip("The weight of the group member at index 4")]
	public float Weight4; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_Weight5")]
	[Token(Token = "0x4000585")]
	[Tooltip("The weight of the group member at index 5")]
	public float Weight5; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_Weight6")]
	[Token(Token = "0x4000586")]
	[Tooltip("The weight of the group member at index 6")]
	public float Weight6; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_Weight7")]
	[Token(Token = "0x4000587")]
	[Tooltip("The weight of the group member at index 7")]
	public float Weight7; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000588")]
	private CinemachineTargetGroup m_Group; //Field offset: 0x40

	[Address(RVA = "0x287DB10", Offset = "0x287CF10", Length = "0x3F")]
	[Token(Token = "0x6000681")]
	public GroupWeightManipulator() { }

	[Address(RVA = "0x287D830", Offset = "0x287CC30", Length = "0x6B")]
	[Token(Token = "0x600067E")]
	private void OnValidate() { }

	[Address(RVA = "0x287D8A0", Offset = "0x287CCA0", Length = "0x3D")]
	[Token(Token = "0x600067D")]
	private void Start() { }

	[Address(RVA = "0x287DAA0", Offset = "0x287CEA0", Length = "0x68")]
	[Token(Token = "0x600067F")]
	private void Update() { }

	[Address(RVA = "0x287D8E0", Offset = "0x287CCE0", Length = "0x1B1")]
	[Token(Token = "0x6000680")]
	private void UpdateWeights() { }

}

