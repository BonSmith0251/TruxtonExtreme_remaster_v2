namespace KANAI.HybridCollision;

[RequireComponent(typeof(Collider2D))]
[Token(Token = "0x2000004")]
public class HybridCollisionBridge : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000006")]
	private Transform _transform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000007")]
	private HybridCollisionModel _ownerModel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000008")]
	private Collider2D _collider2d; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000009")]
	private Rigidbody2D _rigidBody; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000A")]
	private Vector2 _colliderSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400000B")]
	private Bounds _baseBounds; //Field offset: 0x48
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400000C")]
	private float _baseScale; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400000D")]
	private bool _isSelfSized; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x400000E")]
	private bool _isSetuped; //Field offset: 0x65
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400000F")]
	private int _layerNumber; //Field offset: 0x68

	[Token(Token = "0x17000004")]
	public float BaseScale
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000001")]
	public Transform CachedTransform
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000003")]
	public Collider2D Collider
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public HybridCollisionModel Owner
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1DDA200", Offset = "0x1DD9600", Length = "0x58")]
	[Token(Token = "0x6000018")]
	public HybridCollisionBridge() { }

	[Address(RVA = "0x1DD9C10", Offset = "0x1DD9010", Length = "0x85")]
	[Token(Token = "0x6000006")]
	public void DetachOwner() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x6000017")]
	public float get_BaseScale() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000014")]
	public Transform get_CachedTransform() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000016")]
	public Collider2D get_Collider() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000015")]
	public HybridCollisionModel get_Owner() { }

	[Address(RVA = "0x1DD9CA0", Offset = "0x1DD90A0", Length = "0x5D")]
	[Token(Token = "0x600000E")]
	public Bounds GetBounds() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x6000009")]
	public int GetLayer() { }

	[Address(RVA = "0x1DD9D00", Offset = "0x1DD9100", Length = "0x13")]
	[Token(Token = "0x600000C")]
	public Vector3 GetPosition() { }

	[Address(RVA = "0x1DD9D20", Offset = "0x1DD9120", Length = "0x102")]
	[Token(Token = "0x6000003")]
	public void Initialize() { }

	[Address(RVA = "0x1DD9E30", Offset = "0x1DD9230", Length = "0x5D")]
	[Token(Token = "0x600000F")]
	public bool IsSelf(Collider2D target) { }

	[Address(RVA = "0x1DD9E90", Offset = "0x1DD9290", Length = "0x1E")]
	[Token(Token = "0x6000010")]
	private void OnTriggerEnter2D(Collider2D other) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000012")]
	private void OnTriggerExit2D(Collider2D other) { }

	[Address(RVA = "0x1DD9EB0", Offset = "0x1DD92B0", Length = "0x1E")]
	[Token(Token = "0x6000011")]
	private void OnTriggerStay2D(Collider2D other) { }

	[Address(RVA = "0x1DD9ED0", Offset = "0x1DD92D0", Length = "0xB2")]
	[Token(Token = "0x6000013")]
	public void SetBaseScale(float t) { }

	[Address(RVA = "0x1DD9F90", Offset = "0x1DD9390", Length = "0x3C")]
	[Token(Token = "0x6000008")]
	public void SetDisplay(bool v) { }

	[Address(RVA = "0x1DD9FD0", Offset = "0x1DD93D0", Length = "0x58")]
	[Token(Token = "0x6000007")]
	public void SetLayer(int nLayer) { }

	[Address(RVA = "0x1DDA030", Offset = "0x1DD9430", Length = "0x9")]
	[Token(Token = "0x600000D")]
	public void SetSize(Vector2 tsize) { }

	[Address(RVA = "0x1DDA050", Offset = "0x1DD9450", Length = "0x61")]
	[Token(Token = "0x6000004")]
	public void Setup(HybridCollisionModel pOwner) { }

	[Address(RVA = "0x1DDA040", Offset = "0x1DD9440", Length = "0x5")]
	[Token(Token = "0x6000005")]
	public void SetupEnd() { }

	[Address(RVA = "0x1DDA0C0", Offset = "0x1DD94C0", Length = "0x86")]
	[Token(Token = "0x600000B")]
	public void UpdateOnlyPosition(Vector3 pos) { }

	[Address(RVA = "0x1DDA150", Offset = "0x1DD9550", Length = "0xAB")]
	[Token(Token = "0x600000A")]
	public void UpdatePosition(Vector3 pos, Quaternion rot, float tscale) { }

}

