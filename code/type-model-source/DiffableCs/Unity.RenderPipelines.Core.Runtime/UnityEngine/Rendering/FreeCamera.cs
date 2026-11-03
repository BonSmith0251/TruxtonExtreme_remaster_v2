namespace UnityEngine.Rendering;

[Token(Token = "0x200001E")]
public class FreeCamera : MonoBehaviour
{
	[Token(Token = "0x4000095")]
	private const float k_MouseSensitivityMultiplier = 0.01; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000096")]
	public float m_LookSpeedController; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000097")]
	public float m_LookSpeedMouse; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000098")]
	public float m_MoveSpeed; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000099")]
	public float m_MoveSpeedIncrement; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400009A")]
	public float m_Turbo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400009B")]
	private InputAction lookAction; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400009C")]
	private InputAction moveAction; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400009D")]
	private InputAction speedAction; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400009E")]
	private InputAction yMoveAction; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400009F")]
	private float inputRotateAxisX; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40000A0")]
	private float inputRotateAxisY; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000A1")]
	private float inputChangeSpeed; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000A2")]
	private float inputVertical; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000A3")]
	private float inputHorizontal; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000A4")]
	private float inputYAxis; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000A5")]
	private bool leftShiftBoost; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40000A6")]
	private bool leftShift; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x40000A7")]
	private bool fire1; //Field offset: 0x72

	[Address(RVA = "0x2BC1E30", Offset = "0x2BC1230", Length = "0x2A")]
	[Token(Token = "0x60000D9")]
	public FreeCamera() { }

	[Address(RVA = "0x2BC0F90", Offset = "0x2BC0390", Length = "0x7")]
	[Token(Token = "0x60000D5")]
	private void OnEnable() { }

	[Address(RVA = "0x2BC0FA0", Offset = "0x2BC03A0", Length = "0x7B1")]
	[Token(Token = "0x60000D6")]
	private void RegisterInputs() { }

	[Address(RVA = "0x2BC1A10", Offset = "0x2BC0E10", Length = "0x41A")]
	[Token(Token = "0x60000D8")]
	private void Update() { }

	[Address(RVA = "0x2BC1760", Offset = "0x2BC0B60", Length = "0x2A5")]
	[Token(Token = "0x60000D7")]
	private void UpdateInputs() { }

}

