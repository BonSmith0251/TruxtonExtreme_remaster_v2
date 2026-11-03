namespace UnityEngine.EventSystems;

[Token(Token = "0x20000C8")]
public abstract class BaseRaycaster : UIBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400036B")]
	private BaseRaycaster m_RootRaycaster; //Field offset: 0x20

	[Token(Token = "0x170001FE")]
	public abstract Camera eventCamera
	{
		[Token(Token = "0x6000781")]
		 get { } //Length: 0
	}

	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	[Token(Token = "0x170001FF")]
	public override int priority
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000782")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000201")]
	public override int renderOrderPriority
	{
		[Address(RVA = "0x3462DF0", Offset = "0x34621F0", Length = "0x6")]
		[Token(Token = "0x6000784")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000202")]
	public BaseRaycaster rootRaycaster
	{
		[Address(RVA = "0x3462E00", Offset = "0x3462200", Length = "0xB2")]
		[Token(Token = "0x6000785")]
		 get { } //Length: 178
	}

	[Token(Token = "0x17000200")]
	public override int sortOrderPriority
	{
		[Address(RVA = "0x3462DF0", Offset = "0x34621F0", Length = "0x6")]
		[Token(Token = "0x6000783")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600078B")]
	protected BaseRaycaster() { }

	[Token(Token = "0x6000781")]
	public abstract Camera get_eventCamera() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000782")]
	public override int get_priority() { }

	[Address(RVA = "0x3462DF0", Offset = "0x34621F0", Length = "0x6")]
	[Token(Token = "0x6000784")]
	public override int get_renderOrderPriority() { }

	[Address(RVA = "0x3462E00", Offset = "0x3462200", Length = "0xB2")]
	[Token(Token = "0x6000785")]
	public BaseRaycaster get_rootRaycaster() { }

	[Address(RVA = "0x3462DF0", Offset = "0x34621F0", Length = "0x6")]
	[Token(Token = "0x6000783")]
	public override int get_sortOrderPriority() { }

	[Address(RVA = "0x1D510C0", Offset = "0x1D504C0", Length = "0x13")]
	[Token(Token = "0x6000789")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x3462970", Offset = "0x3461D70", Length = "0xF9")]
	[Token(Token = "0x6000788")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3462A70", Offset = "0x3461E70", Length = "0x14E")]
	[Token(Token = "0x6000787")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1D510C0", Offset = "0x1D504C0", Length = "0x13")]
	[Token(Token = "0x600078A")]
	protected virtual void OnTransformParentChanged() { }

	[Token(Token = "0x6000780")]
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x3462BC0", Offset = "0x3461FC0", Length = "0x229")]
	[Token(Token = "0x6000786")]
	public virtual string ToString() { }

}

