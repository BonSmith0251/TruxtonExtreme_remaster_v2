namespace InGame.Kernel.Enemy;

[Token(Token = "0x200015E")]
public class EnemyIdleRotater : MonoBehaviour, IEnemyUpdater
{
	[Token(Token = "0x2000160")]
	private class RData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009DD")]
		private Transform _baseTransform; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009DE")]
		private Quaternion _baseQuaternion; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40009DF")]
		private Vector3 _rotate; //Field offset: 0x28
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40009E0")]
		private Vector3 _rotateStep; //Field offset: 0x34

		[Address(RVA = "0x1D729E0", Offset = "0x1D71DE0", Length = "0xC3")]
		[Token(Token = "0x6000AA3")]
		public RData(RInformation rinf) { }

		[Address(RVA = "0x1D728B0", Offset = "0x1D71CB0", Length = "0xBC")]
		[Token(Token = "0x6000AA5")]
		public void Progress(float dt) { }

		[Address(RVA = "0x1D72970", Offset = "0x1D71D70", Length = "0x6C")]
		[Token(Token = "0x6000AA4")]
		public void Reset() { }

	}

	[Token(Token = "0x200015F")]
	private class RInformation
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40009DB")]
		public Transform _transform; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40009DC")]
		public Vector3 _rotAngles; //Field offset: 0x18

		[Address(RVA = "0x1D72AB0", Offset = "0x1D71EB0", Length = "0x51")]
		[Token(Token = "0x6000AA2")]
		public RInformation() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40009D9")]
	private RInformation[] _informations; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009DA")]
	private RData[] _rdata; //Field offset: 0x28

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000AA1")]
	public EnemyIdleRotater() { }

	[Address(RVA = "0x1D64150", Offset = "0x1D63550", Length = "0x136")]
	[Token(Token = "0x6000A9A")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A9F")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A9E")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D63E70", Offset = "0x1D63270", Length = "0x20A")]
	[Token(Token = "0x6000A99")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D3E090", Offset = "0x1D3D490", Length = "0x6")]
	[Token(Token = "0x6000AA0")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x1D64080", Offset = "0x1D63480", Length = "0xC9")]
	[Token(Token = "0x6000A9B")]
	public override void ProgressReset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A9C")]
	public override void ProgressStart() { }

	[Address(RVA = "0x17A8580", Offset = "0x17A7980", Length = "0x13")]
	[Token(Token = "0x6000A9D")]
	public override void ProgressTerminate() { }

}

