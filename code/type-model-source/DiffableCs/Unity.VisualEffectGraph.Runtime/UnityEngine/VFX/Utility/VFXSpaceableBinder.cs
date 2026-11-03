namespace UnityEngine.VFX.Utility;

[Token(Token = "0x200005C")]
internal abstract class VFXSpaceableBinder : VFXBinderBase
{
	[Token(Token = "0x200005D")]
	internal enum BinderSpace : int
	{
		Automatic = 0,
		World = 1,
		Local = 2,
	}

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001DA")]
	public BinderSpace Space; //Field offset: 0x28

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60001A9")]
	protected VFXSpaceableBinder() { }

	[Address(RVA = "0x2F7FF40", Offset = "0x2F7F340", Length = "0x297")]
	[Token(Token = "0x60001A8")]
	protected Vector3 ApplySpacePosition(VisualEffect component, ExposedProperty targetProperty, Vector3 sourceWorldPosition) { }

	[Address(RVA = "0x2F7FC50", Offset = "0x2F7F050", Length = "0x2E6")]
	[Token(Token = "0x60001A5")]
	protected void ApplySpacePositionNormal(VisualEffect component, ExposedProperty targetProperty, Transform sourceTransform, out Vector3 position, out Vector3 normal) { }

	[Address(RVA = "0x2F801E0", Offset = "0x2F7F5E0", Length = "0x2E2")]
	[Token(Token = "0x60001A7")]
	protected void ApplySpaceTRS(VisualEffect component, ExposedProperty targetProperty, Transform sourceTransform, out Vector3 position, out Vector3 eulerAngles, out Vector3 scale) { }

	[Address(RVA = "0x2F804D0", Offset = "0x2F7F8D0", Length = "0x228")]
	[Token(Token = "0x60001A6")]
	protected void ApplySpaceTS(VisualEffect component, ExposedProperty targetProperty, Transform sourceTransform, out Vector3 position, out Vector3 scale) { }

	[Address(RVA = "0x2F80700", Offset = "0x2F7FB00", Length = "0x94")]
	[Token(Token = "0x60001A4")]
	private VFXSpace GetTargetSpace(VisualEffect component, ExposedProperty targetProperty) { }

}

