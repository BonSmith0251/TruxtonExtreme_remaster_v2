namespace KANAI.HybridCollision;

[ExecuteAlways]
[Token(Token = "0x2000009")]
public class HybridCollisionModel : HybridCollisionModelBase
{
	[Token(Token = "0x200000C")]
	internal enum SelfSubject : int
	{
		Body = 0,
		Bullet = 1,
		Bomber = 2,
		Item = 3,
	}

	[Token(Token = "0x200000A")]
	internal enum Shape : int
	{
		None = 0,
		Circle = 1,
		Box = 2,
		Polygon = 3,
		Edge = 4,
		Capsule = 5,
		CircleNR = 6,
		BoxNR = 7,
	}

	[Token(Token = "0x200000B")]
	internal enum TargetSubject : int
	{
		All = 0,
		OnlyBullet = 1,
		OnlyBody = 2,
	}

	[Token(Token = "0x4000037")]
	public static readonly string Object2DTag; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000038")]
	private Shape _shapeType; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000039")]
	private TargetSubject _subjectType; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400003A")]
	private SelfSubject _selfType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400003B")]
	private Vector2[] _points; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400003C")]
	private bool _isCreate; //Field offset: 0x68

	[Token(Token = "0x17000015")]
	public Vector2[] Points
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600007B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000014")]
	public SelfSubject SelfType
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x600007A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000012")]
	public Shape ShapeType
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000013")]
	public TargetSubject SubjectType
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x6000079")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1DDEF80", Offset = "0x1DDE380", Length = "0x96")]
	[Token(Token = "0x6000077")]
	private int _getMostNearIndex(ContactPoint2D[] contacts) { }

	[Address(RVA = "0x1DDF020", Offset = "0x1DDE420", Length = "0xA3")]
	[Token(Token = "0x600005D")]
	protected void _updateEdge(Vector2[] _pos) { }

	[Address(RVA = "0x1DDEF00", Offset = "0x1DDE300", Length = "0x62")]
	[Token(Token = "0x600007D")]
	private static HybridCollisionModel() { }

	[Address(RVA = "0x1DDEF70", Offset = "0x1DDE370", Length = "0xE")]
	[Token(Token = "0x600007C")]
	public HybridCollisionModel() { }

	[Address(RVA = "0x1DDDDD0", Offset = "0x1DDD1D0", Length = "0x9C")]
	[Token(Token = "0x6000060")]
	public override bool AddDamage(float t, int pno, bool isExboost) { }

	[Address(RVA = "0x1DDDE70", Offset = "0x1DDD270", Length = "0xF4")]
	[Token(Token = "0x600005A")]
	public void CreateCollisionObject(Transform _root, string objctName) { }

	[Address(RVA = "0x1DDE5E0", Offset = "0x1DDD9E0", Length = "0x8A")]
	[Token(Token = "0x600005B")]
	public virtual void DeleteObject() { }

	[Address(RVA = "0x1DDE670", Offset = "0x1DDDA70", Length = "0x94")]
	[Token(Token = "0x600005C")]
	public void DetachObject() { }

	[Address(RVA = "0x1DDE710", Offset = "0x1DDDB10", Length = "0xA2")]
	[Token(Token = "0x6000065")]
	public virtual void EntryHitLists(Collider2D other) { }

	[Address(RVA = "0x1DDE7C0", Offset = "0x1DDDBC0", Length = "0xA5")]
	[Token(Token = "0x6000067")]
	public virtual void EntryLeaveLists(Collider2D other) { }

	[Address(RVA = "0x1DDE870", Offset = "0x1DDDC70", Length = "0xA5")]
	[Token(Token = "0x6000066")]
	public virtual void EntryStayLists(Collider2D other) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600007B")]
	public Vector2[] get_Points() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x600007A")]
	public SelfSubject get_SelfType() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x6000078")]
	public Shape get_ShapeType() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x6000079")]
	public TargetSubject get_SubjectType() { }

	[Address(RVA = "0x5AA980", Offset = "0x5A9D80", Length = "0x4A")]
	[Token(Token = "0x6000061")]
	public override Vector3 GetBurnOffset() { }

	[Address(RVA = "0x1DDE920", Offset = "0x1DDDD20", Length = "0x11")]
	[Token(Token = "0x600006F")]
	public override bool IsBodyHit() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000072")]
	public override bool IsBomberHit() { }

	[Address(RVA = "0x1DDE940", Offset = "0x1DDDD40", Length = "0x8")]
	[Token(Token = "0x6000071")]
	public override bool IsBulletHit(HybridCollisions owner) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000069")]
	public override bool IsEnableCollision() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600006C")]
	public override bool IsEnableDamage() { }

	[Address(RVA = "0x1DDE950", Offset = "0x1DDDD50", Length = "0x257")]
	[Token(Token = "0x6000064")]
	protected override bool IsHitSubject(HybridCollisionBridge bridge) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000076")]
	public override bool IsIndependent() { }

	[Address(RVA = "0x1DDEBB0", Offset = "0x1DDDFB0", Length = "0x8")]
	[Token(Token = "0x6000070")]
	public override bool IsItemHit() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600006E")]
	public override bool IsLaserBlockModel() { }

	[Address(RVA = "0x1DDEBC0", Offset = "0x1DDDFC0", Length = "0x21")]
	[Token(Token = "0x600006D")]
	public override bool IsNoLockOnModel() { }

	[Address(RVA = "0x1DDEBF0", Offset = "0x1DDDFF0", Length = "0x16")]
	[Token(Token = "0x6000068")]
	public bool IsPoint() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000073")]
	public override bool IsSkipClip() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000075")]
	public override bool IsSkipRotate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000074")]
	public override bool IsSkipScale() { }

	[Address(RVA = "0x1DDEC10", Offset = "0x1DDE010", Length = "0x14")]
	[Token(Token = "0x600006A")]
	public override bool IsUpdateCollision() { }

	[Address(RVA = "0x1DDEC10", Offset = "0x1DDE010", Length = "0x14")]
	[Token(Token = "0x600006B")]
	public override bool IsVisibleCollision() { }

	[Address(RVA = "0x1DDEC30", Offset = "0x1DDE030", Length = "0x48")]
	[Token(Token = "0x600005F")]
	public void SetPoint(int index, float px, float py) { }

	[Address(RVA = "0x1DDEC80", Offset = "0x1DDE080", Length = "0x13")]
	[Token(Token = "0x600005E")]
	public void SetShape(Shape stype, Vector2[] p) { }

	[Address(RVA = "0x1DDECA0", Offset = "0x1DDE0A0", Length = "0x24C")]
	[Token(Token = "0x6000063")]
	public void UpdateCollisionShape(Vector2[] cp) { }

	[Address(RVA = "0x1DDEEF0", Offset = "0x1DDE2F0", Length = "0xC")]
	[Token(Token = "0x6000062")]
	public void UpdateCollisionShape() { }

}

