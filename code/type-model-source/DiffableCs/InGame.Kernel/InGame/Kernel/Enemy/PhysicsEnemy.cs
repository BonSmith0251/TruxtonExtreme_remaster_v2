namespace InGame.Kernel.Enemy;

[Token(Token = "0x200022A")]
public class PhysicsEnemy : MonoBehaviour, IEnemyUpdater, IPhysicsUpdater
{
	[Token(Token = "0x200022B")]
	private struct NodeData
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x400136C")]
		public Transform _origins; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x400136D")]
		public Transform _targets; //Field offset: 0x8

		[Address(RVA = "0x1D16DB0", Offset = "0x1D161B0", Length = "0x94")]
		[Token(Token = "0x6001099")]
		public void Reset() { }

		[Address(RVA = "0x1D16E50", Offset = "0x1D16250", Length = "0x4A")]
		[Token(Token = "0x600109A")]
		public void SetLocal(Vector3 lpos, Quaternion lrot) { }

		[Address(RVA = "0x1D16EA0", Offset = "0x1D162A0", Length = "0x43")]
		[Token(Token = "0x600109B")]
		public void SetWorld(Vector3 lpos, Quaternion lrot) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001365")]
	private Transform _parent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001366")]
	private Transform _transformCache; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001367")]
	private bool _isDone; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001368")]
	private bool _isAttked; //Field offset: 0x31
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4001369")]
	private NodeData[] _node; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400136A")]
	private PhysicsAttackAttr _attkAttr; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400136B")]
	private int _nodeCount; //Field offset: 0x48

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6001098")]
	public PhysicsEnemy() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001092")]
	public override void ApplyTransformFromPhysics() { }

	[Address(RVA = "0x1D18640", Offset = "0x1D17A40", Length = "0x99")]
	[Token(Token = "0x6001093")]
	private void AttachObject() { }

	[Address(RVA = "0x1D186E0", Offset = "0x1D17AE0", Length = "0x94")]
	[Token(Token = "0x6001095")]
	private void AttkAttr(bool isEnable) { }

	[Address(RVA = "0x1D18780", Offset = "0x1D17B80", Length = "0x140")]
	[Token(Token = "0x6001094")]
	private void DetachObject() { }

	[Address(RVA = "0x1D188D0", Offset = "0x1D17CD0", Length = "0x102")]
	[Token(Token = "0x6001097")]
	private void NodeReset() { }

	[Address(RVA = "0x1D18B90", Offset = "0x1D17F90", Length = "0xE")]
	[Token(Token = "0x600108D")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x1D189E0", Offset = "0x1D17DE0", Length = "0x1A")]
	[Token(Token = "0x6001091")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x1D189E0", Offset = "0x1D17DE0", Length = "0x1A")]
	[Token(Token = "0x6001090")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D18A00", Offset = "0x1D17E00", Length = "0xCF")]
	[Token(Token = "0x600108A")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D18AD0", Offset = "0x1D17ED0", Length = "0x6")]
	[Token(Token = "0x6001096")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600108B")]
	public override void ProgressReset() { }

	[Address(RVA = "0x1D18AE0", Offset = "0x1D17EE0", Length = "0xA1")]
	[Token(Token = "0x600108C")]
	public override void ProgressStart() { }

	[Address(RVA = "0xD985F0", Offset = "0xD979F0", Length = "0x5")]
	[Token(Token = "0x600108F")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D18BA0", Offset = "0x1D17FA0", Length = "0x33D")]
	[Token(Token = "0x600108E")]
	private void UpdatePositions() { }

}

