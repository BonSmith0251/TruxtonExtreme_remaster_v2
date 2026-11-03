namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000204")]
public class Ene_Sh01 : PawnEnemy
{
	[Token(Token = "0x4001225")]
	private const float RotateTime = 10; //Field offset: 0x0
	[Token(Token = "0x4001226")]
	private static readonly Vector3[] RotateSpeedTable; //Field offset: 0x0
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4001221")]
	private Transform _rotateTarget; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001222")]
	private Quaternion _rotateBaseLocalRotation; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001223")]
	private Vector3 _rotateEuler; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4001224")]
	private int _rotateTableIndex; //Field offset: 0x1D4

	[Address(RVA = "0x1CFF570", Offset = "0x1CFE970", Length = "0x12F")]
	[Token(Token = "0x6000F45")]
	private void _resolveRotateTarget() { }

	[Address(RVA = "0x1CFF6A0", Offset = "0x1CFEAA0", Length = "0x9D")]
	[Token(Token = "0x6000F44")]
	private void _setupRotateByIndexValue() { }

	[Address(RVA = "0x1CFF370", Offset = "0x1CFE770", Length = "0x134")]
	[Token(Token = "0x6000F47")]
	private static Ene_Sh01() { }

	[Address(RVA = "0x1CFF4B0", Offset = "0x1CFE8B0", Length = "0xBC")]
	[Token(Token = "0x6000F46")]
	public Ene_Sh01() { }

	[Address(RVA = "0x1CFEEB0", Offset = "0x1CFE2B0", Length = "0x301")]
	[Token(Token = "0x6000F43")]
	protected virtual void ProgressEvent(float deltaTime, int eventCount) { }

	[Address(RVA = "0x1CFF1C0", Offset = "0x1CFE5C0", Length = "0x1AA")]
	[Token(Token = "0x6000F42")]
	public virtual void ReStart(bool withPlay) { }

}

