namespace InGame.Kernel.Enemy;

[Token(Token = "0x200022E")]
public class RookEnemy : PawnEnemyDD
{
	[CompilerGenerated]
	[Token(Token = "0x200022F")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001382")]
		public RookEnemy <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001383")]
		public PawnEnemy r; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010B4")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x1D1AAA0", Offset = "0x1D19EA0", Length = "0x54")]
		[Token(Token = "0x60010B5")]
		internal void <SetChildObject>b__0() { }

	}

	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x400137C")]
	protected EnemyChildData[] _children; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400137D")]
	protected List<PawnEnemy> _childObjects; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x400137E")]
	protected string _deadEnemyStr; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x400137F")]
	protected string _separationParent; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	[Token(Token = "0x4001380")]
	protected bool _deadEnemyIsGround; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F1")]
	[SerializeField]
	[Token(Token = "0x4001381")]
	protected bool _isChildrenSolidarity; //Field offset: 0x1F1

	[Address(RVA = "0x1D1A560", Offset = "0x1D19960", Length = "0xB3")]
	[Token(Token = "0x60010AE")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1D1A2F0", Offset = "0x1D196F0", Length = "0x262")]
	[Token(Token = "0x60010B1")]
	private void _SeparationChildren() { }

	[Address(RVA = "0x1D1A620", Offset = "0x1D19A20", Length = "0xA8")]
	[Token(Token = "0x60010B3")]
	public RookEnemy() { }

	[Address(RVA = "0x1D19CC0", Offset = "0x1D190C0", Length = "0x43")]
	[Token(Token = "0x60010B2")]
	protected bool HasChildObject() { }

	[Address(RVA = "0x1D19D10", Offset = "0x1D19110", Length = "0x1FD")]
	[Token(Token = "0x60010AD")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D19F10", Offset = "0x1D19310", Length = "0x156")]
	[Token(Token = "0x60010AF")]
	public override void SetChildObject(PawnEnemy r, int tindex) { }

	[Address(RVA = "0x1D1A070", Offset = "0x1D19470", Length = "0x27B")]
	[Token(Token = "0x60010B0")]
	public virtual EnemyChildData[] SubEnemys() { }

}

