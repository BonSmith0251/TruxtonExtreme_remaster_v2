namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[Token(Token = "0x200001F")]
public struct PhysicsJoint : IEquatable<PhysicsJoint>
{
	[Token(Token = "0x2000020")]
	internal enum JointType : int
	{
		DistanceJoint = 0,
		IgnoreJoint = 1,
		RelativeJoint = 2,
		SliderJoint = 3,
		HingeJoint = 4,
		FixedJoint = 5,
		WheelJoint = 6,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000096")]
	private readonly int index1; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000097")]
	private readonly ushort world0; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000098")]
	private readonly ushort generation; //Field offset: 0x6

	[Token(Token = "0x1700003A")]
	public override object callbackTarget
	{
		[Address(RVA = "0x3129C20", Offset = "0x3129020", Length = "0x37")]
		[Token(Token = "0x600011F")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000038")]
	public override bool isValid
	{
		[Address(RVA = "0x3129C60", Offset = "0x3129060", Length = "0x37")]
		[Token(Token = "0x600011D")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000039")]
	public override JointType jointType
	{
		[Address(RVA = "0x3129CA0", Offset = "0x31290A0", Length = "0x37")]
		[Token(Token = "0x600011E")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x3129890", Offset = "0x3128C90", Length = "0x5E")]
	[Token(Token = "0x600011A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3128840", Offset = "0x3127C40", Length = "0x20")]
	[Token(Token = "0x600011B")]
	public override bool Equals(PhysicsJoint other) { }

	[Address(RVA = "0x3129C20", Offset = "0x3129020", Length = "0x37")]
	[Token(Token = "0x600011F")]
	public override object get_callbackTarget() { }

	[Address(RVA = "0x3129C60", Offset = "0x3129060", Length = "0x37")]
	[Token(Token = "0x600011D")]
	public override bool get_isValid() { }

	[Address(RVA = "0x3129CA0", Offset = "0x31290A0", Length = "0x37")]
	[Token(Token = "0x600011E")]
	public override JointType get_jointType() { }

	[Address(RVA = "0x31298F0", Offset = "0x3128CF0", Length = "0x7D")]
	[Token(Token = "0x600011C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3129970", Offset = "0x3128D70", Length = "0x2A0")]
	[Token(Token = "0x6000119")]
	public virtual string ToString() { }

}

