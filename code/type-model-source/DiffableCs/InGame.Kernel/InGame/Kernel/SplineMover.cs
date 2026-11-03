namespace InGame.Kernel;

[Token(Token = "0x20000B4")]
public class SplineMover : InGameEnemyMoveBase
{
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000563")]
	protected String[] _routes; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000564")]
	protected int _routesIndex; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000565")]
	private int _routesIndexMax; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000566")]
	private bool _isEndRouteKeep; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000567")]
	protected Action _endCallback; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000568")]
	protected float _currentOffset; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x4000569")]
	protected float _currentRate; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[SerializeField]
	[Token(Token = "0x400056A")]
	private float _lookAtUpdateSec; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x400056B")]
	private float _lookAtUpdatePas; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400056C")]
	protected Vector3 _upVector; //Field offset: 0x218
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x400056D")]
	protected Vector3 _startPosition; //Field offset: 0x224
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x400056E")]
	private Quaternion _splineRotate; //Field offset: 0x230
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x400056F")]
	protected Matrix4x4 _routeRotate; //Field offset: 0x240
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000570")]
	private int _eventIndex; //Field offset: 0x280
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000571")]
	private float _eventLastRate; //Field offset: 0x284

	[Token(Token = "0x17000139")]
	public Vector3 StartPosition
	{
		[Address(RVA = "0x1D452B0", Offset = "0x1D446B0", Length = "0x19")]
		[Token(Token = "0x6000696")]
		 get { } //Length: 25
	}

	[Address(RVA = "0x1D44AE0", Offset = "0x1D43EE0", Length = "0x54F")]
	[Token(Token = "0x600068F")]
	private void _ProgressSpline(float dt) { }

	[Address(RVA = "0x1D45160", Offset = "0x1D44560", Length = "0x141")]
	[Token(Token = "0x6000690")]
	private void _setNextRoute(float dt) { }

	[Address(RVA = "0x1D45030", Offset = "0x1D44430", Length = "0x128")]
	[Token(Token = "0x6000698")]
	public SplineMover() { }

	[Address(RVA = "0x1D43890", Offset = "0x1D42C90", Length = "0xDF")]
	[Token(Token = "0x6000682")]
	public virtual void Clear() { }

	[Address(RVA = "0x1D43860", Offset = "0x1D42C60", Length = "0x2B")]
	[Token(Token = "0x6000683")]
	public override void ClearToStart() { }

	[Address(RVA = "0x1D43970", Offset = "0x1D42D70", Length = "0x1BC")]
	[Token(Token = "0x6000685")]
	public virtual void CreateRouteData(EnemyData ed, Vector3 spos) { }

	[Address(RVA = "0x1D43B30", Offset = "0x1D42F30", Length = "0xA3")]
	[Token(Token = "0x6000681")]
	public virtual void EndRoute() { }

	[Address(RVA = "0x1D452B0", Offset = "0x1D446B0", Length = "0x19")]
	[Token(Token = "0x6000696")]
	public Vector3 get_StartPosition() { }

	[Address(RVA = "0x1D43BE0", Offset = "0x1D42FE0", Length = "0x11D")]
	[Token(Token = "0x6000687")]
	private void InsertEventSorted(RouteEvent ev) { }

	[Address(RVA = "0x1D43D00", Offset = "0x1D43100", Length = "0x28")]
	[Token(Token = "0x6000692")]
	private bool IsNextRoute() { }

	[Address(RVA = "0x1D43D30", Offset = "0x1D43130", Length = "0x2B")]
	[Token(Token = "0x600068A")]
	public virtual bool IsPlaying() { }

	[Address(RVA = "0x1D43D60", Offset = "0x1D43160", Length = "0x18")]
	[Token(Token = "0x6000693")]
	protected bool IsSplineRoute() { }

	[Address(RVA = "0x1D43D80", Offset = "0x1D43180", Length = "0x3E")]
	[Token(Token = "0x600067B")]
	private void OnDestroy() { }

	[Address(RVA = "0x1D43DC0", Offset = "0x1D431C0", Length = "0x23")]
	[Token(Token = "0x6000695")]
	protected virtual void PlayPasue(bool value) { }

	[Address(RVA = "0x1D43DF0", Offset = "0x1D431F0", Length = "0x3EF")]
	[Token(Token = "0x600068E")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x1D441E0", Offset = "0x1D435E0", Length = "0x15")]
	[Token(Token = "0x6000697")]
	private void ResetEventIndex() { }

	[Address(RVA = "0x1D44200", Offset = "0x1D43600", Length = "0x9")]
	[Token(Token = "0x6000688")]
	public void SetDuration(float t) { }

	[Address(RVA = "0x1D44210", Offset = "0x1D43610", Length = "0x19")]
	[Token(Token = "0x600067D")]
	public void SetEndCallback(Action callback) { }

	[Address(RVA = "0x1D44230", Offset = "0x1D43630", Length = "0x7")]
	[Token(Token = "0x600067E")]
	public void SetEndRouteKeep(bool v) { }

	[Address(RVA = "0x1D44240", Offset = "0x1D43640", Length = "0x219")]
	[Token(Token = "0x6000686")]
	public void SetEventData(RouteEvent[] _events, bool isStackMode, bool isBossStack) { }

	[Address(RVA = "0x1D44460", Offset = "0x1D43860", Length = "0xA7")]
	[Token(Token = "0x6000684")]
	public void SetRouteData(String[] routeNames, Vector3 spos) { }

	[Address(RVA = "0x1D44510", Offset = "0x1D43910", Length = "0x2C")]
	[Token(Token = "0x6000689")]
	public void SetRouteMatrix(Matrix4x4 t) { }

	[Address(RVA = "0x1D44540", Offset = "0x1D43940", Length = "0x35")]
	[Token(Token = "0x600068D")]
	public virtual void SetSpline(Spline _sc, float _length, string routeName) { }

	[Address(RVA = "0x1D44580", Offset = "0x1D43980", Length = "0x58")]
	[Token(Token = "0x600067C")]
	public void SetStartPosition(Vector3 spos) { }

	[Address(RVA = "0x1D445E0", Offset = "0x1D439E0", Length = "0x14")]
	[Token(Token = "0x6000680")]
	public void StartOverrideRoute() { }

	[Address(RVA = "0x1D44600", Offset = "0x1D43A00", Length = "0x117")]
	[Token(Token = "0x600067F")]
	public override void StartRoute(Action callback) { }

	[Address(RVA = "0x1D44720", Offset = "0x1D43B20", Length = "0x163")]
	[Token(Token = "0x6000694")]
	protected override void UpdateEvent(float s, float step) { }

	[Address(RVA = "0x1D44890", Offset = "0x1D43C90", Length = "0xF7")]
	[Token(Token = "0x600068B")]
	public void UpdateObjectData(EnemyPlacementData epd, float speedStep) { }

	[Address(RVA = "0x1D44990", Offset = "0x1D43D90", Length = "0x150")]
	[Token(Token = "0x6000691")]
	private void UpdatePosition(float realStep, float dt) { }

	[Address(RVA = "0x1D452D0", Offset = "0x1D446D0", Length = "0x173")]
	[Token(Token = "0x600068C")]
	private void updateRouteData(float firstDT) { }

}

