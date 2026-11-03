namespace UnityEngine.VFX.Utility;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[Token(Token = "0x2000040")]
internal class VFXRigidBodyCollisionEventBinder : VFXEventBinderBase
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000159")]
	private ExposedProperty positionParameter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400015A")]
	private ExposedProperty directionParameter; //Field offset: 0x40

	[Address(RVA = "0x2F78250", Offset = "0x2F77650", Length = "0x150")]
	[Token(Token = "0x6000106")]
	public VFXRigidBodyCollisionEventBinder() { }

	[Address(RVA = "0x2F77E50", Offset = "0x2F77250", Length = "0x194")]
	[Token(Token = "0x6000105")]
	private void OnCollisionEnter(Collision collision) { }

	[Address(RVA = "0x2F77FF0", Offset = "0x2F773F0", Length = "0x253")]
	[Token(Token = "0x6000104")]
	protected virtual void SetEventAttribute(Object[] parameters) { }

}

