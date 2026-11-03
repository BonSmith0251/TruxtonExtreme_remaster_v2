namespace DG.Tweening.Plugins.Options;

[Token(Token = "0x2000087")]
public struct PathOptions : IPlugOptions
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000166")]
	public PathMode mode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000167")]
	public OrientType orientType; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000168")]
	public AxisConstraint lockPositionAxis; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000169")]
	public AxisConstraint lockRotationAxis; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016A")]
	public bool isClosedPath; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400016B")]
	public Vector3 lookAtPosition; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016C")]
	public Transform lookAtTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016D")]
	public float lookAhead; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400016E")]
	public bool hasCustomForwardDirection; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400016F")]
	public Quaternion forward; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000170")]
	public bool useLocalPosition; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000171")]
	public Transform parent; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000172")]
	public bool isRigidbody; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000173")]
	public bool isRigidbody2D; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x4000174")]
	public bool stableZRotation; //Field offset: 0x52
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000175")]
	internal Quaternion startupRot; //Field offset: 0x54
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000176")]
	internal float startupZRot; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000177")]
	internal bool addedExtraStartWp; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000178")]
	internal bool addedExtraEndWp; //Field offset: 0x69

	[Address(RVA = "0x66AC50", Offset = "0x66A050", Length = "0xF8")]
	[Token(Token = "0x6000358")]
	public override void Reset() { }

}

