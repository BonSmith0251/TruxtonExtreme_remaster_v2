namespace InGame.Kernel.Timeline;

[Token(Token = "0x2000103")]
public class TLEntryOffset : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x4000725")]
	private Vector3 _enemyEntryOffset; //Field offset: 0x20

	[Token(Token = "0x17000176")]
	public Vector3 enemyEntryOffset
	{
		[Address(RVA = "0x1D53450", Offset = "0x1D52850", Length = "0x13")]
		[Token(Token = "0x6000809")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x1D533F0", Offset = "0x1D527F0", Length = "0x51")]
	[Token(Token = "0x600080A")]
	public TLEntryOffset() { }

	[Address(RVA = "0x1D53450", Offset = "0x1D52850", Length = "0x13")]
	[Token(Token = "0x6000809")]
	public Vector3 get_enemyEntryOffset() { }

	[Address(RVA = "0x1D533E0", Offset = "0x1D527E0", Length = "0x10")]
	[Token(Token = "0x6000808")]
	public void SetOffset(Vector3 tpos) { }

}

