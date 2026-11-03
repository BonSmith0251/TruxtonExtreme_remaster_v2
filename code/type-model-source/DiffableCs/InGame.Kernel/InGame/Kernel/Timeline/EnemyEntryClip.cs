namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000E7")]
public class EnemyEntryClip : PlayableAsset, ITimelineClipAsset, IEnemyDataContain
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000640")]
	private EnemyData _enemyData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000641")]
	public string _enemyDataName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000642")]
	public string _ruinObject; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000643")]
	public bool _isLoopWave; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	[Token(Token = "0x4000644")]
	public bool _isGround; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[SerializeField]
	[Token(Token = "0x4000645")]
	public bool _isGroundSky; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[SerializeField]
	[Token(Token = "0x4000646")]
	[Tooltip("複製フラグ：有効だとリソース量が減")]
	public bool _isClone; //Field offset: 0x33
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000647")]
	[Tooltip("非死亡でも廃棄でトリガー")]
	public bool _isOutMeanDestroy; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000648")]
	public Vector3 _offset; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000649")]
	public Vector3 _rotate; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400064A")]
	public float _StartDelaySecond; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400064B")]
	public float _LoopDelaySecond; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400064C")]
	public int _indexValue; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x400064D")]
	public int _loopWaveMax; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400064E")]
	public Vector3[] _offsetTables; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400064F")]
	private Transform _parentTransform; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000650")]
	private Vector3 _entryOffset; //Field offset: 0x70

	[Token(Token = "0x1700015E")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000782")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700015F")]
	public virtual double duration
	{
		[Address(RVA = "0x1D35110", Offset = "0x1D34510", Length = "0x86")]
		[Token(Token = "0x600078E")]
		 get { } //Length: 134
	}

	[Address(RVA = "0x1D35030", Offset = "0x1D34430", Length = "0xD7")]
	[Token(Token = "0x6000781")]
	private EnemyData _getEnemyData() { }

	[Address(RVA = "0x1D34F30", Offset = "0x1D34330", Length = "0xFF")]
	[Token(Token = "0x600078F")]
	public EnemyEntryClip() { }

	[Address(RVA = "0x1D347D0", Offset = "0x1D33BD0", Length = "0x216")]
	[Token(Token = "0x600078B")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000782")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x1D35110", Offset = "0x1D34510", Length = "0x86")]
	[Token(Token = "0x600078E")]
	public virtual double get_duration() { }

	[Address(RVA = "0x1D349F0", Offset = "0x1D33DF0", Length = "0x14F")]
	[Token(Token = "0x6000785")]
	public override List<String> GetBulletTemplateNames() { }

	[Address(RVA = "0x1D34B40", Offset = "0x1D33F40", Length = "0x40")]
	[Token(Token = "0x600078C")]
	public Vector3 GetClipOffset() { }

	[Address(RVA = "0x1D34B80", Offset = "0x1D33F80", Length = "0x1BA")]
	[Token(Token = "0x6000783")]
	public override List<String> GetEnemyNames() { }

	[Address(RVA = "0x1D34D40", Offset = "0x1D34140", Length = "0x79")]
	[Token(Token = "0x6000784")]
	public override List<String> GetRouteNames() { }

	[Address(RVA = "0x1D34DC0", Offset = "0x1D341C0", Length = "0x5")]
	[Token(Token = "0x6000788")]
	public override bool IsClone() { }

	[Address(RVA = "0x1D34DD0", Offset = "0x1D341D0", Length = "0x78")]
	[Token(Token = "0x600078A")]
	public override bool IsContainEnemyData() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000789")]
	public override bool IsEnemyClip() { }

	[Address(RVA = "0x1D34E50", Offset = "0x1D34250", Length = "0xD")]
	[Token(Token = "0x6000787")]
	public override bool IsGround() { }

	[Address(RVA = "0x1D34E60", Offset = "0x1D34260", Length = "0xCE")]
	[Token(Token = "0x6000786")]
	public override string RuinObject() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x600078D")]
	public void SetParentTransform(Transform _root) { }

}

