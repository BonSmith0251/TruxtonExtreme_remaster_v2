namespace InGame.Kernel.Gimmick;

[Token(Token = "0x200014A")]
public class ObstacleEnemy : RookEnemy
{
	[Token(Token = "0x200014B")]
	private struct ObstacleChildData
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095B")]
		private EnemyData <_edata>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400095C")]
		private Transform <_enode>k__BackingField; //Field offset: 0x8

		[Token(Token = "0x170001C1")]
		public private EnemyData _edata
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000A54")]
			 get { } //Length: 4
			[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000A53")]
			private set { } //Length: 8
		}

		[Token(Token = "0x170001C2")]
		public private Transform _enode
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000A56")]
			 get { } //Length: 5
			[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000A55")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x6000A52")]
		public ObstacleChildData(EnemyData edata, Transform tnode) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000A54")]
		public EnemyData get__edata() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000A56")]
		public Transform get__enode() { }

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A53")]
		private void set__edata(EnemyData value) { }

		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A55")]
		private void set__enode(Transform value) { }

	}

	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	[Token(Token = "0x4000959")]
	private string _defaultEnemyData; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400095A")]
	private ObstacleChildData[] _swapedObjects; //Field offset: 0x200

	[Address(RVA = "0x1D725B0", Offset = "0x1D719B0", Length = "0x3C")]
	[Token(Token = "0x6000A51")]
	public ObstacleEnemy() { }

	[Address(RVA = "0x1D71AF0", Offset = "0x1D70EF0", Length = "0x1F")]
	[Token(Token = "0x6000A50")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D71B10", Offset = "0x1D70F10", Length = "0xB9")]
	[Token(Token = "0x6000A4C")]
	public virtual void EndRoute() { }

	[Address(RVA = "0x1D71BD0", Offset = "0x1D70FD0", Length = "0xDE")]
	[Token(Token = "0x6000A4E")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D71CB0", Offset = "0x1D710B0", Length = "0xBB")]
	[Token(Token = "0x6000A4D")]
	public virtual List<String> GetRouteNames() { }

	[Address(RVA = "0x1D71D70", Offset = "0x1D71170", Length = "0x39")]
	[Token(Token = "0x6000A4B")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D71DB0", Offset = "0x1D711B0", Length = "0x2E7")]
	[Token(Token = "0x6000A43")]
	public virtual void Initialize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A47")]
	public virtual bool IsDestroyRateTarget() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A46")]
	public virtual bool IsNoDamaged() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A48")]
	public virtual bool IsObstacle() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A49")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1D720A0", Offset = "0x1D714A0", Length = "0x8B")]
	[Token(Token = "0x6000A44")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D72130", Offset = "0x1D71530", Length = "0x8B")]
	[Token(Token = "0x6000A45")]
	protected virtual void OnStayProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D721C0", Offset = "0x1D715C0", Length = "0x31")]
	[Token(Token = "0x6000A4A")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D72200", Offset = "0x1D71600", Length = "0x3A1")]
	[Token(Token = "0x6000A4F")]
	private void StartChildrens() { }

}

