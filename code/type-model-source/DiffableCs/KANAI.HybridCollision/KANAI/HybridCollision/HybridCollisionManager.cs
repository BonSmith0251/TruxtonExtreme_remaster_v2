namespace KANAI.HybridCollision;

[Token(Token = "0x2000005")]
public class HybridCollisionManager : SimpleSingleton<HybridCollisionManager>
{
	[CompilerGenerated]
	[Token(Token = "0x2000008")]
	private sealed class <Initialize>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000030")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000031")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000032")]
		public HybridCollisionManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000033")]
		public Transform _gameArea; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000034")]
		public Camera mcam; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000035")]
		public Camera ccam; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000036")]
		public Transform _poolArea; //Field offset: 0x40

		[Token(Token = "0x17000010")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000057")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000011")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000059")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000054")]
		public <Initialize>d__4(int <>1__state) { }

		[Address(RVA = "0x1DE16A0", Offset = "0x1DE0AA0", Length = "0xFA8")]
		[Token(Token = "0x6000056")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000057")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000059")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DE2670", Offset = "0x1DE1A70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000058")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000055")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000006")]
	internal struct CollisionOrder
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002B")]
		internal HybridCollisionBridge _enemy; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002C")]
		internal int _collsionType; //Field offset: 0x8

		[Token(Token = "0x1700000F")]
		public int CollisionType
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6000051")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700000E")]
		public HybridCollisionBridge EnemyBridge
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x6000050")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000051")]
		public int get_CollisionType() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000050")]
		public HybridCollisionBridge get_EnemyBridge() { }

		[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
		[Token(Token = "0x6000052")]
		public void Set(HybridCollisionBridge b, int ctype) { }

	}

	[BurstCompile]
	[Token(Token = "0x2000007")]
	private struct SimpleAssignJob : IJobParallelForTransform
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x400002D")]
		public NativeArray<Vector3> sourcePositions; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x400002E")]
		public NativeArray<Quaternion> sourceRotations; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x400002F")]
		public NativeArray<Boolean> sourceIsDo; //Field offset: 0x20

		[Address(RVA = "0x1DE1640", Offset = "0x1DE0A40", Length = "0x60")]
		[Token(Token = "0x6000053")]
		public override void Execute(int index, TransformAccess tt) { }

	}

	[Token(Token = "0x4000012")]
	public static readonly int ScreenWidth; //Field offset: 0x0
	[Token(Token = "0x4000013")]
	public static readonly int ScreenHeight; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000010")]
	private readonly int _orderIndexMax; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000011")]
	private readonly int BurstMax; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000014")]
	private TransformAccessArray _transformAccessArray; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000015")]
	private NativeList<Vector3> _positionAccess; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000016")]
	private NativeList<Quaternion> _rotateAccess; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000017")]
	private NativeList<Boolean> _doAccess; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000018")]
	private JobHandle _jhandle; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000019")]
	private bool _doJob; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400001A")]
	private Quaternion _gameRootRot; //Field offset: 0x4C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400001B")]
	private Transform _collisionArea; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400001C")]
	private Camera _mainCamera; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400001D")]
	private Camera _collisionCamera; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400001E")]
	private Camera _groundCamera; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400001F")]
	private float _scaleFactorZ; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000020")]
	private float _scaleFactorX; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000021")]
	private float _scaleFactorY; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000022")]
	private float _cameraTall; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000023")]
	private Vector2 _sameScaleFactor; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000024")]
	private Bounds _collisionBounds; //Field offset: 0x98
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000025")]
	private Bounds _displayBounds; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000026")]
	private List<HybridCollisions> _chainList; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000027")]
	private int _burstCount; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x4000028")]
	private int _orderIndex; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000029")]
	private CollisionOrder[] _orders; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400002A")]
	private Dictionary<Shape, GameObject> _shapes; //Field offset: 0xE0

	[Token(Token = "0x1700000B")]
	public int BurstCount
	{
		[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000006")]
	public Transform CollisionArea
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600003E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000008")]
	public Camera CollisionCamera
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public Quaternion GameRootRot
	{
		[Address(RVA = "0x1DDD1D0", Offset = "0x1DDC5D0", Length = "0xB")]
		[Token(Token = "0x600003D")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000009")]
	public Camera GroundCamera
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000007")]
	public Camera MainCamera
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000C")]
	public int OrderIndex
	{
		[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700000D")]
	public CollisionOrder[] Orders
	{
		[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000A")]
	public Vector2 SameScaleFactor
	{
		[Address(RVA = "0x16D1F60", Offset = "0x16D1360", Length = "0x19")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 25
	}

	[Address(RVA = "0x1DDCFF0", Offset = "0x1DDC3F0", Length = "0x4E")]
	[Token(Token = "0x600004F")]
	private static HybridCollisionManager() { }

	[Address(RVA = "0x1DDD040", Offset = "0x1DDC440", Length = "0x186")]
	[Token(Token = "0x600004E")]
	public HybridCollisionManager() { }

	[Address(RVA = "0x1DDA260", Offset = "0x1DD9660", Length = "0xCD")]
	[Token(Token = "0x600004B")]
	private float AdjustScreenXFromTarget(Camera cam, float screenX) { }

	[Address(RVA = "0x1DDA330", Offset = "0x1DD9730", Length = "0xE8")]
	[Token(Token = "0x600004A")]
	private float AdjustViewportXFromTarget(Camera cam, float viewportX) { }

	[Address(RVA = "0x1DDA420", Offset = "0x1DD9820", Length = "0xE8")]
	[Token(Token = "0x6000049")]
	private float AdjustViewportXToTarget(Camera cam, float viewportX) { }

	[Address(RVA = "0x1DDA510", Offset = "0x1DD9910", Length = "0x114")]
	[Token(Token = "0x6000025")]
	public void ClearCollisionArea() { }

	[Address(RVA = "0x1DDA630", Offset = "0x1DD9A30", Length = "0xA5")]
	[Token(Token = "0x600003B")]
	public void CompleteJobs() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000034")]
	public void DebugDisplay() { }

	[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
	[Token(Token = "0x6000043")]
	public int get_BurstCount() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600003E")]
	public Transform get_CollisionArea() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000040")]
	public Camera get_CollisionCamera() { }

	[Address(RVA = "0x1DDD1D0", Offset = "0x1DDC5D0", Length = "0xB")]
	[Token(Token = "0x600003D")]
	public Quaternion get_GameRootRot() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000041")]
	public Camera get_GroundCamera() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600003F")]
	public Camera get_MainCamera() { }

	[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
	[Token(Token = "0x6000044")]
	public int get_OrderIndex() { }

	[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
	[Token(Token = "0x6000045")]
	public CollisionOrder[] get_Orders() { }

	[Address(RVA = "0x16D1F60", Offset = "0x16D1360", Length = "0x19")]
	[Token(Token = "0x6000042")]
	public Vector2 get_SameScaleFactor() { }

	[Address(RVA = "0x1DDA6E0", Offset = "0x1DD9AE0", Length = "0xF8")]
	[Token(Token = "0x6000047")]
	private static Rect GetCameraPixelRect(Camera cam) { }

	[Address(RVA = "0x1DDA7E0", Offset = "0x1DD9BE0", Length = "0xE")]
	[Token(Token = "0x6000038")]
	public Camera GetGameCamera(bool isGround) { }

	[Address(RVA = "0x1DDA7F0", Offset = "0x1DD9BF0", Length = "0x1E2")]
	[Token(Token = "0x6000024")]
	public GameObject GetGameObject(Shape shapeType, Transform pparent) { }

	[Address(RVA = "0x1DDA9E0", Offset = "0x1DD9DE0", Length = "0xC")]
	[Token(Token = "0x600001F")]
	public float GetScaleFactorX(float t) { }

	[Address(RVA = "0x1DDA9F0", Offset = "0x1DD9DF0", Length = "0xC")]
	[Token(Token = "0x6000020")]
	public float GetScaleFactorY(float t) { }

	[Address(RVA = "0x5AD610", Offset = "0x5ACA10", Length = "0x9")]
	[Token(Token = "0x600001E")]
	public float GetScaleFactorZ() { }

	[Address(RVA = "0x1DDAA00", Offset = "0x1DD9E00", Length = "0x215")]
	[Token(Token = "0x6000030")]
	public Vector3 GetScreenPosition(Vector3 targetPos, bool isGround, bool isLocal) { }

	[Address(RVA = "0x1DDAC20", Offset = "0x1DDA020", Length = "0x9C")]
	[Token(Token = "0x600004C")]
	private float GetTargetAspect() { }

	[Address(RVA = "0x1DDACC0", Offset = "0x1DDA0C0", Length = "0xD3")]
	[Token(Token = "0x600002D")]
	public Vector3 GroundToLocal(Vector3 p) { }

	[Address(RVA = "0x1DDAFA0", Offset = "0x1DDA3A0", Length = "0x4E")]
	[Token(Token = "0x6000029")]
	public Vector3 GroundToScreen(Vector3 p) { }

	[Address(RVA = "0x1DDADA0", Offset = "0x1DDA1A0", Length = "0x1F0")]
	[Token(Token = "0x600002A")]
	public Vector3 GroundToScreenBase(Vector3 p) { }

	[Address(RVA = "0x1DDAFF0", Offset = "0x1DDA3F0", Length = "0xD3")]
	[Token(Token = "0x600002F")]
	public Vector3 GroundToWorld(Vector3 p) { }

	[Address(RVA = "0x1DDB0D0", Offset = "0x1DDA4D0", Length = "0xAC")]
	[Token(Token = "0x6000026")]
	public void HitThisFrame(HybridCollisions bridge) { }

	[Address(RVA = "0x1DDB180", Offset = "0x1DDA580", Length = "0xD2")]
	[IteratorStateMachine(typeof(<Initialize>d__4))]
	[Token(Token = "0x6000019")]
	public IEnumerator Initialize(Transform _poolArea, Transform _gameArea, Camera mcam, Camera ccam) { }

	[Address(RVA = "0x1DDB260", Offset = "0x1DDA660", Length = "0x191")]
	[Token(Token = "0x6000031")]
	public bool IsGroundDisplay(Vector3 wpos, Rect trect, float farclip = 500) { }

	[Address(RVA = "0x1DDB400", Offset = "0x1DDA800", Length = "0xC8")]
	[Token(Token = "0x6000032")]
	public bool IsGroundOut(Vector3 wpos, float syh) { }

	[Address(RVA = "0x1DDB4D0", Offset = "0x1DDA8D0", Length = "0x6B")]
	[Token(Token = "0x6000036")]
	public bool IsInArea(Bounds tbound) { }

	[Address(RVA = "0x1DDB540", Offset = "0x1DDA940", Length = "0x104")]
	[Token(Token = "0x6000037")]
	public bool IsInScreen(Bounds tbound) { }

	[Address(RVA = "0x1DDB650", Offset = "0x1DDAA50", Length = "0x16B")]
	[Token(Token = "0x6000028")]
	public Vector3 LocalToScreen(Vector3 p) { }

	[Address(RVA = "0x1DDB7C0", Offset = "0x1DDABC0", Length = "0x22E")]
	[Token(Token = "0x600004D")]
	private void RefreshScreenParameters(Vector2 screenSize) { }

	[Address(RVA = "0x1DDB9F0", Offset = "0x1DDADF0", Length = "0x1BF")]
	[Token(Token = "0x6000022")]
	public void Reset() { }

	[Address(RVA = "0x1DDBBB0", Offset = "0x1DDAFB0", Length = "0xC0")]
	[Token(Token = "0x600002B")]
	public Vector3 ScreenToLocal(Vector3 p) { }

	[Address(RVA = "0x1DDBC80", Offset = "0x1DDB080", Length = "0xC0")]
	[Token(Token = "0x600002C")]
	public Vector3 ScreenToWorld(Vector3 p) { }

	[Address(RVA = "0x119FA90", Offset = "0x119EE90", Length = "0x9")]
	[Token(Token = "0x6000033")]
	public float ScreenZ() { }

	[Address(RVA = "0x1DDBD50", Offset = "0x1DDB150", Length = "0x8")]
	[Token(Token = "0x600001B")]
	public void SetGameRotate(Quaternion gameRoot) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x600001A")]
	public void SetGroundCamera(Camera gcam) { }

	[Address(RVA = "0x1DDBD60", Offset = "0x1DDB160", Length = "0x8A")]
	[Token(Token = "0x6000035")]
	public int SetOrder(HybridCollisionBridge b, int ctype) { }

	[Address(RVA = "0x1DDBDF0", Offset = "0x1DDB1F0", Length = "0x146")]
	[Token(Token = "0x6000021")]
	public void Solution(bool isFirst) { }

	[Address(RVA = "0x1DDC020", Offset = "0x1DDB420", Length = "0x38B")]
	[Token(Token = "0x6000023")]
	public void Terminate() { }

	[Address(RVA = "0x1DDBF40", Offset = "0x1DDB340", Length = "0xDB")]
	[Token(Token = "0x600003C")]
	public void TerminateJobs() { }

	[Address(RVA = "0x1DDC3B0", Offset = "0x1DDB7B0", Length = "0x18C")]
	[Token(Token = "0x6000048")]
	private Vector3 ToCameraScreenPoint(Camera cam, Vector3 screenPos) { }

	[Address(RVA = "0x119FC20", Offset = "0x119F020", Length = "0x9")]
	[Token(Token = "0x600001D")]
	public void UpdateCameraTall(float ttall) { }

	[Address(RVA = "0x1DDC540", Offset = "0x1DDB940", Length = "0x13B")]
	[Token(Token = "0x6000039")]
	public void UpdateEntry(Transform target, Vector3 wpos, Quaternion wrot) { }

	[Address(RVA = "0x1DDC680", Offset = "0x1DDBA80", Length = "0x119")]
	[Token(Token = "0x600003A")]
	public void UpdateJobs() { }

	[Address(RVA = "0x1DDC7A0", Offset = "0x1DDBBA0", Length = "0x117")]
	[Token(Token = "0x600001C")]
	public void UpdateScaleFactor() { }

	[Address(RVA = "0x1DDC8C0", Offset = "0x1DDBCC0", Length = "0x4D1")]
	[Token(Token = "0x6000046")]
	public void UpdateScreenSize() { }

	[Address(RVA = "0x1DDCDA0", Offset = "0x1DDC1A0", Length = "0xD3")]
	[Token(Token = "0x600002E")]
	public Vector3 WorldToLocal(Vector3 p) { }

	[Address(RVA = "0x1DDCE80", Offset = "0x1DDC280", Length = "0x16B")]
	[Token(Token = "0x6000027")]
	public Vector3 WorldToScreen(Vector3 p) { }

}

