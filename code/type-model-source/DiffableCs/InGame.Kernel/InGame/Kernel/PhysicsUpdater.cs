namespace InGame.Kernel;

[Token(Token = "0x20000A2")]
public class PhysicsUpdater : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	internal interface IPhysicsUpdater
	{

		[Token(Token = "0x60005F8")]
		public void ApplyTransformFromPhysics() { }

		[Token(Token = "0x60005F7")]
		public void ProgressTerminate() { }

	}

	[Token(Token = "0x40004EA")]
	public static readonly float fixedStep; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004EB")]
	private Transform _physicsRoot; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004EC")]
	private float _physicsStep; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004ED")]
	private HashSet<IPhysicsUpdater> _physicsObjectList; //Field offset: 0x30

	[Token(Token = "0x17000124")]
	public int ObjectCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60005F3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000125")]
	public Transform PhysicsRoot
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60005F4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D3B7D0", Offset = "0x1D3ABD0", Length = "0x39")]
	[Token(Token = "0x60005F6")]
	private static PhysicsUpdater() { }

	[Address(RVA = "0x1D3B810", Offset = "0x1D3AC10", Length = "0x77")]
	[Token(Token = "0x60005F5")]
	public PhysicsUpdater() { }

	[Address(RVA = "0x1D3B280", Offset = "0x1D3A680", Length = "0x53")]
	[Token(Token = "0x60005F1")]
	public bool Add(IPhysicsUpdater physicsObject) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60005F3")]
	public int get_ObjectCount() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60005F4")]
	public Transform get_PhysicsRoot() { }

	[Address(RVA = "0x1D3B2E0", Offset = "0x1D3A6E0", Length = "0x25")]
	[Token(Token = "0x60005ED")]
	public void Initialize() { }

	[Address(RVA = "0x1D3B310", Offset = "0x1D3A710", Length = "0x305")]
	[Token(Token = "0x60005EF")]
	public void ProgressLate(float delta) { }

	[Address(RVA = "0x1D3B620", Offset = "0x1D3AA20", Length = "0x14D")]
	[Token(Token = "0x60005F0")]
	public void Refresh() { }

	[Address(RVA = "0x1D3B770", Offset = "0x1D3AB70", Length = "0x53")]
	[Token(Token = "0x60005F2")]
	public bool Remove(IPhysicsUpdater physicsObject) { }

	[Address(RVA = "0x1D3B620", Offset = "0x1D3AA20", Length = "0x14D")]
	[Token(Token = "0x60005EE")]
	public void Terminate() { }

}

