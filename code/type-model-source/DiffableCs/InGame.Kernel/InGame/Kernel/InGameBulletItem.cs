namespace InGame.Kernel;

[Token(Token = "0x2000013")]
public class InGameBulletItem : MonoBehaviour, InGameBulletInterface, IPrefabBankObject
{
	[Token(Token = "0x400008E")]
	private static readonly float getDistance; //Field offset: 0x0
	[Token(Token = "0x400008F")]
	private static readonly float takenDistance; //Field offset: 0x4
	[Token(Token = "0x4000090")]
	public static readonly float JewelSpeed; //Field offset: 0x8
	[Token(Token = "0x4000091")]
	private static readonly int _jewelGetEffect; //Field offset: 0xC
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private Renderer _modelRender; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000093")]
	private SimpleMoveJewel _jewelMove; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000094")]
	private Action<Int32> _poolAction; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000095")]
	private GameObject _gameobjectCache; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000096")]
	private Transform _transfomCache; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000097")]
	private int _targetPlayer; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000098")]
	private int _pindex; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000099")]
	private float _bornPassed; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400009A")]
	private float _takenLen; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400009B")]
	private bool _isEntryedArea; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x400009C")]
	private bool _isDone; //Field offset: 0x59

	[Token(Token = "0x1700001F")]
	public bool IsDone
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001E")]
	public int PIndex
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700001D")]
	public Transform TransformCache
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1CCA980", Offset = "0x1CC9D80", Length = "0xA4")]
	[Token(Token = "0x60000CF")]
	private static InGameBulletItem() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60000CE")]
	public InGameBulletItem() { }

	[Address(RVA = "0x1CC9E70", Offset = "0x1CC9270", Length = "0x60")]
	[Token(Token = "0x60000B6")]
	public override void CallDisabled() { }

	[Address(RVA = "0x1CC9EE0", Offset = "0x1CC92E0", Length = "0x6")]
	[Token(Token = "0x60000C1")]
	public override BulletColorType ColorType() { }

	[Address(RVA = "0x1CC9EF0", Offset = "0x1CC92F0", Length = "0x29")]
	[Token(Token = "0x60000C5")]
	public Vector3 CurrentPos() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x60000CD")]
	public bool get_IsDone() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60000CC")]
	public int get_PIndex() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60000CB")]
	public Transform get_TransformCache() { }

	[Address(RVA = "0x1CC9F20", Offset = "0x1CC9320", Length = "0x41")]
	[Token(Token = "0x60000C7")]
	public static float GetJewelDropSize(EnemySize tsize) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60000CA")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1CC9F70", Offset = "0x1CC9370", Length = "0x69")]
	[Token(Token = "0x60000B0")]
	public override void Initialize() { }

	[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
	[Token(Token = "0x60000BD")]
	public override bool IsEnableScript() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000BC")]
	public override bool IsLaser() { }

	[Address(RVA = "0x1CC9FF0", Offset = "0x1CC93F0", Length = "0x2B")]
	[Token(Token = "0x60000C3")]
	private void JemsDone() { }

	[Address(RVA = "0x1CCA020", Offset = "0x1CC9420", Length = "0x730")]
	[Token(Token = "0x60000C4")]
	public override void LateUpdater(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C2")]
	public void LocalLateUpdate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000B5")]
	public override void ProgressBullet(float dt) { }

	[Address(RVA = "0x1CCA760", Offset = "0x1CC9B60", Length = "0x23")]
	[Token(Token = "0x60000B2")]
	public override void RefreshRoot(Transform gmr) { }

	[Address(RVA = "0x1CCA790", Offset = "0x1CC9B90", Length = "0x37")]
	[Token(Token = "0x60000C6")]
	public float RotSpeed() { }

	[Address(RVA = "0x1CCA7D0", Offset = "0x1CC9BD0", Length = "0x1E")]
	[Token(Token = "0x60000C9")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000B9")]
	public override void SetCauseOfDeath(int playerNo, attackType atkType, bool isExboost) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000B8")]
	public override void SetCurveData(AnimationCurve _curve, float r, float range) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000B7")]
	public override void SetCurveType(float r, float range) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000BE")]
	public override void SetEmitterInformation(InGameEnemyMoveBase _m, Transform temit, Transform tdir, int nFire, bool isSelf) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000BF")]
	public override void SetIrradiationTime(float t) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C0")]
	public override void SetOffsetPosition(Vector3 pos) { }

	[Address(RVA = "0x1CCA7F0", Offset = "0x1CC9BF0", Length = "0x2B")]
	[Token(Token = "0x60000B3")]
	public override void SetPoolAction(Action<Int32> pa, int tindex) { }

	[Address(RVA = "0x1CCA820", Offset = "0x1CC9C20", Length = "0xCD")]
	[Token(Token = "0x60000BA")]
	public void SetPreInfo(Vector3 tdir, int tpno) { }

	[Address(RVA = "0x1CCA8F0", Offset = "0x1CC9CF0", Length = "0x42")]
	[Token(Token = "0x60000BB")]
	public void SetStartInfo(Vector3 cpos) { }

	[Address(RVA = "0x1CCA940", Offset = "0x1CC9D40", Length = "0x3F")]
	[Token(Token = "0x60000C8")]
	public override void SetupCache() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000B4")]
	public override void StartMove(Vector3 s, Vector3 e, float tspeed, MoveType moveType) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000B1")]
	public override void Terminate() { }

}

