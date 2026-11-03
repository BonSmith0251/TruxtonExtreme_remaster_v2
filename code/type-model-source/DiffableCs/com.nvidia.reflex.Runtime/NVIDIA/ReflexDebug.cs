namespace NVIDIA;

[AddComponentMenu("NVIDIA/Reflex Debug")]
[Token(Token = "0x200000B")]
public class ReflexDebug : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C1")]
	private bool m_Enabled; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C2")]
	private NvReflex_LATENCY_RESULT_PARAMS markers; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C3")]
	private NvReflex_GET_SLEEP_STATUS_PARAMS sleepStatusParams; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C4")]
	private Reflex m_Reflex; //Field offset: 0x38

	[Address(RVA = "0x5D5A40", Offset = "0x5D4E40", Length = "0xB")]
	[Token(Token = "0x6000028")]
	public ReflexDebug() { }

	[Address(RVA = "0x5D4A30", Offset = "0x5D3E30", Length = "0xCA")]
	[Token(Token = "0x6000026")]
	private void AddScrollbar(float range, float size, float start) { }

	[Address(RVA = "0x5D4B00", Offset = "0x5D3F00", Length = "0xD91")]
	[Token(Token = "0x6000027")]
	private void OnGUI() { }

	[Address(RVA = "0x5D58A0", Offset = "0x5D4CA0", Length = "0x49")]
	[Token(Token = "0x6000024")]
	private void Start() { }

	[Address(RVA = "0x5D58F0", Offset = "0x5D4CF0", Length = "0x148")]
	[Token(Token = "0x6000025")]
	private void Update() { }

}

