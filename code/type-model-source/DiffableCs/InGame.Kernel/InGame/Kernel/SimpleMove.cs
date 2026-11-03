namespace InGame.Kernel;

[Token(Token = "0x20000AA")]
public class SimpleMove : MonoBehaviour
{
	[Token(Token = "0x20000AC")]
	internal enum CurveType : int
	{
		Straight = 0,
		Sine = 1,
		Data = 2,
	}

	[Token(Token = "0x20000AB")]
	internal enum MoveType : int
	{
		Lerp = 0,
		SlowFast = 1,
		FastSlow = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000513")]
	private Action onArriveEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000514")]
	private AnimationCurve _curveData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x4000515")]
	private MoveType _moveType; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x4000516")]
	private CurveType _curveType; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000517")]
	private bool _isInArea; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000518")]
	private bool _isArrive; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000519")]
	protected bool _isLookAt; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x400051A")]
	protected bool _isMovePause; //Field offset: 0x3B
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400051B")]
	protected Transform _transformCache; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400051C")]
	protected Transform _gameRootCache; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400051D")]
	protected Vector3 _startPos; //Field offset: 0x50
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400051E")]
	protected Vector3 _oldPos; //Field offset: 0x5C
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400051F")]
	protected Vector3 _currentPos; //Field offset: 0x68
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000520")]
	protected Vector3 _dir; //Field offset: 0x74
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000521")]
	protected Quaternion _currentRot; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000522")]
	private Matrix4x4 _dirMatrix; //Field offset: 0x90
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000523")]
	protected float _baseSpeed; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x4000524")]
	private float _currentTime; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000525")]
	protected float _curveR; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000526")]
	private float _curveRange; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000527")]
	private int _uniqueId; //Field offset: 0xE0

	[Token(Token = "0x17000130")]
	public Vector3 CurrentPos
	{
		[Address(RVA = "0x16D0940", Offset = "0x16CFD40", Length = "0x13")]
		[Token(Token = "0x6000644")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000132")]
	public Quaternion CurrentRot
	{
		[Address(RVA = "0x1D43810", Offset = "0x1D42C10", Length = "0xE")]
		[Token(Token = "0x6000646")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000134")]
	protected float CurrentTime
	{
		[Address(RVA = "0x1D43820", Offset = "0x1D42C20", Length = "0x9")]
		[Token(Token = "0x6000648")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000133")]
	public Matrix4x4 DirMatrix
	{
		[Address(RVA = "0x1D43830", Offset = "0x1D42C30", Length = "0x2F")]
		[Token(Token = "0x6000647")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000131")]
	public Vector3 DirVector
	{
		[Address(RVA = "0x16D0820", Offset = "0x16CFC20", Length = "0x13")]
		[Token(Token = "0x6000645")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700012F")]
	public Transform GameRootCache
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000643")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012D")]
	public bool IsArrive
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[Token(Token = "0x6000641")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012C")]
	public bool IsInArea
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000640")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012E")]
	public Transform TransformCache
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000642")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000135")]
	public int UniqueID
	{
		[Address(RVA = "0x1CCEEF0", Offset = "0x1CCE2F0", Length = "0x7")]
		[Token(Token = "0x6000649")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1D434B0", Offset = "0x1D428B0", Length = "0x117")]
	[Token(Token = "0x600063B")]
	private Vector3 _getMoveVector(float rate) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000637")]
	protected override void _setupStart() { }

	[Address(RVA = "0x1D435D0", Offset = "0x1D429D0", Length = "0xAA")]
	[Token(Token = "0x6000639")]
	private void _updateFlag() { }

	[Address(RVA = "0x1D43680", Offset = "0x1D42A80", Length = "0x18A")]
	[Token(Token = "0x6000638")]
	protected override void _updateMove(float tdt) { }

	[Address(RVA = "0x1D40F90", Offset = "0x1D40390", Length = "0x1B")]
	[Token(Token = "0x600064A")]
	public SimpleMove() { }

	[Address(RVA = "0x1D42D90", Offset = "0x1D42190", Length = "0x5")]
	[Token(Token = "0x600062D")]
	public override void Arrive() { }

	[Address(RVA = "0x16D0940", Offset = "0x16CFD40", Length = "0x13")]
	[Token(Token = "0x6000644")]
	public Vector3 get_CurrentPos() { }

	[Address(RVA = "0x1D43810", Offset = "0x1D42C10", Length = "0xE")]
	[Token(Token = "0x6000646")]
	public Quaternion get_CurrentRot() { }

	[Address(RVA = "0x1D43820", Offset = "0x1D42C20", Length = "0x9")]
	[Token(Token = "0x6000648")]
	protected float get_CurrentTime() { }

	[Address(RVA = "0x1D43830", Offset = "0x1D42C30", Length = "0x2F")]
	[Token(Token = "0x6000647")]
	public Matrix4x4 get_DirMatrix() { }

	[Address(RVA = "0x16D0820", Offset = "0x16CFC20", Length = "0x13")]
	[Token(Token = "0x6000645")]
	public Vector3 get_DirVector() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000643")]
	public Transform get_GameRootCache() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[Token(Token = "0x6000641")]
	public bool get_IsArrive() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000640")]
	public bool get_IsInArea() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000642")]
	public Transform get_TransformCache() { }

	[Address(RVA = "0x1CCEEF0", Offset = "0x1CCE2F0", Length = "0x7")]
	[Token(Token = "0x6000649")]
	public int get_UniqueID() { }

	[Address(RVA = "0xE26BE0", Offset = "0xE25FE0", Length = "0x9")]
	[Token(Token = "0x600063E")]
	public override float GetFirstSpeed() { }

	[Address(RVA = "0xE26BE0", Offset = "0xE25FE0", Length = "0x9")]
	[Token(Token = "0x600063D")]
	public override float GetSpeed() { }

	[Address(RVA = "0x1D42DA0", Offset = "0x1D421A0", Length = "0x25")]
	[Token(Token = "0x6000624")]
	public override void Initialize() { }

	[Address(RVA = "0x1D42DD0", Offset = "0x1D421D0", Length = "0x96")]
	[Token(Token = "0x6000635")]
	public bool IsEntryedArea() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600062E")]
	public override bool IsHorming() { }

	[Address(RVA = "0x1D42E70", Offset = "0x1D42270", Length = "0x4")]
	[Token(Token = "0x600062F")]
	public void MovePause(bool isPause) { }

	[Address(RVA = "0x1D42E80", Offset = "0x1D42280", Length = "0x38")]
	[Token(Token = "0x6000636")]
	private void OnDestroy() { }

	[Address(RVA = "0x1D42EC0", Offset = "0x1D422C0", Length = "0x38")]
	[Token(Token = "0x6000633")]
	public void ProgressEnd() { }

	[Address(RVA = "0x1D42F00", Offset = "0x1D42300", Length = "0x119")]
	[Token(Token = "0x6000631")]
	public void ProgressMove(float dt) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000625")]
	public void RefreshRoot(Transform gmr) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000632")]
	public void SetArriveAction(Action tact) { }

	[Address(RVA = "0x16D0B90", Offset = "0x16CFF90", Length = "0x10")]
	[Token(Token = "0x6000634")]
	public void SetCurrentPos(Vector3 cpos) { }

	[Address(RVA = "0x1D43020", Offset = "0x1D42420", Length = "0x4D")]
	[Token(Token = "0x600062A")]
	public void SetCurveData(AnimationCurve anim, float r, float range) { }

	[Address(RVA = "0x1D43070", Offset = "0x1D42470", Length = "0x2A")]
	[Token(Token = "0x6000628")]
	public void SetCurveType(float r, float range) { }

	[Address(RVA = "0x1D430A0", Offset = "0x1D424A0", Length = "0x2A0")]
	[Token(Token = "0x600062B")]
	public void SetDirection(Vector3 ndir) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x6000630")]
	public void SetInArea(bool isArea) { }

	[Address(RVA = "0x1D43340", Offset = "0x1D42740", Length = "0xB")]
	[Token(Token = "0x600062C")]
	public void SetRot(Quaternion trot) { }

	[Address(RVA = "0xE26EA0", Offset = "0xE262A0", Length = "0x9")]
	[Token(Token = "0x600063C")]
	public void SetSpeed(float t) { }

	[Address(RVA = "0x1D43350", Offset = "0x1D42750", Length = "0x45")]
	[Token(Token = "0x6000627")]
	public void SetStartMove(Vector3 stpos) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600063F")]
	public override void SetTargetPlayer() { }

	[Address(RVA = "0x1D433A0", Offset = "0x1D427A0", Length = "0x7")]
	[Token(Token = "0x6000629")]
	public void SetUniqueId(int tid) { }

	[Address(RVA = "0x1D433B0", Offset = "0x1D427B0", Length = "0xAD")]
	[Token(Token = "0x6000626")]
	public override void StartMove(Vector3 stpos, Vector3 ndir, float speedRate, bool isLookAt = false, MoveType mt = 0) { }

	[Address(RVA = "0x1D43460", Offset = "0x1D42860", Length = "0x4A")]
	[Token(Token = "0x600063A")]
	public override void UpdatePosition() { }

}

