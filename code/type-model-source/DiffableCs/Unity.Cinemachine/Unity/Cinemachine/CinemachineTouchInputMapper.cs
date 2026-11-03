namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[Obsolete]
[Token(Token = "0x2000134")]
public class CinemachineTouchInputMapper : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004FE")]
	[Tooltip("Sensitivity multiplier for x-axis")]
	public float TouchSensitivityX; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004FF")]
	[Tooltip("Sensitivity multiplier for y-axis")]
	public float TouchSensitivityY; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000500")]
	[Tooltip("Input channel to spoof for X axis")]
	public string TouchXInputMapTo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000501")]
	[Tooltip("Input channel to spoof for Y axis")]
	public string TouchYInputMapTo; //Field offset: 0x30

	[Address(RVA = "0x28783D0", Offset = "0x28777D0", Length = "0x84")]
	[Token(Token = "0x60005F9")]
	public CinemachineTouchInputMapper() { }

	[Address(RVA = "0x2878230", Offset = "0x2877630", Length = "0xD4")]
	[Token(Token = "0x60005F8")]
	private float GetInputAxis(string axisName) { }

	[Address(RVA = "0x2878310", Offset = "0x2877710", Length = "0xB3")]
	[Token(Token = "0x60005F7")]
	private void Start() { }

}

