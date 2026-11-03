namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000EC")]
public class EnemyWaveClip : PlayableAsset, ITimelineClipAsset, IEnemyDataContain
{
	[Token(Token = "0x20000ED")]
	internal enum WaveBonus : int
	{
		none = 0,
		Score5000 = 100,
		ItemPow = 200,
		ItemBomb = 201,
		ItemBombGrow = 202,
		ItemSpeedUp = 203,
		ItemScoreUp = 204,
		ItemChange = 205,
		Enemy = 300,
		AreaBreak = 400,
		StageClear = 1000,
	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000663")]
	private WaveBonus _bonus; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000664")]
	private string _enemyDataName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000665")]
	public string _ruinObject; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000666")]
	private String[] _targetFilter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000667")]
	private Vector3 _ePos; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000668")]
	private Vector3 _eRot; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000669")]
	private int _enemyCallIndexValue; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400066A")]
	[Tooltip("エリア内監視継続")]
	private bool _isEmptyArea; //Field offset: 0x54

	[Token(Token = "0x17000160")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600079E")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1D36920", Offset = "0x1D35D20", Length = "0xC6")]
	[Token(Token = "0x60007AA")]
	public EnemyWaveClip() { }

	[Address(RVA = "0x1D36180", Offset = "0x1D35580", Length = "0x5C0")]
	[Token(Token = "0x600079F")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600079E")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x1D36750", Offset = "0x1D35B50", Length = "0x79")]
	[Token(Token = "0x60007A2")]
	public override List<String> GetBulletTemplateNames() { }

	[Address(RVA = "0x1D369F0", Offset = "0x1D35DF0", Length = "0xAE")]
	[Token(Token = "0x60007A8")]
	private EnemyData getEnemyData() { }

	[Address(RVA = "0x1D367D0", Offset = "0x1D35BD0", Length = "0x79")]
	[Token(Token = "0x60007A0")]
	public override List<String> GetEnemyNames() { }

	[Address(RVA = "0x1D36850", Offset = "0x1D35C50", Length = "0x79")]
	[Token(Token = "0x60007A1")]
	public override List<String> GetRouteNames() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60007A4")]
	public override bool IsClone() { }

	[Address(RVA = "0x1D368D0", Offset = "0x1D35CD0", Length = "0x26")]
	[Token(Token = "0x60007A7")]
	public override bool IsContainEnemyData() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60007A6")]
	public override bool IsEnemyClip() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60007A5")]
	public override bool IsGround() { }

	[Address(RVA = "0x1D36900", Offset = "0x1D35D00", Length = "0x16")]
	[Token(Token = "0x60007A9")]
	private bool IsUseFilter() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60007A3")]
	public override string RuinObject() { }

}

