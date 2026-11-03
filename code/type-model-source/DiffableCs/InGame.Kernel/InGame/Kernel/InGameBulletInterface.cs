namespace InGame.Kernel;

[Token(Token = "0x2000012")]
public interface InGameBulletInterface
{

	[Token(Token = "0x60000A5")]
	public void CallDisabled() { }

	[Token(Token = "0x60000AE")]
	public BulletColorType ColorType() { }

	[Token(Token = "0x600009F")]
	public void Initialize() { }

	[Token(Token = "0x60000AF")]
	public bool IsEnableScript() { }

	[Token(Token = "0x60000AA")]
	public bool IsLaser() { }

	[Token(Token = "0x60000A4")]
	public void LateUpdater(float dt) { }

	[Token(Token = "0x60000A3")]
	public void ProgressBullet(float dt) { }

	[Token(Token = "0x60000A6")]
	public void RefreshRoot(Transform gmr) { }

	[Token(Token = "0x60000A9")]
	public void SetCauseOfDeath(int playerNo, attackType atkType, bool isExboost) { }

	[Token(Token = "0x60000A8")]
	public void SetCurveData(AnimationCurve _curve, float r, float range) { }

	[Token(Token = "0x60000A7")]
	public void SetCurveType(float r, float range) { }

	[Token(Token = "0x60000AB")]
	public void SetEmitterInformation(InGameEnemyMoveBase _m, Transform temit, Transform tdir, int nFire, bool isSelf) { }

	[Token(Token = "0x60000AC")]
	public void SetIrradiationTime(float t) { }

	[Token(Token = "0x60000AD")]
	public void SetOffsetPosition(Vector3 pos) { }

	[Token(Token = "0x60000A1")]
	public void SetPoolAction(Action<Int32> _poolAction, int tindex) { }

	[Token(Token = "0x60000A2")]
	public void StartMove(Vector3 s, Vector3 e, float tspeed, MoveType moveType) { }

	[Token(Token = "0x60000A0")]
	public void Terminate() { }

}

