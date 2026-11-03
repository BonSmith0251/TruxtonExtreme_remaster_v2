//Type is in global namespace

[Token(Token = "0x2000005")]
public class TXECameraTextureBinder : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	private string textureName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000011")]
	private Camera targetCamera; //Field offset: 0x28

	[Address(RVA = "0x5D4400", Offset = "0x5D3800", Length = "0x4F")]
	[Token(Token = "0x600000A")]
	public TXECameraTextureBinder() { }

	[Address(RVA = "0x5D4200", Offset = "0x5D3600", Length = "0x117")]
	[Token(Token = "0x6000009")]
	private void OnBeginCameraRendering(ScriptableRenderContext ctx, Camera cam) { }

	[Address(RVA = "0x5D4320", Offset = "0x5D3720", Length = "0x6D")]
	[Token(Token = "0x6000008")]
	private void OnDisable() { }

	[Address(RVA = "0x5D4390", Offset = "0x5D3790", Length = "0x6D")]
	[Token(Token = "0x6000007")]
	private void OnEnable() { }

}

