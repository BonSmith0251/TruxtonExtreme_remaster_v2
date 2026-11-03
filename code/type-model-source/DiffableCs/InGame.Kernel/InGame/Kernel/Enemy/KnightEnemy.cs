namespace InGame.Kernel.Enemy;

[Token(Token = "0x200021A")]
public class KnightEnemy : RookEnemy
{
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40012F2")]
	protected List<PawnEnemy> _childEnemies; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Header("召喚敵prefab")]
	[SerializeField]
	[Token(Token = "0x40012F3")]
	protected string _summonNameStr; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[SerializeField]
	[Token(Token = "0x40012F4")]
	protected int _summonEnemyCount; //Field offset: 0x208

	[Address(RVA = "0x1D0C3E0", Offset = "0x1D0B7E0", Length = "0xB4")]
	[Token(Token = "0x6000FD5")]
	public KnightEnemy() { }

	[Address(RVA = "0x1D0BCC0", Offset = "0x1D0B0C0", Length = "0x6C")]
	[Token(Token = "0x6000FCE")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D0BD30", Offset = "0x1D0B130", Length = "0x56")]
	[Token(Token = "0x6000FD3")]
	public override void ChildDieCallback(PawnEnemy pe) { }

	[Address(RVA = "0x1D0BD90", Offset = "0x1D0B190", Length = "0x207")]
	[Token(Token = "0x6000FD0")]
	protected void CreateAllChildren() { }

	[Address(RVA = "0x1D0BFA0", Offset = "0x1D0B3A0", Length = "0x1B4")]
	[Token(Token = "0x6000FD1")]
	private void CreateChild() { }

	[Address(RVA = "0x1D0C160", Offset = "0x1D0B560", Length = "0x54")]
	[Token(Token = "0x6000FD2")]
	protected PawnEnemy GetChildEnemy(int idx) { }

	[Address(RVA = "0x1D0C1C0", Offset = "0x1D0B5C0", Length = "0x78")]
	[Token(Token = "0x6000FCD")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D0C240", Offset = "0x1D0B640", Length = "0xB4")]
	[Token(Token = "0x6000FD4")]
	protected void SendChildEvent(int num) { }

	[Address(RVA = "0x1D0C300", Offset = "0x1D0B700", Length = "0xD3")]
	[Token(Token = "0x6000FCF")]
	public virtual EnemyChildData[] SubEnemys() { }

}

