namespace InGame.Kernel;

[Token(Token = "0x2000045")]
public class InGameJemManager
{
	[BurstCompile]
	[Token(Token = "0x2000046")]
	private struct JemsJob : IJobParallelForTransform
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4000220")]
		public float deltaTime; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x4000221")]
		public NativeArray<Vector3> sourcePositions; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		[Token(Token = "0x4000222")]
		public NativeArray<Vector3> sourceAngle; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[ReadOnly]
		[Token(Token = "0x4000223")]
		public NativeArray<Vector3> sourceRotate; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[ReadOnly]
		[Token(Token = "0x4000224")]
		public NativeArray<Single> sourceSpeed; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[ReadOnly]
		[Token(Token = "0x4000225")]
		public NativeArray<Single> sourceRand; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[ReadOnly]
		[Token(Token = "0x4000226")]
		public NativeArray<Boolean> sourceBool; //Field offset: 0x58

		[Address(RVA = "0x1CF30C0", Offset = "0x1CF24C0", Length = "0x41B")]
		[Token(Token = "0x600027C")]
		public override void Execute(int index, TransformAccess tt) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000215")]
	private JobHandle _jhandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000216")]
	private int _JemMax; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000217")]
	private int _queCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000218")]
	private bool _doJob; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000219")]
	private TransformAccessArray _transformAccessArray; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400021A")]
	private NativeArray<Vector3> _positionAccess; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400021B")]
	private NativeArray<Vector3> _rotateAccess; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400021C")]
	private NativeArray<Vector3> _angleAccess; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400021D")]
	private NativeArray<Single> _speedAccess; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400021E")]
	private NativeArray<Single> _randAccess; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400021F")]
	private NativeArray<Boolean> _boolAccess; //Field offset: 0x88

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600027B")]
	public InGameJemManager() { }

	[Address(RVA = "0x1CE18C0", Offset = "0x1CE0CC0", Length = "0x2B")]
	[Token(Token = "0x6000279")]
	public void CompleteJemsJob() { }

	[Address(RVA = "0x1CE18F0", Offset = "0x1CE0CF0", Length = "0x12E")]
	[Token(Token = "0x6000278")]
	public void DoJemsJob(float dt) { }

	[Address(RVA = "0x1CE1A20", Offset = "0x1CE0E20", Length = "0x8C")]
	[Token(Token = "0x6000276")]
	public void EntryBornQue(int tindex, Vector3 wpos, Vector3 wangle, float wspd, float wrand) { }

	[Address(RVA = "0x1CE1AB0", Offset = "0x1CE0EB0", Length = "0x3E")]
	[Token(Token = "0x6000277")]
	public void EntryMoveQue(int index, Vector3 wpos, float wspd) { }

	[Address(RVA = "0x1CE1AF0", Offset = "0x1CE0EF0", Length = "0x449")]
	[Token(Token = "0x6000275")]
	public void Initialize(PrefabBank<InGameBulletInterface> pools) { }

	[Address(RVA = "0x1CE1F40", Offset = "0x1CE1340", Length = "0x12C")]
	[Token(Token = "0x600027A")]
	public void TerminateJobs() { }

}

