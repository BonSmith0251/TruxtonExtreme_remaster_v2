namespace UnityEngine.EventSystems;

[Token(Token = "0x20000CD")]
public abstract class UIBehaviour : MonoBehaviour
{

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007AD")]
	protected UIBehaviour() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A0")]
	protected override void Awake() { }

	[Address(RVA = "0x3475310", Offset = "0x3474710", Length = "0x7")]
	[Token(Token = "0x60007A5")]
	public override bool IsActive() { }

	[Address(RVA = "0x3475320", Offset = "0x3474720", Length = "0x4C")]
	[Token(Token = "0x60007AC")]
	public override bool IsDestroyed() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A7")]
	protected override void OnBeforeTransformParentChanged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007AA")]
	protected override void OnCanvasGroupChanged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007AB")]
	protected override void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A4")]
	protected override void OnDestroy() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A9")]
	protected override void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A3")]
	protected override void OnDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A1")]
	protected override void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A6")]
	protected override void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A8")]
	protected override void OnTransformParentChanged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A2")]
	protected override void Start() { }

}

