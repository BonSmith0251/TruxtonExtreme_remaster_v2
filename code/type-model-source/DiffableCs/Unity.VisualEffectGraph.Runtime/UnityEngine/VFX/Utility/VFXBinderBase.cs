namespace UnityEngine.VFX.Utility;

[ExecuteAlways]
[RequireComponent(typeof(VFXPropertyBinder))]
[Token(Token = "0x2000066")]
public abstract class VFXBinderBase : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FB")]
	protected VFXPropertyBinder binder; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60001E8")]
	protected VFXBinderBase() { }

	[Address(RVA = "0x2F7D7A0", Offset = "0x2F7CBA0", Length = "0x49")]
	[Token(Token = "0x60001E3")]
	protected override void Awake() { }

	[Token(Token = "0x60001E1")]
	public abstract bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7D7F0", Offset = "0x2F7CBF0", Length = "0x87")]
	[Token(Token = "0x60001E5")]
	protected override void OnDisable() { }

	[Address(RVA = "0x2F7D880", Offset = "0x2F7CC80", Length = "0xE7")]
	[Token(Token = "0x60001E4")]
	protected override void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001E2")]
	public override void Reset() { }

	[Address(RVA = "0x2F7D970", Offset = "0x2F7CD70", Length = "0x30")]
	[Token(Token = "0x60001E7")]
	public virtual string ToString() { }

	[Token(Token = "0x60001E6")]
	public abstract void UpdateBinding(VisualEffect component) { }

}

