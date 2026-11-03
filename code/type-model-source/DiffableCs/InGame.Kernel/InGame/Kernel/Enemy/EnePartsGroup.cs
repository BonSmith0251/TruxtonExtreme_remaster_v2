namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000172")]
public class EnePartsGroup
{
	[CompilerGenerated]
	[Token(Token = "0x2000174")]
	private struct <ChangeColor>d__93 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AC1")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AC2")]
		public float tsecond; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000AC3")]
		public bool isReverse; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AC4")]
		public EnePartsGroup <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AC5")]
		public Color targetColor; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AC6")]
		public CancellationToken _token; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AC7")]
		private float <tpassed>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000AC8")]
		private Awaiter <>u__1; //Field offset: 0x3C

		[Address(RVA = "0x1D88C30", Offset = "0x1D88030", Length = "0x4D1")]
		[Token(Token = "0x6000BB9")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000BBA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Flags]
	[Token(Token = "0x2000173")]
	internal enum PartsFlag : int
	{
		None = 0,
		MasterBody = 1,
		Independent = 2,
		BrokenStill = 4,
		SleepStart = 16,
	}

	[Token(Token = "0x4000AB5")]
	private const float _damageTimeMax = 0.2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000A9C")]
	private PartsFlag _partsFlags; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000A9D")]
	private string _partsName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000A9E")]
	private GameObject _partsRoot; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A9F")]
	private GameObject _damageObject; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000AA0")]
	private Transform _explosionRoot; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AA1")]
	private float _HitPoint; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000AA2")]
	private float _damagePoint; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AA3")]
	private float _damageScored; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000AA4")]
	private int _partsScore; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AA5")]
	private int _partsLayer; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000AA6")]
	private int _breakEffectCode; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AA7")]
	private Record _dbrecrod; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000AA8")]
	private string BreakEffect; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000AA9")]
	private String[] _breakToAwake; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AAA")]
	public Int32[] BreakToAwakeIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000AAB")]
	private EnemyCollisionModel[] _collisions; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AAC")]
	private int _numColllision; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000AAD")]
	private Renderer[] _renderers; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000AAE")]
	private int _renderCount; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000AAF")]
	private RenderData[] _renderDatas; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000AB0")]
	private bool _isDamageEffectDisplay; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x4000AB1")]
	private bool _isDamageEffectCalled; //Field offset: 0x99
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x4000AB2")]
	private bool _isPartsBroken; //Field offset: 0x9A
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000AB3")]
	private float _blinkTimer; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000AB4")]
	private float _hitFlushTime; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000AB6")]
	private float _damageBlinkRate; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000AB7")]
	private attackType _lastHit; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000AB8")]
	private bool _sleepFlag; //Field offset: 0xAC
	[FieldOffset(Offset = "0xAD")]
	[Token(Token = "0x4000AB9")]
	private bool _noDamageFlag; //Field offset: 0xAD

	[Token(Token = "0x170001D9")]
	public int BreakEffectCode
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x6000B8C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001DC")]
	public String[] BreakToAwake
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000B8F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D5")]
	public bool BrokenStill
	{
		[Address(RVA = "0x1D633D0", Offset = "0x1D627D0", Length = "0x8")]
		[Token(Token = "0x6000B88")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001DD")]
	public EnemyCollisionModel[] Collisions
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000B90")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001DF")]
	public float DamagePoint
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x6000BB2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001DB")]
	public Record DBRecord
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000B8E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001E0")]
	public float HitPoint
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x6000BB3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001DE")]
	public bool IsDamageEffectCalled
	{
		[Address(RVA = "0x1D633F0", Offset = "0x1D627F0", Length = "0x8")]
		[Token(Token = "0x6000B91")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001D7")]
	public bool IsIndependent
	{
		[Address(RVA = "0x1D63400", Offset = "0x1D62800", Length = "0x8")]
		[Token(Token = "0x6000B8A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001D6")]
	public bool IsSleepStart
	{
		[Address(RVA = "0x1D63410", Offset = "0x1D62810", Length = "0x8")]
		[Token(Token = "0x6000B89")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001E1")]
	public float LeftHp
	{
		[Address(RVA = "0x1D63420", Offset = "0x1D62820", Length = "0xB")]
		[Token(Token = "0x6000BB4")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170001D3")]
	public bool MasterBodyFlag
	{
		[Address(RVA = "0x1D63430", Offset = "0x1D62830", Length = "0x7")]
		[Token(Token = "0x6000B86")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001D8")]
	public string PartsName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000B8B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001DA")]
	public int Score
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6000B8D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001D4")]
	public bool WithOwnerDamage
	{
		[Address(RVA = "0x1D63440", Offset = "0x1D62840", Length = "0xA")]
		[Token(Token = "0x6000B87")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x1D632A0", Offset = "0x1D626A0", Length = "0x126")]
	[Token(Token = "0x6000BB8")]
	public EnePartsGroup() { }

	[Address(RVA = "0x1D61850", Offset = "0x1D60C50", Length = "0x3D4")]
	[Token(Token = "0x6000BA1")]
	public void BreakParts(bool isGround, bool withEffect, bool withSound = true, Vector3 dv = null) { }

	[Address(RVA = "0x1D61C30", Offset = "0x1D61030", Length = "0x7B")]
	[Token(Token = "0x6000BA7")]
	public void ChangeCollisionsAttribute(EnemyCollisionAttribute _tarribute, bool isSet) { }

	[Address(RVA = "0x1D61DB0", Offset = "0x1D611B0", Length = "0xE4")]
	[AsyncStateMachine(typeof(<ChangeColor>d__93))]
	[Token(Token = "0x6000BB5")]
	private UniTaskVoid ChangeColor(CancellationToken _token, Color targetColor, float tsecond, bool isReverse) { }

	[Address(RVA = "0x1D61CB0", Offset = "0x1D610B0", Length = "0xFD")]
	[Token(Token = "0x6000BB6")]
	public void ChangeColorTask(CancellationToken _token, Color targetColor, float tsecond, bool isReverse) { }

	[Address(RVA = "0x1D61EA0", Offset = "0x1D612A0", Length = "0x134")]
	[Token(Token = "0x6000BAD")]
	private void ClearFadeColor() { }

	[Address(RVA = "0x1D62050", Offset = "0x1D61450", Length = "0x48")]
	[Token(Token = "0x6000BA6")]
	public void CollisionsChageEnable(int tindex, bool isHit) { }

	[Address(RVA = "0x1D61FE0", Offset = "0x1D613E0", Length = "0x6D")]
	[Token(Token = "0x6000BA5")]
	public void CollisionsChageEnable(bool isHit) { }

	[Address(RVA = "0x1D620A0", Offset = "0x1D614A0", Length = "0x201")]
	[Token(Token = "0x6000B92")]
	public void FirstInit(PawnEnemy self) { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x6000B8C")]
	public int get_BreakEffectCode() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000B8F")]
	public String[] get_BreakToAwake() { }

	[Address(RVA = "0x1D633D0", Offset = "0x1D627D0", Length = "0x8")]
	[Token(Token = "0x6000B88")]
	public bool get_BrokenStill() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000B90")]
	public EnemyCollisionModel[] get_Collisions() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x6000BB2")]
	public float get_DamagePoint() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000B8E")]
	public Record get_DBRecord() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x6000BB3")]
	public float get_HitPoint() { }

	[Address(RVA = "0x1D633F0", Offset = "0x1D627F0", Length = "0x8")]
	[Token(Token = "0x6000B91")]
	public bool get_IsDamageEffectCalled() { }

	[Address(RVA = "0x1D63400", Offset = "0x1D62800", Length = "0x8")]
	[Token(Token = "0x6000B8A")]
	public bool get_IsIndependent() { }

	[Address(RVA = "0x1D63410", Offset = "0x1D62810", Length = "0x8")]
	[Token(Token = "0x6000B89")]
	public bool get_IsSleepStart() { }

	[Address(RVA = "0x1D63420", Offset = "0x1D62820", Length = "0xB")]
	[Token(Token = "0x6000BB4")]
	public float get_LeftHp() { }

	[Address(RVA = "0x1D63430", Offset = "0x1D62830", Length = "0x7")]
	[Token(Token = "0x6000B86")]
	public bool get_MasterBodyFlag() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000B8B")]
	public string get_PartsName() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x6000B8D")]
	public int get_Score() { }

	[Address(RVA = "0x1D63440", Offset = "0x1D62840", Length = "0xA")]
	[Token(Token = "0x6000B87")]
	public bool get_WithOwnerDamage() { }

	[Address(RVA = "0x1D622B0", Offset = "0x1D616B0", Length = "0xA7")]
	[Token(Token = "0x6000BA9")]
	public int GetDamageScore() { }

	[Address(RVA = "0x1D62360", Offset = "0x1D61760", Length = "0xB8")]
	[Token(Token = "0x6000B9D")]
	public Transform GetExplosionTop() { }

	[Address(RVA = "0x1D62420", Offset = "0x1D61820", Length = "0x9A")]
	[Token(Token = "0x6000B98")]
	public float GetPartsDamage(float tdamage) { }

	[Address(RVA = "0x1D624C0", Offset = "0x1D618C0", Length = "0x14F")]
	[Token(Token = "0x6000B9C")]
	public Vector3 GetPartsPosition() { }

	[Address(RVA = "0x1D62610", Offset = "0x1D61A10", Length = "0x17")]
	[Token(Token = "0x6000BB1")]
	public float HpRate() { }

	[Address(RVA = "0x1D62630", Offset = "0x1D61A30", Length = "0x8")]
	[Token(Token = "0x6000BB0")]
	public bool IsBreakedParts() { }

	[Address(RVA = "0x1D62640", Offset = "0x1D61A40", Length = "0x1F")]
	[Token(Token = "0x6000B9B")]
	public bool IsDropSomthing() { }

	[Address(RVA = "0x1D62660", Offset = "0x1D61A60", Length = "0x8")]
	[Token(Token = "0x6000B94")]
	public bool IsNoDamage() { }

	[Address(RVA = "0x1D59150", Offset = "0x1D58550", Length = "0x8")]
	[Token(Token = "0x6000B93")]
	public bool IsSleep() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[Token(Token = "0x6000B95")]
	public attackType LastHit() { }

	[Address(RVA = "0x1D62680", Offset = "0x1D61A80", Length = "0x7")]
	[Token(Token = "0x6000BA0")]
	public void NoDamage(bool isNoDamage) { }

	[Address(RVA = "0x1D62690", Offset = "0x1D61A90", Length = "0x12")]
	[Token(Token = "0x6000B9A")]
	public int NumJewel() { }

	[Address(RVA = "0x1D626B0", Offset = "0x1D61AB0", Length = "0x12")]
	[Token(Token = "0x6000B99")]
	public int NumPipil() { }

	[Address(RVA = "0x1D626D0", Offset = "0x1D61AD0", Length = "0x3D9")]
	[Token(Token = "0x6000BAA")]
	public void OnUpdate(float delta, float coreRate = 1) { }

	[Address(RVA = "0x1D62BC0", Offset = "0x1D61FC0", Length = "0x84")]
	[Token(Token = "0x6000BA4")]
	public void RendererChangeEnable(bool sw = true) { }

	[Address(RVA = "0x1D62C50", Offset = "0x1D62050", Length = "0x13F")]
	[Token(Token = "0x6000BA2")]
	public void RepairParts(bool forceRepair) { }

	[Address(RVA = "0x1D62D90", Offset = "0x1D62190", Length = "0xA")]
	[Token(Token = "0x6000BA3")]
	public void ResetBlink() { }

	[Address(RVA = "0x1D62DA0", Offset = "0x1D621A0", Length = "0xDA")]
	[Token(Token = "0x6000BAC")]
	public void ResetHitColor() { }

	[Address(RVA = "0x1D62AB0", Offset = "0x1D61EB0", Length = "0x10C")]
	[Token(Token = "0x6000B96")]
	public void ReStart() { }

	[Address(RVA = "0x1D62E80", Offset = "0x1D62280", Length = "0x105")]
	[Token(Token = "0x6000BA8")]
	public bool SendDamage(float adddamage) { }

	[Address(RVA = "0x1D62F90", Offset = "0x1D62390", Length = "0x9")]
	[Token(Token = "0x6000BB7")]
	public void SetDamageBlinkRate(float rate) { }

	[Address(RVA = "0x1D62FA0", Offset = "0x1D623A0", Length = "0x93")]
	[Token(Token = "0x6000BAF")]
	public void SetDamageEffect(bool isActive) { }

	[Address(RVA = "0x1D63120", Offset = "0x1D62520", Length = "0x69")]
	[Token(Token = "0x6000BAE")]
	public void SetHit(attackType atype) { }

	[Address(RVA = "0x1D63040", Offset = "0x1D62440", Length = "0xD4")]
	[Token(Token = "0x6000BAB")]
	public void SetHitColor(Color hitcolor) { }

	[Address(RVA = "0x1D63190", Offset = "0x1D62590", Length = "0x4E")]
	[Token(Token = "0x6000B97")]
	public void SetRecord(Record r) { }

	[Address(RVA = "0x1D631E0", Offset = "0x1D625E0", Length = "0x5B")]
	[Token(Token = "0x6000B9E")]
	public void ToSleep() { }

	[Address(RVA = "0x1D63240", Offset = "0x1D62640", Length = "0x5B")]
	[Token(Token = "0x6000B9F")]
	public void Wakeup() { }

}

