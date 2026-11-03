namespace UnityEngine.Rendering;

[Token(Token = "0x200001D")]
public class CameraSwitcher : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008B")]
	public Camera[] m_Cameras; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008C")]
	private int m_CurrentCameraIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400008D")]
	private Camera m_OriginalCamera; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400008E")]
	private Vector3 m_OriginalCameraPosition; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400008F")]
	private Quaternion m_OriginalCameraRotation; //Field offset: 0x44
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000090")]
	private Camera m_CurrentCamera; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000091")]
	private GUIContent[] m_CameraNames; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000092")]
	private Int32[] m_CameraIndices; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000093")]
	private EnumField m_DebugEntry; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000094")]
	private int m_DebugEntryEnumIndex; //Field offset: 0x78

	[Address(RVA = "0x2BBAF90", Offset = "0x2BBA390", Length = "0xE")]
	[Token(Token = "0x60000D0")]
	public CameraSwitcher() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000D1")]
	private int <OnEnable>b__10_0() { }

	[Address(RVA = "0x2BBAF80", Offset = "0x2BBA380", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000D2")]
	private void <OnEnable>b__10_1(int value) { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000D3")]
	private int <OnEnable>b__10_2() { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000D4")]
	private void <OnEnable>b__10_3(int value) { }

	[Address(RVA = "0x2BBA550", Offset = "0x2BB9950", Length = "0x1C")]
	[Token(Token = "0x60000CD")]
	private int GetCameraCount() { }

	[Address(RVA = "0x2BBA570", Offset = "0x2BB9970", Length = "0x40")]
	[Token(Token = "0x60000CE")]
	private Camera GetNextCamera() { }

	[Address(RVA = "0x2BBA5C0", Offset = "0x2BB99C0", Length = "0x92")]
	[Token(Token = "0x60000CC")]
	private void OnDisable() { }

	[Address(RVA = "0x2BBA660", Offset = "0x2BB9A60", Length = "0x679")]
	[Token(Token = "0x60000CB")]
	private void OnEnable() { }

	[Address(RVA = "0x2BBACE0", Offset = "0x2BBA0E0", Length = "0x295")]
	[Token(Token = "0x60000CF")]
	private void SetCameraIndex(int index) { }

}

