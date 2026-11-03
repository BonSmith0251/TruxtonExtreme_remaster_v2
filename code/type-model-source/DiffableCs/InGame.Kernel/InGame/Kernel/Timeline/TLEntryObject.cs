namespace InGame.Kernel.Timeline;

[Token(Token = "0x2000102")]
public class TLEntryObject : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000724")]
	private PlayableDirector _tl; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000807")]
	public TLEntryObject() { }

	[Address(RVA = "0x1D530F0", Offset = "0x1D524F0", Length = "0xB1")]
	[Token(Token = "0x6000802")]
	public void Initialize() { }

	[Address(RVA = "0x1D531B0", Offset = "0x1D525B0", Length = "0x34")]
	[Token(Token = "0x6000804")]
	public void Progress(double n) { }

	[Address(RVA = "0x1D531F0", Offset = "0x1D525F0", Length = "0x4D")]
	[Token(Token = "0x6000805")]
	public void SetTLActive(bool ta) { }

	[Address(RVA = "0x1D53240", Offset = "0x1D52640", Length = "0x70")]
	[Token(Token = "0x6000803")]
	public void StartTL(double n) { }

	[Address(RVA = "0x1D532C0", Offset = "0x1D526C0", Length = "0x111")]
	[Token(Token = "0x6000806")]
	public void Terminate() { }

}

